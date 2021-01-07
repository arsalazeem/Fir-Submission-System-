namespace projecttest
{
    partial class reportcontent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportcontent));
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.doi = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.placeofincident = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.messegecontent = new System.Windows.Forms.RichTextBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateofincidentpicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.time = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.AutoSizeHeightOnly = true;
            this.bunifuLabel1.BackColor = System.Drawing.Color.Blue;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(976, 27);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Information Report";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuLabel2.Location = new System.Drawing.Point(22, 57);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(218, 18);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Note:All Fileds are neccessary to fill.";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // doi
            // 
            this.doi.AutoEllipsis = false;
            this.doi.CursorType = null;
            this.doi.Font = new System.Drawing.Font("Arial", 12F);
            this.doi.Location = new System.Drawing.Point(22, 106);
            this.doi.Name = "doi";
            this.doi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.doi.Size = new System.Drawing.Size(197, 20);
            this.doi.TabIndex = 4;
            this.doi.Text = "Date of Incident (dd-mm-yy):";
            this.doi.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Arial", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(22, 164);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(198, 20);
            this.bunifuLabel3.TabIndex = 5;
            this.bunifuLabel3.Text = "Time of Incident (10:30 AM):";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Arial", 12F);
            this.bunifuLabel4.Location = new System.Drawing.Point(22, 214);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(122, 20);
            this.bunifuLabel4.TabIndex = 6;
            this.bunifuLabel4.Text = "Place of incident:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // placeofincident
            // 
            this.placeofincident.AcceptsReturn = false;
            this.placeofincident.AcceptsTab = false;
            this.placeofincident.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.placeofincident.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.placeofincident.BackColor = System.Drawing.Color.Transparent;
            this.placeofincident.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("placeofincident.BackgroundImage")));
            this.placeofincident.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.placeofincident.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.placeofincident.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.placeofincident.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.placeofincident.BorderRadius = 1;
            this.placeofincident.BorderThickness = 2;
            this.placeofincident.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.placeofincident.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeofincident.DefaultText = "";
            this.placeofincident.FillColor = System.Drawing.Color.White;
            this.placeofincident.HideSelection = true;
            this.placeofincident.IconLeft = null;
            this.placeofincident.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.placeofincident.IconPadding = 10;
            this.placeofincident.IconRight = null;
            this.placeofincident.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.placeofincident.Location = new System.Drawing.Point(248, 199);
            this.placeofincident.MaxLength = 32767;
            this.placeofincident.MinimumSize = new System.Drawing.Size(100, 35);
            this.placeofincident.Modified = false;
            this.placeofincident.Name = "placeofincident";
            this.placeofincident.PasswordChar = '\0';
            this.placeofincident.ReadOnly = false;
            this.placeofincident.SelectedText = "";
            this.placeofincident.SelectionLength = 0;
            this.placeofincident.SelectionStart = 0;
            this.placeofincident.ShortcutsEnabled = true;
            this.placeofincident.Size = new System.Drawing.Size(231, 35);
            this.placeofincident.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.placeofincident.TabIndex = 11;
            this.placeofincident.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.placeofincident.TextMarginLeft = 5;
            this.placeofincident.TextPlaceholder = "";
            this.placeofincident.UseSystemPasswordChar = false;
            // 
            // messegecontent
            // 
            this.messegecontent.Location = new System.Drawing.Point(248, 267);
            this.messegecontent.Name = "messegecontent";
            this.messegecontent.Size = new System.Drawing.Size(740, 171);
            this.messegecontent.TabIndex = 12;
            this.messegecontent.Text = "";
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Arial", 12F);
            this.bunifuLabel5.Location = new System.Drawing.Point(22, 267);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(56, 20);
            this.bunifuLabel5.TabIndex = 13;
            this.bunifuLabel5.Text = "Details:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Submit";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(481, 457);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 14;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // dateofincidentpicker
            // 
            this.dateofincidentpicker.BackColor = System.Drawing.Color.SeaGreen;
            this.dateofincidentpicker.BorderRadius = 0;
            this.dateofincidentpicker.ForeColor = System.Drawing.Color.White;
            this.dateofincidentpicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateofincidentpicker.FormatCustom = null;
            this.dateofincidentpicker.Location = new System.Drawing.Point(248, 90);
            this.dateofincidentpicker.Name = "dateofincidentpicker";
            this.dateofincidentpicker.Size = new System.Drawing.Size(303, 36);
            this.dateofincidentpicker.TabIndex = 15;
            this.dateofincidentpicker.Value = new System.DateTime(2018, 12, 26, 17, 56, 22, 441);
            // 
            // time
            // 
            this.time.AcceptsReturn = false;
            this.time.AcceptsTab = false;
            this.time.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.time.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("time.BackgroundImage")));
            this.time.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.time.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.time.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.time.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.time.BorderRadius = 1;
            this.time.BorderThickness = 2;
            this.time.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.time.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.DefaultText = "";
            this.time.FillColor = System.Drawing.Color.White;
            this.time.HideSelection = true;
            this.time.IconLeft = null;
            this.time.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.time.IconPadding = 10;
            this.time.IconRight = null;
            this.time.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.time.Location = new System.Drawing.Point(248, 149);
            this.time.MaxLength = 32767;
            this.time.MinimumSize = new System.Drawing.Size(100, 35);
            this.time.Modified = false;
            this.time.Name = "time";
            this.time.PasswordChar = '\0';
            this.time.ReadOnly = false;
            this.time.SelectedText = "";
            this.time.SelectionLength = 0;
            this.time.SelectionStart = 0;
            this.time.ShortcutsEnabled = true;
            this.time.Size = new System.Drawing.Size(231, 35);
            this.time.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.time.TabIndex = 16;
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.time.TextMarginLeft = 5;
            this.time.TextPlaceholder = "";
            this.time.UseSystemPasswordChar = false;
            // 
            // reportcontent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 513);
            this.Controls.Add(this.time);
            this.Controls.Add(this.dateofincidentpicker);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.messegecontent);
            this.Controls.Add(this.placeofincident);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.doi);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reportcontent";
            this.Text = "reportcontent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel doi;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox placeofincident;
        private System.Windows.Forms.RichTextBox messegecontent;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuDatepicker dateofincidentpicker;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox time;
    }
}