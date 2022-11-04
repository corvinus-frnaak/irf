using _6.het.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.het.Entities
{
  public class Car : Toy
  {
    protected override void DrawImage(Graphics g)
    {
      Image imageFile = Image.FromFile("Images/car.png");
      g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
    }
  }
}
