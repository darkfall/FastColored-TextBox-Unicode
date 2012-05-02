using System.Drawing;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;

namespace Tester
{
    public partial class CustomStyleSample : Form
    {
        //create my custom style
        EllipseStyle ellipseStyle = new EllipseStyle();

        public CustomStyleSample()
        {
            InitializeComponent();
            fctb.Text = "Available historical resources suggest that Babylon was at first a small town which had sprung up by the beginning of the 3rd millennium BC. The town flourished and attained prominence and political repute with the rise of the First Babylonian Dynasty. Claiming to be the successor of the ancient Eridu, Babylon eclipsed Nippur as the \"holy city\" of Mesopotamia around the time Hammurabi first unified the Babylonian Empire, and again became the seat of the Neo-Babylonian Empire from 612 to 539 BC. The Hanging Gardens of Babylon were one of the Seven Wonders of the Ancient World.";
        }

        private void fctb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //clear old styles of chars
            e.ChangedRange.ClearStyle(ellipseStyle);
            //append style for word 'Babylon'
            e.ChangedRange.SetStyle(ellipseStyle, @"\bBabylon\b", RegexOptions.IgnoreCase);
        }
    }

    /// <summary>
    /// This style will drawing ellipse around of the word
    /// </summary>
    class EllipseStyle : Style
    {
        public override void Draw(Graphics gr, Point position, Range range)
        {
            //get size of rectangle
            Size size = GetSizeOfRange(range);
            //create rectangle
            Rectangle rect = new Rectangle(position, size);
            //inflate it
            rect.Inflate(2, 2);
            //get rounded rectangle
            var path = GetRoundedRectangle(rect, 7);
            //draw rounded rectangle
            gr.DrawPath(Pens.Red, path);
        }
    }
}
