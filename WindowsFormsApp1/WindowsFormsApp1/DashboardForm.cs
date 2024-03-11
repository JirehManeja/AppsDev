using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DashboardForm : Form
    {
        private Form LoginForm;
        public DashboardForm(Form LoginForm)
        {
            InitializeComponent();
            this.LoginForm = LoginForm;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.Show();
        }

        private void ParkInButton_Click(object sender, EventArgs e)
        {
            ParkInForm parkInForm = new ParkInForm(this);
            parkInForm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
