using ChoosePC_UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQNet
{
    public partial class Form1 : Form
    {
        QLPC ql = new QLPC();
        public Form1()
        {
            InitializeComponent();
            AddPC();
        }

        public string PC1 { get; private set; }
        string txt;
        PictureBox picture;
        Label label1;
        private void AddPC()
        {
            int i=1;
            foreach(PC p in ql.createPc())
            {

                picture = new PictureBox
                {
                    Name = p.Name,
                    Size = new Size(272, 223),
                    Location = new Point(0, 3),
                    Image = global::QLQNet.Properties.Resources.PC,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    BackColor = System.Drawing.Color.DarkSeaGreen,
                    TabIndex = 3,
                    TabStop = false,
                };
                label1 = new Label()
                {
                    AutoSize = true,
                    BackColor = System.Drawing.SystemColors.ActiveCaption,
                    Font = new System.Drawing.Font("Rosewood Std Regular", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(101, 3),
                    Name = "label1",
                    Size = new System.Drawing.Size(80, 33),
                    TabIndex = 1,
                    Text = "Máy " + i.ToString(),
                };
                Panel panel1 = new Panel()
                {
                Location = new System.Drawing.Point(3, 3),
                Name = "panel2",
                Size = new System.Drawing.Size(275, 226),
                    TabIndex = 0,
                };
                

                picture.SendToBack();
                panel1.Controls.Add(label1);
                panel1.Controls.Add(picture);
                flpListPC.Controls.Add(panel1);

                picture.DoubleClick += pbMay_DoubleClick;

                i++;
            }

            
        }

        private void pbMay_DoubleClick(object sender, EventArgs e)
        {
            
            MessageBox.Show(txt);

            DetailPC f = new DetailPC();
            f.d(txt);
            f.Show();

        }
        private string text(string txt)
        {
            return txt;
        }

        private void flpListPC_Paint(object sender, PaintEventArgs e)
        {

        }
        //private void LoadEvent()
        //{
        //    foreach(Control i in this.Controls)
        //    {
        //        if (i is PictureBox)
        //        {
        //            txt = i.Name;
        //            i.DoubleClick += new System.EventHandler(this.pbMay_DoubleClick);
        //        }
        //    }
        //}

    }
}
