namespace DuplicateFinder
{
    partial class MainForm
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
            this.duplicateListBox = new System.Windows.Forms.ListBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.duplicatePictureBox = new System.Windows.Forms.PictureBox();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.listSplitContainer = new System.Windows.Forms.SplitContainer();
            this.logSplitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastModifiedLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duplicatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSplitContainer)).BeginInit();
            this.listSplitContainer.Panel1.SuspendLayout();
            this.listSplitContainer.Panel2.SuspendLayout();
            this.listSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logSplitContainer)).BeginInit();
            this.logSplitContainer.Panel1.SuspendLayout();
            this.logSplitContainer.Panel2.SuspendLayout();
            this.logSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSplitContainer)).BeginInit();
            this.pictureSplitContainer.Panel1.SuspendLayout();
            this.pictureSplitContainer.Panel2.SuspendLayout();
            this.pictureSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // duplicateListBox
            // 
            this.duplicateListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duplicateListBox.FormattingEnabled = true;
            this.duplicateListBox.Location = new System.Drawing.Point(0, 0);
            this.duplicateListBox.Name = "duplicateListBox";
            this.duplicateListBox.Size = new System.Drawing.Size(200, 600);
            this.duplicateListBox.TabIndex = 0;
            this.duplicateListBox.SelectedIndexChanged += new System.EventHandler(this.DuplicateListBox_SelectedIndexChanged);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1264, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewSearchToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startNewSearchToolStripMenuItem
            // 
            this.startNewSearchToolStripMenuItem.Name = "startNewSearchToolStripMenuItem";
            this.startNewSearchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.startNewSearchToolStripMenuItem.Text = "Start New Search";
            this.startNewSearchToolStripMenuItem.Click += new System.EventHandler(this.StartNewSearchToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // duplicatePictureBox
            // 
            this.duplicatePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.duplicatePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.duplicatePictureBox.Location = new System.Drawing.Point(0, 60);
            this.duplicatePictureBox.Margin = new System.Windows.Forms.Padding(12);
            this.duplicatePictureBox.Name = "duplicatePictureBox";
            this.duplicatePictureBox.Size = new System.Drawing.Size(660, 645);
            this.duplicatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.duplicatePictureBox.TabIndex = 2;
            this.duplicatePictureBox.TabStop = false;
            // 
            // fileListBox
            // 
            this.fileListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(0, 0);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(396, 600);
            this.fileListBox.TabIndex = 3;
            this.fileListBox.SelectedIndexChanged += new System.EventHandler(this.FileListBox_SelectedIndexChanged);
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(0, 0);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(600, 101);
            this.logTextBox.TabIndex = 4;
            this.logTextBox.Text = "Started Duplicate Finder.";
            // 
            // listSplitContainer
            // 
            this.listSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.listSplitContainer.Name = "listSplitContainer";
            // 
            // listSplitContainer.Panel1
            // 
            this.listSplitContainer.Panel1.Controls.Add(this.duplicateListBox);
            this.listSplitContainer.Panel1MinSize = 200;
            // 
            // listSplitContainer.Panel2
            // 
            this.listSplitContainer.Panel2.Controls.Add(this.fileListBox);
            this.listSplitContainer.Panel2MinSize = 200;
            this.listSplitContainer.Size = new System.Drawing.Size(600, 600);
            this.listSplitContainer.SplitterDistance = 200;
            this.listSplitContainer.TabIndex = 5;
            // 
            // logSplitContainer
            // 
            this.logSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.logSplitContainer.Name = "logSplitContainer";
            this.logSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // logSplitContainer.Panel1
            // 
            this.logSplitContainer.Panel1.Controls.Add(this.listSplitContainer);
            this.logSplitContainer.Panel1MinSize = 100;
            // 
            // logSplitContainer.Panel2
            // 
            this.logSplitContainer.Panel2.Controls.Add(this.logTextBox);
            this.logSplitContainer.Panel2MinSize = 100;
            this.logSplitContainer.Size = new System.Drawing.Size(600, 705);
            this.logSplitContainer.SplitterDistance = 600;
            this.logSplitContainer.TabIndex = 6;
            // 
            // pictureSplitContainer
            // 
            this.pictureSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.pictureSplitContainer.Name = "pictureSplitContainer";
            // 
            // pictureSplitContainer.Panel1
            // 
            this.pictureSplitContainer.Panel1.Controls.Add(this.logSplitContainer);
            this.pictureSplitContainer.Panel1MinSize = 400;
            // 
            // pictureSplitContainer.Panel2
            // 
            this.pictureSplitContainer.Panel2.Controls.Add(this.deleteButton);
            this.pictureSplitContainer.Panel2.Controls.Add(this.fileNameLabel);
            this.pictureSplitContainer.Panel2.Controls.Add(this.sizeLabel);
            this.pictureSplitContainer.Panel2.Controls.Add(this.createdLabel);
            this.pictureSplitContainer.Panel2.Controls.Add(this.lastModifiedLabel);
            this.pictureSplitContainer.Panel2.Controls.Add(this.label4);
            this.pictureSplitContainer.Panel2.Controls.Add(this.label3);
            this.pictureSplitContainer.Panel2.Controls.Add(this.label2);
            this.pictureSplitContainer.Panel2.Controls.Add(this.label1);
            this.pictureSplitContainer.Panel2.Controls.Add(this.duplicatePictureBox);
            this.pictureSplitContainer.Panel2MinSize = 280;
            this.pictureSplitContainer.Size = new System.Drawing.Size(1264, 705);
            this.pictureSplitContainer.SplitterDistance = 600;
            this.pictureSplitContainer.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Modified:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Created:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filename:";
            // 
            // lastModifiedLabel
            // 
            this.lastModifiedLabel.AutoSize = true;
            this.lastModifiedLabel.Location = new System.Drawing.Point(76, 42);
            this.lastModifiedLabel.Name = "lastModifiedLabel";
            this.lastModifiedLabel.Size = new System.Drawing.Size(0, 13);
            this.lastModifiedLabel.TabIndex = 7;
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(76, 29);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(0, 13);
            this.createdLabel.TabIndex = 8;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(76, 16);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(0, 13);
            this.sizeLabel.TabIndex = 9;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(76, 3);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fileNameLabel.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(573, 31);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.pictureSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "MainForm";
            this.Text = "Duplicate Finder";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duplicatePictureBox)).EndInit();
            this.listSplitContainer.Panel1.ResumeLayout(false);
            this.listSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSplitContainer)).EndInit();
            this.listSplitContainer.ResumeLayout(false);
            this.logSplitContainer.Panel1.ResumeLayout(false);
            this.logSplitContainer.Panel2.ResumeLayout(false);
            this.logSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logSplitContainer)).EndInit();
            this.logSplitContainer.ResumeLayout(false);
            this.pictureSplitContainer.Panel1.ResumeLayout(false);
            this.pictureSplitContainer.Panel2.ResumeLayout(false);
            this.pictureSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSplitContainer)).EndInit();
            this.pictureSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox duplicateListBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.PictureBox duplicatePictureBox;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.SplitContainer listSplitContainer;
        private System.Windows.Forms.SplitContainer logSplitContainer;
        private System.Windows.Forms.SplitContainer pictureSplitContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label lastModifiedLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}

