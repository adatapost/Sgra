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
            this.SuspendLayout();
            // 
            // kvOpenFile
            // 
            this.kvOpenFile.FileName = "openFileDialog1";
            // 
            // kvBtnImport
            // 
            this.kvBtnImport.Location = new System.Drawing.Point(12, 12);
            this.kvBtnImport.Name = "kvBtnImport";
            this.kvBtnImport.Size = new System.Drawing.Size(99, 39);
            this.kvBtnImport.TabIndex = 0;
            this.kvBtnImport.Text = "Import";
            this.kvBtnImport.UseVisualStyleBackColor = true;
            // 
            // SgraMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 358);
            this.Controls.Add(this.kvBtnImport);
            this.Name = "SgraMain";
            this.Text = "Sapp";
            this.Load += new System.EventHandler(this.SgraMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog kvOpenFile;
        private System.Windows.Forms.Button kvBtnImport;
    }
}

