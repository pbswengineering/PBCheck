
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
            this.lbNote = new System.Windows.Forms.Label();
            this.ttNote = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 377);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tvHints);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(765, 351);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(765, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Installed Software";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
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
            // FrmPBCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
    }
}

