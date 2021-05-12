
namespace RetHashFuncs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusLabel = new System.Windows.Forms.Label();
            this.btnVerify1 = new System.Windows.Forms.Button();
            this.txtHashString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHash1 = new System.Windows.Forms.Button();
            this.boxAlgorithm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusLabel2 = new System.Windows.Forms.Label();
            this.btnVerify2 = new System.Windows.Forms.Button();
            this.txtHashFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHash2 = new System.Windows.Forms.Button();
            this.boxAlgorithm2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusLabel3 = new System.Windows.Forms.Label();
            this.btnVerify3 = new System.Windows.Forms.Button();
            this.txtHashFileHmac = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHashHmac = new System.Windows.Forms.Button();
            this.boxAlgorithm3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRandomCode = new System.Windows.Forms.Button();
            this.txtCodeHex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrowse2 = new System.Windows.Forms.Button();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusLabel);
            this.tabPage1.Controls.Add(this.btnVerify1);
            this.tabPage1.Controls.Add(this.txtHashString);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnHash1);
            this.tabPage1.Controls.Add(this.boxAlgorithm);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtString1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Strings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(300, 314);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "[Status]";
            // 
            // btnVerify1
            // 
            this.btnVerify1.Location = new System.Drawing.Point(6, 309);
            this.btnVerify1.Name = "btnVerify1";
            this.btnVerify1.Size = new System.Drawing.Size(288, 23);
            this.btnVerify1.TabIndex = 7;
            this.btnVerify1.Text = "Verify String and Digest";
            this.btnVerify1.UseVisualStyleBackColor = true;
            this.btnVerify1.Click += new System.EventHandler(this.btnVerify1_Click);
            // 
            // txtHashString
            // 
            this.txtHashString.Location = new System.Drawing.Point(7, 183);
            this.txtHashString.Multiline = true;
            this.txtHashString.Name = "txtHashString";
            this.txtHashString.Size = new System.Drawing.Size(455, 119);
            this.txtHashString.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hashed String:";
            // 
            // btnHash1
            // 
            this.btnHash1.Location = new System.Drawing.Point(219, 129);
            this.btnHash1.Name = "btnHash1";
            this.btnHash1.Size = new System.Drawing.Size(243, 23);
            this.btnHash1.TabIndex = 4;
            this.btnHash1.Text = "Compute Hash";
            this.btnHash1.UseVisualStyleBackColor = true;
            this.btnHash1.Click += new System.EventHandler(this.btnHash1_Click);
            // 
            // boxAlgorithm
            // 
            this.boxAlgorithm.FormattingEnabled = true;
            this.boxAlgorithm.Location = new System.Drawing.Point(70, 131);
            this.boxAlgorithm.Name = "boxAlgorithm";
            this.boxAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.boxAlgorithm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Algorithm:";
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(6, 23);
            this.txtString1.Multiline = true;
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(456, 101);
            this.txtString1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter String:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusLabel2);
            this.tabPage2.Controls.Add(this.btnVerify2);
            this.tabPage2.Controls.Add(this.txtHashFile);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnHash2);
            this.tabPage2.Controls.Add(this.boxAlgorithm2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnBrowse);
            this.tabPage2.Controls.Add(this.txtPath);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusLabel2
            // 
            this.statusLabel2.AutoSize = true;
            this.statusLabel2.Location = new System.Drawing.Point(313, 317);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(43, 13);
            this.statusLabel2.TabIndex = 12;
            this.statusLabel2.Text = "[Status]";
            // 
            // btnVerify2
            // 
            this.btnVerify2.Location = new System.Drawing.Point(9, 312);
            this.btnVerify2.Name = "btnVerify2";
            this.btnVerify2.Size = new System.Drawing.Size(288, 23);
            this.btnVerify2.TabIndex = 11;
            this.btnVerify2.Text = "Verify File and Digest";
            this.btnVerify2.UseVisualStyleBackColor = true;
            this.btnVerify2.Click += new System.EventHandler(this.btnVerify2_Click);
            // 
            // txtHashFile
            // 
            this.txtHashFile.Location = new System.Drawing.Point(9, 104);
            this.txtHashFile.Multiline = true;
            this.txtHashFile.Name = "txtHashFile";
            this.txtHashFile.Size = new System.Drawing.Size(455, 202);
            this.txtHashFile.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hashed File:";
            // 
            // btnHash2
            // 
            this.btnHash2.Location = new System.Drawing.Point(223, 48);
            this.btnHash2.Name = "btnHash2";
            this.btnHash2.Size = new System.Drawing.Size(243, 23);
            this.btnHash2.TabIndex = 7;
            this.btnHash2.Text = "Compute Hash";
            this.btnHash2.UseVisualStyleBackColor = true;
            this.btnHash2.Click += new System.EventHandler(this.btnHash2_Click);
            // 
            // boxAlgorithm2
            // 
            this.boxAlgorithm2.FormattingEnabled = true;
            this.boxAlgorithm2.Location = new System.Drawing.Point(74, 50);
            this.boxAlgorithm2.Name = "boxAlgorithm2";
            this.boxAlgorithm2.Size = new System.Drawing.Size(121, 21);
            this.boxAlgorithm2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Algorithm:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(348, 11);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(44, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(298, 20);
            this.txtPath.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Path:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.statusLabel3);
            this.tabPage3.Controls.Add(this.btnVerify3);
            this.tabPage3.Controls.Add(this.txtHashFileHmac);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.btnHashHmac);
            this.tabPage3.Controls.Add(this.boxAlgorithm3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnRandomCode);
            this.tabPage3.Controls.Add(this.txtCodeHex);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtBrowse2);
            this.tabPage3.Controls.Add(this.txtPath2);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(472, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HMac Files";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusLabel3
            // 
            this.statusLabel3.AutoSize = true;
            this.statusLabel3.Location = new System.Drawing.Point(310, 317);
            this.statusLabel3.Name = "statusLabel3";
            this.statusLabel3.Size = new System.Drawing.Size(43, 13);
            this.statusLabel3.TabIndex = 16;
            this.statusLabel3.Text = "[Status]";
            // 
            // btnVerify3
            // 
            this.btnVerify3.Location = new System.Drawing.Point(6, 312);
            this.btnVerify3.Name = "btnVerify3";
            this.btnVerify3.Size = new System.Drawing.Size(288, 23);
            this.btnVerify3.TabIndex = 15;
            this.btnVerify3.Text = "Verify File and Digest";
            this.btnVerify3.UseVisualStyleBackColor = true;
            this.btnVerify3.Click += new System.EventHandler(this.btnVerify3_Click);
            // 
            // txtHashFileHmac
            // 
            this.txtHashFileHmac.Location = new System.Drawing.Point(6, 104);
            this.txtHashFileHmac.Multiline = true;
            this.txtHashFileHmac.Name = "txtHashFileHmac";
            this.txtHashFileHmac.Size = new System.Drawing.Size(455, 202);
            this.txtHashFileHmac.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Hashed File:";
            // 
            // btnHashHmac
            // 
            this.btnHashHmac.Location = new System.Drawing.Point(223, 64);
            this.btnHashHmac.Name = "btnHashHmac";
            this.btnHashHmac.Size = new System.Drawing.Size(243, 23);
            this.btnHashHmac.TabIndex = 11;
            this.btnHashHmac.Text = "Compute HMAC";
            this.btnHashHmac.UseVisualStyleBackColor = true;
            this.btnHashHmac.Click += new System.EventHandler(this.btnHashHmac_Click);
            // 
            // boxAlgorithm3
            // 
            this.boxAlgorithm3.FormattingEnabled = true;
            this.boxAlgorithm3.Location = new System.Drawing.Point(78, 66);
            this.boxAlgorithm3.Name = "boxAlgorithm3";
            this.boxAlgorithm3.Size = new System.Drawing.Size(117, 21);
            this.boxAlgorithm3.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Algorithm:";
            // 
            // btnRandomCode
            // 
            this.btnRandomCode.Location = new System.Drawing.Point(348, 35);
            this.btnRandomCode.Name = "btnRandomCode";
            this.btnRandomCode.Size = new System.Drawing.Size(118, 23);
            this.btnRandomCode.TabIndex = 8;
            this.btnRandomCode.Text = "Random";
            this.btnRandomCode.UseVisualStyleBackColor = true;
            this.btnRandomCode.Click += new System.EventHandler(this.btnRandomCode_Click);
            // 
            // txtCodeHex
            // 
            this.txtCodeHex.Location = new System.Drawing.Point(78, 38);
            this.txtCodeHex.Name = "txtCodeHex";
            this.txtCodeHex.Size = new System.Drawing.Size(264, 20);
            this.txtCodeHex.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Code (Hex):";
            // 
            // txtBrowse2
            // 
            this.txtBrowse2.Location = new System.Drawing.Point(348, 4);
            this.txtBrowse2.Name = "txtBrowse2";
            this.txtBrowse2.Size = new System.Drawing.Size(118, 23);
            this.txtBrowse2.TabIndex = 5;
            this.txtBrowse2.Text = "Browse...";
            this.txtBrowse2.UseVisualStyleBackColor = true;
            this.txtBrowse2.Click += new System.EventHandler(this.txtBrowse2_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(44, 6);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(298, 20);
            this.txtPath2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 393);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "C# Hashing tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button btnVerify1;
        private System.Windows.Forms.TextBox txtHashString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHash1;
        private System.Windows.Forms.ComboBox boxAlgorithm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label statusLabel2;
        private System.Windows.Forms.Button btnVerify2;
        private System.Windows.Forms.TextBox txtHashFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHash2;
        private System.Windows.Forms.ComboBox boxAlgorithm2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label statusLabel3;
        private System.Windows.Forms.Button btnVerify3;
        private System.Windows.Forms.TextBox txtHashFileHmac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHashHmac;
        private System.Windows.Forms.ComboBox boxAlgorithm3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRandomCode;
        private System.Windows.Forms.TextBox txtCodeHex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtBrowse2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

