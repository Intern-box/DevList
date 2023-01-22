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
    public partial class OsnovnaiaForma : Form
    {
        INIFail iniFail;
        Baza baza;
        ListViewHitTestInfo koordinati;

        public OsnovnaiaForma(INIFail iniFail, Baza baza)
        {
            InitializeComponent();

            this.iniFail = iniFail;
            this.baza = baza;
        }

        private void Tablica_MouseDown(object sender, MouseEventArgs e)
        {
            koordinati = Tablica.HitTest(e.X, e.Y);
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

            Tablica.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Sozdat_Click(object sender, EventArgs e)
        {
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
        }

        private void Sohranit_Kak_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog adresDliaSohraneniia = new FolderBrowserDialog();

            adresDliaSohraneniia.ShowDialog();

            if (!Directory.Exists($"{adresDliaSohraneniia.SelectedPath}\\БД"))
                Directory.CreateDirectory($"{adresDliaSohraneniia.SelectedPath}\\БД");

            if (!Directory.Exists($"{adresDliaSohraneniia.SelectedPath}\\История перемещений"))
                Directory.CreateDirectory($"{adresDliaSohraneniia.SelectedPath}\\История перемещений");

            File.Copy(iniFail.Adres, Path.Combine(adresDliaSohraneniia.SelectedPath, Path.GetFileName(iniFail.Adres)), true);
            File.Copy(iniFail.Baza, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Baza)), true);
            File.Copy(iniFail.Pomescheniia, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Pomescheniia)), true);
            File.Copy(iniFail.Oborudovanie, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Oborudovanie)), true);
            File.Copy(iniFail.Sotrudniki, Path.Combine($"{adresDliaSohraneniia.SelectedPath}\\БД", Path.GetFileName(iniFail.Sotrudniki)), true);
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
                }
            }
        }

        private void KDobavit_Click(object sender, EventArgs e)
        {
            Dobavit_Click(sender, e);
        }

        private void Pravit_Click(object sender, EventArgs e)
        {
            if (koordinati != null || koordinati.Location == ListViewHitTestLocations.None)
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
                    }
                }
                else if(koordinati.Item.SubItems.IndexOf(koordinati.SubItem) == 0)
                {
                    // Столбец ID нельзя изменить!
                }
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
                Udalit udalit = new Udalit(baza, koordinati);

                udalit.ShowDialog();

                VivodVTablicu(baza.Tablica);
            }
        }

        private void KUdalit_Click(object sender, EventArgs e)
        {
            Udalit_Click(sender, e);
        }

        private void Poisk_Click(object sender, EventArgs e)
        {
            if (koordinati != null && koordinati.Location != ListViewHitTestLocations.None)
            {
                int zapominaemStroku = koordinati.Item.Index;

                DobavitPravitPoisk poisk = new DobavitPravitPoisk("DevList - Поиск", iniFail, baza.Tablica[zapominaemStroku]);

                poisk.ShowDialog();

                if (poisk.rezultat != null)
                {
                    VivodVTablicu(baza.Poisk_Strok(poisk.rezultat));

                    GlavnoeMenu.Items[5].Visible = true;
                }
            }
        }

        private void KPoisk_Click(object sender, EventArgs e)
        {
            Poisk_Click(sender, e);
        }

        private void TextBoxObschiiPoisk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VivodVTablicu(baza.Obschii_Poisk(TextBoxObschiiPoisk.Text));

                GlavnoeMenu.Items[5].Visible = true;
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
            baza.Tablica.Sort((x, y) => x[3].CompareTo(y[3]));

            VivodVTablicu(baza.Tablica);

            GlavnoeMenu.Items[5].Visible = false;
        }
    }
}