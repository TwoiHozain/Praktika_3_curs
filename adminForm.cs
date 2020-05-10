using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalSystem
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();  
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            DataGridInit();
        }

        public void DataGridUpdate()
        {
            userDataGredView.Rows.Clear();
            DataGridInit();
        }

        private void DataGridInit()
        {
            var context = new TestSystemDBEntities();
            foreach(users user in context.users)
            {
                string[] userStr = new string[] {user.id.ToString(),user.UserRole.ToString(),user.UserLogin.ToString(),user.UserPassword.ToString()};
                userDataGredView.Rows.Add(userStr);
            }
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addufrm = new AddUserForm();
            addufrm.Show();
        }

        private void userDataGredView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex == 4)
            {
                var context = new TestSystemDBEntities();
                users user = context.users.Find(Convert.ToInt32(userDataGredView.Rows[e.RowIndex].Cells[0].Value));

                context.users.Remove(user);
                context.SaveChanges();

                DataGridUpdate();
            }

            if (e.ColumnIndex == 5)
            {
                using (var context = new TestSystemDBEntities())
                {
                    users user = context.users.Find(Convert.ToInt32(userDataGredView.Rows[e.RowIndex].Cells[0].Value));
                    if (user != null)
                    {
                        if (!(String.IsNullOrEmpty(userDataGredView.Rows[e.RowIndex].Cells[2].Value.ToString())) && !(String.IsNullOrEmpty(userDataGredView.Rows[e.RowIndex].Cells[3].Value.ToString())) && !(String.IsNullOrEmpty(userDataGredView.Rows[e.RowIndex].Cells[1].Value.ToString())))
                        {
                            erorLabel.Visible = false;
                            user.UserLogin = userDataGredView.Rows[e.RowIndex].Cells[2].Value.ToString();
                            user.UserPassword = userDataGredView.Rows[e.RowIndex].Cells[3].Value.ToString();
                            user.UserRole = Convert.ToInt32(userDataGredView.Rows[e.RowIndex].Cells[1].Value.ToString());

                            context.Entry(user).State = EntityState.Modified;
                            context.SaveChanges();

                            DataGridUpdate();
                        }
                        else
                        {
                            erorLabel.Visible = true;
                            erorLabel.Text = "Все поля должны быть заполнены";
                        }
                    }
                }
            }
        }
    }
}
