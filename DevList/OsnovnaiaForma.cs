using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public partial class OsnovnaiaForma : FormenniiFunkcional
    {
        public OsnovnaiaForma(INIFail iniFail, Baza baza)
        {
            InitializeComponent();

            this.iniFail = iniFail;

            this.baza = baza;

            Komplekt.Visible = false;

            KKomplekt.Visible = false;
        }

        private void Tablica_MouseDown(object sender, MouseEventArgs e)
        {
            koordinati = Tablica.HitTest(e.X, e.Y);

            if (koordinati != null && koordinati.Location != ListViewHitTestLocations.None)
            {
                if (baza.Tablica[koordinati.Item.Index][6] == "Системный блок")
                {
                    Komplekt.Visible = true;

                    KKomplekt.Visible = true;
                }
                else
                {
                    Komplekt.Visible = false;

                    KKomplekt.Visible = false;
                }
            }
        }

        private void OsnovnaiaForma_Load(object sender, EventArgs e)
        {
            VivodVTablicu(baza.Tablica);
        }

        private void VivodVTablicu(List<string[]> tablica)
        {
            Tablica.Items.Clear();

            for (int i = 0; i < tablica.Count; i++)
            {
                tablica[i][0] = (i + 1).ToString();
            }

            for (int i = 0; i < tablica.Count; i++)
            {
                ListViewItem stroka = new ListViewItem(tablica[i]);

                Tablica.Items.Add(stroka);
            }

            if (vidKolonok[0])
            {
                Tablica.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[1].Width = 0;
            }

            if (vidKolonok[1])
            {
                Tablica.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[2].Width = 0;
            }

            if (vidKolonok[2])
            {
                Tablica.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[3].Width = 0;
            }

            if (vidKolonok[3])
            {
                Tablica.Columns[4].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[4].Width = 0;
            }

            if (vidKolonok[4])
            {
                Tablica.Columns[5].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[5].Width = 0;
            }

            if (vidKolonok[5])
            {
                Tablica.Columns[6].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[6].Width = 0;
            }

            if (vidKolonok[6])
            {
                Tablica.Columns[7].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[7].Width = 0;
            }

            if (vidKolonok[7])
            {
                Tablica.Columns[8].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[8].Width = 0;
            }

            if (vidKolonok[8])
            {
                Tablica.Columns[9].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[9].Width = 0;
            }

            if (vidKolonok[9])
            {
                Tablica.Columns[10].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[10].Width = 0;
            }

            if (vidKolonok[10])
            {
                Tablica.Columns[11].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[11].Width = 0;
            }

            if (vidKolonok[11])
            {
                Tablica.Columns[12].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                Tablica.Columns[12].Width = 0;
            }
        }

        private void Tablica_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Tablica.Items.Clear();

            if (sortirovkaVKolonkah)
            {
                baza.Tablica.Sort((x, y) => x[e.Column].CompareTo(y[e.Column]));

                sortirovkaVKolonkah = false;
            }
            else
            {
                baza.Tablica.Sort((y, x) => x[e.Column].CompareTo(y[e.Column]));

                sortirovkaVKolonkah = true;
            }

            VivodVTablicu(baza.Tablica);

            UbratFiltri.Visible = true;
        }

        private void Sozdat_Click(object sender, EventArgs e)
        {
            ProverkaNaIzmenenieBazi();

            FolderBrowserDialog putKNovoiBaze = new FolderBrowserDialog();

            putKNovoiBaze.ShowDialog();

            if (putKNovoiBaze.SelectedPath != "")
            {
                iniFail = new INIFail(putKNovoiBaze.SelectedPath);

                baza = new Baza(iniFail.Baza);

                VivodVTablicu(baza.Tablica);
            }
        }

        private void Otkrit_Click(object sender, EventArgs e)
        {
            ProverkaNaIzmenenieBazi();

            OpenFileDialog otkrit_fail = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (otkrit_fail.ShowDialog() == DialogResult.OK)
            {
                iniFail = new INIFail(otkrit_fail.FileName);

                baza = new Baza(iniFail.Baza);

                VivodVTablicu(baza.Tablica);
            }
        }

        private void Sohranit_Click(object sender, EventArgs e)
        {
            baza.Zapisat();

            baza.Izmenenie = false;
        }

        private void Sohranit_Kak_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog adresDliaSohraneniia = new FolderBrowserDialog();

            adresDliaSohraneniia.ShowDialog();

            if (adresDliaSohraneniia.SelectedPath != "")
            {
                if (!Directory.Exists($"{adresDliaSohraneniia.SelectedPath}\\БД"))
                    Directory.CreateDirectory($"{adresDliaSohraneniia.SelectedPath}\\БД");

                if (!Directory.Exists($"{adresDliaSohraneniia.SelectedPath}\\История перемещений"))
                    Directory.CreateDirectory($"{adresDliaSohraneniia.SelectedPath}\\История перемещений");

                File.Copy(iniFail.Adres, Path.Combine(adresDliaSohraneniia.SelectedPath, Path.GetFileName(iniFail.Adres)), true);
                File.Copy(iniFail.Baza, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Baza)), true);
                File.Copy(iniFail.Pomescheniia, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Pomescheniia)), true);
                File.Copy(iniFail.Oborudovanie, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Oborudovanie)), true);
                File.Copy(iniFail.Sotrudniki, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Sotrudniki)), true);
                File.Copy(iniFail.Istoriia, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Istoriia)), true);
                File.Copy(iniFail.Komplekt, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Komplekt)), true);

                baza.Izmenenie = false;
            }
        }

        // Если курсор на НЕ пустой строке, то  ListViewHitTestLocations НЕ none
        // Если курсор на ПУСТОЙ строке, то ListViewHitTestLocations равен NONE
        // Если курсор на строке заголовка, то метод ListView.HitTest() возвращает NULL
        private void Dobavit_Click(object sender, EventArgs e)
        {
            DobavitPravitPoisk okno = new DobavitPravitPoisk("DevList - Добавить", iniFail);

            okno.ShowDialog();

            if (koordinati == null || koordinati.Location == ListViewHitTestLocations.None)
            {
                if (okno.rezultat[1] != null)
                {
                    baza.Tablica.Add(okno.rezultat);

                    VivodVTablicu(baza.Tablica);

                    Tablica.Items[baza.Tablica.Count - 1].Selected = true;

                    baza.Izmenenie = true;
                }
            }
            else
            {
                int zapominaemStroku = koordinati.Item.Index;

                if (okno.rezultat[1] != null)
                {
                    baza.Tablica.Insert(koordinati.Item.Index + 1, okno.rezultat);

                    VivodVTablicu(baza.Tablica);

                    Tablica.Items[zapominaemStroku + 1].Selected = true;

                    baza.Izmenenie = true;


                }
            }
        }

        private void KDobavit_Click(object sender, EventArgs e)
        {
            Dobavit_Click(sender, e);
        }

        // Если курсор на НЕ пустой строке, то  ListViewHitTestLocations НЕ none
        // Если курсор на ПУСТОЙ строке, то ListViewHitTestLocations равен NONE
        // Если курсор на строке заголовка, то метод ListView.HitTest() возвращает NULL
        private void Pravit_Click(object sender, EventArgs e)
        {
            if (koordinati != null && koordinati.Location != ListViewHitTestLocations.None)
            {
                int zapominaemStroku = koordinati.Item.Index;

                if (koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 3 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 4 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 6 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 7 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 12)
                {
                    PravitSpisok pravitSpisok = new PravitSpisok(koordinati.Item.SubItems.IndexOf(koordinati.SubItem), iniFail);

                    pravitSpisok.ShowDialog();

                    if (pravitSpisok.rezultat != null)
                    {
                        if (koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 3)
                        {
                            File.AppendAllText
                            (
                            $"{Path.GetDirectoryName(Path.GetFullPath(iniFail.Adres))}\\История перемещений\\{pravitSpisok.rezultat}.txt",
                            $"Из помещения: {baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)]}\r\n" +
                            $"переместили: {DateTime.Now}\r\n" +
                            $"{baza.Tablica[koordinati.Item.Index][5]}\r\n" +
                            $"с инв.№: {baza.Tablica[koordinati.Item.Index][2]}\r\n\r\n"
                            );
                        }

                        baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)] = pravitSpisok.rezultat;

                        VivodVTablicu(baza.Tablica);

                        Tablica.Items[zapominaemStroku].Selected = true;

                        baza.Izmenenie = true;
                    }
                }
                else if(koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 0)
                {
                    // Столбец ID нельзя изменить!
                }
                ////else if(koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 1)
                ////{
                ////    DateTimePicker dateTimePicker = new DateTimePicker();

                ////    dateTimePicker.Width = 200;

                ////    Controls.Add(dateTimePicker);
                ////}
                else
                {
                    PravitStroku pravitStroku = new PravitStroku(baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)]);

                    pravitStroku.ShowDialog();

                    if (pravitStroku.rezultat != null)
                    {
                        baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)] = pravitStroku.rezultat;

                        VivodVTablicu(baza.Tablica);

                        Tablica.Columns[9].Width = 150;

                        Tablica.Items[zapominaemStroku].Selected = true;

                        baza.Izmenenie = true;
                    }
                }
            }
        }

        private void KPravit_Click(object sender, EventArgs e)
        {
            Pravit_Click(sender, e);
        }

        // Если курсор на НЕ пустой строке, то  ListViewHitTestLocations НЕ none
        // Если курсор на ПУСТОЙ строке, то ListViewHitTestLocations равен NONE
        // Если курсор на строке заголовка, то метод ListView.HitTest() возвращает NULL
        private void PravitVse_Click(object sender, EventArgs e)
        {
            if (koordinati != null && koordinati.Location != ListViewHitTestLocations.None)
            {
                int zapominaemStroku = koordinati.Item.Index;

                DobavitPravitPoisk okno = new DobavitPravitPoisk("DevList - Править всё", iniFail, baza.Tablica[zapominaemStroku]);

                okno.ShowDialog();

                if (okno.rezultat[1] != null)
                {
                    baza.Tablica[zapominaemStroku] = okno.rezultat;

                    VivodVTablicu(baza.Tablica);

                    baza.Izmenenie = true;
                }
            }
        }

        private void KPravitVse_Click(object sender, EventArgs e)
        {
            PravitVse_Click(sender, e);
        }

        private void Vverh_Click(object sender, EventArgs e)
        {
            if (koordinati != null && koordinati.Location != ListViewHitTestLocations.None)
            {
                if (koordinati.Item.Index > 0)
                {
                    int zapominaemStroku = koordinati.Item.Index;

                    baza.PeremeschenieStroki(zapominaemStroku - 1, zapominaemStroku);

                    VivodVTablicu(baza.Tablica);

                    Tablica.Items[zapominaemStroku - 1].Selected = true;
                    Tablica.Items[zapominaemStroku - 1].Focused = true;

                    baza.Izmenenie = true;
                }
            }
        }

        private void KVverh_Click(object sender, EventArgs e)
        {
            Vverh_Click(sender, e);
        }

        private void Vniz_Click(object sender, EventArgs e)
        {
            if (koordinati != null && koordinati.Location != ListViewHitTestLocations.None)
            {
                int zapominaemStroku = koordinati.Item.Index;

                if (baza.Tablica.Count > zapominaemStroku + 1)
                {
                    baza.PeremeschenieStroki(zapominaemStroku + 1, zapominaemStroku);

                    VivodVTablicu(baza.Tablica);

                    Tablica.Items[zapominaemStroku + 1].Selected = true;
                    Tablica.Items[zapominaemStroku + 1].Focused = true;

                    baza.Izmenenie = true;
                }
            }
        }

        private void KVniz_Click(object sender, EventArgs e)
        {
            Vniz_Click(sender, e);
        }

        private void Udalit_Click(object sender, EventArgs e)
        {
            if (koordinati != null && koordinati.Location != ListViewHitTestLocations.None)
            {
                DialogResult rezultat =

                MessageBox.Show
                (
                    "Удалить МЦ?\r\n\r\nМЦ будет перемещена в Историю!",
                    "Удаление МЦ",
                    MessageBoxButtons.YesNo
                );

                if (rezultat == DialogResult.Yes)
                {
                    Udalit udalit = new Udalit(baza, koordinati, iniFail, true);

                    VivodVTablicu(baza.Tablica);

                    baza.Izmenenie = true;
                }
            }
        }

        private void KUdalit_Click(object sender, EventArgs e)
        {
            if (GlavnoeMenu.Items.Count == 0)
            {
                DialogResult rezultat =

                MessageBox.Show
                (
                    "Удалить полностью?",
                    "Удаление МЦ",
                    MessageBoxButtons.YesNo
                );

                if (rezultat == DialogResult.Yes)
                {
                    Udalit udalit = new Udalit(baza, koordinati);

                    VivodVTablicu(baza.Tablica);

                    baza.Izmenenie = true;
                }
            }
            else
            {
                Udalit_Click(sender, e);
            }
        }

        private void Poisk_Click(object sender, EventArgs e)
        {
            string[] stroka = new string[13];

            for (int i = 0; i < stroka.Length; i++)
            {
                stroka[i] = string.Empty;
            }

            DobavitPravitPoisk poisk = new DobavitPravitPoisk("DevList - Поиск", iniFail, stroka);

            poisk.ShowDialog();

            if (poisk.KnopkaVipolnit)
            {
                if (poisk.rezultat != null)
                {
                    bool proverkaNaPustieStroki = false;

                    foreach (string slovo in poisk.rezultat)
                    {
                        if (slovo != "")
                        {
                            proverkaNaPustieStroki = true;
                        }
                    }

                    if (proverkaNaPustieStroki)
                    {
                        VivodVTablicu(baza.Poisk_Strok(poisk.rezultat));
                    }
                    else
                    {
                        Tablica.Items.Clear();
                    }

                    UbratFiltri.Visible = true;
                }
            }
        }

        private void KPoisk_Click(object sender, EventArgs e)
        {
            DobavitPravitPoisk poisk;

            int zapominaemStroku;

            if (koordinati == null || koordinati.Item == null)
            {
                koordinati = Tablica.HitTest(0, 0);

                string[] stroka = new string[13];

                for (int i = 0; i < stroka.Length; i++)
                {
                    stroka[i] = string.Empty;
                }

                poisk = new DobavitPravitPoisk("DevList - Поиск", iniFail, stroka);
            }
            else
            {
                zapominaemStroku = koordinati.Item == null ? 0 : koordinati.Item.Index;

                if (zapominaemStroku >= 0)
                {
                    poisk = new DobavitPravitPoisk("DevList - Поиск", iniFail, baza.Tablica[zapominaemStroku]);
                }
                else
                {
                    poisk = new DobavitPravitPoisk("DevList - Поиск", iniFail, baza.Tablica[0]);
                }
            }

            poisk.ShowDialog();

            if (poisk.KnopkaVipolnit)
            {
                if (poisk.rezultat != null)
                {
                    bool proverkaNaPustieStroki = false;

                    foreach (string slovo in poisk.rezultat)
                    {
                        if (slovo != "")
                        {
                            proverkaNaPustieStroki = true;
                        }
                    }

                    if (proverkaNaPustieStroki)
                    {
                        VivodVTablicu(baza.Poisk_Strok(poisk.rezultat));
                    }
                    else
                    {
                        Tablica.Items.Clear();
                    }

                    UbratFiltri.Visible = true;
                }
            }
        }

        private void TextBoxObschiiPoisk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VivodVTablicu(baza.Obschii_Poisk(TextBoxObschiiPoisk.Text));

                UbratFiltri.Visible = true;
            }
        }

        private void RedaktirovanieSpiskov_Click(object sender, EventArgs e)
        {
            RedaktirovanieSpiskov redaktirovanie_spiskov = new RedaktirovanieSpiskov(iniFail);

            redaktirovanie_spiskov.ShowDialog();
        }

        private void KolVoPoTipam_Click(object sender, EventArgs e)
        {
            Otcheti otchet = new Otcheti(iniFail, baza, tipOtcheta: 0);

            otchet.ShowDialog();
        }

        private void KolVoVPomeschenii_Click(object sender, EventArgs e)
        {
            Otcheti otchet = new Otcheti(iniFail, baza, tipOtcheta: 1);

            otchet.ShowDialog();
        }

        private void UbratFiltri_Click(object sender, EventArgs e)
        {
            baza = new Baza(iniFail.Baza);

            VivodVTablicu(baza.Tablica);

            UbratFiltri.Visible = false;
        }

        private void ProverkaNaIzmenenieBazi()
        {
            if (baza.Izmenenie)
            {
                DialogResult resultat_vibora =

                MessageBox.Show
                (
                    "Сохранить изменения?",
                    "Открытие файла",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

                if (resultat_vibora == DialogResult.Yes) { baza.Zapisat(); }

                baza.Izmenenie = false;
            }
        }

        private void OsnovnaiaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProverkaNaIzmenenieBazi();
        }

        private void OsnovnaiaForma_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.S) == Keys.S)
            {
                Dobavit_Click(sender, e);
            }
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.E) == Keys.E)
            {
                PravitVse_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                Udalit_Click(sender, e);
            }
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.F) == Keys.F)
            {
                Poisk_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                ProverkaNaIzmenenieBazi();

                Close();
            }
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Up) == Keys.Up)
            {
                Vverh_Click(sender, e);
            }
            if ((e.KeyData & Keys.Control) == Keys.Control && (e.KeyData & Keys.Down) == Keys.Down)
            {
                Vniz_Click(sender, e);
            }
        }

        private void Kolonki_Click(object sender, EventArgs e)
        {
            Kolonki kolonki = new Kolonki();

            kolonki.ShowDialog();

            vidKolonok = kolonki.rezultat;

            if (kolonki.KnopkaVipolnit)
            {
                VivodVTablicu(baza.Tablica);
            }
        }

        private void Istoria_Click(object sender, EventArgs e)
        {
            Baza istoriaBaza = new Baza(iniFail.Istoriia);

            OsnovnaiaForma istoria = new OsnovnaiaForma(iniFail, istoriaBaza);

            istoria.Fail.Visible = false;

            istoria.Pravka.Visible = false;

            istoria.RedaktirovanieSpiskov.Visible = false;

            istoria.Otcheti.Visible = false;

            istoria.Istoria.Visible = false;



            istoria.KDobavit.Visible = false;

            istoria.KPravitVse.Visible = false;

            istoria.KVverh.Visible = false;

            istoria.KVniz.Visible = false;



            istoria.Text = "DevList - История";

            istoria.ShowDialog();
        }

        private void Tablica_DoubleClick(object sender, EventArgs e)
        {
            Pravit_Click(sender, e);
        }

        private void Komplekt_Click(object sender, EventArgs e)
        {
            RabotaSKomplektom komplekt = new RabotaSKomplektom();

            komplekt.ShowDialog();
        }

        private void KKomplekt_Click(object sender, EventArgs e)
        {
            Komplekt_Click(sender, e);
        }
    }
}