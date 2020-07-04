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
    public partial class FormReg : Form
    {
        
        public FormReg()
        {
            InitializeComponent();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (textBoxFam.Text != "" && textBoxPassword.Text != "" && textBoxPassword2.Text != "" && textBoxMail.Text != "" 
                && textBoxName.Text != "" && textBoxOt.Text != "" && textBoxPhone.Text != "")
            {
                if (textBoxPassword.Text == textBoxPassword2.Text)
                {
                    Buyer user = new Buyer();
                    user.Surname = textBoxFam.Text;
                    user.Name = textBoxName.Text;
                    user.MiddleName = textBoxOt.Text;
                    user.Phone = textBoxPhone.Text;
                    user.Email = textBoxMail.Text;
                    user.Login = textBoxLogin.Text;
                    user.Password = textBoxPassword.Text;
                    Program.Экзамен.Buyer.Add(user);
                    Program.Экзамен.SaveChanges();
                    MessageBox.Show("Пользователь зарегестрирован.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonBec_Click(object sender, EventArgs e)
        {
            Form formAvtoriz = new FormAvtoriz();
            formAvtoriz.Show();
        }
    }
}
