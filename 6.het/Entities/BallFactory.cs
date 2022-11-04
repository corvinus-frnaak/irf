using _6.het.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.het.Entities
{
  public class BallFactory : IToyFactory
  {
    public Color BallColor { get; set; }

    public Toy CreateNew()
    {
      return new Ball(BallColor);
    }
  }
}
