using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DevList
{
    public partial class Izmenit_Iz_Spiska : Form
    {
        string iz, naimenovanie, inv_nomer;

        public Izmenit_Iz_Spiska()
        {
            InitializeComponent();

            if (Glavnoe_Okno.nomer_stolbca == 3)            // Помещения
            {
                label_Nazvanie.Text = "Помещения";

                iz = Glavnoe_Okno.baza[Glavnoe_Okno.nomer_najatoi_stroki][Glavnoe_Okno.nomer_stolbca];
                inv_nomer = Glavnoe_Okno.baza[Glavnoe_Okno.nomer_najatoi_stroki][2];
                naimenovanie = Glavnoe_Okno.baza[Glavnoe_Okno.nomer_najatoi_stroki][5];

                comboBox_Spisok_Vibora.Items.AddRange(Glavnoe_Okno.pomescheniia);
            }
            else if (Glavnoe_Okno.nomer_stolbca == 4)       // Сотрудники
            {
                label_Nazvanie.Text = "Сотрудники";

                comboBox_Spisok_Vibora.Items.AddRange(Glavnoe_Okno.sotrudniki);
            }
            else if (Glavnoe_Okno.nomer_stolbca == 6)       // Тип
            {
                label_Nazvanie.Text = "Тип";

                comboBox_Spisok_Vibora.Items.AddRange(Glavnoe_Okno.tipi);
            }
            else if (Glavnoe_Okno.nomer_stolbca == 7)       // Состояние
            {
                label_Nazvanie.Text = "Состояние";

                comboBox_Spisok_Vibora.Items.Add("рабочее");
                comboBox_Spisok_Vibora.Items.Add("в ремонте");
                comboBox_Spisok_Vibora.Items.Add("сломано");
                comboBox_Spisok_Vibora.Items.Add("утеряно");
            }
            else
            {
                Close();
            }
        }
        private void button_Vipolnit_Click(object sender, EventArgs e)
        {
            Glavnoe_Okno.izmeneniia_s_otkritiia = true;

            // Если изменяется Помещение, то происходит запись в папку "История перемещений"
            // В файл с названием помещения КУДА перемещают МЦ добавляется строка
            // с названием помещения ОТКУДА переместили и датой перемещения
            if (Glavnoe_Okno.nomer_stolbca == 3)
            {
                File.AppendAllText
                (
                    $"История перемещений\\{comboBox_Spisok_Vibora.Text}.txt",
                    $"Из помещения: {iz}\r\n" +
                    $"переместили: {DateTime.Now}\r\n" +
                    $"{naimenovanie}\r\n" +
                    $"с инв.№: {inv_nomer}\r\n\r\n"
                );
            }

            Glavnoe_Okno.baza[Glavnoe_Okno.nomer_najatoi_stroki][Glavnoe_Okno.nomer_stolbca] = comboBox_Spisok_Vibora.Text;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Plus_Element(string put, ComboBox textovaia_stroka, string[] spisok)
        {
            File.AppendAllText(put, textovaia_stroka.Text + "\r\n");

            spisok = File.ReadAllLines(put);

            textovaia_stroka.Items.Clear();

            textovaia_stroka.Items.AddRange(spisok);
        }
        private void Minus_Element(string put, ComboBox textovaia_stroka, string[] spisok)
        {
            string[] massiv_strok = File.ReadAllLines(put);

            string spisok_strok = "";

            foreach (string stroka in massiv_strok)
            {
                if (stroka != textovaia_stroka.Text)
                {
                    spisok_strok += stroka + "\r\n";
                }
            }

            File.Delete(put);
            File.AppendAllText(put, spisok_strok.ToString());

            spisok = File.ReadAllLines(put);
            textovaia_stroka.Items.Clear();
            textovaia_stroka.Items.AddRange(spisok);
        }
        private void Izmenit_Iz_Spiska_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Vipolnit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                button_Otmenit_Click(sender, e);
            }
        }

        private void button_tip_plus_Click(object sender, EventArgs e)
        {
            if (Glavnoe_Okno.nomer_stolbca == 3)            // Помещения
            {
                Plus_Element(Glavnoe_Okno.put_do_spiska_pomeschenii, comboBox_Spisok_Vibora, Glavnoe_Okno.pomescheniia);
            }
            else if (Glavnoe_Okno.nomer_stolbca == 4)       // Сотрудники
            {
                Plus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_Spisok_Vibora, Glavnoe_Okno.sotrudniki);
            }
            else if (Glavnoe_Okno.nomer_stolbca == 6)       // Тип
            {
                Plus_Element(Glavnoe_Okno.put_do_spiska_tipov_oborudovania, comboBox_Spisok_Vibora, Glavnoe_Okno.tipi);
            }
        }
        private void button_tip_minus_Click(object sender, EventArgs e)
        {
            if (Glavnoe_Okno.nomer_stolbca == 3)            // Помещения
            {
                Minus_Element(Glavnoe_Okno.put_do_spiska_pomeschenii, comboBox_Spisok_Vibora, Glavnoe_Okno.pomescheniia);
            }
            else if (Glavnoe_Okno.nomer_stolbca == 4)       // Сотрудники
            {
                Minus_Element(Glavnoe_Okno.put_do_spiska_sotrudnikov, comboBox_Spisok_Vibora, Glavnoe_Okno.sotrudniki);
            }
            else if (Glavnoe_Okno.nomer_stolbca == 6)       // Тип
            {
                Minus_Element(Glavnoe_Okno.put_do_spiska_tipov_oborudovania, comboBox_Spisok_Vibora, Glavnoe_Okno.tipi);
            }
        }
    }
}