using IniModificator.Util;

namespace IniModificator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @textBox1.Text;
            path += @"\PLAYLIST.ini";
            ReadInit init = new ReadInit(path);










        }
    }
}