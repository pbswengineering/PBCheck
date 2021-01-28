
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
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpChecks = new System.Windows.Forms.TabPage();
            this.tpSoftware = new System.Windows.Forms.TabPage();
            this.lbNote = new System.Windows.Forms.Label();
            this.btAddSoftware = new System.Windows.Forms.Button();
            this.tbSoftwareToAdd = new System.Windows.Forms.TextBox();
            this.lbInstalledSoftware = new System.Windows.Forms.ListBox();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.tvConfig = new System.Windows.Forms.TreeView();
            this.btRemoveCheck = new System.Windows.Forms.Button();
            this.btAddExeCheck = new System.Windows.Forms.Button();
            this.btAddDirectoryCheck = new System.Windows.Forms.Button();
            this.btAddSoftwareCheck = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPBCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttNote = new System.Windows.Forms.ToolTip(this.components);
            this.tcTabs.SuspendLayout();
            this.tpChecks.SuspendLayout();
            this.tpSoftware.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvHints
            // 
            this.tvHints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvHints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvHints.Location = new System.Drawing.Point(6, 6);
            this.tvHints.Name = "tvHints";
            this.tvHints.Size = new System.Drawing.Size(753, 342);
            this.tvHints.TabIndex = 0;
            // 
            // tcTabs
            // 
            this.tcTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTabs.Controls.Add(this.tpChecks);
            this.tcTabs.Controls.Add(this.tpSoftware);
            this.tcTabs.Controls.Add(this.tpConfiguration);
            this.tcTabs.Location = new System.Drawing.Point(15, 27);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(773, 377);
            this.tcTabs.TabIndex = 3;
            // 
            // tpChecks
            // 
            this.tpChecks.Controls.Add(this.tvHints);
            this.tpChecks.Location = new System.Drawing.Point(4, 22);
            this.tpChecks.Name = "tpChecks";
            this.tpChecks.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpChecks.Size = new System.Drawing.Size(765, 351);
            this.tpChecks.TabIndex = 0;
            this.tpChecks.Text = "Failed Checks";
            this.tpChecks.UseVisualStyleBackColor = true;
            // 
            // tpSoftware
            // 
            this.tpSoftware.Controls.Add(this.lbNote);
            this.tpSoftware.Controls.Add(this.btAddSoftware);
            this.tpSoftware.Controls.Add(this.tbSoftwareToAdd);
            this.tpSoftware.Controls.Add(this.lbInstalledSoftware);
            this.tpSoftware.Location = new System.Drawing.Point(4, 22);
            this.tpSoftware.Name = "tpSoftware";
            this.tpSoftware.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSoftware.Size = new System.Drawing.Size(765, 351);
            this.tpSoftware.TabIndex = 1;
            this.tpSoftware.Text = "Installed Software";
            this.tpSoftware.UseVisualStyleBackColor = true;
            // 
            // lbNote
            // 
            this.lbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNote.AutoEllipsis = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(7, 332);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(756, 13);
            this.lbNote.TabIndex = 3;
            this.lbNote.Text = "NOTE: you may want to add only the prefix of the software, leaving out any versio" +
    "n number (e.g. \"Python\" rather than \"Python 3.9\")";
            this.ttNote.SetToolTip(this.lbNote, "NOTE: you may want to add only the prefix of the software, leaving out any versio" +
        "n number (e.g. \"Python\" rather than \"Python 3.9\")");
            // 
            // btAddSoftware
            // 
            this.btAddSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddSoftware.Location = new System.Drawing.Point(683, 307);
            this.btAddSoftware.Name = "btAddSoftware";
            this.btAddSoftware.Size = new System.Drawing.Size(76, 23);
            this.btAddSoftware.TabIndex = 2;
            this.btAddSoftware.Text = "Add";
            this.btAddSoftware.UseVisualStyleBackColor = true;
            this.btAddSoftware.Click += new System.EventHandler(this.btAddSoftware_Click);
            // 
            // tbSoftwareToAdd
            // 
            this.tbSoftwareToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSoftwareToAdd.Location = new System.Drawing.Point(7, 309);
            this.tbSoftwareToAdd.Name = "tbSoftwareToAdd";
            this.tbSoftwareToAdd.Size = new System.Drawing.Size(673, 20);
            this.tbSoftwareToAdd.TabIndex = 1;
            // 
            // lbInstalledSoftware
            // 
            this.lbInstalledSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInstalledSoftware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbInstalledSoftware.FormattingEnabled = true;
            this.lbInstalledSoftware.Location = new System.Drawing.Point(7, 7);
            this.lbInstalledSoftware.Name = "lbInstalledSoftware";
            this.lbInstalledSoftware.Size = new System.Drawing.Size(752, 286);
            this.lbInstalledSoftware.TabIndex = 0;
            this.lbInstalledSoftware.SelectedIndexChanged += new System.EventHandler(this.lbInstalledSoftware_SelectedIndexChanged);
            this.lbInstalledSoftware.DoubleClick += new System.EventHandler(this.lbInstalledSoftware_DoubleClick);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Controls.Add(this.tvConfig);
            this.tpConfiguration.Controls.Add(this.btRemoveCheck);
            this.tpConfiguration.Controls.Add(this.btAddExeCheck);
            this.tpConfiguration.Controls.Add(this.btAddDirectoryCheck);
            this.tpConfiguration.Controls.Add(this.btAddSoftwareCheck);
            this.tpConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tpConfiguration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpConfiguration.Size = new System.Drawing.Size(765, 351);
            this.tpConfiguration.TabIndex = 2;
            this.tpConfiguration.Text = "Configuration";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // tvConfig
            // 
            this.tvConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvConfig.Location = new System.Drawing.Point(165, 6);
            this.tvConfig.Name = "tvConfig";
            this.tvConfig.Size = new System.Drawing.Size(595, 342);
            this.tvConfig.TabIndex = 9;
            // 
            // btRemoveCheck
            // 
            this.btRemoveCheck.Location = new System.Drawing.Point(11, 87);
            this.btRemoveCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRemoveCheck.Name = "btRemoveCheck";
            this.btRemoveCheck.Size = new System.Drawing.Size(148, 19);
            this.btRemoveCheck.TabIndex = 8;
            this.btRemoveCheck.Text = "Remove Check...";
            this.btRemoveCheck.UseVisualStyleBackColor = true;
            this.btRemoveCheck.Click += new System.EventHandler(this.btRemoveCheck_Click);
            // 
            // btAddExeCheck
            // 
            this.btAddExeCheck.Location = new System.Drawing.Point(11, 63);
            this.btAddExeCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAddExeCheck.Name = "btAddExeCheck";
            this.btAddExeCheck.Size = new System.Drawing.Size(148, 19);
            this.btAddExeCheck.TabIndex = 7;
            this.btAddExeCheck.Text = "Add \"Exe in Path\" Check...";
            this.btAddExeCheck.UseVisualStyleBackColor = true;
            this.btAddExeCheck.Click += new System.EventHandler(this.btAddExeCheck_Click);
            // 
            // btAddDirectoryCheck
            // 
            this.btAddDirectoryCheck.Location = new System.Drawing.Point(11, 38);
            this.btAddDirectoryCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAddDirectoryCheck.Name = "btAddDirectoryCheck";
            this.btAddDirectoryCheck.Size = new System.Drawing.Size(148, 19);
            this.btAddDirectoryCheck.TabIndex = 6;
            this.btAddDirectoryCheck.Text = "Add Directory Check...";
            this.btAddDirectoryCheck.UseVisualStyleBackColor = true;
            this.btAddDirectoryCheck.Click += new System.EventHandler(this.btAddDirectoryCheck_Click);
            // 
            // btAddSoftwareCheck
            // 
            this.btAddSoftwareCheck.Location = new System.Drawing.Point(11, 14);
            this.btAddSoftwareCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAddSoftwareCheck.Name = "btAddSoftwareCheck";
            this.btAddSoftwareCheck.Size = new System.Drawing.Size(148, 19);
            this.btAddSoftwareCheck.TabIndex = 5;
            this.btAddSoftwareCheck.Text = "Add Software Check...";
            this.btAddSoftwareCheck.UseVisualStyleBackColor = true;
            this.btAddSoftwareCheck.Click += new System.EventHandler(this.btAddSoftwareCheck_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigurationFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openConfigurationFileToolStripMenuItem
            // 
            this.openConfigurationFileToolStripMenuItem.Name = "openConfigurationFileToolStripMenuItem";
            this.openConfigurationFileToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openConfigurationFileToolStripMenuItem.Text = "Open configuration file...";
            this.openConfigurationFileToolStripMenuItem.Click += new System.EventHandler(this.openConfigurationFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPBCheckToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutPBCheckToolStripMenuItem
            // 
            this.aboutPBCheckToolStripMenuItem.Name = "aboutPBCheckToolStripMenuItem";
            this.aboutPBCheckToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutPBCheckToolStripMenuItem.Text = "About PBCheck";
            this.aboutPBCheckToolStripMenuItem.Click += new System.EventHandler(this.aboutPBCheckToolStripMenuItem_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 415);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(800, 22);
            this.ssStatus.TabIndex = 5;
            this.ssStatus.Text = "Status";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(53, 17);
            this.tssStatus.Text = "tssStatus";
            // 
            // FrmPBCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tcTabs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPBCheck";
            this.Text = "PBCheck";
            this.Load += new System.EventHandler(this.FrmPBCheck_Load);
            this.tcTabs.ResumeLayout(false);
            this.tpChecks.ResumeLayout(false);
            this.tpSoftware.ResumeLayout(false);
            this.tpSoftware.PerformLayout();
            this.tpConfiguration.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvHints;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpChecks;
        private System.Windows.Forms.TabPage tpSoftware;
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
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.TreeView tvConfig;
        private System.Windows.Forms.Button btRemoveCheck;
        private System.Windows.Forms.Button btAddExeCheck;
        private System.Windows.Forms.Button btAddDirectoryCheck;
        private System.Windows.Forms.Button btAddSoftwareCheck;
    }
}

