using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EducationalSystem
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {
            label5.MaximumSize = new Size(400, 0);
            label5.AutoSize = true;
            label5.TextAlign = ContentAlignment.TopCenter;
        }

        private void Zareg_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(newUserLogin.Text)) && !(String.IsNullOrEmpty(newUserPassword.Text)) && !(String.IsNullOrEmpty(repeatUserPassword.Text)))
            {
                if (repeatUserPassword.Text == newUserPassword.Text)
                {
                    TestSystemDBEntities context = new TestSystemDBEntities();
                    users serchuserLog = context.users.Where(p => p.UserLogin == newUserLogin.Text).FirstOrDefault();

                    if (serchuserLog == null)
                    {
                        label6.Visible = false;
                        users user = new users();
                        user.UserLogin = newUserLogin.Text;
                        user.UserPassword = newUserPassword.Text;
                        user.UserRole = 2;
                        context.users.Add(user);
                        context.SaveChanges();
                        MessageBox.Show("Успешная регистрация!");
                    }
                    else
                    {
                        label6.Visible = true;
                        label6.Text = "*Пользователь с таким логином уже существует";
                    }
                }
                else
                {
                    label6.Visible = true;
                    label6.Text = "*Пароль и повтор пароля не совпадают";
                }
            }
            else
            {
                label6.Visible = true;
                label6.Text = "*Не все поля заполнены";
            }
        }
    }
}
