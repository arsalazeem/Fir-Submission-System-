namespace projecttest
{
    partial class testingform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testingform));
            this.token = new Bunifu.UI.WinForms.BunifuLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homescreen = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // token
            // 
            this.token.AutoEllipsis = false;
            this.token.AutoSize = false;
            this.token.AutoSizeHeightOnly = true;
            this.token.BackColor = System.Drawing.Color.Blue;
            this.token.CursorType = null;
            this.token.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.token.ForeColor = System.Drawing.Color.White;
            this.token.Location = new System.Drawing.Point(4, 12);
            this.token.Name = "token";
            this.token.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.token.Size = new System.Drawing.Size(1175, 27);
            this.token.TabIndex = 2;
            this.token.Text = "Information Report";
            this.token.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1181, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // homescreen
            // 
            this.homescreen.ActiveBorderThickness = 1;
            this.homescreen.ActiveCornerRadius = 20;
            this.homescreen.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.homescreen.ActiveForecolor = System.Drawing.Color.White;
            this.homescreen.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.homescreen.BackColor = System.Drawing.SystemColors.Control;
            this.homescreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homescreen.BackgroundImage")));
            this.homescreen.ButtonText = "Home Screen";
            this.homescreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homescreen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homescreen.ForeColor = System.Drawing.Color.SeaGreen;
            this.homescreen.IdleBorderThickness = 1;
            this.homescreen.IdleCornerRadius = 20;
            this.homescreen.IdleFillColor = System.Drawing.Color.White;
            this.homescreen.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.homescreen.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.homescreen.Location = new System.Drawing.Point(493, 203);
            this.homescreen.Margin = new System.Windows.Forms.Padding(5);
            this.homescreen.Name = "homescreen";
            this.homescreen.Size = new System.Drawing.Size(181, 41);
            this.homescreen.TabIndex = 4;
            this.homescreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homescreen.Click += new System.EventHandler(this.homescreen_Click);
            // 
            // testingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 242);
            this.Controls.Add(this.homescreen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.token);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "testingform";
            this.Load += new System.EventHandler(this.testingform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel token;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 homescreen;
    }
}