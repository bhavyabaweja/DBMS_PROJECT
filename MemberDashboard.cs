using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCentre
{
    public partial class MemberDashboard : Form
    {
        public MemberDashboard()
        {
            InitializeComponent();
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Close current form
            new Login().Show();
        }
    }
}
