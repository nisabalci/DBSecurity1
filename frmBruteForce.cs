using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSecurity1
{
    public partial class frmBruteForce : Form
    {
        public frmBruteForce()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBruteForce_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs;
            string serverName = txtServerName.Text;
            string userName = "SA";
            string dbName = txtDbName.Text;
            string password;
            int i;
            int k = 0;
            int count;
            count = Convert.ToInt32(txtCount.Text);


            lstPasswordList.Items.Clear();
            System.IO.StreamReader sr = new System.IO.StreamReader("uniqpass_preview.txt");
            for(i=0; i<count;i++)
            {
                k++;
                password = sr.ReadLine();
                lblStatus.Text = password;
                lstPasswordList.Items.Add(password);
                Update();

                if(k>=15)
                {
                    k = 0;
                    lstPasswordList.Items.Clear();
                }
            }

        }
    }
}
