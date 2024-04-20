using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouCanBan.Forms
{
    public partial class frmEnterBakEncryptionPassword : Form
    {
        public frmEnterBakEncryptionPassword()
        {
            InitializeComponent();
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtPassword.UseSystemPasswordChar = true; // Hide password
            }
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtPassword.UseSystemPasswordChar = false; // Show password
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
