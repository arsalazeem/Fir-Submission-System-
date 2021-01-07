namespace projecttest
{
    partial class usercheckstatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usercheckstatus));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.tokenid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tokencheckbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.statuslabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.labelstatusnew = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // tokenid
            // 
            this.tokenid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tokenid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tokenid.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tokenid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tokenid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tokenid.ForeColor = System.Drawing.Color.Blue;
            this.tokenid.HintForeColor = System.Drawing.Color.Empty;
            this.tokenid.HintText = "";
            this.tokenid.isPassword = false;
            this.tokenid.LineFocusedColor = System.Drawing.Color.Blue;
            this.tokenid.LineIdleColor = System.Drawing.Color.Gray;
            this.tokenid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tokenid.LineThickness = 3;
            this.tokenid.Location = new System.Drawing.Point(420, 78);
            this.tokenid.Margin = new System.Windows.Forms.Padding(4);
            this.tokenid.MaxLength = 32767;
            this.tokenid.Name = "tokenid";
            this.tokenid.Size = new System.Drawing.Size(328, 33);
            this.tokenid.TabIndex = 0;
            this.tokenid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tokencheckbtn
            // 
            this.tokencheckbtn.BackColor = System.Drawing.Color.Transparent;
            this.tokencheckbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tokencheckbtn.BackgroundImage")));
            this.tokencheckbtn.ButtonText = "Check";
            this.tokencheckbtn.ButtonTextMarginLeft = 0;
            this.tokencheckbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tokencheckbtn.DisabledFillColor = System.Drawing.Color.Gray;
            this.tokencheckbtn.DisabledForecolor = System.Drawing.Color.White;
            this.tokencheckbtn.ForeColor = System.Drawing.Color.White;
            this.tokencheckbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.tokencheckbtn.IconPadding = 10;
            this.tokencheckbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.tokencheckbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.tokencheckbtn.IdleBorderRadius = 1;
            this.tokencheckbtn.IdleBorderThickness = 0;
            this.tokencheckbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.tokencheckbtn.IdleIconLeftImage = null;
            this.tokencheckbtn.IdleIconRightImage = null;
            this.tokencheckbtn.Location = new System.Drawing.Point(420, 138);
            this.tokencheckbtn.Name = "tokencheckbtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.tokencheckbtn.onHoverState = stateProperties1;
            this.tokencheckbtn.Size = new System.Drawing.Size(156, 29);
            this.tokencheckbtn.TabIndex = 1;
            this.tokencheckbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tokencheckbtn.Click += new System.EventHandler(this.tokencheckbtn_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoEllipsis = false;
            this.statuslabel.CursorType = null;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Location = new System.Drawing.Point(506, 226);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statuslabel.Size = new System.Drawing.Size(0, 0);
            this.statuslabel.TabIndex = 2;
            this.statuslabel.Text = null;
            this.statuslabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Return Home";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(600, 138);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(148, 29);
            this.bunifuButton1.TabIndex = 3;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // labelstatusnew
            // 
            this.labelstatusnew.AutoEllipsis = false;
            this.labelstatusnew.CursorType = null;
            this.labelstatusnew.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelstatusnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelstatusnew.Location = new System.Drawing.Point(552, 199);
            this.labelstatusnew.Name = "labelstatusnew";
            this.labelstatusnew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelstatusnew.Size = new System.Drawing.Size(9, 27);
            this.labelstatusnew.TabIndex = 4;
            this.labelstatusnew.Text = ".";
            this.labelstatusnew.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usercheckstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 323);
            this.Controls.Add(this.labelstatusnew);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.tokencheckbtn);
            this.Controls.Add(this.tokenid);
            this.Name = "usercheckstatus";
            this.Text = "usercheckstatus";
            this.Load += new System.EventHandler(this.usercheckstatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox tokenid;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton tokencheckbtn;
        private Bunifu.UI.WinForms.BunifuLabel statuslabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuLabel labelstatusnew;
    }
}