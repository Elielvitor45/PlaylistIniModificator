using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniModificator.Util
{
    public class CompareParameters
    {
        public List<bool> compareCommercialBlockParameter(List<string> ini) {
            List<bool> newparameter = new List<bool>();
            int cont = 0;
            foreach (var item in ini)
            {
                if (item.Trim().Equals("[BLOCOCOMERCIAL]"))
                {
                        newparameter.Add(true);
                    if (ini[cont].Trim().Equals("FORMATO=AUTO"))
                    {
                        newparameter.Add(true);
                    
                    } else if (ini[cont].Trim().Equals("FORMATO=TXT1")) {

                        newparameter.Add(false);
                    }
                }
                newparameter.Add(false);
                cont++;
            }
            return newparameter;
        }
        public List<bool> compareMusicBlockParameter(List<string> ini)
        {
            List<bool> newparameter = new List<bool>();
            int cont = 0;
            foreach (var item in ini)
            {
                if (item.Trim().Equals("[BLOCO MUSICAL]"))
                {
                    newparameter.Add(true);
                    if (ini[cont].Trim().Equals("FORMATO=AUTO"))
                    {
                        newparameter.Add(true);
                    }
                    else if (ini[cont].Trim().Equals("FORMATO=TXT1"))
                    {
                        newparameter.Add(false);
                    }
                }
                newparameter.Add(false);
                cont++;
            }
            return newparameter;
        }
        public List<bool> compareMusicWatchParameter(List<string> ini)
        {
            List<bool> newparameter = new List<bool>();
            int cont = 0;
            foreach (var item in ini)
            {
                if (item.Trim().Equals("[[RELOGIO MUSICAL]"))
                {
                    newparameter.Add(true);
                    if (ini[cont].Trim().Equals("FORMATO=AUTO"))
                    {
                        newparameter.Add(true);
                    }
                    else if (ini[cont].Trim().Equals("FORMATO=TXT1"))
                    {

                        newparameter.Add(false);
                    }
                }
                newparameter.Add(false);
                cont++;
            }
            return newparameter;
        }
        public bool compareAffiliateNet(List<string> ini) {

            foreach (var item in ini)
            {
                if (item.Trim().Equals("[AFILIADAS"))
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }
    }
}
