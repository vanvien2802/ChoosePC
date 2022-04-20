using ChoosePC_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQNet
{
    public class QLPC
    {
        public List<PC> createPc()
        {
            List<PC> pc = new List<PC>();
            pc.AddRange(new PC[]
            {
                new PC{Name ="Máy 1", IDMay = "PC1", Status = true},
                new PC{Name ="Máy 2", IDMay = "PC2", Status = true},
                new PC{Name ="Máy 3", IDMay = "PC3", Status = false},
                new PC{Name ="Máy 4", IDMay = "PC4", Status = false},
            });
            return pc;
        }
    }
}
