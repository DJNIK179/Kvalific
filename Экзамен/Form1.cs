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
    public partial class FormAvtoriz : Form
    {
        public FormAvtoriz()
        {
            InitializeComponent();
        }
        public struct User
        {
            public string Name;
            public string Login;
            public string Password;
            public int Type;
        }

        public static User users = new User();

        private void button3_Click(object sender, EventArgs e)
        {
            Form formReg = new FormReg();
            formReg.Show();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                
                    foreach (Pharmacist user in Program.Экзамен.Pharmacist)
                    {
                        if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                        {
                            users.Type = 2;
                            key = true;
                            users.Login = user.Login;
                            users.Password = user.Password;
                        }
                    }
                    
                
                    
                     foreach (Buyer user in Program.Экзамен.Buyer)
                     {
                        if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                        {
                                users.Type = 1;
                                key = true;
                                users.Login = user.Login;
                                users.Password = user.Password;
                        }
                     }

                    
                
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Form formMenu = new FormMenu();
                    formMenu.Show();
                    textBoxPassword.Text = "";
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
