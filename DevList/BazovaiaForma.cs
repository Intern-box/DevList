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

        public BazovaiaForma(INIFail iniFail, Baza baza)
        {
            InitializeComponent();

            this.iniFail = iniFail;

            this.baza = baza;
        }
    }
}