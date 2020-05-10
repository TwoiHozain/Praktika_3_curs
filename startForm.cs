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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(userLogin.Text)) && !(String.IsNullOrEmpty(userPassword.Text)))
            {
                TestSystemDBEntities context = new TestSystemDBEntities();
                users serchuserLog = context.users.Where(p => p.UserLogin == userLogin.Text && p.UserPassword == userPassword.Text).FirstOrDefault();

                if (serchuserLog != null)
                {
                    if (serchuserLog.UserRole == 1)
                    {
                        //MessageBox.Show("Вы вошли как админ Nik: "+serchuserLog.UserLogin.ToString() + "  Password: " + serchuserLog.UserPassword);
                        Program.Context.MainForm = new adminForm();
                        this.Close();
                        Program.Context.MainForm.Show();
                    }
                    else
                    {
                        //MessageBox.Show("Вы вошли как пользователь Nik: " + serchuserLog.UserLogin.ToString() + "Password: " + serchuserLog.UserPassword);
                        Program.Context.MainForm = new listnerForm();
                        this.Close();
                        Program.Context.MainForm.Show();
                    }
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "Неверное имя пользователя или пароль";
                }
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Поля логин и пароль не должны быть пустыми";
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            registrationForm regfrm = new registrationForm();
            regfrm.Show();
            this.Close();
        }
    }
}
