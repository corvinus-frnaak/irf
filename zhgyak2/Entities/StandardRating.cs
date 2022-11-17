using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zhgyak2.Abstractions;

namespace zhgyak2.Entities
{
	public class StandardRating : Rating
	{
		public override string GetDisplayText()
		{
			return Title + " " + RatingType;
		}
	}
}
