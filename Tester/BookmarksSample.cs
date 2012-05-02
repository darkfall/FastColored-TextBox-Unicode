using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Drawing.Drawing2D;

namespace Tester
{
    public partial class BookmarksSample : Form
    {
        // Key - Line.UniqueId
        HashSet<int> bookmarksLineId = new HashSet<int>();
        // Index - bookmark number, Value - Line.UniqueId
        List<int> bookmarks = new List<int>();

        public BookmarksSample()
        {
            InitializeComponent();
        }

        private void fctb_PaintLine(object sender, PaintLineEventArgs e)
        {
            //draw bookmark
            if (bookmarksLineId.Contains(fctb[e.LineIndex].UniqueId))
            {
                e.Graphics.FillEllipse(new LinearGradientBrush(new Rectangle(0, e.LineRect.Top, 15, 15), Color.White, Color.PowderBlue, 45), 0, e.LineRect.Top, 15, 15);
                e.Graphics.DrawEllipse(Pens.PowderBlue, 0, e.LineRect.Top, 15, 15);
            }
        }

        private void btAddBookmark_Click(object sender, EventArgs e)
        {
            //get UniqueId of current line
            int id = fctb[fctb.Selection.Start.iLine].UniqueId;
            if (bookmarksLineId.Contains(id))
                return;
            //add bookmark
            bookmarks.Add(id);
            bookmarksLineId.Add(id);
            //repaint
            fctb.Invalidate();
        }

        private void btRemoveBookmark_Click(object sender, EventArgs e)
        {
            //get UniqueId of current line
            int id = fctb[fctb.Selection.Start.iLine].UniqueId;
            if (!bookmarksLineId.Contains(id))
                return;
            //remove bookmark
            bookmarks.Remove(id);
            bookmarksLineId.Remove(id);
            //repaint
            fctb.Invalidate();
        }

        private void fctb_LineRemoved(object sender, LineRemovedEventArgs e)
        {
            //remove lines from bookmarks
            foreach (int id in e.RemovedLineUniqueIds)
            if(bookmarksLineId.Contains(id))
            {
                bookmarksLineId.Remove(id);
                bookmarks.Remove(id);
            }
        }

        private void btGo_DropDownOpening(object sender, EventArgs e)
        {
            btGo.DropDownItems.Clear();
            for (int i = 0; i < bookmarks.Count; i++)
            {
                var item = btGo.DropDownItems.Add("Bookmark " + i);
                item.Tag = i;
                item.Click += (o, a) => GoTo((int)(o as ToolStripItem).Tag);
            }
        }

        private void GoTo(int iBookmark)
        {
            if (iBookmark < 0 || iBookmark >= bookmarks.Count)
                return;

            int id = bookmarks[iBookmark];
            for(int i=0;i<fctb.LinesCount;i++)
                if(fctb[i].UniqueId == id)
                {
                    fctb.Selection.Start = new Place(0, i);
                    fctb.DoSelectionVisible();
                    fctb.Invalidate();
                    break;
                }
        }
    }
}
