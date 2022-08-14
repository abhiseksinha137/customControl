namespace TestControl
{
    partial class Form1
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
            this.comboSerial3 = new customControl.comboSerial();
            this.comboSerial2 = new customControl.comboSerial();
            this.comboSerial1 = new customControl.comboSerial();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSerial3
            // 
            this.comboSerial3.Location = new System.Drawing.Point(398, 12);
            this.comboSerial3.Name = "comboSerial3";
            this.comboSerial3.Size = new System.Drawing.Size(99, 58);
            this.comboSerial3.TabIndex = 2;
            // 
            // comboSerial2
            // 
            this.comboSerial2.Location = new System.Drawing.Point(170, 12);
            this.comboSerial2.Name = "comboSerial2";
            this.comboSerial2.Size = new System.Drawing.Size(99, 58);
            this.comboSerial2.TabIndex = 1;
            // 
            // comboSerial1
            // 
            this.comboSerial1.Location = new System.Drawing.Point(2, 12);
            this.comboSerial1.Name = "comboSerial1";
            this.comboSerial1.Size = new System.Drawing.Size(99, 71);
            this.comboSerial1.TabIndex = 0;
            this.comboSerial1.Load += new System.EventHandler(this.comboSerial1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSerial3);
            this.Controls.Add(this.comboSerial2);
            this.Controls.Add(this.comboSerial1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customControl.comboSerial comboSerial1;
        private customControl.comboSerial comboSerial2;
        private customControl.comboSerial comboSerial3;
        private System.Windows.Forms.Label label1;
    }
}

