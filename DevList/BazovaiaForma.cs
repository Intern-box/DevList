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
    public partial class BazovaiaForma : Form
    {
        public INIFail iniFail;

        public Baza baza;

        public ListViewHitTestInfo koordinati;

        public bool sortirovkaVKolonkah = true;

        public bool[] vidKolonok = new bool[13];

        public BazovaiaForma(INIFail iniFail, Baza baza)
        {
            InitializeComponent();

            this.iniFail = iniFail;

            this.baza = baza;

            for (int i = 0; i < vidKolonok.Length; i++) { vidKolonok[i] = true; }
        }

        private void Tablica_MouseDown(object sender, MouseEventArgs e)
        {
            koordinati = Tablica.HitTest(e.X, e.Y);
        }

        private void BazovaiaForma_Load(object sender, EventArgs e)
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

            Tablica.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            for (int i = 0; i < vidKolonok.Length; i++)
            {
                if (vidKolonok[i])
                {
                    Tablica.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                else
                {
                    Tablica.Columns[i].Width = 0;
                }
            }
        }

        private void Tablica_ColumnClick(object sender, ColumnClickEventArgs e)
        {
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

            Tablica.Items.Clear();

            VivodVTablicu(baza.Tablica);

            GMenu.Items[8].Visible = true;
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

        private void SohranitKak_Click(object sender, EventArgs e)
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
            if (Text == "DevList 6.6 - Главное окно")
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
            if (Text == "DevList - Комплект")
            {
                KDobavitPravitPoisk okno = new KDobavitPravitPoisk("DevList - Добавить", iniFail);

                okno.ShowDialog();

                if (koordinati == null || koordinati.Location == ListViewHitTestLocations.None)
                {
                    if (okno.rezultat[2] != null)
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

                    if (okno.rezultat[2] != null)
                    {
                        baza.Tablica.Insert(koordinati.Item.Index + 1, okno.rezultat);

                        VivodVTablicu(baza.Tablica);

                        Tablica.Items[zapominaemStroku + 1].Selected = true;

                        baza.Izmenenie = true;
                    }
                }
            }
        }

        private void KDobavit_Click(object sender, EventArgs e)
        {
            Dobavit_Click(sender, e);
        }

        private void Pravit_Click(object sender, EventArgs e)
        {
            if (koordinati != null && koordinati.Location != ListViewHitTestLocations.None)
            {
                int zapominaemStroku = koordinati.Item.Index;

                if (Text == "DevList 6.6 - Главное окно")
                {
                    if (koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 3 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 4 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 5 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 6 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 7 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 12)
                    {
                        PravitSpisok pravitSpisok = new PravitSpisok("DevList - Правка", koordinati.Item.SubItems.IndexOf(koordinati.SubItem), iniFail);

                        pravitSpisok.ShowDialog();

                        if (pravitSpisok.rezultat != null)
                        {
                            if (koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 3)
                            {
                                if (pravitSpisok.rezultat != baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)])
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
                            }

                            baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)] = pravitSpisok.rezultat;

                            VivodVTablicu(baza.Tablica);

                            Tablica.Items[zapominaemStroku].Selected = true;

                            baza.Izmenenie = true;
                        }
                    }
                    else if (koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 0)
                    {
                        // Столбец ID нельзя изменить!
                    }
                    else
                    {
                        PravitStroku pravitStroku = new PravitStroku("DevList - Правка комплект", baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)]);

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
                if (Text == "DevList - Комплект")
                {
                    if (koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 3 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 4 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 5 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 6 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 7 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 8 ||
                    koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 9)
                    {
                        PravitSpisok pravitSpisok = new PravitSpisok("DevList - Комплект правка", koordinati.Item.SubItems.IndexOf(koordinati.SubItem), iniFail);

                        pravitSpisok.ShowDialog();

                        if (pravitSpisok.rezultat != null)
                        {
                            baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)] = pravitSpisok.rezultat;

                            VivodVTablicu(baza.Tablica);

                            Tablica.Items[zapominaemStroku].Selected = true;

                            baza.Izmenenie = true;
                        }
                    }
                    else if (koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 0)
                    {
                        // Столбец ID нельзя изменить!
                    }
                    else
                    {
                        PravitStroku pravitStroku = new PravitStroku("DevList - Правка", baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)]);

                        pravitStroku.ShowDialog();

                        if (pravitStroku.rezultat != null)
                        {
                            baza.Tablica[koordinati.Item.Index][koordinati.Item.SubItems.IndexOf(koordinati.SubItem)] = pravitStroku.rezultat;

                            VivodVTablicu(baza.Tablica);

                            Tablica.Items[zapominaemStroku].Selected = true;

                            baza.Izmenenie = true;
                        }
                    }
                }
            }
        }

        private void KPravit_Click(object sender, EventArgs e)
        {
            Pravit_Click(sender, e);
        }

        private void Tablica_DoubleClick(object sender, EventArgs e)
        {
            Pravit_Click(sender, e);
        }

        private void PravitVse_Click(object sender, EventArgs e)
        {
            if (Text == "DevList 6.6 - Главное окно")
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
            if (Text == "DevList - Комплект")
            {
                if (koordinati != null && koordinati.Location != ListViewHitTestLocations.None)
                {
                    int zapominaemStroku = koordinati.Item.Index;

                    KDobavitPravitPoisk okno = new KDobavitPravitPoisk("DevList - Править всё", iniFail, baza.Tablica[zapominaemStroku]);

                    okno.ShowDialog();

                    if (okno.rezultat[2] != null)
                    {
                        baza.Tablica[zapominaemStroku] = okno.rezultat;

                        VivodVTablicu(baza.Tablica);

                        baza.Izmenenie = true;
                    }
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
            if (GMenu.Items.Count == 0)
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

        private void Vid_Click(object sender, EventArgs e)
        {
            Kolonki kolonki = new Kolonki(vidKolonok);

            kolonki.ShowDialog();

            vidKolonok = kolonki.rezultat;

            if (kolonki.KnopkaVipolnit)
            {
                VivodVTablicu(baza.Tablica);
            }
        }

        private void Poisk_Click(object sender, EventArgs e)
        {
            if (Text == "DevList 6.6 - Главное окно" || Text == "DevList - История")
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

                        Filtr.Visible = true;
                    }
                }
            }
            if (Text == "DevList - Комплект")
            {
                string[] stroka = new string[11];

                for (int i = 0; i < stroka.Length; i++)
                {
                    stroka[i] = string.Empty;
                }

                KDobavitPravitPoisk poisk = new KDobavitPravitPoisk("DevList - Поиск", iniFail, stroka);

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

                        Filtr.Visible = true;
                    }
                }
            }
        }

        private void KPoisk_Click(object sender, EventArgs e)
        {
            if (Text == "DevList 6.6 - Главное окно" || Text == "DevList - История")
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

                        Filtr.Visible = true;
                    }
                }
            }
            if (Text == "DevList - Комплект")
            {
                KDobavitPravitPoisk poisk = new KDobavitPravitPoisk("DevList - Поиск", iniFail);

                int zapominaemStroku;

                if (koordinati == null || koordinati.Item == null)
                {
                    koordinati = Tablica.HitTest(0, 0);

                    string[] stroka = new string[13];

                    for (int i = 0; i < stroka.Length; i++)
                    {
                        stroka[i] = string.Empty;
                    }

                    poisk = new KDobavitPravitPoisk("DevList - Поиск", iniFail, stroka);
                }
                else
                {
                    zapominaemStroku = koordinati.Item == null ? 0 : koordinati.Item.Index;

                    if (zapominaemStroku >= 0)
                    {
                        poisk = new KDobavitPravitPoisk("DevList - Поиск", iniFail, baza.Tablica[zapominaemStroku]);
                    }
                    else
                    {
                        poisk = new KDobavitPravitPoisk("DevList - Поиск", iniFail, baza.Tablica[0]);
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

                        Filtr.Visible = true;
                    }
                }
            }
        }

        private void TextBoxObschiiPoisk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VivodVTablicu(baza.Obschii_Poisk(TextBoxObschiiPoisk.Text));

                Filtr.Visible = true;
            }
        }

        private void Spiski_Click(object sender, EventArgs e)
        {
            Spiski redaktirovanie_spiskov = new Spiski(iniFail);

            redaktirovanie_spiskov.ShowDialog();
        }

        private void PoTipam_Click(object sender, EventArgs e)
        {
            Otcheti otchet = new Otcheti(iniFail, baza, tipOtcheta: 0);

            otchet.ShowDialog();
        }

        private void VPomeschenii_Click(object sender, EventArgs e)
        {
            Otcheti otchet = new Otcheti(iniFail, baza, tipOtcheta: 1);

            otchet.ShowDialog();
        }

        private void Istoria_Click(object sender, EventArgs e)
        {
            Baza istoriaBaza = new Baza(iniFail.Istoriia);

            BazovaiaForma istoria = new BazovaiaForma(iniFail, istoriaBaza);

            istoria.Fail.Visible = false;

            istoria.Pravka.Visible = false;

            istoria.Spiski.Visible = false;

            istoria.Otcheti.Visible = false;

            istoria.Istoria.Visible = false;

            istoria.KDobavit.Visible = false;

            istoria.KPravitVse.Visible = false;

            istoria.KVverh.Visible = false;

            istoria.KVniz.Visible = false;

            istoria.KUdalit.Visible = false;

            istoria.Text = "DevList - История";

            istoria.ShowDialog();
        }

        private void Komplekt_Click(object sender, EventArgs e)
        {
            Baza komplektBaza = new Baza(iniFail.Komplekt);

            BazovaiaForma komplekt = new BazovaiaForma(iniFail, komplektBaza);

            komplekt.Sozdat.Visible = false;

            komplekt.Otkrit.Visible = false;

            komplekt.Vid.Visible = false;

            komplekt.Otcheti.Visible = false;

            komplekt.Istoria.Visible = false;

            komplekt.Komplekt.Visible = false;

            komplekt.Tablica.Columns.Clear();

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "ID", Text = "ID", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "InvNomer", Text = "Системный блок Инв. №", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "Data", Text = "Приобретено", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "CPU", Text = "Процессор", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "Mainboard", Text = "Мат. плата", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "RAM", Text = "ОЗУ", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "Disk", Text = "Накопитель", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "Videocard", Text = "Видеокарта", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "Power", Text = "Блок питания", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "Case", Text = "Корпус", TextAlign = HorizontalAlignment.Center });

            komplekt.Tablica.Columns.Add(new ColumnHeader() { Name = "GvCPU", Text = "Год выпуска процессора", TextAlign = HorizontalAlignment.Center });

            Array.Resize<bool>(ref komplekt.vidKolonok, 11);

            komplekt.Text = "DevList - Комплект";

            komplekt.WindowState = FormWindowState.Normal;

            komplekt.ShowDialog();
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            baza = new Baza(baza.Adres);

            VivodVTablicu(baza.Tablica);

            Filtr.Visible = false;
        }

        private void BazovaiaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProverkaNaIzmenenieBazi();
        }

        private void BazovaiaForma_KeyUp(object sender, KeyEventArgs e)
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
    }
}