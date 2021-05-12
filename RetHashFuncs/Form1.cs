using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetHashFuncs
{
    public partial class Form1 : Form
    {
        byte[] savedByteArr;
        public enum HashFuncs
        {
            MD5=1,
            SHA1=2,
            SHA256=3,
            SHA512=4,
            SHA3_256=5,
            SHA3_512=6
        }
        public enum HMACHashFunctions
        {
            HmacMD5 = 1,
            HmacSHA1 = 2,
            HmacSHA256 = 3,
            HmacSHA512 = 4
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boxAlgorithm.DataSource = Enum.GetNames(typeof(HashFuncs));
            boxAlgorithm2.DataSource = Enum.GetNames(typeof(HashFuncs));
            boxAlgorithm3.DataSource = Enum.GetNames(typeof(HMACHashFunctions));
            statusLabel.Text = "Waiting...";
            statusLabel2.Text = "Waiting...";
            statusLabel3.Text = "Waiting...";
        }

        private void btnHash1_Click(object sender, EventArgs e)
        {
            txtHashString.Text = HashingHandler.ComputeHashAsBytesString(txtString1.Text, boxAlgorithm.SelectedIndex);
        }

        private void btnVerify1_Click(object sender, EventArgs e)
        {
            string hashed = HashingHandler.ComputeHashAsBytesString(txtString1.Text, boxAlgorithm.SelectedIndex);
            if(hashed==txtHashString.Text)
            {
                statusLabel.Text = "OK!";
                statusLabel.BackColor = Color.Lime;
            }
            else
            {
                statusLabel.Text = "BAD!";
                statusLabel.BackColor = Color.Red;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                txtPath.Text = file;
            }
        }

        private void btnHash2_Click(object sender, EventArgs e)
        {
            try
            {
                txtHashFile.Text = HashingHandler.ComputeHashAsBytesFile(txtPath.Text, boxAlgorithm2.SelectedIndex);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                txtPath2.Text = file;
            }
        }

        private void btnRandomCode_Click(object sender, EventArgs e)
        {
            savedByteArr = HashingHandler.GenerateRandomKey();
            txtCodeHex.Text = HashingHandler.DisplayBytesAsString(savedByteArr);
        }

        private void btnHashHmac_Click(object sender, EventArgs e)
        {
            try
            {
                txtHashFileHmac.Text = HashingHandler.ComputeHMACHashAsBytesFile(savedByteArr, txtPath2.Text, boxAlgorithm3.SelectedIndex);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerify2_Click(object sender, EventArgs e)
        {
            try
            {
                string hashed = HashingHandler.ComputeHashAsBytesFile(txtPath.Text, boxAlgorithm2.SelectedIndex);
                if (hashed == txtHashFile.Text)
                {
                    statusLabel2.Text = "OK!";
                    statusLabel2.BackColor = Color.Lime;
                }
                else
                {
                    statusLabel2.Text = "BAD!";
                    statusLabel2.BackColor = Color.Red;
                }
            }
            catch(IOException)
            {
                statusLabel2.Text = "Waiting...";
            }
        }

        private void btnVerify3_Click(object sender, EventArgs e)
        {
            try
            {
                string hashed = HashingHandler.ComputeHMACHashAsBytesFile(savedByteArr, txtPath2.Text, boxAlgorithm3.SelectedIndex);
                if (hashed == txtHashFileHmac.Text)
                {
                    statusLabel3.Text = "OK!";
                    statusLabel3.BackColor = Color.Lime;
                }
                else
                {
                    statusLabel3.Text = "BAD!";
                    statusLabel3.BackColor = Color.Red;
                }
            }
            catch (IOException)
            {
                statusLabel3.Text = "Waiting...";
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Are you sure you chose a key?");
                statusLabel3.Text = "Waiting...";
            }
        }
    }
}
