namespace MusicSorter
{
    partial class fMusicSorter
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
            this.gbInputFiles = new System.Windows.Forms.GroupBox();
            this.bInputBrowse = new System.Windows.Forms.Button();
            this.tbInputFolder = new System.Windows.Forms.TextBox();
            this.lInputFolder = new System.Windows.Forms.Label();
            this.fbdInput = new System.Windows.Forms.FolderBrowserDialog();
            this.gbInputFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInputFiles
            // 
            this.gbInputFiles.Controls.Add(this.bInputBrowse);
            this.gbInputFiles.Controls.Add(this.tbInputFolder);
            this.gbInputFiles.Controls.Add(this.lInputFolder);
            this.gbInputFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInputFiles.Location = new System.Drawing.Point(0, 0);
            this.gbInputFiles.Name = "gbInputFiles";
            this.gbInputFiles.Size = new System.Drawing.Size(731, 49);
            this.gbInputFiles.TabIndex = 0;
            this.gbInputFiles.TabStop = false;
            this.gbInputFiles.Text = "Input Files";
            // 
            // bInputBrowse
            // 
            this.bInputBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInputBrowse.Location = new System.Drawing.Point(644, 13);
            this.bInputBrowse.Name = "bInputBrowse";
            this.bInputBrowse.Size = new System.Drawing.Size(75, 23);
            this.bInputBrowse.TabIndex = 2;
            this.bInputBrowse.Text = "Browse";
            this.bInputBrowse.UseVisualStyleBackColor = true;
            this.bInputBrowse.Click += new System.EventHandler(this.bInputBrowse_Click);
            // 
            // tbInputFolder
            // 
            this.tbInputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInputFolder.Location = new System.Drawing.Point(81, 15);
            this.tbInputFolder.Name = "tbInputFolder";
            this.tbInputFolder.Size = new System.Drawing.Size(557, 20);
            this.tbInputFolder.TabIndex = 1;
            // 
            // lInputFolder
            // 
            this.lInputFolder.AutoSize = true;
            this.lInputFolder.Location = new System.Drawing.Point(12, 18);
            this.lInputFolder.Name = "lInputFolder";
            this.lInputFolder.Size = new System.Drawing.Size(63, 13);
            this.lInputFolder.TabIndex = 0;
            this.lInputFolder.Text = "Input Folder";
            // 
            // fbdInput
            // 
            this.fbdInput.Description = "Select Folder to Pick Files From";
            this.fbdInput.ShowNewFolderButton = false;
            // 
            // fMusicSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 273);
            this.Controls.Add(this.gbInputFiles);
            this.Name = "fMusicSorter";
            this.Text = "Music Sorter";
            this.gbInputFiles.ResumeLayout(false);
            this.gbInputFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInputFiles;
        private System.Windows.Forms.Button bInputBrowse;
        private System.Windows.Forms.TextBox tbInputFolder;
        private System.Windows.Forms.Label lInputFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdInput;
    }
}

