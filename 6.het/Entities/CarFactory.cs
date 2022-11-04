using _6.het.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.het.Entities
{
  public class CarFactory : IToyFactory
  {
    public Toy CreateNew()
    {
      return new Car();
    }
  }
}
