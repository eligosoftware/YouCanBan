﻿using System;
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
    public partial class frmBackupDatabase : Form
    {
        
        public frmBackupDatabase(string serverName="localhost", string databaseName="master")
        {
            InitializeComponent();
            txtServer.Text = serverName;
            txtDatabase.Text = databaseName;
        }

        private void btnBackup_Click(object sender, EventArgs e)
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
                string newFileName = Path.Combine(path, filename + "_enc" + extension);
                string filename_full = Path.Combine(path, filename + extension);







                if (DBManager.BackupDatabase(
                    server: txtServer.Text.Trim(),
                    databaseName: txtDatabase.Text.Trim(),
                    username: txtUsername.Text.Trim(),
                    password: txtPassword.Text.Trim(),
                    backupPath: filename_full))
                {
                    CryptManager.EncryptFile(filename_full, newFileName, decryptionPassword);
                    File.Delete(filename_full);
                    // rename the file to the original name
                    File.Move(newFileName, filename_full);
                    MessageBox.Show("Database backup completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Database backup failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPickFile_Click(object sender, EventArgs e)
        {
            // open file choose dialog and search for the location to save the bak file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "bak files (*.bak)|*.bak|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = saveFileDialog.FileName;
            }
        }
    }
}
