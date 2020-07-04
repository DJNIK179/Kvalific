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
    public partial class FormNalichie : Form
    {
        public FormNalichie()
        {
            InitializeComponent();
            ShowMed();
        }

        void ShowMed()
        {
            listViewNal.Items.Clear();
            foreach (Medicines medicines in Program.Экзамен.Medicines)
            {
                ListViewItem item = new ListViewItem(new string[] {

                    medicines.Id.ToString(),
                    medicines.Name,
                    medicines.Form_release,
                    medicines.Dosage,
                    medicines.Manufacturer,
                    medicines.Shelf_life
                    });
                item.Tag = medicines;
                listViewNal.Items.Add(item);
            }
        }

        private void listViewNal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMed();
        }
    }
}
