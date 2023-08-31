using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniModificator.Playlist.Ini
{
    public class ChekingBlocks
    {
        public bool cheking_txt { get; set; }
        public bool chekingDataS { get; set; }
        public bool chekingDataN { get; set; }
        public bool blocktype { get; set; }
        public bool auto { get; set; }
        public bool formatTxt1 { get; set; }

        public ChekingBlocks()
        {
        }
        public void init(List<string> ini, bool blocktype)
        {
            this.blocktype = blocktype;
            GeneralCheck(ini);
        }

        private string checkingBlock()
        {
            string block;
            if (blocktype == true)
            {
                return block = "[BLOCO COMERCIAL]";
            }
            else
            {
                return block = "[BLOCO MUSICAL]";
            }
        }
        private void GeneralCheck(List<string> ini)
        {
            List<string> format = GetFormat(ini);
            if (format == null)
            {
                cheking_txt = false;
                chekingDataS = false;
                chekingDataN = false;
                auto = false;
                formatTxt1 = false;
            }
            else
            {
                ReadFormat(format);
                if (auto == true)
                {
                    cheking_txt = false;
                    chekingDataS = false;
                    chekingDataN = false;
                }
                else if (auto == false)
                {
                    ReadArchive(format[1], ini);
                }
            }
        }
        private void ReadArchive(string format, List<string> ini)
        {
            string nameDiretory;
            string nameTxt;
            if (blocktype == true)
            {
                nameDiretory = "MAPAS";
                nameTxt = "Mapa";
            }
            else
            {
                nameDiretory = "GRADES";
                nameTxt = "Grade";
            }
            int pos = int.Parse(format);
            if (ini[pos + 1].Equals(@$"ARQUIVO={nameDiretory}\{nameTxt}.txt"))
            {

                cheking_txt = true;
                chekingDataN = false;
                chekingDataS = false;

            }
            else if (ini[pos + 1].Equals(@$"ARQUIVO={nameDiretory}\%d-%m-%Y.TXT"))
            {
                chekingDataN = true;
                cheking_txt = false;
                chekingDataS = false;


            }
            else if (ini[pos + 1].Equals(@$"ARQUIVO={nameDiretory}\%a.txt"))
            {
                chekingDataS = true;
                chekingDataN = false;
                cheking_txt = false;
            }
            else
            {
            }
        }
        private void ReadFormat(List<string> format)
        {
            if (format[0].Equals("FORMATO=AUTO"))
            {
                auto = true;
                formatTxt1 = false;
            }
            else if (format[0].Equals("FORMATO=TXT1"))
            {
                auto = false;
                formatTxt1 = true;
            }
        }
        private List<string> GetFormat(List<string> ini2)
        {
            string block = checkingBlock();
            if (ini2 != null)
            {
                var palavrasModificadas = ini2
                    .Select((p, i) => (Palavra: p, Indice: i))
                    .SelectMany((x, index) =>
                    {
                        if (x.Indice > 0 && ini2[x.Indice - 1] == block)
                            return new[] { x.Palavra + "-" + x.Indice };
                        else
                            return Enumerable.Empty<string>();
                    })
                    .ToList();
                try
                {
                    palavrasModificadas.AddRange(palavrasModificadas[0].Split('-'));
                    palavrasModificadas.RemoveAt(0);
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
                return palavrasModificadas;
            }
            else
            {

                MessageBox.Show("Playlist.ini não pode ser nulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
