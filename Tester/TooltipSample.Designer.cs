﻿namespace Tester
{
    partial class TooltipSample
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TooltipSample));
            this.label1 = new System.Windows.Forms.Label();
            this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "This example shows tooltips for words under mouse.";
            // 
            // fctb
            // 
            this.fctb.AutoScrollMinSize = new System.Drawing.Size(0, 285);
            this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctb.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctb.LeftBracket = '(';
            this.fctb.Location = new System.Drawing.Point(0, 30);
            this.fctb.Name = "fctb";
            this.fctb.ReadOnly = true;
            this.fctb.RightBracket = ')';
            this.fctb.Size = new System.Drawing.Size(355, 282);
            this.fctb.TabIndex = 5;
            this.fctb.Text = resources.GetString("fctb.Text");
            this.fctb.WordWrap = true;
            this.fctb.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.tb_TextChanged);
            this.fctb.MouseLeave += new System.EventHandler(this.tb_MouseLeave);
            this.fctb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tb_MouseMove);
            // 
            // tm
            // 
            this.tm.Interval = 500;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // TooltipSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 312);
            this.Controls.Add(this.fctb);
            this.Controls.Add(this.label1);
            this.Name = "TooltipSample";
            this.Text = "TooltipSample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.ToolTip tt;
    }
}