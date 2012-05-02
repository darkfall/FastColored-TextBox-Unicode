namespace Tester
{
    partial class SimplestCodeFoldingSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "This example shows how to make simplest code folding.";
            // 
            // fctb
            // 
            this.fctb.AutoScrollMinSize = new System.Drawing.Size(12, 15);
            this.fctb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctb.LeftPadding = 10;
            this.fctb.Location = new System.Drawing.Point(0, 45);
            this.fctb.Name = "fctb";
            this.fctb.ServiceLinesColor = System.Drawing.Color.Gray;
            this.fctb.ShowLineNumbers = false;
            this.fctb.Size = new System.Drawing.Size(284, 217);
            this.fctb.TabIndex = 3;
            this.fctb.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctb_TextChanged);
            // 
            // SimplestCodeFoldingSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.fctb);
            this.Controls.Add(this.label1);
            this.Name = "SimplestCodeFoldingSample";
            this.Text = "SimplestCodeFolding Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FastColoredTextBoxNS.FastColoredTextBox fctb;
    }
}