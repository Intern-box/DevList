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
        public bool[] rezultat = new bool[13];

        public bool KnopkaVipolnit = false;

        public Kolonki(bool[] vidKolonok)
        {
            InitializeComponent();

            if (vidKolonok[1] == false) { CheckBoxDataPriobretenia.Checked = false; }
            if (vidKolonok[2] == false) { CheckBoxInvNomer.Checked = false; }
            if (vidKolonok[3] == false) { CheckBoxPomeschenie.Checked = false; }
            if (vidKolonok[4] == false) { CheckBoxFIO.Checked = false; }
            if (vidKolonok[5] == false) { CheckBoxNaimenovanie.Checked = false; }
            if (vidKolonok[6] == false) { CheckBoxOborudovanie.Checked = false; }
            if (vidKolonok[7] == false) { CheckBoxSostoianie.Checked = false; }
            if (vidKolonok[8] == false) { CheckBoxInventarizaciia.Checked = false; }
            if (vidKolonok[9] == false) { CheckBoxKommentarii.Checked = false; }
            if (vidKolonok[10] == false) { CheckBoxHostname.Checked = false; }
            if (vidKolonok[11] == false) { CheckBoxIP.Checked = false; }
            if (vidKolonok[12] == false) { CheckBoxIzmenil.Checked = false; }
        }

        private void ButtonVipolnit_Click(object sender, EventArgs e)
        {
            rezultat[0] = true;

            if (CheckBoxDataPriobretenia.Checked) { rezultat[1] = true; } else { rezultat[1] = false; }
            if (CheckBoxInvNomer.Checked) { rezultat[2] = true; } else { rezultat[2] = false; }
            if (CheckBoxPomeschenie.Checked) { rezultat[3] = true; } else { rezultat[3] = false; }
            if (CheckBoxFIO.Checked) { rezultat[4] = true; } else { rezultat[4] = false; }
            if (CheckBoxNaimenovanie.Checked) { rezultat[5] = true; } else { rezultat[5] = false; }
            if (CheckBoxOborudovanie.Checked) { rezultat[6] = true; } else { rezultat[6] = false; }
            if (CheckBoxSostoianie.Checked) { rezultat[7] = true; } else { rezultat[7] = false; }
            if (CheckBoxInventarizaciia.Checked) { rezultat[8] = true; } else { rezultat[8] = false; }
            if (CheckBoxKommentarii.Checked) { rezultat[9] = true; } else { rezultat[9] = false; }
            if (CheckBoxHostname.Checked) { rezultat[10] = true; } else { rezultat[10] = false; }
            if (CheckBoxIP.Checked) { rezultat[11] = true; } else { rezultat[11] = false; }
            if (CheckBoxIzmenil.Checked) { rezultat[12] = true; } else { rezultat[12] = false; }

            KnopkaVipolnit = true;

            Close();
        }

        private void ButtonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
