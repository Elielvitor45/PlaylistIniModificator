using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IniModificator.BlocoComercial
{
    public partial class Comercial : Form
    {
        public Comercial()
        {
            InitializeComponent();
        }
        

        private void Comercial_Load(object sender, EventArgs e)
        {

            

        }
        private List<bool> boolComercial()
        {
            List<bool> comercial = new List<bool>();
            comercial.Add(checkBoxDataN.Checked);
            comercial.Add(checkBoxDataS.Checked);
            comercial.Add(checkAuto.Checked);
            comercial.Add(checkTxt.Checked);
            comercial.Add(checkMapa.Checked);
            return comercial;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            ParameterComercial comercial = new ParameterComercial(f2.ini,boolComercial(),f2.path);










        }
    }
}
