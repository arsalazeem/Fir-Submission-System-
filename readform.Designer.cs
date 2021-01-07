namespace projecttest
{
    partial class readform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(readform));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.acceptbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rejectbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1199, 291);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // acceptbtn
            // 
            this.acceptbtn.ActiveBorderThickness = 1;
            this.acceptbtn.ActiveCornerRadius = 20;
            this.acceptbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.acceptbtn.ActiveForecolor = System.Drawing.Color.White;
            this.acceptbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.acceptbtn.BackColor = System.Drawing.SystemColors.Control;
            this.acceptbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("acceptbtn.BackgroundImage")));
            this.acceptbtn.ButtonText = "Accepted";
            this.acceptbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.acceptbtn.IdleBorderThickness = 1;
            this.acceptbtn.IdleCornerRadius = 20;
            this.acceptbtn.IdleFillColor = System.Drawing.Color.White;
            this.acceptbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.acceptbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.acceptbtn.Location = new System.Drawing.Point(248, 373);
            this.acceptbtn.Margin = new System.Windows.Forms.Padding(5);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(181, 41);
            this.acceptbtn.TabIndex = 2;
            this.acceptbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // rejectbtn
            // 
            this.rejectbtn.ActiveBorderThickness = 1;
            this.rejectbtn.ActiveCornerRadius = 20;
            this.rejectbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.rejectbtn.ActiveForecolor = System.Drawing.Color.White;
            this.rejectbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.rejectbtn.BackColor = System.Drawing.SystemColors.Control;
            this.rejectbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rejectbtn.BackgroundImage")));
            this.rejectbtn.ButtonText = "Reject";
            this.rejectbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.rejectbtn.IdleBorderThickness = 1;
            this.rejectbtn.IdleCornerRadius = 20;
            this.rejectbtn.IdleFillColor = System.Drawing.Color.White;
            this.rejectbtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.rejectbtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.rejectbtn.Location = new System.Drawing.Point(755, 373);
            this.rejectbtn.Margin = new System.Windows.Forms.Padding(5);
            this.rejectbtn.Name = "rejectbtn";
            this.rejectbtn.Size = new System.Drawing.Size(181, 41);
            this.rejectbtn.TabIndex = 3;
            this.rejectbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rejectbtn.Click += new System.EventHandler(this.rejectbtn_Click);
            // 
            // readform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 504);
            this.Controls.Add(this.rejectbtn);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.richTextBox1);
            this.Name = "readform";
            this.Text = "readform";
            this.Load += new System.EventHandler(this.readform_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 acceptbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 rejectbtn;
    }
}