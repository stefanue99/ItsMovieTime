using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
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
    public partial class Admins : Form
    {
        private readonly IAdministratorBusiness administrationBusiness;
        public Admins()
        {
            InitializeComponent();
            this.administrationBusiness = new AdministratorBusiness();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxEmail.Text != "" && textBoxPhone.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                Administrator a = new Administrator()
                {
                    Id = Convert.ToInt32(textBoxId.Text),
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Email = textBoxEmail.Text,
                    PhoneNumber = textBoxPhone.Text,
                    UserName = textBoxUsername.Text,
                    Password = textBoxPassword.Text
                };
                if (this.administrationBusiness.UpdateAdministrator(a) == true)
                {
                    MessageBox.Show("Uspjesno izmenjen administrator!");
                    List<Administrator> list = this.administrationBusiness.GetAllAdministrators();
                    dataGridView1.DataSource = list;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxEmail.Text != "" && textBoxPhone.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                Administrator a = new Administrator()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Email = textBoxEmail.Text,
                    PhoneNumber = textBoxPhone.Text,
                    UserName = textBoxUsername.Text,
                    Password = textBoxPassword.Text
                };
                if (this.administrationBusiness.InsertAdministrator(a) == true)
                {
                    MessageBox.Show("Uspjesno unet administrator!");
                    List<Administrator> list = this.administrationBusiness.GetAllAdministrators();
                    dataGridView1.DataSource = list;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (this.administrationBusiness.DeleteAdministrator(id) == true)
                {
                    MessageBox.Show("Uspjesno izbrisan administrator!");
                    List<Administrator> list = this.administrationBusiness.GetAllAdministrators();
                    dataGridView1.DataSource = list;
                    Clear();
                }
                else 
                {
                    MessageBox.Show("Greska!");
                }
            }
        }
        public void Clear()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxPassword.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxUsername.Text= "";
        }
      

        private void Admins_Load(object sender, EventArgs e)
        {
            List<Administrator> list = this.administrationBusiness.GetAllAdministrators();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
