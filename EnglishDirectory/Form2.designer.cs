namespace TimChu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnStar = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Algerian", 50.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(169, 29);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label1.Size = new System.Drawing.Size(435, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Words";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(62, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thể Lệ ";
            // 
            // lb2
            // 
            this.lb2.Location = new System.Drawing.Point(6, 38);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(654, 46);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "      Tìm các chữ theo hàng dọc ,ngang, chéo trong khoảng thời gian nhanh nhất ! " +
    "   ";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.SkyBlue;
            this.btn2.Location = new System.Drawing.Point(400, 241);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(250, 100);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Computer";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Form2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.SkyBlue;
            this.btn3.Location = new System.Drawing.Point(152, 340);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(250, 100);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Fruits";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Form2_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.SkyBlue;
            this.btn4.Location = new System.Drawing.Point(400, 340);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(250, 100);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "Country";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Form2_Click);
            // 
            // btnStar
            // 
            this.btnStar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnStar.ForeColor = System.Drawing.Color.Black;
            this.btnStar.Location = new System.Drawing.Point(237, 505);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(120, 47);
            this.btnStar.TabIndex = 6;
            this.btnStar.Text = "Bắt Đầu";
            this.btnStar.UseVisualStyleBackColor = false;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.SkyBlue;
            this.btn1.Location = new System.Drawing.Point(152, 241);
            this.btn1.Margin = new System.Windows.Forms.Padding(5);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(2);
            this.btn1.Size = new System.Drawing.Size(250, 100);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Animals";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Form2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(463, 505);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 47);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnStar);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 650);
            this.panel1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}