using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevList
{
    public class FormenniiFunkcional : Form
    {
        public INIFail iniFail;
        public Baza baza;
        public ListViewHitTestInfo koordinati;
        public bool sortirovkaVKolonkah = false;
        public bool[] vidKolonok = { true, true, true, true, true, true, true, true, true, true, true, true };
    }
}