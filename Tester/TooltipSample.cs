using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Tester
{
    public partial class TooltipSample : Form
    {
        Point lastMouseCoord = Point.Empty;

        public TooltipSample()
        {
            InitializeComponent();
        }

        void CancelToolTip()
        {
            tm.Stop();
            tt.Hide(this);
        }

        private void tb_MouseMove(object sender, MouseEventArgs e)
        {
            if (lastMouseCoord != e.Location)
            {
                //restart tooltip timer
                CancelToolTip();
                tm.Start();
            }
            lastMouseCoord = e.Location;
        }

        private void tb_MouseLeave(object sender, EventArgs e)
        {
            CancelToolTip();
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            CancelToolTip();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop();
            //get place under mouse
            var place = fctb.PointToPlace(lastMouseCoord);

            //check distance
            var p = fctb.PlaceToPoint(place);
            if (Math.Abs(p.X - lastMouseCoord.X) > fctb.CharWidth * 2 ||
                Math.Abs(p.Y - lastMouseCoord.Y) > fctb.CharHeight * 2)
                return;
            //get word under mouse
            var r = new Range(fctb, place, place);
            string hoverWord = r.GetFragment("[a-zA-Z]").Text;
            if (hoverWord == "")
                return;
            //show tooltip
            string text = "Help for " + hoverWord;
            tt.ToolTipTitle = hoverWord;
            tt.SetToolTip(fctb, text);
            tt.Show(text, fctb, new Point(lastMouseCoord.X, lastMouseCoord.Y + fctb.CharHeight));
        }
    }
}
