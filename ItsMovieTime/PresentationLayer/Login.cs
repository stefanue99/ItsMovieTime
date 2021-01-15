using BusinessLayer;
using Shared.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        private readonly IAdministratorBusiness administrationBusiness;
        public Login()
        {
            InitializeComponent();
            this.administrationBusiness = new AdministratorBusiness();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "") 
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                if (this.administrationBusiness.GetAdministratorForLogIn(username,password))
                {
                    DialogResult = DialogResult.OK;
                }
                else 
                {
                    MessageBox.Show("Pogrijesno korisnicko ime ili lozinka");
                }
            }
        }
    }
}
