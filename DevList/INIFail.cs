using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DevList
{
    public class INIFail
    {
        public string Papka;
        public string Adres = "DevList.ini";
        public string Baza = "БД\\БД.csv";
        public string Pomescheniia = "БД\\Помещения.txt";
        public string Oborudovanie = "БД\\Оборудование.txt";
        public string Sotrudniki = "БД\\Сотрудники.txt";
        public string Naimenovaniia = "БД\\Наименования.txt";
        public string Istoriia = "БД\\История.csv";
        public string Komplekt = "БД\\Комплект.csv";
        public string Komplektuiuschie = "БД\\Комплектующие.txt";

        public INIFail()
        {
        }

        public INIFail(string adres)
        {
            if (!File.Exists(adres))
            {
                try
                {
                    File.WriteAllText(adres, "");

                    Adres = adres;
                    Papka = Path.GetDirectoryName(Adres);
                }
                catch (Exception)
                {
                    if (!File.Exists($"{adres}\\{Adres}"))
                    {
                        File.WriteAllText($"{adres}\\{Adres}", "");
                    }

                    Papka = adres;
                }

                if (!Directory.Exists($"{Papka}\\БД"))
                    Directory.CreateDirectory($"{Papka}\\БД");

                if (!Directory.Exists($"{Papka}\\История перемещений"))
                    Directory.CreateDirectory($"{Papka}\\История перемещений");

                File.WriteAllText
                (
                    $"{Papka}\\{Adres}",
                    
                    $"{Baza}\r\n" +
                    $"{Pomescheniia}\r\n" +
                    $"{Oborudovanie}\r\n" +
                    $"{Sotrudniki}\r\n" +
                    $"{Naimenovaniia}\r\n" +
                    $"{Istoriia}\r\n" +
                    $"{Komplekt}\r\n" +
                    $"{Komplektuiuschie}\r\n"
                );

                File.WriteAllText($"{Papka}\\{Baza}", "");
                File.WriteAllText($"{Papka}\\{Pomescheniia}", "");
                File.WriteAllText($"{Papka}\\{Oborudovanie}", "");
                File.WriteAllText($"{Papka}\\{Sotrudniki}", "");
                File.WriteAllText($"{Papka}\\{Naimenovaniia}", "");
                File.WriteAllText($"{Papka}\\{Istoriia}", "");
                File.WriteAllText($"{Papka}\\{Komplekt}", "");
                File.WriteAllText($"{Papka}\\{Komplektuiuschie}", "");
            }
            else
            {
                Adres = adres;
                Papka = Path.GetDirectoryName(Adres);
            }

            string[] ini_fail = File.ReadAllLines(Adres);

            Baza = $"{Papka}\\{ini_fail[0]}";
            Pomescheniia = $"{Papka}\\{ini_fail[1]}";
            Oborudovanie = $"{Papka}\\{ini_fail[2]}";
            Sotrudniki = $"{Papka}\\{ini_fail[3]}";
            Naimenovaniia = $"{Papka}\\{ini_fail[4]}";
            Istoriia = $"{Papka}\\{ini_fail[5]}";
            Komplekt = $"{Papka}\\{ini_fail[6]}";
            Komplektuiuschie = $"{Papka}\\{ini_fail[7]}";
        }
    }
}
