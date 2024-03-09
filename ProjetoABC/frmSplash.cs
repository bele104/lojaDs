using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoABC
{
    public partial class pctSplash : Form
    {
        public pctSplash()
        {

            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();

            abrir.Show();
            this.Hide();
        }
    }
}
