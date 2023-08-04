using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace IniModificator.BlocoComercial
{
    public class ParameterComercial
    {
        public bool existAuto { get; set; }
        public bool existTxt { get; set; }

        List<string> list = new List<string>();
        public ParameterComercial(List<string> ini,List<bool> parameters,string path) {
            readCommercial(ini);
            writingParameters(parameters);
            var list = buildList(ini);
            writWriteFile(list,path);
        }
        public void readCommercial(List<string> ini)
        {
            for (int i = 0; i < ini.Count; i++)
            {
                if (ini[i].Equals("[BLOCO COMERCIAL]"))
                {
                    if (ini[i+1].Equals("FORMATO=AUTO"))
                    {
                        existAuto = true;
                        break;
                    }
                    else
                    {
                        existTxt = true;
                        break;

                    }
                }
            }
        }
        public void writingParameters(List<bool> parameters)
        {
            list.Add("");
            list.Add("[BLOCO COMERCIAL]");
            if (parameters[2] == true)
            {
                string add = "FORMATO=AUTO";
                list.Add(add.Trim());
                list.Add("");
            }else if (parameters[3] == true)
            {
                string add = "FORMATO=TXT1";
                list.Add(add.Trim());
                if (parameters[0] == true)
                {
                    list.Add("ARQUIVO=MAPAS\\%d%m%Y.TXT");
                }
                else if (parameters[1] == true)
                {
                    list.Add("ARQUIVO=MAPAS\\%a.txt");
                }
                else if (parameters[4] == true)
                {
                    list.Add("ARQUIVO=MAPAS\\Mapa.txt");
                }
            }
        }
        public List<string> buildList(List<string> ini)
        {
            var ini2 = ini;
            var condicion = ini2.FirstOrDefault(x => x.Contains("[BLOCO COMERCIAL]"));
            if (condicion != null)
            {
                //EstouModificandoEsseLugarAtualmente
                var formato = ini2.FirstOrDefault(x => x.Contains("FORMATO=")).Split('=')[1];
                var formato2 = list.FirstOrDefault(x => x.Contains("FORMATO=")).Split('=')[1];
                int pos = ini2.FindIndex(x => x.Contains("FORMATO=AUTO"));
                var arquivo = ini2.FirstOrDefault(x => x.Contains("ARQUIVO=MAPAS"))?.Split('=')[1];
                if (string.IsNullOrEmpty(arquivo))
                {
                    ini2[pos + 1] = "ARQUIVO=MAPAS";
                    arquivo = "MAPAS";
                }
                var arquiv2 = list.FirstOrDefault(x => x.Contains("ARQUIVO=MAPAS")).Split('=')[1];
                var format = ini2.Select(x => x.Replace(formato, formato2)).ToList();
                var format2 = format.Select(x => x.Replace(arquivo, arquiv2)).ToList();
                return format2;
            }
            ini.AddRange(list);
            return ini;
        }
        public void writWriteFile(List<string> ini,string path)
        {
            File.WriteAllLines(path, ini);
        }
    }
}
