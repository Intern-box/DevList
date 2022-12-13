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
    public partial class Udalit : Form
    {
        ListViewHitTestInfo koordinati_mishi;                               // Переданные координаты мыши
        public Baza baza;                                                   // Переданный объект с базой

        public Udalit(Baza baza, ListViewHitTestInfo koordinati_mishi)      // Инициирование компонентов
        {
            InitializeComponent();

            this.baza = baza;

            this.koordinati_mishi = koordinati_mishi;
        }

        // Действия по кнопкам ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_Udalit_Click(object sender, EventArgs e)        // Обработка данных
        {
            baza.baza.RemoveAt(koordinati_mishi.Item.Index);

            baza.izmeneniia_v_baze = true;

            Close();
        }
        private void button_Otmenit_Click(object sender, EventArgs e)       // Закрываем форму без обработки
        {
            Close();
        }
    }
}