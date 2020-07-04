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
    public partial class FormMedicines : Form
    {
        public FormMedicines()
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && comboBoxForma.SelectedItem != null && textBoxDoz.Text != "" 
                && textBoxProiz.Text != "" && textBoxSroc.Text != "")
            {
                Medicines medicines = new Medicines();
                medicines.Name = textBoxName.Text;
                medicines.Form_release = comboBoxForma.SelectedItem.ToString();
                medicines.Dosage = textBoxDoz.Text;
                medicines.Manufacturer = textBoxProiz.Text;
                medicines.Shelf_life = textBoxSroc.Text;
                Program.Экзамен.Medicines.Add(medicines);
                Program.Экзамен.SaveChanges();
                ShowMed();
            }
            else MessageBox.Show("Заполнены не все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewNal.SelectedItems.Count == 1)
            {
                if (textBoxName.Text != "" && comboBoxForma.SelectedItem != null && textBoxDoz.Text != ""
                && textBoxProiz.Text != "" && textBoxSroc.Text != "")
                {
                    Medicines medicines = listViewNal.SelectedItems[0].Tag as Medicines;
                    medicines.Name = textBoxName.Text;
                    medicines.Form_release = comboBoxForma.SelectedItem.ToString();
                    medicines.Dosage = textBoxDoz.Text;
                    medicines.Manufacturer = textBoxProiz.Text;
                    medicines.Shelf_life = textBoxSroc.Text;
                    Program.Экзамен.SaveChanges();
                    ShowMed();
                }
                else MessageBox.Show("Заполнены не все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewNal.SelectedItems.Count == 1)
                {
                    Medicines medicines = listViewNal.SelectedItems[0].Tag as Medicines;
                    Program.Экзамен.Medicines.Remove(medicines);
                    Program.Экзамен.SaveChanges();
                    ShowMed();
                }
                textBoxName.Text = "";
                comboBoxForma.SelectedItem = null;
                textBoxDoz.Text = "";
                textBoxProiz.Text = "";
                textBoxSroc.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewNal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNal.SelectedItems.Count == 1)
            {
                Medicines medicines = listViewNal.SelectedItems[0].Tag as Medicines;
                textBoxName.Text = medicines.Name;
                textBoxDoz.Text = medicines.Dosage;
                textBoxProiz.Text = medicines.Manufacturer;
                textBoxSroc.Text = medicines.Shelf_life;
                comboBoxForma.SelectedIndex = comboBoxForma.FindString(medicines.Form_release.ToString());
            }
            else
            {
                textBoxName.Text = "";
                comboBoxForma.SelectedItem = null;
                textBoxDoz.Text = "";
                textBoxProiz.Text = "";
                textBoxSroc.Text = "";
            }
        }
    }
}
