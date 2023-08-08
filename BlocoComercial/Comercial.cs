using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace IniModificator.BlocoComercial
{
    public partial class Comercial : Form
    {
        public Comercial()
        {
            InitializeComponent();
        }
        private bool checkingmap;
        private bool checkingDataN;
        private bool checkingDataS;
        private Form1 f2 = new Form1();
        private void Comercial_Load(object sender, EventArgs e)
        {
            ChekingComercial cheking = new ChekingComercial(f2.ini);
            checkBoxDataN.Checked = cheking.chekingDataN;
            checkBoxDataS.Checked = cheking.chekingDataS;
            checkMapa.Checked = cheking.chekingMap;
            checkAuto.Checked = cheking.auto;
            checkTxt.Checked = cheking.txt1;
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
            ParameterComercial comercial = new ParameterComercial(f2.ini,boolComercial(),f2.path);
        }
        private void checkMapa_CheckedChanged(object sender, EventArgs e)
        {
            checkingmap = checkMapa.Checked;
            checkingDataS = checkBoxDataS.Checked;
            checkingDataN = checkBoxDataN.Checked;
            CheckChanged(ref checkingmap, ref checkingDataS, ref checkingDataN);
            checkMapa.Checked = checkingmap;
            checkBoxDataS.Checked = checkingDataS;
            checkBoxDataN.Checked = checkingDataN;
        }
        private void CheckChanged(ref bool maincheckbox, ref bool checkboxsecond01, ref bool checkboxsecond02) {
            if (checkAuto.Checked == true && maincheckbox == true)
            {
                maincheckbox = false;
            }
            else if (maincheckbox == true)
            {
                checkTxt.Checked = true;
                checkboxsecond01 = false;
                checkboxsecond02 = false;
            }
        }
        private void checkBoxDataN_CheckedChanged(object sender, EventArgs e)
        {
            checkingmap = checkMapa.Checked;
            checkingDataS = checkBoxDataS.Checked;
            checkingDataN = checkBoxDataN.Checked;
            CheckChanged(ref checkingDataN, ref checkingDataS, ref checkingmap);
            checkMapa.Checked = checkingmap;
            checkBoxDataS.Checked = checkingDataS;
            checkBoxDataN.Checked = checkingDataN;
        }
        private void checkBoxDataS_CheckedChanged(object sender, EventArgs e)
        {
            checkingmap = checkMapa.Checked;
            checkingDataS = checkBoxDataS.Checked;
            checkingDataN = checkBoxDataN.Checked;
            CheckChanged(ref checkingDataS, ref checkingmap, ref checkingDataN);
            checkMapa.Checked = checkingmap;
            checkBoxDataS.Checked = checkingDataS;
            checkBoxDataN.Checked = checkingDataN;
        }
        private void checkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuto.Checked == true)
            {
                checkTxt.Checked = false;
                checkMapa.Checked = false;
                checkBoxDataS.Checked = false;
                checkBoxDataN.Checked=false;
            }
        }
        private void checkTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTxt.Checked == true)
            {
                checkAuto.Checked = false;
            }
        }
    }
}
