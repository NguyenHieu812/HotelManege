using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ql_KhachSan
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManageHotel dashboard = new ManageHotel();
            dashboard.Show();
        }
    }
}
