namespace Sgra
{
    partial class SgraMain
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
            this.kvOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.kvBtnImport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kbBtnShow = new System.Windows.Forms.Button();
            this.kvStartDate = new System.Windows.Forms.DateTimePicker();
            this.kvEndDate = new System.Windows.Forms.DateTimePicker();
            this.kvBtnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kvBtnCheckAll = new System.Windows.Forms.Button();
            this.kvBtnPassed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kvOpenFile
            // 
            this.kvOpenFile.FileName = "openFileDialog1";
            // 
            // kvBtnImport
            // 
            this.kvBtnImport.Location = new System.Drawing.Point(753, 10);
            this.kvBtnImport.Name = "kvBtnImport";
            this.kvBtnImport.Size = new System.Drawing.Size(136, 70);
            this.kvBtnImport.TabIndex = 0;
            this.kvBtnImport.Text = "Import";
            this.kvBtnImport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(991, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // kbBtnShow
            // 
            this.kbBtnShow.Location = new System.Drawing.Point(205, 10);
            this.kbBtnShow.Name = "kbBtnShow";
            this.kbBtnShow.Size = new System.Drawing.Size(136, 70);
            this.kbBtnShow.TabIndex = 0;
            this.kbBtnShow.Text = "New";
            this.kbBtnShow.UseVisualStyleBackColor = true;
            // 
            // kvStartDate
            // 
            this.kvStartDate.CustomFormat = "dd-MM-yyyy";
            this.kvStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kvStartDate.Location = new System.Drawing.Point(15, 10);
            this.kvStartDate.Name = "kvStartDate";
            this.kvStartDate.Size = new System.Drawing.Size(172, 26);
            this.kvStartDate.TabIndex = 2;
            // 
            // kvEndDate
            // 
            this.kvEndDate.CustomFormat = "dd-MM-yyyy";
            this.kvEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kvEndDate.Location = new System.Drawing.Point(15, 54);
            this.kvEndDate.Name = "kvEndDate";
            this.kvEndDate.Size = new System.Drawing.Size(172, 26);
            this.kvEndDate.TabIndex = 2;
            // 
            // kvBtnDelete
            // 
            this.kvBtnDelete.Location = new System.Drawing.Point(163, 18);
            this.kvBtnDelete.Name = "kvBtnDelete";
            this.kvBtnDelete.Size = new System.Drawing.Size(136, 70);
            this.kvBtnDelete.TabIndex = 0;
            this.kvBtnDelete.Text = "Delete";
            this.kvBtnDelete.UseVisualStyleBackColor = true;
            this.kvBtnDelete.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kvBtnCheckAll);
            this.panel1.Controls.Add(this.kvBtnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 100);
            this.panel1.TabIndex = 3;
            // 
            // kvBtnCheckAll
            // 
            this.kvBtnCheckAll.Location = new System.Drawing.Point(15, 18);
            this.kvBtnCheckAll.Name = "kvBtnCheckAll";
            this.kvBtnCheckAll.Size = new System.Drawing.Size(136, 70);
            this.kvBtnCheckAll.TabIndex = 0;
            this.kvBtnCheckAll.Text = "Select All";
            this.kvBtnCheckAll.UseVisualStyleBackColor = true;
            // 
            // kvBtnPassed
            // 
            this.kvBtnPassed.Location = new System.Drawing.Point(347, 10);
            this.kvBtnPassed.Name = "kvBtnPassed";
            this.kvBtnPassed.Size = new System.Drawing.Size(136, 70);
            this.kvBtnPassed.TabIndex = 0;
            this.kvBtnPassed.Text = "Passed";
            this.kvBtnPassed.UseVisualStyleBackColor = true;
            // 
            // SgraMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kvEndDate);
            this.Controls.Add(this.kvStartDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kvBtnPassed);
            this.Controls.Add(this.kbBtnShow);
            this.Controls.Add(this.kvBtnImport);
            this.Name = "SgraMain";
            this.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.Text = "Sapp";
            this.Load += new System.EventHandler(this.SgraMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog kvOpenFile;
        private System.Windows.Forms.Button kvBtnImport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kbBtnShow;
        private System.Windows.Forms.DateTimePicker kvStartDate;
        private System.Windows.Forms.DateTimePicker kvEndDate;
        private System.Windows.Forms.Button kvBtnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kvBtnCheckAll;
        private System.Windows.Forms.Button kvBtnPassed;
    }
}

