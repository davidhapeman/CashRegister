using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Functions oFunc = new Functions(); Models oModel = new Models();

        public Form1()
        {
            InitializeComponent();
        }

        private void RunIT(Boolean bReadFile)
        {
            if (bReadFile)
            {
                this.dgFileData.DataSource = (Models.fileInputs)oFunc.loadInputFile(this.txtFileName.Text); // Input File Information
            }
            this.dgModel.DataSource    = (Models.denomOuts)oFunc.RunItAllClass(this.txtFileName.Text);  // Required Output Information
            this.dgChange.DataSource   = (DataTable)oFunc.RunItAllDataTable(this.txtFileName.Text);     // Full Output Information (For Debugging purposes)
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            RunIT(true);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            oFunc.getFilename(this.txtFileName.Text, this.txtFileName);
        }


        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            RunIT(false);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int iArea = this.Width - this.dgModel.Left - 80;

            this.dgChange.Width = iArea / 2;
            this.dgModel.Width = iArea / 2;
            this.dgChange.Left = this.dgModel.Left + this.dgModel.Width + 25;
            this.lblHeader1.Left = this.dgModel.Left;
            this.lblHeader2.Left = this.dgChange.Left;
            
            this.dgChange.Height = this.Height - this.dgChange.Top - 50;
            this.dgFileData.Height = this.dgChange.Height;
            this.dgModel.Height = this.dgChange.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgChange.AutoGenerateColumns = false;
            Form1_Resize(sender, e);
        }

        private void btnWhatIsThis_Click(object sender, EventArgs e)
        {
            frm_WhatIsThis oForm = new frm_WhatIsThis();
            oForm.Show();
        }
    }
}
