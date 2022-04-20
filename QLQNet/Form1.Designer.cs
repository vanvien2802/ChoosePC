namespace QLQNet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpListPC = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1554, 110);
            this.panel1.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Rosewood Std Regular", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbName.Location = new System.Drawing.Point(561, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(496, 63);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Quán Net Sinh Viên";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 110);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::QLQNet.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flpListPC
            // 
            this.flpListPC.AutoScroll = true;
            this.flpListPC.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.flpListPC.AutoSize = true;
            this.flpListPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListPC.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.flpListPC.Location = new System.Drawing.Point(0, 110);
            this.flpListPC.Name = "flpListPC";
            this.flpListPC.Size = new System.Drawing.Size(1554, 941);
            this.flpListPC.TabIndex = 3;
            this.flpListPC.Paint += new System.Windows.Forms.PaintEventHandler(this.flpListPC_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 1051);
            this.Controls.Add(this.flpListPC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpListPC;
    }
}

