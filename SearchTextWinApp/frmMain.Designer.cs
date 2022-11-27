namespace SearchTextWinApp
{
    partial class frmMain
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
            this.lblSearchValue = new System.Windows.Forms.Label();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxSearchPattern = new System.Windows.Forms.GroupBox();
            this.rbtEqual = new System.Windows.Forms.RadioButton();
            this.rbtContain = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.grpBoxSearchPattern.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchValue
            // 
            this.lblSearchValue.AutoSize = true;
            this.lblSearchValue.Location = new System.Drawing.Point(44, 54);
            this.lblSearchValue.Name = "lblSearchValue";
            this.lblSearchValue.Size = new System.Drawing.Size(88, 16);
            this.lblSearchValue.TabIndex = 0;
            this.lblSearchValue.Text = "Search Value";
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(227, 51);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(493, 22);
            this.txtSearchValue.TabIndex = 2;
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colLineNo,
            this.colData,
            this.colFileName});
            this.dtGrid.Location = new System.Drawing.Point(47, 298);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersWidth = 51;
            this.dtGrid.RowTemplate.Height = 24;
            this.dtGrid.Size = new System.Drawing.Size(673, 241);
            this.dtGrid.TabIndex = 9;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.MinimumWidth = 6;
            this.colNo.Name = "colNo";
            this.colNo.Width = 125;
            // 
            // colLineNo
            // 
            this.colLineNo.HeaderText = "Line No";
            this.colLineNo.MinimumWidth = 6;
            this.colLineNo.Name = "colLineNo";
            this.colLineNo.Width = 125;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.MinimumWidth = 6;
            this.colData.Name = "colData";
            this.colData.Width = 125;
            // 
            // colFileName
            // 
            this.colFileName.HeaderText = "File Path";
            this.colFileName.MinimumWidth = 6;
            this.colFileName.Name = "colFileName";
            this.colFileName.Width = 125;
            // 
            // grpBoxSearchPattern
            // 
            this.grpBoxSearchPattern.Controls.Add(this.rbtEqual);
            this.grpBoxSearchPattern.Controls.Add(this.rbtContain);
            this.grpBoxSearchPattern.Location = new System.Drawing.Point(47, 107);
            this.grpBoxSearchPattern.Name = "grpBoxSearchPattern";
            this.grpBoxSearchPattern.Size = new System.Drawing.Size(673, 83);
            this.grpBoxSearchPattern.TabIndex = 11;
            this.grpBoxSearchPattern.TabStop = false;
            this.grpBoxSearchPattern.Text = "Search Options";
            // 
            // rbtEqual
            // 
            this.rbtEqual.AutoSize = true;
            this.rbtEqual.Location = new System.Drawing.Point(265, 40);
            this.rbtEqual.Name = "rbtEqual";
            this.rbtEqual.Size = new System.Drawing.Size(63, 20);
            this.rbtEqual.TabIndex = 1;
            this.rbtEqual.TabStop = true;
            this.rbtEqual.Text = "Equal";
            this.rbtEqual.UseVisualStyleBackColor = true;
            // 
            // rbtContain
            // 
            this.rbtContain.AutoSize = true;
            this.rbtContain.Checked = true;
            this.rbtContain.Location = new System.Drawing.Point(21, 40);
            this.rbtContain.Name = "rbtContain";
            this.rbtContain.Size = new System.Drawing.Size(80, 20);
            this.rbtContain.TabIndex = 0;
            this.rbtContain.TabStop = true;
            this.rbtContain.Text = "Contains";
            this.rbtContain.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(530, 252);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(645, 252);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.SpringGreen;
            this.progressBar.Location = new System.Drawing.Point(47, 217);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(673, 23);
            this.progressBar.TabIndex = 15;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpBoxSearchPattern);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.lblSearchValue);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Search Text Application";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.grpBoxSearchPattern.ResumeLayout(false);
            this.grpBoxSearchPattern.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchValue;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.GroupBox grpBoxSearchPattern;
        private System.Windows.Forms.RadioButton rbtEqual;
        private System.Windows.Forms.RadioButton rbtContain;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

