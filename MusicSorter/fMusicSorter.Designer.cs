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
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbTrackNo = new System.Windows.Forms.TextBox();
            this.lTrackNo = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lFileName = new System.Windows.Forms.Label();
            this.lLocation = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.lArtist = new System.Windows.Forms.Label();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.lAlbum = new System.Windows.Forms.Label();
            this.bProcess = new System.Windows.Forms.Button();
            this.gbInputFiles.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInputFiles
            // 
            this.gbInputFiles.Controls.Add(this.bInputBrowse);
            this.gbInputFiles.Controls.Add(this.tbInputFolder);
            this.gbInputFiles.Controls.Add(this.lInputFolder);
            this.gbInputFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInputFiles.Location = new System.Drawing.Point(3, 3);
            this.gbInputFiles.Name = "gbInputFiles";
            this.gbInputFiles.Size = new System.Drawing.Size(705, 48);
            this.gbInputFiles.TabIndex = 0;
            this.gbInputFiles.TabStop = false;
            this.gbInputFiles.Text = "Input Files";
            // 
            // bInputBrowse
            // 
            this.bInputBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInputBrowse.Location = new System.Drawing.Point(618, 13);
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
            this.tbInputFolder.Size = new System.Drawing.Size(531, 20);
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
            // lbFiles
            // 
            this.lbFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(3, 51);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(348, 529);
            this.lbFiles.TabIndex = 1;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetails.Controls.Add(this.tbAlbum);
            this.gbDetails.Controls.Add(this.lAlbum);
            this.gbDetails.Controls.Add(this.tbArtist);
            this.gbDetails.Controls.Add(this.lArtist);
            this.gbDetails.Controls.Add(this.tbTitle);
            this.gbDetails.Controls.Add(this.lTitle);
            this.gbDetails.Controls.Add(this.tbTrackNo);
            this.gbDetails.Controls.Add(this.lTrackNo);
            this.gbDetails.Controls.Add(this.tbFileName);
            this.gbDetails.Controls.Add(this.tbLocation);
            this.gbDetails.Controls.Add(this.lFileName);
            this.gbDetails.Controls.Add(this.lLocation);
            this.gbDetails.Location = new System.Drawing.Point(354, 54);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(357, 201);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "File Details";
            // 
            // tbTrackNo
            // 
            this.tbTrackNo.Location = new System.Drawing.Point(83, 97);
            this.tbTrackNo.Name = "tbTrackNo";
            this.tbTrackNo.Size = new System.Drawing.Size(38, 20);
            this.tbTrackNo.TabIndex = 5;
            // 
            // lTrackNo
            // 
            this.lTrackNo.AutoSize = true;
            this.lTrackNo.Location = new System.Drawing.Point(25, 100);
            this.lTrackNo.Name = "lTrackNo";
            this.lTrackNo.Size = new System.Drawing.Size(52, 13);
            this.lTrackNo.TabIndex = 4;
            this.lTrackNo.Text = "Track No";
            this.lTrackNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbFileName
            // 
            this.tbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileName.Location = new System.Drawing.Point(83, 45);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(268, 20);
            this.tbFileName.TabIndex = 3;
            // 
            // tbLocation
            // 
            this.tbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocation.Location = new System.Drawing.Point(83, 19);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(268, 20);
            this.tbLocation.TabIndex = 2;
            // 
            // lFileName
            // 
            this.lFileName.AutoSize = true;
            this.lFileName.Location = new System.Drawing.Point(23, 48);
            this.lFileName.Name = "lFileName";
            this.lFileName.Size = new System.Drawing.Size(54, 13);
            this.lFileName.TabIndex = 1;
            this.lFileName.Text = "File Name";
            // 
            // lLocation
            // 
            this.lLocation.AutoSize = true;
            this.lLocation.Location = new System.Drawing.Point(29, 22);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(48, 13);
            this.lLocation.TabIndex = 0;
            this.lLocation.Text = "Location";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(83, 123);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(268, 20);
            this.tbTitle.TabIndex = 7;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(50, 126);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(27, 13);
            this.lTitle.TabIndex = 6;
            this.lTitle.Text = "Title";
            // 
            // tbArtist
            // 
            this.tbArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArtist.Location = new System.Drawing.Point(83, 149);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(268, 20);
            this.tbArtist.TabIndex = 9;
            // 
            // lArtist
            // 
            this.lArtist.AutoSize = true;
            this.lArtist.Location = new System.Drawing.Point(50, 152);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(30, 13);
            this.lArtist.TabIndex = 8;
            this.lArtist.Text = "Artist";
            // 
            // tbAlbum
            // 
            this.tbAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlbum.Location = new System.Drawing.Point(83, 175);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(268, 20);
            this.tbAlbum.TabIndex = 11;
            // 
            // lAlbum
            // 
            this.lAlbum.AutoSize = true;
            this.lAlbum.Location = new System.Drawing.Point(44, 178);
            this.lAlbum.Name = "lAlbum";
            this.lAlbum.Size = new System.Drawing.Size(36, 13);
            this.lAlbum.TabIndex = 10;
            this.lAlbum.Text = "Album";
            // 
            // bProcess
            // 
            this.bProcess.Location = new System.Drawing.Point(630, 554);
            this.bProcess.Name = "bProcess";
            this.bProcess.Size = new System.Drawing.Size(75, 23);
            this.bProcess.TabIndex = 3;
            this.bProcess.Text = "Process";
            this.bProcess.UseVisualStyleBackColor = true;
            this.bProcess.Click += new System.EventHandler(this.bProcess_Click);
            // 
            // fMusicSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 583);
            this.Controls.Add(this.bProcess);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.gbInputFiles);
            this.Name = "fMusicSorter";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Music Sorter";
            this.gbInputFiles.ResumeLayout(false);
            this.gbInputFiles.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInputFiles;
        private System.Windows.Forms.Button bInputBrowse;
        private System.Windows.Forms.TextBox tbInputFolder;
        private System.Windows.Forms.Label lInputFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdInput;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lFileName;
        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.TextBox tbTrackNo;
        private System.Windows.Forms.Label lTrackNo;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.Label lAlbum;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.Label lArtist;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button bProcess;
    }
}

