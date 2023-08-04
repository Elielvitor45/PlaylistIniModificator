using IniModificator.BlocoComercial;
using IniModificator.Util;
using static System.Windows.Forms.LinkLabel;

namespace IniModificator
{
    public partial class Form1 : Form
    {
        public string path { get; set; }
        public List<string> ini { get; set; } = new List<string>();
     
        public Form1()
        {
            InitializeComponent();
            textBox.Text = @"C:\Playlist\pgm";
            path = textBox.Text;
            path += @"\PLAYLIST.ini";
            ini = File.ReadAllLines(path).ToList();
        }
        private void configurarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Comercial CommercialWindow = new Comercial();
            // Set the Parent Form of the Child window.
            // Display the new form.
            CommercialWindow.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string pathF = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Reset();
            if (!File.Exists(pathF + @"\PLAYLIST.ini"))
            {
                MessageBox.Show("Arquiv 'PLAYLIST.ini' não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                textBox.Text = pathF;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Text = @"C:\Playlist\pgm";
        }
    }
}