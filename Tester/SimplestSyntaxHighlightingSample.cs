using System.Drawing;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Tester
{
    public partial class SimplestSyntaxHighlightingSample : Form
    {
        //Create style for highlighting
        TextStyle maroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);

        public SimplestSyntaxHighlightingSample()
        {
            InitializeComponent();
            fctb.Text = "<li>Article\n<a href=\"#_comments\">Ask a Question about this article</a></li>\n<li class=\"heading\">Quick Answers</li>\n<li><a href=\"/Questions/ask.aspx\">Ask a Question</a></li>";
        }

        private void fctb_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            //clear previous highlighting
            e.ChangedRange.ClearStyle(maroonStyle);
            //highlight tags
            e.ChangedRange.SetStyle(maroonStyle, "<[^>]+>");
        }
    }
}
