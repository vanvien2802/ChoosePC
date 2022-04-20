using QLQNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoosePC_UI
{
    
    public partial class DetailPC : Form
    {
        public delegate void Mydel(string Message);
        public Mydel d;
        public DetailPC()
        {
            InitializeComponent();
            d= new Mydel(setName);
            createLPc();
        }
        List<PC> pc = new List<PC>();
        private List<PC> createLPc()
        {
            pc.AddRange(new PC[]
            {
                new PC{Name ="Máy 1", IDMay = "PC1", Status = true},
                new PC{Name ="Máy 2", IDMay = "PC2", Status = true},
                new PC{Name ="Máy 3", IDMay = "PC3", Status = false},
                new PC{Name ="Máy 3", IDMay = "PC3", Status = false},
            });
            return pc;
        }

        private void tbTenMay_TextChanged(object sender, EventArgs e)
        {

        }

        public void setName(string txt)
        {
            tbTenMay.Text = txt;
        }
    }
}
