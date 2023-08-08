﻿using System;
using System.Collections;
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
     

        List<string> parameterList = new List<string>();
        public ParameterComercial(List<string> ini,List<bool> parameters,string path) {
            writingParameters(parameters);
            if (existsBlockCommercial(ini,path))
            {
                var buildlist = buildList(ini, parameters[2]);
                writWriteFile(buildlist, path);
            }
            else
            {
            }   
        }
        private void writingParameters(List<bool> parameters)
        {
            parameterList.Add("");
            parameterList.Add("[BLOCO COMERCIAL]");
            if (parameters[2] == true)
            {
                string add = "FORMATO=AUTO";
                parameterList.Add(add.Trim());
                parameterList.Add("");
            }else if (parameters[3] == true)
            {
                string add = "FORMATO=TXT1";
                parameterList.Add(add.Trim());
                if (parameters[0] == true)
                {
                    parameterList.Add("ARQUIVO=MAPAS\\%d-%m-%Y.TXT");
                }
                else if (parameters[1] == true)
                {
                    parameterList.Add("ARQUIVO=MAPAS\\%a.txt");
                }
                else if (parameters[4] == true)
                {
                    parameterList.Add("ARQUIVO=MAPAS\\Mapa.txt");
                }
            }
        }
        private bool existsBlockCommercial(List<string> ini,string path)
        {
            List<string> ini2 = ini;
            var condicion = ini2.FirstOrDefault(x => x.Contains("[BLOCO COMERCIAL]"));
            if (!string.IsNullOrEmpty(condicion))
            {
                return true;
            }
            else { 
                ini.AddRange(parameterList);
                writWriteFile(ini, path);
                return false;
            }
        }
        private List<string> getFormat(List<string> ini2) 
        {
            if (ini2 != null)
            {
            var palavrasModificadas = ini2
                .Select((p, i) => (Palavra: p, Indice: i))
                .SelectMany((x, index) =>
                {
                    if (x.Indice > 0 && ini2[x.Indice - 1] == "[BLOCO COMERCIAL]")
                        return new[] { x.Palavra + "-" + x.Indice };
                    else
                        return Enumerable.Empty<string>();
                })
                .ToList();
            palavrasModificadas.AddRange(palavrasModificadas[0].Split('-'));
            palavrasModificadas.RemoveAt(0);
            return palavrasModificadas;
            }
            else { return null; }
        }
        private List<string> buildList(List<string> ini, bool format)
        {
            List<string> Listformat = getFormat(ini);
            if (format == false)
            {
                ini = buildListFormatTxT1(ini, Listformat);
                return ini;
            }else if (format == true )
            {
                ini = BuildListFormatAuto(ini, Listformat);
                return ini;
            }
            else
            {
                return null;
            }
        }
        private List<string> BuildListFormatAuto(List<string> ini, List<string> palavrasModificadas)
        {
            List<string> ini2 = ini;
            ini2[int.Parse(palavrasModificadas[1])] = "FORMATO=AUTO";
            ini2[int.Parse(palavrasModificadas[1]) + 1] = "";
            return ini;
        }
        private List<string> buildListFormatTxT1(List<string> ini , List<string> palavrasModificadas) {
            List<string> ini2 = ini;
            ini2[int.Parse(palavrasModificadas[1])] = "FORMATO=TXT1";
            if (ini2.Count <= int.Parse(palavrasModificadas[1])+1)
            {
                ini2.Add("ARQUIVO=MAPAS");
            }
            else
            {
                ini2[int.Parse(palavrasModificadas[1]) + 1] = "ARQUIVO=MAPAS";
            }
            var arquiv2 = parameterList.FirstOrDefault(x => x.Contains("ARQUIVO=MAPAS")).Split('=')[1];
            ini2 = ini2.Select(x => x.Replace("MAPAS", arquiv2)).ToList();
            return ini2;
        }
        private void writWriteFile(List<string> ini,string path)
        {
            File.WriteAllLines(path, ini);
            MessageBox.Show("Lista Construida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
