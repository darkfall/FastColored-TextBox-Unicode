using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tester
{
    public partial class SyntaxHighlightingByXmlDescription : Form
    {
        public SyntaxHighlightingByXmlDescription()
        {
            InitializeComponent();
            fctb.Text =
@"<div class=""clip5x9 nav_arrows"">
      <img src=""http://i3.msdn.microsoft.com/Hash/0f73868cd340280cac28f7eeb3d2dd7d.png"" class=""cl_nav_arrow"" alt="""" />
</div>
    
<div class=""nav_div_currentroot"">
<a href=""http://msdn.microsoft.com/en-us/library/abeh092z(v=VS.90).aspx"" title=""System.Globalization Namespace"">System.Globalization Namespace</a></div>";
        }
    }
}
