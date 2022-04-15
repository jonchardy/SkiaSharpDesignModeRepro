using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiaSharpReproLib
{
    [ToolboxItem(true)]
    public partial class MyCustomControl : SKControl
    {
        private SKFont myFont;

        public MyCustomControl()
        {
            InitializeComponent();

            myFont = new SKFont
            {
                Typeface = SKTypeface.FromFamilyName("Segoe UI"),
                Subpixel = true
            };
        }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            base.OnPaintSurface(e);
            var c = e.Surface.Canvas;
            c.Clear();
            c.DrawText("Test", new SKPoint(20, 20), new SKPaint());
        }
    }
}
