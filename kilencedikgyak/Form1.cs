using kilencedikgyak.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kilencedikgyak
{
	public partial class Form1 : Form
	{
		List<Person> Population = new List<Person>();
    List<int> maleNumber = new List<int>();
    List<int> femaleNumber = new List<int>();
    List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
		List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
    Random rng = new Random(1234);
		public Form1()
		{
			InitializeComponent();
      Population = GetPopulation(textBox1.Text+@"\nép.csv");
      BirthProbabilities = GetBirthProbabilities(textBox1.Text + @"\születés.csv");
      DeathProbabilities = GetDeathProbabilities(textBox1.Text + @"\halál.csv");
      
    }
    public List<Person> GetPopulation(string csvpath)
    {
      List<Person> population = new List<Person>();

      using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
      {
        while (!sr.EndOfStream)
        {
          var line = sr.ReadLine().Split(';');
          population.Add(new Person()
          {
            BirthYear = int.Parse(line[0]),
            Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
            NbrOfChildren = int.Parse(line[2])
          });
        }
      }

      return population;
    }
    public List<BirthProbability> GetBirthProbabilities(string csvpath)
    {
      List<BirthProbability> birthProbabilities = new List<BirthProbability>();

      using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
      {
        while (!sr.EndOfStream)
        {
          var line = sr.ReadLine().Split(';');
          birthProbabilities.Add(new BirthProbability()
          {
            Age = int.Parse(line[0]),
            NbrOfChildren = int.Parse(line[1]),
            Probability = double.Parse(line[2])
          });
        }
      }

      return birthProbabilities;
    }
    public List<DeathProbability> GetDeathProbabilities(string csvpath)
    {
      List<DeathProbability> deathProbabilities = new List<DeathProbability>();

      using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
      {
        while (!sr.EndOfStream)
        {
          var line = sr.ReadLine().Split(';');
          deathProbabilities.Add(new DeathProbability()
          {
            Gender = int.Parse(line[0])==1 ? Gender.Male:Gender.Female,
            Age = int.Parse(line[1]),
            Probability = double.Parse(line[2])
          });
        }
      }

      return deathProbabilities;
    }
    public void Simulation()
		{
			for (int year = 2005; year < 2024; year++)
			{
				for (int i = 0; i < Population.Count; i++)
				{
          SimStep(year,Population[i]);
				}
        int nbrOfMales = (from x in Population where x.Gender == Gender.Male select x).Count();
        int nbrOfFemales = (from x in Population where x.Gender == Gender.Male select x).Count();
        maleNumber[year-2005] = nbrOfMales;
        femaleNumber[year - 2005] = nbrOfFemales;
        
      }
    }
    public void SimStep(int year, Person person)
    {
      if (person.IsAlive == false) return;
			
        byte age = (byte)(year - person.BirthYear);

        double deathProb = (from x in DeathProbabilities where x.Gender == person.Gender && x.Age == age select x.Probability).FirstOrDefault();
        if (rng.NextDouble() <= deathProb) person.IsAlive = false;
			if (person.Gender == Gender.Female && person.IsAlive)
			{
        double bProb = (from x in BirthProbabilities where x.Age == age select x.Probability).FirstOrDefault();

				if (rng.NextDouble() <= bProb)
				{
          Person newborn = new Person();
          newborn.BirthYear = year;
          newborn.NbrOfChildren = 0;
          newborn.Gender = (Gender)(rng.Next(1, 3));
          Population.Add(newborn);
				}
      }

    }

		private void btBrowse_Click(object sender, EventArgs e)
		{
      FolderBrowserDialog open = new FolderBrowserDialog();
			if (open.ShowDialog() == DialogResult.OK)
			{
        textBox1.Text = open.SelectedPath;
			}
		}

		private void btStart_Click(object sender, EventArgs e)
		{
      richTextBox1.Text = "";
      maleNumber.Clear();
      femaleNumber.Clear();
      Simulation();
      DisplayResults();
    }
    public void DisplayResults()
		{
			for (int i = 2005; i < numericUpDown1.Value; i++)
			{
        richTextBox1.Text+= string.Format("Szimulációs év:{0}\t  \nFiúk:{1}\t \n Lányok:{2}\t", i, maleNumber[i-2005], femaleNumber[i-2005]);
			}
		}

  }
}
