namespace customControl
{
    partial class comboSerial
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbbx = new System.Windows.Forms.ComboBox();
            this.pnlLight = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.baudrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbbx
            // 
            this.cmbbx.FormattingEnabled = true;
            this.cmbbx.Location = new System.Drawing.Point(2, 16);
            this.cmbbx.Name = "cmbbx";
            this.cmbbx.Size = new System.Drawing.Size(75, 21);
            this.cmbbx.TabIndex = 0;
            this.cmbbx.SelectedIndexChanged += new System.EventHandler(this.cmbbx_SelectedIndexChanged);
            this.cmbbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbbx_MouseClick);
            // 
            // pnlLight
            // 
            this.pnlLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLight.Location = new System.Drawing.Point(83, 21);
            this.pnlLight.Name = "pnlLight";
            this.pnlLight.Size = new System.Drawing.Size(11, 11);
            this.pnlLight.TabIndex = 1;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(1, 43);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(76, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baudrateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // baudrateToolStripMenuItem
            // 
            this.baudrateToolStripMenuItem.Name = "baudrateToolStripMenuItem";
            this.baudrateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.baudrateToolStripMenuItem.Text = "baudrate";
            this.baudrateToolStripMenuItem.Click += new System.EventHandler(this.baudrateToolStripMenuItem_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Com Ch.";
            // 
            // comboSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.pnlLight);
            this.Controls.Add(this.cmbbx);
            this.Name = "comboSerial";
            this.Size = new System.Drawing.Size(102, 72);
            this.Load += new System.EventHandler(this.comboSerial_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbx;
        private System.Windows.Forms.Panel pnlLight;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baudrateToolStripMenuItem;
        private System.Windows.Forms.Label lbl;
    }
}
