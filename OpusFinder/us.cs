using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpusFinder
{
    public partial class us : Form
    {
        public us()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cv cv = new cv();
            cv.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
