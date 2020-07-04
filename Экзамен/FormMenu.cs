using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            if (FormAvtoriz.users.Type == 1) buttonMed.Enabled = false;
        }

        private void buttonPhar_Click(object sender, EventArgs e)
        {
            Form formPharmacist = new FormNalichie();
            formPharmacist.Show();
        }

        private void buttonMed_Click(object sender, EventArgs e)
        {
            Form formMedicines = new FormMedicines();
            formMedicines.Show();
        }
    }
}
