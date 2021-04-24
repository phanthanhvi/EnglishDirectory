namespace EnglishDirectory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnGame = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnDirectory = new Guna.UI2.WinForms.Guna2Button();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.btnMinimize);
            this.pnHeader.Controls.Add(this.btnExit);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.ShadowDecoration.Parent = this.pnHeader;
            this.pnHeader.Size = new System.Drawing.Size(1000, 30);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("UVN Bach Tuyet Nang", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ Điển Anh Việt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(929, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 23);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(964, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnOut);
            this.guna2Panel2.Controls.Add(this.btnInfo);
            this.guna2Panel2.Controls.Add(this.btnGame);
            this.guna2Panel2.Controls.Add(this.btnHome);
            this.guna2Panel2.Controls.Add(this.btnDirectory);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 30);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(200, 650);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnOut
            // 
            this.btnOut.BorderRadius = 20;
            this.btnOut.CheckedState.Parent = this.btnOut;
            this.btnOut.CustomImages.Parent = this.btnOut;
            this.btnOut.FillColor = System.Drawing.Color.OrangeRed;
            this.btnOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.HoverState.Parent = this.btnOut;
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.Location = new System.Drawing.Point(12, 573);
            this.btnOut.Name = "btnOut";
            this.btnOut.ShadowDecoration.Parent = this.btnOut;
            this.btnOut.Size = new System.Drawing.Size(167, 65);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Thoát";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BorderRadius = 20;
            this.btnInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInfo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnInfo.CheckedState.Parent = this.btnInfo;
            this.btnInfo.CustomImages.Parent = this.btnInfo;
            this.btnInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.HoverState.Parent = this.btnInfo;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInfo.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnInfo.ImageSize = new System.Drawing.Size(27, 27);
            this.btnInfo.Location = new System.Drawing.Point(-22, 361);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.ShadowDecoration.Parent = this.btnInfo;
            this.btnInfo.Size = new System.Drawing.Size(163, 52);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Thông Tin";
            this.btnInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInfo.TextOffset = new System.Drawing.Point(20, 0);
            this.btnInfo.UseTransparentBackground = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Transparent;
            this.btnGame.BorderRadius = 20;
            this.btnGame.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnGame.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnGame.CheckedState.Parent = this.btnGame;
            this.btnGame.CustomImages.Parent = this.btnGame;
            this.btnGame.FillColor = System.Drawing.Color.Transparent;
            this.btnGame.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnGame.ForeColor = System.Drawing.Color.White;
            this.btnGame.HoverState.Parent = this.btnGame;
            this.btnGame.Image = ((System.Drawing.Image)(resources.GetObject("btnGame.Image")));
            this.btnGame.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGame.ImageOffset = new System.Drawing.Point(17, 0);
            this.btnGame.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGame.Location = new System.Drawing.Point(-22, 291);
            this.btnGame.Name = "btnGame";
            this.btnGame.ShadowDecoration.Parent = this.btnGame;
            this.btnGame.Size = new System.Drawing.Size(163, 52);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Trò Chơi";
            this.btnGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGame.TextOffset = new System.Drawing.Point(20, 0);
            this.btnGame.UseTransparentBackground = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 20;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.Checked = true;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHome.Location = new System.Drawing.Point(-22, 125);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(163, 52);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(20, 0);
            this.btnHome.UseTransparentBackground = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.BackColor = System.Drawing.Color.Transparent;
            this.btnDirectory.BorderRadius = 20;
            this.btnDirectory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDirectory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btnDirectory.CheckedState.Parent = this.btnDirectory;
            this.btnDirectory.CustomImages.Parent = this.btnDirectory;
            this.btnDirectory.FillColor = System.Drawing.Color.Transparent;
            this.btnDirectory.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnDirectory.ForeColor = System.Drawing.Color.White;
            this.btnDirectory.HoverState.Parent = this.btnDirectory;
            this.btnDirectory.Image = ((System.Drawing.Image)(resources.GetObject("btnDirectory.Image")));
            this.btnDirectory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDirectory.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnDirectory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDirectory.Location = new System.Drawing.Point(-22, 210);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.ShadowDecoration.Parent = this.btnDirectory;
            this.btnDirectory.Size = new System.Drawing.Size(163, 52);
            this.btnDirectory.TabIndex = 0;
            this.btnDirectory.Text = "Từ Điển";
            this.btnDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDirectory.TextOffset = new System.Drawing.Point(20, 0);
            this.btnDirectory.UseTransparentBackground = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 30);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.ShadowDecoration.Parent = this.panelChildForm;
            this.panelChildForm.Size = new System.Drawing.Size(800, 650);
            this.panelChildForm.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ Điển Anh Việt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel pnHeader;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnOut;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2Button btnGame;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        //private Home home1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

