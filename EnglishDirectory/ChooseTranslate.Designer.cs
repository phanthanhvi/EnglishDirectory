namespace EnglishDirectory
{
    partial class ChooseTranslate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTranslate));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAV = new Guna.UI2.WinForms.Guna2Button();
            this.btnVA = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Lac Long Quan", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng chọn chức năng:";
            // 
            // btnAV
            // 
            this.btnAV.BorderRadius = 30;
            this.btnAV.CheckedState.Parent = this.btnAV;
            this.btnAV.CustomImages.Parent = this.btnAV;
            this.btnAV.FillColor = System.Drawing.Color.DarkOrange;
            this.btnAV.Font = new System.Drawing.Font("UVN Nhan Nang", 20F);
            this.btnAV.ForeColor = System.Drawing.Color.White;
            this.btnAV.HoverState.Parent = this.btnAV;
            this.btnAV.Image = ((System.Drawing.Image)(resources.GetObject("btnAV.Image")));
            this.btnAV.ImageOffset = new System.Drawing.Point(58, -70);
            this.btnAV.ImageSize = new System.Drawing.Size(80, 80);
            this.btnAV.Location = new System.Drawing.Point(51, 212);
            this.btnAV.Name = "btnAV";
            this.btnAV.ShadowDecoration.Parent = this.btnAV;
            this.btnAV.Size = new System.Drawing.Size(293, 272);
            this.btnAV.TabIndex = 1;
            this.btnAV.Text = "DỊCH ANH - VIỆT";
            this.btnAV.TextOffset = new System.Drawing.Point(-20, 40);
            this.btnAV.Click += new System.EventHandler(this.btnAV_Click);
            // 
            // btnVA
            // 
            this.btnVA.BorderRadius = 30;
            this.btnVA.CheckedState.Parent = this.btnVA;
            this.btnVA.CustomImages.Parent = this.btnVA;
            this.btnVA.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnVA.Font = new System.Drawing.Font("UVN Nhan Nang", 20F);
            this.btnVA.ForeColor = System.Drawing.Color.White;
            this.btnVA.HoverState.Parent = this.btnVA;
            this.btnVA.Image = ((System.Drawing.Image)(resources.GetObject("btnVA.Image")));
            this.btnVA.ImageOffset = new System.Drawing.Point(58, -70);
            this.btnVA.ImageSize = new System.Drawing.Size(80, 80);
            this.btnVA.Location = new System.Drawing.Point(445, 212);
            this.btnVA.Name = "btnVA";
            this.btnVA.ShadowDecoration.Parent = this.btnVA;
            this.btnVA.Size = new System.Drawing.Size(293, 272);
            this.btnVA.TabIndex = 1;
            this.btnVA.Text = "DỊCH VIỆT - ANH";
            this.btnVA.TextOffset = new System.Drawing.Point(-20, 40);
            this.btnVA.Click += new System.EventHandler(this.btnVA_Click);
            // 
            // ChooseTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.btnVA);
            this.Controls.Add(this.btnAV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseTranslate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAV;
        private Guna.UI2.WinForms.Guna2Button btnVA;
    }
}
