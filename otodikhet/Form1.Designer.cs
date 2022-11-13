namespace otodikhet
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.dgwRates = new System.Windows.Forms.DataGridView();
			this.chartRateDAta = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwRates)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartRateDAta)).BeginInit();
			this.SuspendLayout();
			// 
			// dgwRates
			// 
			this.dgwRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwRates.Location = new System.Drawing.Point(12, 38);
			this.dgwRates.Name = "dgwRates";
			this.dgwRates.RowHeadersWidth = 51;
			this.dgwRates.RowTemplate.Height = 24;
			this.dgwRates.Size = new System.Drawing.Size(318, 286);
			this.dgwRates.TabIndex = 0;
			this.dgwRates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRates_CellContentClick);
			// 
			// chartRateDAta
			// 
			chartArea10.Name = "ChartArea1";
			this.chartRateDAta.ChartAreas.Add(chartArea10);
			legend10.Name = "Legend1";
			this.chartRateDAta.Legends.Add(legend10);
			this.chartRateDAta.Location = new System.Drawing.Point(336, 38);
			this.chartRateDAta.Name = "chartRateDAta";
			series10.ChartArea = "ChartArea1";
			series10.Legend = "Legend1";
			series10.Name = "Series1";
			this.chartRateDAta.Series.Add(series10);
			this.chartRateDAta.Size = new System.Drawing.Size(947, 286);
			this.chartRateDAta.TabIndex = 1;
			this.chartRateDAta.Text = "chart1";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 10);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 2;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(218, 10);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker2.TabIndex = 3;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "EUR"});
			this.comboBox1.Location = new System.Drawing.Point(424, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "EUR";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1295, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.chartRateDAta);
			this.Controls.Add(this.dgwRates);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgwRates)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartRateDAta)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwRates;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartRateDAta;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

