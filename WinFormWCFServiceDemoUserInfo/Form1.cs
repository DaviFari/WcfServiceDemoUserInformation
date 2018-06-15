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
        private void btnSingleShow_Click(object sender, EventArgs e)
        {
            string listsingle = wsf1.find(txtUserPass.Text).UserName.ToString();
            label1.Text = listsingle;
        }

        private void btnAllShow_Click(object sender, EventArgs e)
        {
            var listsingle = wsf1.findAll();
            dataGridView1.DataSource = listsingle;
            dataGridView1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
