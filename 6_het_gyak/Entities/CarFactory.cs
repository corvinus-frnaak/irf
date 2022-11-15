using _6_het_gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_het_gyak.Entities
{
	public class CarFactory : IToyFactory
	{
		public Toy CreateNew()
		{
			return new Car();
		}
	}
}
