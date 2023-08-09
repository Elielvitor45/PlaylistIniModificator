using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniModificator.Playlist.Ini
{
    public class Blocos
    {
        public string blocos { get; set; } 
        public bool blockType { get; set; }

        public Blocos(bool BlockType, bool FormatType, byte ArchiveType) {
            this.blockType = BlockType;
            ReadTypeBlock();
            ReadFormatAndArchivetype(FormatType, ArchiveType);
        }
        private void ReadTypeBlock()
        {
            if (blockType == true)
            {
                blocos = "[BLOCO COMERCIAL]@";
            }
            else
            {
                blocos = "[BLOCO MUSICAL]@";
            }
        }
        private void ReadFormatAndArchivetype(bool formatType, byte archiveType) {
            if (formatType == true)
            {
                blocos += "FORMATO=TXT1@";
                if (archiveType == 1)
                {
                    blocos += "ARQUIVO=GRADES\\%d-%m-%Y.TXT";
                }
                else if (archiveType == 2)
                {
                    blocos += "ARQUIVO=GRADES\\%a.txt";
                }
                else if (archiveType == 0 && blockType == true)
                {
                    blocos += "ARQUIVO=GRADES\\Mapa.txt";
                }
                else if (archiveType == 0 && blockType == false)
                {
                    blocos += "ARQUIVO=GRADES\\Grade.txt";
                }
            }
            else
            {
                blocos += "FORMATO=AUTO";
                blocos += " ";
            }
        }
    }
}
