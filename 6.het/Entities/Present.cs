using _6.het.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.het.Entities
{
	internal class Present :Toy
	{
    public SolidBrush PresentColor { get; private set; }
    public SolidBrush RibbonColor { get; private set; }

    public Present(Color ribbon, Color box)
    {
      PresentColor = new SolidBrush(box);
      RibbonColor = new SolidBrush(ribbon);
    }

    protected override void DrawImage(Graphics g)
    {
      g.FillRectangle(PresentColor, 0, 0, Width, Height);
      g.FillRectangle(RibbonColor, 0, 0, Width, Height/5);
       g.FillRectangle(RibbonColor, 0, 0, Width / 5, Height);
    }
  }
}
