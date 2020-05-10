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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            using (var context = new TestSystemDBEntities())
            {
                users user = new users();

                if (!(String.IsNullOrEmpty(user_Nametb.Text)) && !(String.IsNullOrEmpty(user_Passwordtb.Text)) && !(String.IsNullOrEmpty(user_Roletb.Text)))
                {
                    erorLabel.Visible = false;
                    user.UserLogin = user_Nametb.Text;
                    user.UserPassword = user_Passwordtb.Text;
                    user.UserRole = Convert.ToInt32(user_Roletb.Text);

                    context.users.Add(user);
                    context.SaveChanges();

                    adminForm admfrm = (adminForm)Application.OpenForms[0];
                    admfrm.DataGridUpdate();
                }
                else
                {
                    erorLabel.Visible = true;
                    erorLabel.Text = "Все поля должны быть заполнены";
                }
            }
        }

        private void clearUserForm_Click(object sender, EventArgs e)
        {
            user_Nametb.Text = null;
            user_Passwordtb.Text = null;
            user_Roletb.Text = null;
        }

        private void closeCreateUserForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
