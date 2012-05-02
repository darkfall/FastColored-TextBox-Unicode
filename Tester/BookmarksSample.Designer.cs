namespace Tester
{
    partial class BookmarksSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarksSample));
            this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAddBookmark = new System.Windows.Forms.ToolStripButton();
            this.btRemoveBookmark = new System.Windows.Forms.ToolStripButton();
            this.btGo = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fctb
            // 
            this.fctb.AutoScrollMinSize = new System.Drawing.Size(0, 4065);
            this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctb.DelayedEventsInterval = 500;
            this.fctb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctb.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctb.LeftBracket = '(';
            this.fctb.LeftPadding = 17;
            this.fctb.Location = new System.Drawing.Point(0, 25);
            this.fctb.Name = "fctb";
            this.fctb.RightBracket = ')';
            this.fctb.Size = new System.Drawing.Size(487, 273);
            this.fctb.TabIndex = 0;
            this.fctb.Text = resources.GetString("fctb.Text");
            this.fctb.WordWrap = true;
            this.fctb.PaintLine += new System.EventHandler<FastColoredTextBoxNS.PaintLineEventArgs>(this.fctb_PaintLine);
            this.fctb.LineRemoved += new System.EventHandler<FastColoredTextBoxNS.LineRemovedEventArgs>(this.fctb_LineRemoved);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAddBookmark,
            this.btRemoveBookmark,
            this.btGo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(487, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAddBookmark
            // 
            this.btAddBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btAddBookmark.Image = ((System.Drawing.Image)(resources.GetObject("btAddBookmark.Image")));
            this.btAddBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAddBookmark.Name = "btAddBookmark";
            this.btAddBookmark.Size = new System.Drawing.Size(90, 22);
            this.btAddBookmark.Text = "Add bookmark";
            this.btAddBookmark.Click += new System.EventHandler(this.btAddBookmark_Click);
            // 
            // btRemoveBookmark
            // 
            this.btRemoveBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btRemoveBookmark.Image = ((System.Drawing.Image)(resources.GetObject("btRemoveBookmark.Image")));
            this.btRemoveBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRemoveBookmark.Name = "btRemoveBookmark";
            this.btRemoveBookmark.Size = new System.Drawing.Size(111, 22);
            this.btRemoveBookmark.Text = "Remove bookmark";
            this.btRemoveBookmark.Click += new System.EventHandler(this.btRemoveBookmark_Click);
            // 
            // btGo
            // 
            this.btGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btGo.Image = ((System.Drawing.Image)(resources.GetObject("btGo.Image")));
            this.btGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(61, 22);
            this.btGo.Text = "Go to ...";
            this.btGo.DropDownOpening += new System.EventHandler(this.btGo_DropDownOpening);
            // 
            // BookmarksSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 298);
            this.Controls.Add(this.fctb);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BookmarksSample";
            this.Text = "Bookmarks Sample";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAddBookmark;
        private System.Windows.Forms.ToolStripButton btRemoveBookmark;
        private System.Windows.Forms.ToolStripDropDownButton btGo;
    }
}