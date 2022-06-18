using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NullLib.TextBoxEx
{
    public class TextBoxEx : Control
    {
        public TextBoxEx()
        {
            if (!TextBoxRenderer.IsSupported)
                throw new PlatformNotSupportedException();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            TextBoxRenderer.DrawTextBox(e.Graphics, e.ClipRectangle, Text, Font, TextBoxState.Normal);
        }
    }
}
