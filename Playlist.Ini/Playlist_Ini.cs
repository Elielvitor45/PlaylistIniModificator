using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniModificator.Playlist.Ini
{
    public class Playlist_Ini
    {
        public List<string> playlist_ini { get; set; } = new List<string>();
        public ChekingBlocks chekingBlocks { get; set; } = new ChekingBlocks();
        public Playlist_Ini(){
        }
        private bool UpdatePlaylistIni(List<string> bloco,bool blockType) {
            bool filter = false;
            int cont = 0;
            var condicion0 = playlist_ini.FirstOrDefault(x => x.Contains("[BLOCO COMERCIAL]"));
            var condicion1 = playlist_ini.FirstOrDefault(x => x.Contains("[BLOCO MUSICAL]"));
            for (int i = 0; i < playlist_ini.Count; i++)
            {
                if ((blockType == true && playlist_ini[i].Equals("[BLOCO COMERCIAL]") && !string.IsNullOrEmpty(condicion0)) || filter == true)
                {
                    filter = true;
                    playlist_ini[i] = bloco[cont];
                    cont++;

                    if (playlist_ini[i].Equals("FORMATO=AUTO"))
                    {
                        return true;
                    }
                    else if (playlist_ini[i].StartsWith("ARQUIVO="))
                    {
                        return true;
                    }
                }
                else if ((blockType == false && playlist_ini[i].Equals("[BLOCO MUSICAL]") && !string.IsNullOrEmpty(condicion1)) || filter == true)
                {
                    filter = true;
                    playlist_ini[i] = bloco[cont];
                    cont++;
                    if (playlist_ini[i].Equals("FORMATO=AUTO"))
                    {
                        return true;
                    }
                    else if (playlist_ini[i].StartsWith("ARQUIVO="))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void ReadPlaylist_ini(string path, bool Blocktype)
        {
            path += "\\PLAYLIST.ini";
            playlist_ini = File.ReadAllLines(path).ToList();
            chekingBlocks.init(playlist_ini,Blocktype);
        }
        public void ReadPlaylist_ini(string path, bool Blocktype, bool formatType, byte archiveType)
        {
            playlist_ini = File.ReadAllLines(path).ToList();
            WritePlaylist_ini(path, Blocktype, formatType, archiveType);
        }
        public void WritePlaylist_ini(string path, bool Blocktype, bool formatType, byte archiveType)
        {
            path += "\\PLAYLIST.ini";
            Blocos bloco = new Blocos(Blocktype, formatType, archiveType);
            if (UpdatePlaylistIni(bloco.blocos.Split('@').ToList(), Blocktype))
            {
                File.WriteAllLines(path, playlist_ini);
            }
            else
            {
                playlist_ini.Add("");
                playlist_ini.AddRange(bloco.blocos.Split('@').ToList());
                File.WriteAllLines(path, playlist_ini);
            }   
        }
    }

}