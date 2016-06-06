namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.dgFileData = new System.Windows.Forms.DataGridView();
            this.amountOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalculateChange = new System.Windows.Forms.Button();
            this.dgChange = new System.Windows.Forms.DataGridView();
            this.chgWording = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgHundreds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgFiftys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgTwentys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgTens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgFives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgOnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgQuarters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgDimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgNickels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgPennies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgDiv3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dgModel = new System.Windows.Forms.DataGridView();
            this.outChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.btnWhatIsThis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgModel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(101, 22);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(375, 22);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Text = "c:\\Users\\David\\Desktop\\MoneySample.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FileName";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(31, 51);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(90, 23);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // dgFileData
            // 
            this.dgFileData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgFileData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFileData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountOwed,
            this.amountPaid});
            this.dgFileData.Location = new System.Drawing.Point(31, 118);
            this.dgFileData.Name = "dgFileData";
            this.dgFileData.RowTemplate.Height = 24;
            this.dgFileData.Size = new System.Drawing.Size(319, 550);
            this.dgFileData.TabIndex = 3;
            // 
            // amountOwed
            // 
            this.amountOwed.DataPropertyName = "amountOwed";
            this.amountOwed.HeaderText = "Owed";
            this.amountOwed.Name = "amountOwed";
            // 
            // amountPaid
            // 
            this.amountPaid.DataPropertyName = "amountPaid";
            this.amountPaid.HeaderText = "Paid";
            this.amountPaid.Name = "amountPaid";
            // 
            // btnCalculateChange
            // 
            this.btnCalculateChange.Location = new System.Drawing.Point(356, 118);
            this.btnCalculateChange.Name = "btnCalculateChange";
            this.btnCalculateChange.Size = new System.Drawing.Size(90, 77);
            this.btnCalculateChange.TabIndex = 4;
            this.btnCalculateChange.Text = "Calculate Change";
            this.btnCalculateChange.UseVisualStyleBackColor = true;
            this.btnCalculateChange.Click += new System.EventHandler(this.btnCalculateChange_Click);
            // 
            // dgChange
            // 
            this.dgChange.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgChange.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chgWording,
            this.chgDue,
            this.chgHundreds,
            this.chgFiftys,
            this.chgTwentys,
            this.chgTens,
            this.chgFives,
            this.chgOnes,
            this.chgQuarters,
            this.chgDimes,
            this.chgNickels,
            this.chgPennies,
            this.chgDiv3});
            this.dgChange.Location = new System.Drawing.Point(1027, 118);
            this.dgChange.Name = "dgChange";
            this.dgChange.RowTemplate.Height = 24;
            this.dgChange.Size = new System.Drawing.Size(231, 551);
            this.dgChange.TabIndex = 5;
            // 
            // chgWording
            // 
            this.chgWording.DataPropertyName = "chgWording";
            this.chgWording.HeaderText = "Change";
            this.chgWording.Name = "chgWording";
            this.chgWording.Width = 500;
            // 
            // chgDue
            // 
            this.chgDue.DataPropertyName = "chgDue";
            this.chgDue.HeaderText = "Amt Due";
            this.chgDue.Name = "chgDue";
            // 
            // chgHundreds
            // 
            this.chgHundreds.DataPropertyName = "chgHundreds";
            this.chgHundreds.HeaderText = "100";
            this.chgHundreds.Name = "chgHundreds";
            this.chgHundreds.Width = 50;
            // 
            // chgFiftys
            // 
            this.chgFiftys.DataPropertyName = "chgFiftys";
            this.chgFiftys.HeaderText = "50";
            this.chgFiftys.Name = "chgFiftys";
            this.chgFiftys.Width = 50;
            // 
            // chgTwentys
            // 
            this.chgTwentys.DataPropertyName = "chgTwentys";
            this.chgTwentys.HeaderText = "20";
            this.chgTwentys.Name = "chgTwentys";
            this.chgTwentys.Width = 50;
            // 
            // chgTens
            // 
            this.chgTens.DataPropertyName = "chgTens";
            this.chgTens.HeaderText = "10";
            this.chgTens.Name = "chgTens";
            this.chgTens.Width = 50;
            // 
            // chgFives
            // 
            this.chgFives.DataPropertyName = "chgFives";
            this.chgFives.HeaderText = "5";
            this.chgFives.Name = "chgFives";
            this.chgFives.Width = 50;
            // 
            // chgOnes
            // 
            this.chgOnes.DataPropertyName = "chgOnes";
            this.chgOnes.HeaderText = "1";
            this.chgOnes.Name = "chgOnes";
            this.chgOnes.Width = 50;
            // 
            // chgQuarters
            // 
            this.chgQuarters.DataPropertyName = "chgQuarters";
            this.chgQuarters.HeaderText = ".25";
            this.chgQuarters.Name = "chgQuarters";
            this.chgQuarters.Width = 50;
            // 
            // chgDimes
            // 
            this.chgDimes.DataPropertyName = "chgDimes";
            this.chgDimes.HeaderText = ".10";
            this.chgDimes.Name = "chgDimes";
            this.chgDimes.Width = 50;
            // 
            // chgNickels
            // 
            this.chgNickels.DataPropertyName = "chgNickels";
            this.chgNickels.HeaderText = ".05";
            this.chgNickels.Name = "chgNickels";
            this.chgNickels.Width = 50;
            // 
            // chgPennies
            // 
            this.chgPennies.DataPropertyName = "chgPennies";
            this.chgPennies.HeaderText = ".01";
            this.chgPennies.Name = "chgPennies";
            this.chgPennies.Width = 50;
            // 
            // chgDiv3
            // 
            this.chgDiv3.DataPropertyName = "chgDiv3";
            this.chgDiv3.HeaderText = "Div 3";
            this.chgDiv3.Name = "chgDiv3";
            this.chgDiv3.Width = 75;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(482, 21);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(42, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dgModel
            // 
            this.dgModel.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgModel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outChange});
            this.dgModel.Location = new System.Drawing.Point(452, 118);
            this.dgModel.Name = "dgModel";
            this.dgModel.RowTemplate.Height = 24;
            this.dgModel.Size = new System.Drawing.Size(569, 551);
            this.dgModel.TabIndex = 7;
            // 
            // outChange
            // 
            this.outChange.DataPropertyName = "outChange";
            this.outChange.HeaderText = "Change Due";
            this.outChange.Name = "outChange";
            this.outChange.Width = 400;
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Location = new System.Drawing.Point(449, 98);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(165, 17);
            this.lblHeader1.TabIndex = 8;
            this.lblHeader1.Text = "Output Based on a Class";
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Location = new System.Drawing.Point(1024, 98);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(197, 17);
            this.lblHeader2.TabIndex = 9;
            this.lblHeader2.Text = "Output Based on a DataTable";
            // 
            // btnWhatIsThis
            // 
            this.btnWhatIsThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhatIsThis.Location = new System.Drawing.Point(1197, 22);
            this.btnWhatIsThis.Name = "btnWhatIsThis";
            this.btnWhatIsThis.Size = new System.Drawing.Size(61, 47);
            this.btnWhatIsThis.TabIndex = 10;
            this.btnWhatIsThis.Text = "?";
            this.btnWhatIsThis.UseVisualStyleBackColor = true;
            this.btnWhatIsThis.Click += new System.EventHandler(this.btnWhatIsThis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 697);
            this.Controls.Add(this.btnWhatIsThis);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.dgModel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.dgChange);
            this.Controls.Add(this.btnCalculateChange);
            this.Controls.Add(this.dgFileData);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgFileData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.DataGridView dgFileData;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOwed;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaid;
        private System.Windows.Forms.Button btnCalculateChange;
        private System.Windows.Forms.DataGridView dgChange;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgWording;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgHundreds;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgFiftys;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgTwentys;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgTens;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgFives;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgOnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgQuarters;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgDimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgNickels;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgPennies;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chgDiv3;
        private System.Windows.Forms.DataGridView dgModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn outChange;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Button btnWhatIsThis;
    }
}

