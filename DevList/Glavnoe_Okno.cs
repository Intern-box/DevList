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
    public partial class Glavnoe_Okno : Form
    {
        Nastroiki nastroiki;
        ListViewHitTestInfo koordinati_mishi;
        Baza baza;
        string[] stolbci;

        public Glavnoe_Okno()
        {
            InitializeComponent();
        }
        public void Glavnoe_Okno_Load(object sender, EventArgs e)
        {
            nastroiki = new Nastroiki();

            nastroiki.ShowDialog();

            Otkrit_Bazu(nastroiki.put_do_bazi);

            for (int i = 0; i < listView_Tablica_Vivoda_Bazi.Columns.Count; i++)
            {
                Array.Resize(ref stolbci, i + 1);

                stolbci[i] = listView_Tablica_Vivoda_Bazi.Columns[i].Text;
            }
        }

        // Читаем данные из "списка" БД в таблицу главного окна
        private void Chtenie_Bazi()
        {
            listView_Tablica_Vivoda_Bazi.Items.Clear();

            for (int i = 0; i < baza.baza.Count; i++)                   // Пересчёт порядковых номеров
            {                                                           // в столбце ID
                baza.baza[i][0] = (i + 1).ToString();
            }

            for (int i = 0; i < baza.baza.Count; i++)                   // Чтение строк в базе
            {                                                           // в ListView
                ListViewItem stroka = new ListViewItem(baza.baza[i]);

                listView_Tablica_Vivoda_Bazi.Items.Add(stroka);
            }

            listView_Tablica_Vivoda_Bazi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void Otkrit_Bazu(string put)
        {
            baza = new Baza(put);

            if (baza != null && baza.baza.Count > 0)
            {
                Chtenie_Bazi();
            }
            else
            {
                listView_Tablica_Vivoda_Bazi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void ToolStripMenuItem_Otkrit_Click(object sender, EventArgs e)
        {
            if (baza.izmeneniia_v_baze)
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

                if (resultat_vibora == DialogResult.Yes) { ToolStripMenuItem_Sohranit_Click(sender, e); }

                baza.izmeneniia_v_baze = false;
            }

            OpenFileDialog otkrit_fail = new OpenFileDialog();

            if (otkrit_fail.ShowDialog() == DialogResult.Yes)
            {
                if (File.Exists(otkrit_fail.FileName) == false)
                {
                    File.WriteAllText(otkrit_fail.FileName, "");
                }

                nastroiki.put_do_bazi = otkrit_fail.FileName;

                Otkrit_Bazu(nastroiki.put_do_bazi);
            }
        }
        private void listView_Tablica_Vivoda_Bazi_MouseClick(object sender, MouseEventArgs e)
        {
            koordinati_mishi = listView_Tablica_Vivoda_Bazi.HitTest(e.X, e.Y);
        }
        private void ToolStripMenuItem_Dobavit_Click(object sender, EventArgs e)
        {
            Dobavit dobavit = new Dobavit(baza, koordinati_mishi);

            dobavit.ShowDialog();

            baza.izmeneniia_v_baze = true;

            Chtenie_Bazi();
        }
        private void ToolStripMenuItem_Context_Dobavit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Dobavit_Click(sender, e);
        }
        private void ToolStripMenuItem_Udalit_Click(object sender, EventArgs e)
        {
            if (koordinati_mishi != null)
            {
                Udalit udalit = new Udalit(baza, koordinati_mishi);

                udalit.ShowDialog();

                baza.izmeneniia_v_baze = true;
            }

            Chtenie_Bazi();
        }
        private void ToolStripMenuItem_Context_Udalit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Udalit_Click(sender, e);
        }
        private void ToolStripMenuItem_Pravit_Click(object sender, EventArgs e)
        {
            int nomer_stolbca = koordinati_mishi.Item.SubItems.IndexOf(koordinati_mishi.SubItem);

            if (nomer_stolbca == 1 || nomer_stolbca == 2 || nomer_stolbca == 5 || nomer_stolbca == 8 || nomer_stolbca == 9 || nomer_stolbca == 10 || nomer_stolbca == 11 || nomer_stolbca == 12)
            {
                Izmenit_Stroku izmenit_stroku = new Izmenit_Stroku(baza, koordinati_mishi);

                izmenit_stroku.ShowDialog();

                baza.izmeneniia_v_baze = true;

                Chtenie_Bazi();
            }
            else if (nomer_stolbca == 3 || nomer_stolbca == 4 || nomer_stolbca == 6 || nomer_stolbca == 7)
            {
                Izmenit_Iz_Spiska izmenit_Iz_spiska = new Izmenit_Iz_Spiska(baza, koordinati_mishi);

                izmenit_Iz_spiska.ShowDialog();

                baza.izmeneniia_v_baze = true;

                Chtenie_Bazi();
            }
        }
        private void ToolStripMenuItem_Context_Pravit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Pravit_Click(sender, e);
        }
        private void ToolStripMenuItem_Perechitat_Click(object sender, EventArgs e)
        {
            string[] stolbci = baza.baza[0];

            baza.baza.RemoveAt(0);

            baza.baza.Sort((x, y) => x[2].CompareTo(y[2]));

            baza.baza.Insert(0, stolbci);

            Chtenie_Bazi();

            menuStrip_Glavnoe_Menu.Items[5].Visible = false;
        }
        private void ToolStripMenuItem_Sohranit_Click(object sender, EventArgs e)
        {
            baza.Zapisat(nastroiki.put_do_bazi);
        }
        private void ToolStripMenuItem_Sohranit_Kak_Click(object sender, EventArgs e)
        {
            SaveFileDialog put_k_failu = new SaveFileDialog() { Filter = "*.CSV|*.csv" };

            if (put_k_failu.ShowDialog() == DialogResult.OK)
            {
                baza.Zapisat(put_k_failu.FileName);
            }
        }
        private void ToolStripMenuItem_Sozdat_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Otkrit_Click(sender, e);
        }
        /*private void ToolStripMenuItem_Poisk_Click(object sender, EventArgs e)
        {
            Poisk poisk = new Poisk();

            poisk.ShowDialog();

            if (Poisk.stroka_iz_poiska != null)
            {
                int chislo_parametrov_dlia_sravnenia = 0;

                int chislo_naidennih_parametrov = 0;

                for (int i = 0; i < Poisk.stroka_iz_poiska.Length; i++)
                {
                    if (i > 0)
                    {
                        if (Poisk.stroka_iz_poiska[i] != "")
                        {
                            chislo_parametrov_dlia_sravnenia++;
                        }
                    }
                }

                if (chislo_parametrov_dlia_sravnenia > 0)
                {
                    listView_Tablica_Vivoda_Bazi.Items.Clear();

                    foreach (string[] stroka_iz_bazi in baza)
                    {
                        for (int i = 0; i < Poisk.stroka_iz_poiska.Length; i++)
                        {
                            if (i > 0)
                            {
                                if (Poisk.stroka_iz_poiska[i] != "")
                                {
                                    if (Poisk.stroka_iz_poiska[i] == stroka_iz_bazi[i])
                                    {
                                        chislo_naidennih_parametrov++;
                                    }
                                }
                            }
                        }

                        if (chislo_naidennih_parametrov >= chislo_parametrov_dlia_sravnenia)
                        {
                            ListViewItem lv = new ListViewItem(stroka_iz_bazi);

                            listView_Tablica_Vivoda_Bazi.Items.Add(lv);
                        }

                        chislo_naidennih_parametrov = 0;
                    }

                    menuStrip_Glavnoe_Menu.Items[5].Visible = true;
                }
                else
                {
                    listView_Tablica_Vivoda_Bazi.Items.Clear();

                    menuStrip_Glavnoe_Menu.Items[5].Visible = true;
                }
            }
        }*/
        private void ToolStripMenuItem_Context_Poisk_Click(object sender, EventArgs e)
        {
            if (koordinati_mishi != null)
            {
                Poisk poisk = new Poisk(koordinati_mishi, baza);

                poisk.ShowDialog();

                List<string[]> resultat = Naiti_V_Baze.Perebor(baza.baza, poisk.stroka_iz_poiska);

                listView_Tablica_Vivoda_Bazi.Items.Clear();

                for (int i = 1; i < resultat.Count; i++)
                {
                    ListViewItem stroka = new ListViewItem(resultat[i]);

                    listView_Tablica_Vivoda_Bazi.Items.Add(stroka);
                }

                listView_Tablica_Vivoda_Bazi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                ToolStripMenuItem_Perechitat.Visible = true;
            }
        }
        private void Glavnoe_Okno_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (baza.izmeneniia_v_baze)
            {
                DialogResult resultat_vibora =

                MessageBox.Show
                (
                    "Сохранить изменения?",
                    "Закрытие программы",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

                if (resultat_vibora == DialogResult.Yes)
                {
                    ToolStripMenuItem_Sohranit_Click(sender, e);
                }
            }
        }
        private void toolStripMenuItem_Redaktirovanie_Spiskov_Click(object sender, EventArgs e)
        {
            Redaktirovanie_Spiskov redaktirovanie_spiskov = new Redaktirovanie_Spiskov();

            redaktirovanie_spiskov.ShowDialog();
        }
        private void listView_Tablica_Vivoda_Bazi_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string[] stolbci = baza.baza[0];

            baza.baza.RemoveAt(0);

            listView_Tablica_Vivoda_Bazi.Items.Clear();

            baza.baza.Sort((x, y) => x[e.Column].CompareTo(y[e.Column]));

            baza.baza.Insert(0, stolbci);

            Chtenie_Bazi();

            ToolStripMenuItem_Perechitat.Visible = true;
        }
        /*private void Obschii_poisk()
        {
            bool popadanie = false;

            listView_Tablica_Vivoda_Bazi.Items.Clear();

            foreach (string[] stroka_iz_bazi in baza)
            {
                for (int i = 0; i < stroka_iz_bazi.Length; i++)
                {
                    if (i > 0)
                    {
                        if (stroka_iz_bazi[i].Contains(textBox_Obschii_Poisk.Text))
                        {
                            popadanie = true;
                        }
                    }
                }

                if (popadanie)
                {
                    ListViewItem lvi = new ListViewItem(stroka_iz_bazi);

                    listView_Tablica_Vivoda_Bazi.Items.Add(lvi);

                    menuStrip_Glavnoe_Menu.Items[4].Visible = true;
                }

                popadanie = false;
            }
        }
        public static int Poisk_Shtuk(string stroka_dlia_poiska, int stolbec)
        {
            int kol_vo_naidennih_elementov = 0;

            foreach (string[] stroka_iz_bazi in baza)
            {
                if (stroka_iz_bazi[stolbec].Contains(stroka_dlia_poiska))
                {
                    kol_vo_naidennih_elementov++;
                }
            }

            return kol_vo_naidennih_elementov;
        }
        private void textBox_Obschii_Poisk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Obschii_poisk();
            }
        }
        /*private void Glavnoe_Okno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.F))
            {
                ToolStripMenuItem_Poisk_Click(sender, e);
            }
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                ToolStripMenuItem_Sohranit_Click(sender, e);

                izmeneniia_s_otkritiia = false;
            }
        }*/
        private void ToolStripMenuItem_Obschee_KolVo_Po_Tipam_Click(object sender, EventArgs e)
        {
            Otcheti_Po_MC otchet = new Otcheti_Po_MC(1);

            otchet.ShowDialog();
        }
        private void ToolStripMenuItem_Obschee_KolVo_Po_Tipu_Click(object sender, EventArgs e)
        {
            Otcheti_Po_MC otchet = new Otcheti_Po_MC(2);

            otchet.ShowDialog();
        }
        private void ToolStripMenuItem_KolVo_V_Pomeschenii_Click(object sender, EventArgs e)
        {
            Otcheti_Po_MC otchet = new Otcheti_Po_MC(3);

            otchet.ShowDialog();
        }
    }
}