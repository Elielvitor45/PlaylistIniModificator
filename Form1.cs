using IniModificator.Bloco_Musical;
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
            try
            {
                ini = File.ReadAllLines(path).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }
        private void configurarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Comercial commercialWindow = new Comercial();
            commercialWindow.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string pathF = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Reset();
            if (!File.Exists(pathF + @"\PLAYLIST.ini"))
            {
                MessageBox.Show("Arquivo 'PLAYLIST.ini' não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                textBox.Text = pathF;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void configurarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Musical musicalWindow = new Musical();
            musicalWindow.ShowDialog();


        }
    }
}