using System;

namespace Webmilio.Utilities.AutoMP3Tagger
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.nbrCreatedMinsAgo = new System.Windows.Forms.NumericUpDown();
            this.lblCreatedMinsAgo = new System.Windows.Forms.Label();
            this.listFilesFound = new System.Windows.Forms.ListBox();
            this.lblFilesFound = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSearchFiles = new System.Windows.Forms.Button();
            this.btnParseFiles = new System.Windows.Forms.Button();
            this.btnApplyTags = new System.Windows.Forms.Button();
            this.cmbFileParser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbrCreatedMinsAgo)).BeginInit();
            this.SuspendLayout();
            // 
            // nbrCreatedMinsAgo
            // 
            this.nbrCreatedMinsAgo.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nbrCreatedMinsAgo.Location = new System.Drawing.Point(12, 139);
            this.nbrCreatedMinsAgo.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nbrCreatedMinsAgo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrCreatedMinsAgo.Name = "nbrCreatedMinsAgo";
            this.nbrCreatedMinsAgo.Size = new System.Drawing.Size(107, 20);
            this.nbrCreatedMinsAgo.TabIndex = 0;
            this.nbrCreatedMinsAgo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbrCreatedMinsAgo.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblCreatedMinsAgo
            // 
            this.lblCreatedMinsAgo.AutoSize = true;
            this.lblCreatedMinsAgo.Location = new System.Drawing.Point(12, 123);
            this.lblCreatedMinsAgo.Name = "lblCreatedMinsAgo";
            this.lblCreatedMinsAgo.Size = new System.Drawing.Size(92, 13);
            this.lblCreatedMinsAgo.TabIndex = 1;
            this.lblCreatedMinsAgo.Text = "Created mins. ago";
            // 
            // listFilesFound
            // 
            this.listFilesFound.FormattingEnabled = true;
            this.listFilesFound.Location = new System.Drawing.Point(12, 199);
            this.listFilesFound.Name = "listFilesFound";
            this.listFilesFound.Size = new System.Drawing.Size(425, 238);
            this.listFilesFound.TabIndex = 2;
            this.listFilesFound.SelectedIndexChanged += new System.EventHandler(this.listFilesFound_SelectedIndexChanged);
            // 
            // lblFilesFound
            // 
            this.lblFilesFound.AutoSize = true;
            this.lblFilesFound.Location = new System.Drawing.Point(12, 183);
            this.lblFilesFound.Name = "lblFilesFound";
            this.lblFilesFound.Size = new System.Drawing.Size(61, 13);
            this.lblFilesFound.TabIndex = 3;
            this.lblFilesFound.Text = "Files Found";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 66);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(67, 13);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Music Folder";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 82);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(324, 20);
            this.txtFilePath.TabIndex = 5;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(342, 80);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(95, 23);
            this.btnBrowseFolder.TabIndex = 6;
            this.btnBrowseFolder.Text = "Browse Folder";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.SelectedPath = "C:\\Users\\Webmilio\\Music";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // btnSearchFiles
            // 
            this.btnSearchFiles.Location = new System.Drawing.Point(125, 136);
            this.btnSearchFiles.Name = "btnSearchFiles";
            this.btnSearchFiles.Size = new System.Drawing.Size(111, 23);
            this.btnSearchFiles.TabIndex = 7;
            this.btnSearchFiles.Text = "Search Files";
            this.btnSearchFiles.UseVisualStyleBackColor = true;
            this.btnSearchFiles.Click += new System.EventHandler(this.btnSearchFiles_Click);
            // 
            // btnParseFiles
            // 
            this.btnParseFiles.Location = new System.Drawing.Point(242, 136);
            this.btnParseFiles.Name = "btnParseFiles";
            this.btnParseFiles.Size = new System.Drawing.Size(94, 23);
            this.btnParseFiles.TabIndex = 8;
            this.btnParseFiles.Text = "Parse Files";
            this.btnParseFiles.UseVisualStyleBackColor = true;
            this.btnParseFiles.Click += new System.EventHandler(this.btnParseFiles_Click);
            // 
            // btnApplyTags
            // 
            this.btnApplyTags.Location = new System.Drawing.Point(342, 136);
            this.btnApplyTags.Name = "btnApplyTags";
            this.btnApplyTags.Size = new System.Drawing.Size(95, 23);
            this.btnApplyTags.TabIndex = 9;
            this.btnApplyTags.Text = "Apply Tags";
            this.btnApplyTags.UseVisualStyleBackColor = true;
            this.btnApplyTags.Click += new System.EventHandler(this.btnApplyTags_Click);
            // 
            // cmbFileParser
            // 
            this.cmbFileParser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileParser.FormattingEnabled = true;
            this.cmbFileParser.Location = new System.Drawing.Point(12, 29);
            this.cmbFileParser.Name = "cmbFileParser";
            this.cmbFileParser.Size = new System.Drawing.Size(425, 21);
            this.cmbFileParser.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "File Parser";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFileParser);
            this.Controls.Add(this.btnApplyTags);
            this.Controls.Add(this.btnParseFiles);
            this.Controls.Add(this.btnSearchFiles);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblFilesFound);
            this.Controls.Add(this.listFilesFound);
            this.Controls.Add(this.lblCreatedMinsAgo);
            this.Controls.Add(this.nbrCreatedMinsAgo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Auto MP3 Tagger";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrCreatedMinsAgo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nbrCreatedMinsAgo;
        private System.Windows.Forms.Label lblCreatedMinsAgo;
        private System.Windows.Forms.ListBox listFilesFound;
        private System.Windows.Forms.Label lblFilesFound;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSearchFiles;
        private System.Windows.Forms.Button btnParseFiles;
        private System.Windows.Forms.Button btnApplyTags;
        private System.Windows.Forms.ComboBox cmbFileParser;
        private System.Windows.Forms.Label label1;
    }
}

