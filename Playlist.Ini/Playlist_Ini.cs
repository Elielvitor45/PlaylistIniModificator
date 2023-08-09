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

        public Playlist_Ini(){

        }
        private void UpdatePlaylistIni(List<string> bloco,bool blockType) {
            bool filter = false;
            int cont = 0;
            for (int i = 0; i < playlist_ini.Count; i++)
            {
                if ((blockType == true && playlist_ini[i].Equals("[BLOCO COMERCIAL]")) || filter == true)
                {
                    filter = true;
                    playlist_ini[i] = bloco[cont];
                    cont++;

                    if (playlist_ini[i].Equals("FORMATO=AUTO"))
                    {
                        break;
                    }
                    else if (playlist_ini[i].StartsWith("ARQUIVO="))
                    {
                        break;
                    }
                }
                else if ((blockType == false && playlist_ini[i].Equals("[BLOCO MUSICAL]")) || filter == true)
                {
                    filter = true;
                    playlist_ini[i] = bloco[cont];
                    cont++;
                    if (playlist_ini[i].Equals("FORMATO=AUTO"))
                    {
                        break;
                    }
                    else if (playlist_ini[i].StartsWith("ARQUIVO="))
                    {
                        break;
                    }
                }
            }
        }
        public void ReadPlaylist_ini(string path, bool Blocktype, bool formatType, byte archiveType)
        {
            path = @"C:\Playlist\pgm\PLAYLIST.ini";
            playlist_ini = File.ReadAllLines(path).ToList();
            WritePlaylist_ini(path, Blocktype, formatType, archiveType);
        }
        public void WritePlaylist_ini(string path, bool Blocktype, bool formatType, byte archiveType)
        {
            Blocos bloco = new Blocos(Blocktype, formatType,archiveType);
            UpdatePlaylistIni(bloco.blocos.Split('@').ToList(), Blocktype);
            File.WriteAllLines(path, playlist_ini);
        }
    }
}
