using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zhgyak2.Abstractions;

namespace zhgyak2.Entities
{
	public class DetailedRanking : Rating
	{
		public override string GetDisplayText()
		{
			return Title + "\n" + RatingReason;
		}
		public string RatingReason { get; set; }
	}
}
