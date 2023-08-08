using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniModificator.Bloco_Musical
{
    public class ChekingMusical
    {
        public bool chekingGrade { get; set; }
        public bool chekingDataS { get; set; }
        public bool chekingDataN { get; set; }
        public bool auto { get; set; }
        public bool txt1 { get; set; }

        public ChekingMusical(List<string> ini) {

            GeneralCheck(ini);
        }
        private void GeneralCheck(List<string> ini)
        {
            List<string> format = GetFormat(ini);
            ReadFormat(format);
            if (auto == true)
            {
                chekingGrade = false;
                chekingDataS = false;
                chekingDataN = false;
            }
            else if (auto == false)
            {
                ReadArchive(format[1], ini);
            }
        }
        private void ReadArchive(string format, List<string> ini)
        {
            int pos = int.Parse(format);
            if (ini[pos + 1].Equals(@"ARQUIVO=GRADES\Grade.txt"))
            {

                chekingGrade = true;
                chekingDataN = false;
                chekingDataS = false;

            }
            else if (ini[pos + 1].Equals(@"ARQUIVO=GRADES\%d-%m-%Y.TXT"))
            {
                chekingDataN = true;
                chekingGrade = false;
                chekingDataS = false;


            }
            else if (ini[pos + 1].Equals(@"ARQUIVO=GRADES\%a.txt"))
            {
                chekingDataS = true;
                chekingDataN = false;
                chekingGrade = false;
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
                txt1 = false;
            }
            else if (format[0].Equals("FORMATO=TXT1"))
            {
                auto = false;
                txt1 = true;
            }
        }
        private List<string> GetFormat(List<string> ini2)
        {
            if (ini2 != null)
            {
                var palavrasModificadas = ini2
                    .Select((p, i) => (Palavra: p, Indice: i))
                    .SelectMany((x, index) =>
                    {
                        if (x.Indice > 0 && ini2[x.Indice - 1] == "[BLOCO MUSICAL]")
                            return new[] { x.Palavra + "-" + x.Indice };
                        else
                            return Enumerable.Empty<string>();
                    })
                    .ToList();
                palavrasModificadas.AddRange(palavrasModificadas[0].Split('-'));
                palavrasModificadas.RemoveAt(0);
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
