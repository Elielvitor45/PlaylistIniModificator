using IniModificator.Playlist.Ini;
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
        public string playlist_ini_path { get; set; }
        Playlist_Ini playlistIni = new Playlist_Ini();
        public Comercial(string playlist_ini_path)
        {
            InitializeComponent();
            this.playlist_ini_path = playlist_ini_path;
        }
        private bool checkingmap;
        private bool checkingDataN;
        private bool checkingDataS;
        private void Comercial_Load(object sender, EventArgs e)
        {
            playlistIni.ReadPlaylist_ini(playlist_ini_path, true);
            ReadCheking(playlistIni.chekingBlocks);
        }
        public void ReadCheking(ChekingBlocks check)
        {
            checkMapa.Checked = check.cheking_txt;
            checkBoxDataS.Checked = check.chekingDataS;
            checkBoxDataN.Checked = check.chekingDataN;
            checkAuto.Checked = check.auto;
            checkTxt.Checked = check.formatTxt1;

        }



        public byte getArchiveType()
        {
            byte archiveType = new byte();
            if (checkMapa.Checked == true)
            {
                archiveType = 0;
            }
            else if (checkingDataN == true)
            {
                archiveType = 1;
            }
            else if (checkingDataS == true)
            {
                archiveType= 2;
            }
            return archiveType;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            playlistIni.ReadPlaylist_ini(playlist_ini_path,true,checkTxt.Checked, getArchiveType());
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
