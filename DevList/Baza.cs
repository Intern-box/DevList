﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;


namespace DevList
{
    public class Baza
    {
        public string Adres;
        public List<string[]> Tablica = new List<string[]>();
        public bool Izmenenie = false;

        public Baza(string adres)
        {
            Adres = adres;

            foreach (string stroka in File.ReadAllLines(adres))
            {
                stroka.TrimEnd('\r');

                stroka.TrimEnd('\n');

                Tablica.Add(stroka.Split(','));
            }
        }

        public void Zapisat()
        {
            File.WriteAllLines(Adres, Tablica.Select(x => string.Join(",", x)));
        }

        public void Zapisat(string adres)
        {
            File.WriteAllLines(adres, Tablica.Select(x => string.Join(",", x)));
        }

        public void PeremeschenieStroki(int nomer_pervoi, int nomer_vtoroi)
        {
            string[] zapominaem_pervuiu = new string[Tablica[nomer_pervoi].Length];

            for (int i = 0; i < Tablica[nomer_pervoi].Length; i++)
            {
                zapominaem_pervuiu[i] = Tablica[nomer_pervoi][i];
            }

            for (int i = 0; i < Tablica[nomer_pervoi].Length; i++)
            {
                Tablica[nomer_pervoi][i] = Tablica[nomer_vtoroi][i];
            }

            for (int i = 0; i < Tablica[nomer_pervoi].Length; i++)
            {
                Tablica[nomer_vtoroi][i] = zapominaem_pervuiu[i];
            }
        }

        public List<string[]> Poisk_Strok(string[] zapros)
        {
            List<string[]> resultat = new List<string[]>();

            byte skolko_nado_naiti_sovpadenii = 0;

            for (int i = 1; i < zapros.Length; i++)
            {
                if (zapros[i] != null && zapros[i] != "")
                {
                    skolko_nado_naiti_sovpadenii++;
                }
            }

            byte naideno_sovpadenii = 0;

            foreach (string[] stroka in Tablica)
            {
                for (int i = 1; i < Tablica[0].Length; i++)
                {
                    if (zapros[i] != null && zapros[i] != "")
                    {
                        if (stroka[i].IndexOf(zapros[i], StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            naideno_sovpadenii++;
                        }
                    }
                }

                if (naideno_sovpadenii >= skolko_nado_naiti_sovpadenii)
                {
                    resultat.Add(stroka);
                }

                naideno_sovpadenii = 0;
            }

            return resultat;
        }

        public List<string[]> Obschii_Poisk(string zapros)
        {
            List<string[]> resultat = new List<string[]>();

            bool sovpadenie = false;

            foreach (string[] stroka in Tablica)
            {
                foreach (string slovo in stroka)
                {
                    if (slovo.IndexOf(zapros, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        sovpadenie = true;
                    }
                }

                if (sovpadenie)
                {
                    resultat.Add(stroka);
                }

                sovpadenie = false;
            }

            return resultat;
        }
    }
}