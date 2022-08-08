﻿using System;
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
        public static List<string[]> baza = new List<string[]>();

        public static uint index = 0;
        public Glavnoe_Okno()
        {
            InitializeComponent();
        }
        private void Glavnoe_Okno_Load(object sender, EventArgs e)
        {
            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
        private void Chtenie_Bazi(ListView listview, List<string[]> baza)
        {
            listView_Tablica_Vivoda_Bazi.Items.Clear();

            for (int i = 0; i < baza.Count; i++)
            {
                ListViewItem iz_bazi_v_tablicu = new ListViewItem(baza[i]);

                listview.Items.Add(iz_bazi_v_tablicu);
            }
        }
        private void ToolStripMenuItem_Dobavit_Click(object sender, EventArgs e)
        {
            Dobavit dobavit = new Dobavit();

            dobavit.ShowDialog();

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
        private void ToolStripMenuItem_Udalit_Click(object sender, EventArgs e)
        {
            Udalit udalit = new Udalit();

            udalit.ShowDialog();

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
        private void ToolStripMenuItem_Context_Dobavit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Dobavit_Click(sender, e);
        }
        private void ToolStripMenuItem_Context_Udalit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Udalit_Click(sender, e);
        }
        private void ToolStripMenuItem_Pravit_Click(object sender, EventArgs e)
        {
            Pravit pravit = new Pravit();

            pravit.ShowDialog();

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
        private void ToolStripMenuItem_Context_Pravit_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Pravit_Click(sender, e);
        }
        private void ToolStripMenuItem_Poisk_Click(object sender, EventArgs e)
        {
            Poisk poisk = new Poisk();

            poisk.ShowDialog();

            int po_skolki_parametram_sravnivaem = 0;
            int vsego_odinakovih_parametrov = 0;

            foreach (string[] stroka in baza)
            {
                if (Poisk.stroka[0] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[0] == stroka[0])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[1] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[1] == stroka[1])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[2] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[2] == stroka[2])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[3] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[3] == stroka[3])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[4] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[4] == stroka[4])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }
                if (Poisk.stroka[5] != "")
                {
                    po_skolki_parametram_sravnivaem++;

                    if (Poisk.stroka[5] == stroka[5])
                    {
                        vsego_odinakovih_parametrov++;
                    }
                }

                if (po_skolki_parametram_sravnivaem == 0)
                {
                    return;
                }

                if (vsego_odinakovih_parametrov >= po_skolki_parametram_sravnivaem)
                {
                    listView_Tablica_Vivoda_Bazi.Items.Clear();

                    listView_Tablica_Vivoda_Bazi.Items.Add(Viborka_Strok_Iz_Bazi(stroka));
                }

                po_skolki_parametram_sravnivaem = vsego_odinakovih_parametrov = 0;
            }
        }
        private void ToolStripMenuItem_Context_Poisk_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Poisk_Click(sender, e);
        }
        private ListViewItem Viborka_Strok_Iz_Bazi(string[] stroka)
        {
            ListViewItem lv = new ListViewItem(stroka);

            return lv;
        }
        private void ToolStripMenuItem_Perechitat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < baza.Count; i++)
            {
                baza[i][0] = (i + 1).ToString();
            }

            Chtenie_Bazi(listView_Tablica_Vivoda_Bazi, baza);
        }
    }
}