using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevList
{
    static class Naiti_V_Baze
    {
        static Naiti_V_Baze() { }

        static public List<string[]> Perebor(List<string[]> baza, string[] slova)
        {
            int chislo_parametrov_dlia_sravnenia = 0;

            int chislo_naidennih_parametrov = 0;

            List<string[]> resultat = new List<string[]>();

            foreach (string stroka in slova)
            {
                if (stroka != "")
                    chislo_parametrov_dlia_sravnenia++;
            }

            if (chislo_parametrov_dlia_sravnenia > 0)
            {
                foreach (string[] stroka_iz_bazi in baza)
                {
                    for (int i = 0; i < slova.Length; i++)
                    {
                        if (i > 0)
                        {
                            if (slova[i] != "")
                            {
                                if (slova[i] == stroka_iz_bazi[i])
                                {
                                    chislo_naidennih_parametrov++;
                                }
                            }
                        }
                    }

                    if (chislo_naidennih_parametrov >= chislo_parametrov_dlia_sravnenia)
                    {
                        resultat.Add(stroka_iz_bazi);
                    }

                    chislo_naidennih_parametrov = 0;
                }
            }

            return resultat;
        }
    }
}