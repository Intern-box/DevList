﻿using System;
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
    public partial class PravitSpisok : Form
    {
        int nomerStolbca;

        INIFail iniFail;

        public string rezultat;

        public PravitSpisok(string zagolovok, int nomerStolbca, INIFail iniFail)
        {
            InitializeComponent();

            this.nomerStolbca = nomerStolbca;

            this.iniFail = iniFail;

            Text = zagolovok;
        }

        private void PravitSpisok_Load(object sender, EventArgs e)
        {
            if (Text == "DevList - Правка")
            {
                if (nomerStolbca == 3)  // Помещение
                {
                    Spisok spisok = new Spisok(iniFail.Pomescheniia);

                    ElementSpiska.Items.AddRange(spisok.Elementi);
                }
                if (nomerStolbca == 4)  // Закреплено за
                {
                    Spisok spisok = new Spisok(iniFail.Sotrudniki);

                    ElementSpiska.Items.AddRange(spisok.Elementi);
                }
                if (nomerStolbca == 5)  // Наименование
                {
                    Spisok spisok = new Spisok(iniFail.Naimenovaniia);

                    ElementSpiska.Items.AddRange(spisok.Elementi);
                }
                if (nomerStolbca == 6)  // Оборудование
                {
                    Spisok spisok = new Spisok(iniFail.Oborudovanie);

                    ElementSpiska.Items.AddRange(spisok.Elementi);
                }
                if (nomerStolbca == 7)  // Состояние
                {
                    ButtonDobavlenieElementa.Enabled = false;
                    ButtonUdalenieElementa.Enabled = false;

                    ElementSpiska.Items.Add("рабочее");
                    ElementSpiska.Items.Add("в ремонте");
                    ElementSpiska.Items.Add("сломано");
                    ElementSpiska.Items.Add("утеряно");
                }
                if (nomerStolbca == 12) // Изменил
                {
                    Spisok spisok = new Spisok(iniFail.Sotrudniki);

                    ElementSpiska.Items.AddRange(spisok.Elementi);
                }
            }
            if (Text == "DevList - Комплект правка")
            {
                Spisok spisok = new Spisok(iniFail.Komplektuiuschie);

                ElementSpiska.Items.AddRange(spisok.Elementi);
            }
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            rezultat = ElementSpiska.Text;

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonDobavlenieElementa_Click(object sender, EventArgs e)
        {
            if (nomerStolbca == 3)  // Помещение
            {
                Spisok spisok = new Spisok(iniFail.Pomescheniia);

                spisok.Dobavit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
            if (nomerStolbca == 4)  // Закреплено за
            {
                Spisok spisok = new Spisok(iniFail.Sotrudniki);

                spisok.Dobavit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
            if (nomerStolbca == 5)  // Наименования
            {
                Spisok spisok = new Spisok(iniFail.Naimenovaniia);

                spisok.Dobavit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
            if (nomerStolbca == 6)  // Оборудование
            {
                Spisok spisok = new Spisok(iniFail.Oborudovanie);

                spisok.Dobavit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
            if (nomerStolbca == 12) // Изменил
            {
                Spisok spisok = new Spisok(iniFail.Sotrudniki);

                spisok.Dobavit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
        }

        private void ButtonUdalenieElementa_Click(object sender, EventArgs e)
        {
            if (nomerStolbca == 3)  // Помещение
            {
                Spisok spisok = new Spisok(iniFail.Pomescheniia);

                spisok.Udalit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
            if (nomerStolbca == 4)  // Закреплено за
            {
                Spisok spisok = new Spisok(iniFail.Sotrudniki);

                spisok.Udalit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
            if (nomerStolbca == 5)  // Наименование
            {
                Spisok spisok = new Spisok(iniFail.Naimenovaniia);

                spisok.Udalit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
            if (nomerStolbca == 6)  // Оборудование
            {
                Spisok spisok = new Spisok(iniFail.Oborudovanie);

                spisok.Udalit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
            if (nomerStolbca == 12) // Изменил
            {
                Spisok spisok = new Spisok(iniFail.Sotrudniki);

                spisok.Udalit(ElementSpiska.Text);

                ElementSpiska.Items.Clear();

                ElementSpiska.Items.AddRange(File.ReadAllLines(spisok.Adres));
            }
        }

        private void PravitSpisok_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonVipolnit_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                ButtonZakrit_Click(sender, e);
            }
        }
    }
}