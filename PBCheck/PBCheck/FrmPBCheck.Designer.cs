
namespace PBCheck
{
    partial class FrmPBCheck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPBCheck));
            this.tvHints = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbNote = new System.Windows.Forms.Label();
            this.btAddSoftware = new System.Windows.Forms.Button();
            this.tbSoftwareToAdd = new System.Windows.Forms.TextBox();
            this.lbInstalledSoftware = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPBCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttNote = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btRemoveCheck = new System.Windows.Forms.Button();
            this.btAddExeCheck = new System.Windows.Forms.Button();
            this.btAddDirectoryCheck = new System.Windows.Forms.Button();
            this.btAddSoftwareCheck = new System.Windows.Forms.Button();
            this.tvConfig = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvHints
            // 
            this.tvHints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvHints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvHints.Location = new System.Drawing.Point(8, 7);
            this.tvHints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvHints.Name = "tvHints";
            this.tvHints.Size = new System.Drawing.Size(1004, 421);
            this.tvHints.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(20, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 464);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvHints);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1023, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Failed Checks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbNote);
            this.tabPage2.Controls.Add(this.btAddSoftware);
            this.tabPage2.Controls.Add(this.tbSoftwareToAdd);
            this.tabPage2.Controls.Add(this.lbInstalledSoftware);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1023, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Installed Software";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbNote
            // 
            this.lbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNote.AutoEllipsis = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(9, 409);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(1008, 16);
            this.lbNote.TabIndex = 3;
            this.lbNote.Text = "NOTE: you may want to add only the prefix of the software, leaving out any versio" +
    "n number (e.g. \"Python\" rather than \"Python 3.9\")";
            this.ttNote.SetToolTip(this.lbNote, "NOTE: you may want to add only the prefix of the software, leaving out any versio" +
        "n number (e.g. \"Python\" rather than \"Python 3.9\")");
            // 
            // btAddSoftware
            // 
            this.btAddSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddSoftware.Location = new System.Drawing.Point(911, 378);
            this.btAddSoftware.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddSoftware.Name = "btAddSoftware";
            this.btAddSoftware.Size = new System.Drawing.Size(101, 28);
            this.btAddSoftware.TabIndex = 2;
            this.btAddSoftware.Text = "Add";
            this.btAddSoftware.UseVisualStyleBackColor = true;
            this.btAddSoftware.Click += new System.EventHandler(this.btAddSoftware_Click);
            // 
            // tbSoftwareToAdd
            // 
            this.tbSoftwareToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSoftwareToAdd.Location = new System.Drawing.Point(9, 380);
            this.tbSoftwareToAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSoftwareToAdd.Name = "tbSoftwareToAdd";
            this.tbSoftwareToAdd.Size = new System.Drawing.Size(896, 22);
            this.tbSoftwareToAdd.TabIndex = 1;
            // 
            // lbInstalledSoftware
            // 
            this.lbInstalledSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInstalledSoftware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbInstalledSoftware.FormattingEnabled = true;
            this.lbInstalledSoftware.ItemHeight = 16;
            this.lbInstalledSoftware.Location = new System.Drawing.Point(9, 9);
            this.lbInstalledSoftware.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbInstalledSoftware.Name = "lbInstalledSoftware";
            this.lbInstalledSoftware.Size = new System.Drawing.Size(1003, 352);
            this.lbInstalledSoftware.TabIndex = 0;
            this.lbInstalledSoftware.SelectedIndexChanged += new System.EventHandler(this.lbInstalledSoftware_SelectedIndexChanged);
            this.lbInstalledSoftware.DoubleClick += new System.EventHandler(this.lbInstalledSoftware_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigurationFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openConfigurationFileToolStripMenuItem
            // 
            this.openConfigurationFileToolStripMenuItem.Name = "openConfigurationFileToolStripMenuItem";
            this.openConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.openConfigurationFileToolStripMenuItem.Text = "Open configuration file...";
            this.openConfigurationFileToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPBCheckToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutPBCheckToolStripMenuItem
            // 
            this.aboutPBCheckToolStripMenuItem.Name = "aboutPBCheckToolStripMenuItem";
            this.aboutPBCheckToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.aboutPBCheckToolStripMenuItem.Text = "About PBCheck";
            this.aboutPBCheckToolStripMenuItem.Click += new System.EventHandler(this.aboutPBCheckToolStripMenuItem_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 512);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssStatus.Size = new System.Drawing.Size(1067, 26);
            this.ssStatus.TabIndex = 5;
            this.ssStatus.Text = "Status";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(66, 20);
            this.tssStatus.Text = "tssStatus";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tvConfig);
            this.tabPage3.Controls.Add(this.btRemoveCheck);
            this.tabPage3.Controls.Add(this.btAddExeCheck);
            this.tabPage3.Controls.Add(this.btAddDirectoryCheck);
            this.tabPage3.Controls.Add(this.btAddSoftwareCheck);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1023, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configuration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btRemoveCheck
            // 
            this.btRemoveCheck.Location = new System.Drawing.Point(15, 107);
            this.btRemoveCheck.Name = "btRemoveCheck";
            this.btRemoveCheck.Size = new System.Drawing.Size(198, 23);
            this.btRemoveCheck.TabIndex = 8;
            this.btRemoveCheck.Text = "Remove Check...";
            this.btRemoveCheck.UseVisualStyleBackColor = true;
            this.btRemoveCheck.Click += new System.EventHandler(this.btRemoveCheck_Click);
            // 
            // btAddExeCheck
            // 
            this.btAddExeCheck.Location = new System.Drawing.Point(15, 77);
            this.btAddExeCheck.Name = "btAddExeCheck";
            this.btAddExeCheck.Size = new System.Drawing.Size(198, 23);
            this.btAddExeCheck.TabIndex = 7;
            this.btAddExeCheck.Text = "Add \"Exe in Path\" Check...";
            this.btAddExeCheck.UseVisualStyleBackColor = true;
            this.btAddExeCheck.Click += new System.EventHandler(this.btAddExeCheck_Click);
            // 
            // btAddDirectoryCheck
            // 
            this.btAddDirectoryCheck.Location = new System.Drawing.Point(15, 47);
            this.btAddDirectoryCheck.Name = "btAddDirectoryCheck";
            this.btAddDirectoryCheck.Size = new System.Drawing.Size(198, 23);
            this.btAddDirectoryCheck.TabIndex = 6;
            this.btAddDirectoryCheck.Text = "Add Directory Check...";
            this.btAddDirectoryCheck.UseVisualStyleBackColor = true;
            this.btAddDirectoryCheck.Click += new System.EventHandler(this.btAddDirectoryCheck_Click);
            // 
            // btAddSoftwareCheck
            // 
            this.btAddSoftwareCheck.Location = new System.Drawing.Point(15, 17);
            this.btAddSoftwareCheck.Name = "btAddSoftwareCheck";
            this.btAddSoftwareCheck.Size = new System.Drawing.Size(198, 23);
            this.btAddSoftwareCheck.TabIndex = 5;
            this.btAddSoftwareCheck.Text = "Add Software Check...";
            this.btAddSoftwareCheck.UseVisualStyleBackColor = true;
            this.btAddSoftwareCheck.Click += new System.EventHandler(this.btAddSoftwareCheck_Click);
            // 
            // tvConfig
            // 
            this.tvConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvConfig.Location = new System.Drawing.Point(220, 7);
            this.tvConfig.Margin = new System.Windows.Forms.Padding(4);
            this.tvConfig.Name = "tvConfig";
            this.tvConfig.Size = new System.Drawing.Size(793, 421);
            this.tvConfig.TabIndex = 9;
            // 
            // FrmPBCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 538);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPBCheck";
            this.Text = "PBCheck";
            this.Load += new System.EventHandler(this.FrmPBCheck_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvHints;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbInstalledSoftware;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigurationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPBCheckToolStripMenuItem;
        private System.Windows.Forms.Button btAddSoftware;
        private System.Windows.Forms.TextBox tbSoftwareToAdd;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.ToolTip ttNote;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView tvConfig;
        private System.Windows.Forms.Button btRemoveCheck;
        private System.Windows.Forms.Button btAddExeCheck;
        private System.Windows.Forms.Button btAddDirectoryCheck;
        private System.Windows.Forms.Button btAddSoftwareCheck;
    }
}

