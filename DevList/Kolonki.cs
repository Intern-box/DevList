using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public partial class Kolonki : Form
    {
        public bool[] rezultat = new bool[12];
        public bool KnopkaVipolnit = false;

        public Kolonki()
        {
            InitializeComponent();
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            if (CheckBoxDataPriobretenia.Checked)
            {
                rezultat[0] = true;
            }
            else
            {
                rezultat[0] = false;
            }

            if (CheckBoxInvNomer.Checked)
            {
                rezultat[1] = true;
            }
            else
            {
                rezultat[1] = false;
            }

            if (CheckBoxPomeschenie.Checked)
            {
                rezultat[2] = true;
            }
            else
            {
                rezultat[2] = false;
            }

            if (CheckBoxFIO.Checked)
            {
                rezultat[3] = true;
            }
            else
            {
                rezultat[3] = false;
            }

            if (CheckBoxNaimenovanie.Checked)
            {
                rezultat[4] = true;
            }
            else
            {
                rezultat[4] = false;
            }

            if (CheckBoxOborudovanie.Checked)
            {
                rezultat[5] = true;
            }
            else
            {
                rezultat[5] = false;
            }

            if (CheckBoxSostoianie.Checked)
            {
                rezultat[6] = true;
            }
            else
            {
                rezultat[6] = false;
            }

            if (CheckBoxInventarizaciia.Checked)
            {
                rezultat[7] = true;
            }
            else
            {
                rezultat[7] = false;
            }

            if (CheckBoxKommentarii.Checked)
            {
                rezultat[8] = true;
            }
            else
            {
                rezultat[8] = false;
            }

            if (CheckBoxHostname.Checked)
            {
                rezultat[9] = true;
            }
            else
            {
                rezultat[9] = false;
            }

            if (CheckBoxIP.Checked)
            {
                rezultat[10] = true;
            }
            else
            {
                rezultat[10] = false;
            }

            if (CheckBoxIzmenil.Checked)
            {
                rezultat[11] = true;
            }
            else
            {
                rezultat[11] = false;
            }

            KnopkaVipolnit = true;

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
