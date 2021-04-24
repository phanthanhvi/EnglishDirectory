namespace EnglishDirectory
{
    partial class ChooseGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGame));
            this.label1 = new System.Windows.Forms.Label();
            this.pnGame1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGame1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnGame2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGame2 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnGame3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGame3 = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pnGame1.SuspendLayout();
            this.pnGame2.SuspendLayout();
            this.pnGame3.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("UVN Huong Que Nang", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vui Lòng Chọn Game:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnGame1
            // 
            this.pnGame1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.pnGame1.BorderRadius = 30;
            this.pnGame1.BorderThickness = 2;
            this.pnGame1.Controls.Add(this.btnGame1);
            this.pnGame1.Controls.Add(this.label2);
            this.pnGame1.Location = new System.Drawing.Point(24, 109);
            this.pnGame1.MaximumSize = new System.Drawing.Size(737, 119);
            this.pnGame1.MinimumSize = new System.Drawing.Size(205, 119);
            this.pnGame1.Name = "pnGame1";
            this.pnGame1.ShadowDecoration.Parent = this.pnGame1;
            this.pnGame1.Size = new System.Drawing.Size(205, 119);
            this.pnGame1.TabIndex = 3;
            // 
            // btnGame1
            // 
            this.btnGame1.BackColor = System.Drawing.Color.Transparent;
            this.btnGame1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btnGame1.BorderRadius = 30;
            this.btnGame1.BorderThickness = 2;
            this.btnGame1.CheckedState.Parent = this.btnGame1;
            this.btnGame1.CustomImages.Parent = this.btnGame1;
            this.btnGame1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGame1.FillColor = System.Drawing.Color.OrangeRed;
            this.btnGame1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnGame1.ForeColor = System.Drawing.Color.White;
            this.btnGame1.HoverState.Parent = this.btnGame1;
            this.btnGame1.Image = ((System.Drawing.Image)(resources.GetObject("btnGame1.Image")));
            this.btnGame1.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnGame1.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGame1.Location = new System.Drawing.Point(0, 0);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.ShadowDecoration.Parent = this.btnGame1;
            this.btnGame1.Size = new System.Drawing.Size(205, 119);
            this.btnGame1.TabIndex = 0;
            this.btnGame1.Text = "Trả Lời Câu Hỏi";
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            this.btnGame1.MouseLeave += new System.EventHandler(this.btnGame1_MouseLeave);
            this.btnGame1.MouseHover += new System.EventHandler(this.btnGame1_MouseHover);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("UVN Thay Giao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-321, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 119);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnGame2
            // 
            this.pnGame2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.pnGame2.BorderRadius = 30;
            this.pnGame2.BorderThickness = 2;
            this.pnGame2.Controls.Add(this.btnGame2);
            this.pnGame2.Controls.Add(this.label3);
            this.pnGame2.Location = new System.Drawing.Point(24, 299);
            this.pnGame2.MaximumSize = new System.Drawing.Size(737, 119);
            this.pnGame2.MinimumSize = new System.Drawing.Size(205, 119);
            this.pnGame2.Name = "pnGame2";
            this.pnGame2.ShadowDecoration.Parent = this.pnGame2;
            this.pnGame2.Size = new System.Drawing.Size(205, 119);
            this.pnGame2.TabIndex = 4;
            // 
            // btnGame2
            // 
            this.btnGame2.BackColor = System.Drawing.Color.Transparent;
            this.btnGame2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btnGame2.BorderRadius = 30;
            this.btnGame2.BorderThickness = 2;
            this.btnGame2.CheckedState.Parent = this.btnGame2;
            this.btnGame2.CustomImages.Parent = this.btnGame2;
            this.btnGame2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGame2.FillColor = System.Drawing.Color.LimeGreen;
            this.btnGame2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnGame2.ForeColor = System.Drawing.Color.White;
            this.btnGame2.HoverState.Parent = this.btnGame2;
            this.btnGame2.Image = ((System.Drawing.Image)(resources.GetObject("btnGame2.Image")));
            this.btnGame2.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnGame2.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGame2.Location = new System.Drawing.Point(0, 0);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.ShadowDecoration.Parent = this.btnGame2;
            this.btnGame2.Size = new System.Drawing.Size(205, 119);
            this.btnGame2.TabIndex = 0;
            this.btnGame2.Text = "Điền Từ";
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            this.btnGame2.MouseLeave += new System.EventHandler(this.btnGame2_MouseLeave);
            this.btnGame2.MouseHover += new System.EventHandler(this.btnGame2_MouseHover);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("UVN Thay Giao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-321, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(526, 119);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnGame3
            // 
            this.pnGame3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.pnGame3.BorderRadius = 30;
            this.pnGame3.BorderThickness = 2;
            this.pnGame3.Controls.Add(this.btnGame3);
            this.pnGame3.Controls.Add(this.label4);
            this.pnGame3.Location = new System.Drawing.Point(24, 490);
            this.pnGame3.MaximumSize = new System.Drawing.Size(737, 119);
            this.pnGame3.MinimumSize = new System.Drawing.Size(205, 119);
            this.pnGame3.Name = "pnGame3";
            this.pnGame3.ShadowDecoration.Parent = this.pnGame3;
            this.pnGame3.Size = new System.Drawing.Size(205, 119);
            this.pnGame3.TabIndex = 5;
            // 
            // btnGame3
            // 
            this.btnGame3.BackColor = System.Drawing.Color.Transparent;
            this.btnGame3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btnGame3.BorderRadius = 30;
            this.btnGame3.BorderThickness = 2;
            this.btnGame3.CheckedState.Parent = this.btnGame3;
            this.btnGame3.CustomImages.Parent = this.btnGame3;
            this.btnGame3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGame3.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnGame3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnGame3.ForeColor = System.Drawing.Color.White;
            this.btnGame3.HoverState.Parent = this.btnGame3;
            this.btnGame3.Image = ((System.Drawing.Image)(resources.GetObject("btnGame3.Image")));
            this.btnGame3.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnGame3.ImageSize = new System.Drawing.Size(50, 50);
            this.btnGame3.Location = new System.Drawing.Point(0, 0);
            this.btnGame3.Name = "btnGame3";
            this.btnGame3.ShadowDecoration.Parent = this.btnGame3;
            this.btnGame3.Size = new System.Drawing.Size(205, 119);
            this.btnGame3.TabIndex = 0;
            this.btnGame3.Text = "Tìm Chữ";
            this.btnGame3.Click += new System.EventHandler(this.btnGame3_Click);
            this.btnGame3.MouseLeave += new System.EventHandler(this.btnGame3_MouseLeave);
            this.btnGame3.MouseHover += new System.EventHandler(this.btnGame3_MouseHover);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("UVN Thay Giao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-321, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 119);
            this.label4.TabIndex = 1;
            this.label4.Text = "+ Những chữ cần tìm sẽ cho trước.\r\n+ Người chơi có 1 khoàng thời gian để tìm được" +
    " những chữ đó trong khối hình vuông.\r\n+ Trò chơi sẽ tính giờ khi bắt đầu.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 5;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChildForm.Controls.Add(this.pnGame2);
            this.panelChildForm.Controls.Add(this.pnGame3);
            this.panelChildForm.Controls.Add(this.pnGame1);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(800, 650);
            this.panelChildForm.TabIndex = 6;
            // 
            // ChooseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseGame";
            this.Text = "ChooseGame";
            this.pnGame1.ResumeLayout(false);
            this.pnGame2.ResumeLayout(false);
            this.pnGame3.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnGame1;
        private Guna.UI2.WinForms.Guna2Button btnGame1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnGame2;
        private Guna.UI2.WinForms.Guna2Button btnGame2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel pnGame3;
        private Guna.UI2.WinForms.Guna2Button btnGame3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panelChildForm;
    }
}