using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouCanBan.classes.cryptography;
using YouCanBan.classes.db;

namespace YouCanBan.Forms
{
    public partial class frmRestoreDatabase : Form
    {
        public frmRestoreDatabase()
        {
            InitializeComponent();
        }

        private void btnPickFile_Click(object sender, EventArgs e)
        {
            // open file choose dialog and search for the bak file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "bak files (*.bak)|*.bak|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = openFileDialog.FileName;
            }

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string decryptionPassword = "";
                

                // check if all fields are filled
                if (string.IsNullOrEmpty(txtServer.Text.Trim())
                    || string.IsNullOrEmpty(txtDatabase.Text.Trim())
                    || string.IsNullOrEmpty(txtUsername.Text.Trim())
                    || string.IsNullOrEmpty(txtPassword.Text.Trim())
                    || string.IsNullOrEmpty(txtBackupPath.Text.Trim()))
                {
                    MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ask the user for the password
                frmEnterBakEncryptionPassword frmEnterBakEncryptionPassword1 = new frmEnterBakEncryptionPassword();
                if (frmEnterBakEncryptionPassword1.ShowDialog() == DialogResult.OK && frmEnterBakEncryptionPassword1.txtPassword.Text.Trim() != "")
                {
                    decryptionPassword = frmEnterBakEncryptionPassword1.txtPassword.Text;
                }
                else
                {
                    MessageBox.Show("Enter Encryption/Decryption Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // add _bak to the end of the selected file
                string filename = Path.GetFileNameWithoutExtension(txtBackupPath.Text);
                string extension = Path.GetExtension(txtBackupPath.Text);
                string path = Path.GetDirectoryName(txtBackupPath.Text);
                string newFileName = Path.Combine(path, filename + "_dec" + extension);
                

                CryptManager.DecryptFile(txtBackupPath.Text, newFileName, decryptionPassword);


                if (!DBManager.RestoreDatabase(
                    server: txtServer.Text.Trim(),
                    databaseName: txtDatabase.Text.Trim(),
                    username: txtUsername.Text.Trim(),
                    password: txtPassword.Text.Trim(),
                    backupPath: newFileName))
                {
                    MessageBox.Show("Database restore failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // delete the decrypted file
                File.Delete(newFileName);
                MessageBox.Show("Database restore completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

        }
    }
}
