using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1;

namespace WinFormWCFServiceDemoUserInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DemoUserInfoDBServiceWCFClient wsf1 = new DemoUserInfoDBServiceWCFClient();


        private void btnAllShow_Click(object sender, EventArgs e)
        {
            var listsingle = wsf1.findAll();
            dataGridView1.DataSource = listsingle;
            dataGridView1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSingleShow_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = wsf1.find(txtUserPass.Text).UserName.ToString();
                string password = wsf1.find(txtUserPass.Text).UserPassword.ToString();
                lblUsersinglView.Text = name + "-" + password;
            }
            catch
            {

                MessageBox.Show("unvalaite password");

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool Edite = wsf1.Edit(txtEditNNam.Text, txtEditCurentPass.Text);
            if (Edite == true)
            {
                MessageBox.Show("Edite Successes");
            }
            else
            {
                MessageBox.Show("error No Successes Edit");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            bool insert = wsf1.insert(txtInsertNam.Text, txtInsertPass.Text);
            if (insert == true)
            {
                MessageBox.Show("Insert Successes");
            }
            else
            {
                MessageBox.Show("error No Successes Insert");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool delete = wsf1.delete(txtDelete.Text);
            if (delete == true)
            {
                MessageBox.Show("DElete Successes");
            }
            else
            {
                MessageBox.Show("error No Successes Delete");
            }
        }
        public bool ClearTxtboxs(object sender)
        {
            TextBox t = (Control)sender as TextBox;
            t.Text = "";
            return true;

        }
     
        private void txtUserPass_MouseClick(object sender, MouseEventArgs e)
        {

                ClearTxtboxs(sender);

           
        }
    }
}
