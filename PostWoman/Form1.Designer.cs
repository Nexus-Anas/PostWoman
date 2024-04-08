namespace PostWoman
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAbout = new Guna.UI.WinForms.GunaCircleButton();
            this.btnMinimize = new Guna.UI.WinForms.GunaCircleButton();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.btnExit = new Guna.UI.WinForms.GunaCircleButton();
            this.MainPanel = new Guna.UI.WinForms.GunaElipsePanel();
            this.TxtError = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.LblStatusCode = new Guna.UI.WinForms.GunaLabel();
            this.BtnRun = new Guna.UI2.WinForms.Guna2Button();
            this.TxtUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.HttpSelector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panelDuration = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TxtRequestBody = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.TxtOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panelDuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.btnAbout);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1030, 37);
            this.panelHeader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PostWoman.Properties.Resources.postwoman;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.AnimationHoverSpeed = 0.07F;
            this.btnAbout.AnimationSpeed = 0.03F;
            this.btnAbout.BaseColor = System.Drawing.Color.DarkOrange;
            this.btnAbout.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAbout.FocusedColor = System.Drawing.Color.Empty;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = null;
            this.btnAbout.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAbout.Location = new System.Drawing.Point(954, 10);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.btnAbout.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.btnAbout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAbout.OnHoverImage = null;
            this.btnAbout.OnPressedColor = System.Drawing.Color.Black;
            this.btnAbout.Size = new System.Drawing.Size(17, 17);
            this.btnAbout.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = null;
            this.btnMinimize.ImageSize = new System.Drawing.Size(52, 52);
            this.btnMinimize.Location = new System.Drawing.Point(977, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.Cyan;
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Cyan;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Size = new System.Drawing.Size(17, 17);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 23);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "POSTWOMAN";
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(52, 52);
            this.btnExit.Location = new System.Drawing.Point(1000, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(17, 17);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.MainPanel.Controls.Add(this.TxtError);
            this.MainPanel.Controls.Add(this.gunaLabel3);
            this.MainPanel.Controls.Add(this.LblStatusCode);
            this.MainPanel.Controls.Add(this.BtnRun);
            this.MainPanel.Controls.Add(this.TxtUrl);
            this.MainPanel.Controls.Add(this.HttpSelector);
            this.MainPanel.Controls.Add(this.gunaLabel2);
            this.MainPanel.Location = new System.Drawing.Point(12, 55);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1006, 205);
            this.MainPanel.TabIndex = 10;
            // 
            // TxtError
            // 
            this.TxtError.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtError.BorderRadius = 11;
            this.TxtError.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtError.DefaultText = "";
            this.TxtError.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtError.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtError.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtError.DisabledState.Parent = this.TxtError;
            this.TxtError.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtError.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.TxtError.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtError.FocusedState.Parent = this.TxtError;
            this.TxtError.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtError.ForeColor = System.Drawing.Color.Crimson;
            this.TxtError.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtError.HoverState.Parent = this.TxtError;
            this.TxtError.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.TxtError.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TxtError.Location = new System.Drawing.Point(129, 120);
            this.TxtError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtError.Multiline = true;
            this.TxtError.Name = "TxtError";
            this.TxtError.PasswordChar = '\0';
            this.TxtError.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtError.PlaceholderText = "";
            this.TxtError.ReadOnly = true;
            this.TxtError.SelectedText = "";
            this.TxtError.ShadowDecoration.Parent = this.TxtError;
            this.TxtError.Size = new System.Drawing.Size(763, 69);
            this.TxtError.TabIndex = 41;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(7, 122);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(52, 19);
            this.gunaLabel3.TabIndex = 40;
            this.gunaLabel3.Text = "Error:";
            // 
            // LblStatusCode
            // 
            this.LblStatusCode.AutoSize = true;
            this.LblStatusCode.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatusCode.ForeColor = System.Drawing.Color.White;
            this.LblStatusCode.Location = new System.Drawing.Point(113, 88);
            this.LblStatusCode.Name = "LblStatusCode";
            this.LblStatusCode.Size = new System.Drawing.Size(0, 19);
            this.LblStatusCode.TabIndex = 39;
            // 
            // BtnRun
            // 
            this.BtnRun.Animated = true;
            this.BtnRun.BackColor = System.Drawing.Color.Transparent;
            this.BtnRun.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnRun.BorderRadius = 12;
            this.BtnRun.BorderThickness = 2;
            this.BtnRun.CheckedState.Parent = this.BtnRun;
            this.BtnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRun.CustomImages.Parent = this.BtnRun;
            this.BtnRun.FillColor = System.Drawing.Color.Transparent;
            this.BtnRun.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRun.ForeColor = System.Drawing.Color.White;
            this.BtnRun.HoverState.Parent = this.BtnRun;
            this.BtnRun.Location = new System.Drawing.Point(903, 24);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.ShadowDecoration.BorderRadius = 12;
            this.BtnRun.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.BtnRun.ShadowDecoration.Depth = 50;
            this.BtnRun.ShadowDecoration.Enabled = true;
            this.BtnRun.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnRun.ShadowDecoration.Parent = this.BtnRun;
            this.BtnRun.Size = new System.Drawing.Size(93, 36);
            this.BtnRun.TabIndex = 38;
            this.BtnRun.Text = "Run";
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // TxtUrl
            // 
            this.TxtUrl.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtUrl.BorderRadius = 11;
            this.TxtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUrl.DefaultText = "";
            this.TxtUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUrl.DisabledState.Parent = this.TxtUrl;
            this.TxtUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.TxtUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUrl.FocusedState.Parent = this.TxtUrl;
            this.TxtUrl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrl.ForeColor = System.Drawing.Color.White;
            this.TxtUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUrl.HoverState.Parent = this.TxtUrl;
            this.TxtUrl.IconLeft = global::PostWoman.Properties.Resources.rocket;
            this.TxtUrl.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.TxtUrl.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TxtUrl.Location = new System.Drawing.Point(156, 24);
            this.TxtUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.PasswordChar = '\0';
            this.TxtUrl.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtUrl.PlaceholderText = "enter url";
            this.TxtUrl.SelectedText = "";
            this.TxtUrl.ShadowDecoration.Parent = this.TxtUrl;
            this.TxtUrl.Size = new System.Drawing.Size(736, 36);
            this.TxtUrl.TabIndex = 37;
            // 
            // HttpSelector
            // 
            this.HttpSelector.BackColor = System.Drawing.Color.Transparent;
            this.HttpSelector.BorderColor = System.Drawing.Color.DodgerBlue;
            this.HttpSelector.BorderRadius = 11;
            this.HttpSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HttpSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HttpSelector.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.HttpSelector.FocusedColor = System.Drawing.Color.Empty;
            this.HttpSelector.FocusedState.Parent = this.HttpSelector;
            this.HttpSelector.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HttpSelector.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.HttpSelector.FormattingEnabled = true;
            this.HttpSelector.HoverState.Parent = this.HttpSelector;
            this.HttpSelector.ItemHeight = 30;
            this.HttpSelector.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "PATCH",
            "REMOVE"});
            this.HttpSelector.ItemsAppearance.Parent = this.HttpSelector;
            this.HttpSelector.Location = new System.Drawing.Point(13, 24);
            this.HttpSelector.Name = "HttpSelector";
            this.HttpSelector.ShadowDecoration.Parent = this.HttpSelector;
            this.HttpSelector.Size = new System.Drawing.Size(131, 36);
            this.HttpSelector.TabIndex = 36;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(7, 88);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(100, 19);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Status Code:";
            // 
            // panelDuration
            // 
            this.panelDuration.BackColor = System.Drawing.Color.Transparent;
            this.panelDuration.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.panelDuration.Controls.Add(this.gunaLabel1);
            this.panelDuration.Controls.Add(this.TxtRequestBody);
            this.panelDuration.Controls.Add(this.gunaLabel8);
            this.panelDuration.Controls.Add(this.TxtOutput);
            this.panelDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDuration.Location = new System.Drawing.Point(12, 287);
            this.panelDuration.Name = "panelDuration";
            this.panelDuration.Size = new System.Drawing.Size(1005, 290);
            this.panelDuration.TabIndex = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(597, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(113, 23);
            this.gunaLabel1.TabIndex = 44;
            this.gunaLabel1.Text = "Request Body:";
            // 
            // TxtRequestBody
            // 
            this.TxtRequestBody.BorderColor = System.Drawing.Color.DarkOrange;
            this.TxtRequestBody.BorderRadius = 11;
            this.TxtRequestBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRequestBody.DefaultText = "";
            this.TxtRequestBody.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRequestBody.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRequestBody.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRequestBody.DisabledState.Parent = this.TxtRequestBody;
            this.TxtRequestBody.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRequestBody.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.TxtRequestBody.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRequestBody.FocusedState.Parent = this.TxtRequestBody;
            this.TxtRequestBody.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRequestBody.ForeColor = System.Drawing.Color.White;
            this.TxtRequestBody.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRequestBody.HoverState.Parent = this.TxtRequestBody;
            this.TxtRequestBody.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.TxtRequestBody.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TxtRequestBody.Location = new System.Drawing.Point(596, 48);
            this.TxtRequestBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRequestBody.Multiline = true;
            this.TxtRequestBody.Name = "TxtRequestBody";
            this.TxtRequestBody.PasswordChar = '\0';
            this.TxtRequestBody.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtRequestBody.PlaceholderText = "";
            this.TxtRequestBody.SelectedText = "";
            this.TxtRequestBody.ShadowDecoration.Parent = this.TxtRequestBody;
            this.TxtRequestBody.Size = new System.Drawing.Size(399, 232);
            this.TxtRequestBody.TabIndex = 43;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(9, 13);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(63, 23);
            this.gunaLabel8.TabIndex = 30;
            this.gunaLabel8.Text = "Output:";
            // 
            // TxtOutput
            // 
            this.TxtOutput.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtOutput.BorderRadius = 11;
            this.TxtOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOutput.DefaultText = "";
            this.TxtOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtOutput.DisabledState.Parent = this.TxtOutput;
            this.TxtOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.TxtOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtOutput.FocusedState.Parent = this.TxtOutput;
            this.TxtOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutput.ForeColor = System.Drawing.Color.White;
            this.TxtOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtOutput.HoverState.Parent = this.TxtOutput;
            this.TxtOutput.IconLeftOffset = new System.Drawing.Point(0, -2);
            this.TxtOutput.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TxtOutput.Location = new System.Drawing.Point(11, 48);
            this.TxtOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.PasswordChar = '\0';
            this.TxtOutput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtOutput.PlaceholderText = "";
            this.TxtOutput.ReadOnly = true;
            this.TxtOutput.SelectedText = "";
            this.TxtOutput.ShadowDecoration.Parent = this.TxtOutput;
            this.TxtOutput.Size = new System.Drawing.Size(567, 232);
            this.TxtOutput.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1030, 589);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelDuration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panelDuration.ResumeLayout(false);
            this.panelDuration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaCircleButton btnAbout;
        private Guna.UI.WinForms.GunaCircleButton btnMinimize;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaCircleButton btnExit;
        private Guna.UI.WinForms.GunaElipsePanel MainPanel;
        private Guna.UI.WinForms.GunaElipsePanel panelDuration;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TxtUrl;
        private Guna.UI2.WinForms.Guna2ComboBox HttpSelector;
        private Guna.UI2.WinForms.Guna2TextBox TxtError;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel LblStatusCode;
        private Guna.UI2.WinForms.Guna2Button BtnRun;
        private Guna.UI2.WinForms.Guna2TextBox TxtOutput;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TxtRequestBody;
    }
}

