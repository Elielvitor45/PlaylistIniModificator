using IniModificator.BlocoComercial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IniModificator.Bloco_Musical
{
    public partial class Musical : Form
    {
        public Musical()
        {
            InitializeComponent();
        }
        private bool checkingGrade;
        private bool checkingDataN;
        private bool checkingDataS;
        private Form1 f2 = new Form1();
        private void checkBoxDataS_CheckedChanged(object sender, EventArgs e)
        {
            checkingGrade = checkGrade.Checked;
            checkingDataS = checkBoxDataS.Checked;
            checkingDataN = checkBoxDataN.Checked;
            CheckChanged(ref checkingDataS, ref checkingGrade, ref checkingDataN);
            checkGrade.Checked = checkingGrade;
            checkBoxDataS.Checked = checkingDataS;
            checkBoxDataN.Checked = checkingDataN;
        }
        private void checkBoxDataN_CheckedChanged(object sender, EventArgs e)
        {
            checkingGrade = checkGrade.Checked;
            checkingDataS = checkBoxDataS.Checked;
            checkingDataN = checkBoxDataN.Checked;
            CheckChanged(ref checkingDataN, ref checkingDataS, ref checkingGrade);
            checkGrade.Checked = checkingGrade;
            checkBoxDataS.Checked = checkingDataS;
            checkBoxDataN.Checked = checkingDataN;
        }
        private void checkGrade_CheckedChanged(object sender, EventArgs e)
        {
            checkingGrade = checkGrade.Checked;
            checkingDataS = checkBoxDataS.Checked;
            checkingDataN = checkBoxDataN.Checked;
            CheckChanged(ref checkingGrade, ref checkingDataS, ref checkingDataN);
            checkGrade.Checked = checkingGrade;
            checkBoxDataS.Checked = checkingDataS;
            checkBoxDataN.Checked = checkingDataN;
        }
        private void CheckChanged(ref bool maincheckbox, ref bool checkboxsecond01, ref bool checkboxsecond02)
        {
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
        private void checkTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTxt.Checked == true)
            {
                checkAuto.Checked = false;
            }
        }
        private void checkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuto.Checked == true)
            {
                checkTxt.Checked = false;
                checkGrade.Checked = false;
                checkBoxDataS.Checked = false;
                checkBoxDataN.Checked = false;
            }
        }
        private List<bool> BoolMusical()
        {
            List<bool> musical = new List<bool>();
            musical.Add(checkBoxDataN.Checked);
            musical.Add(checkBoxDataS.Checked);
            musical.Add(checkAuto.Checked);
            musical.Add(checkTxt.Checked);
            musical.Add(checkGrade.Checked);
            return musical;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ParameterMusical Musical = new ParameterMusical(f2.ini, BoolMusical(), f2.path);
        }
        private void Musical_Load(object sender, EventArgs e)
        {
            ChekingMusical cheking = new ChekingMusical(f2.ini);
            checkBoxDataN.Checked = cheking.chekingDataN;
            checkBoxDataS.Checked = cheking.chekingDataS;
            checkGrade.Checked = cheking.chekingGrade;
            checkAuto.Checked = cheking.auto;
            checkTxt.Checked = cheking.txt1;
        }
    }
}
