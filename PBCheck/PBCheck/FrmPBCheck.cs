using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBCheck
{
    public partial class FrmPBCheck : Form
    {
        private const string MISSING_SW_CHECKS = "Missing Software Checks";
        private const string MISSING_DIR_CHECKS = "Missing Directories Check";
        private const string MISSING_EXE_CHECKS = "Missing Executables in Path Check";

        private Config conf;

        public FrmPBCheck()
        {
            InitializeComponent();
        }

        private string GetConfigFile(bool force)
        {
            if (force || Properties.Settings.Default.ConfigFile.Length == 0)
            {
                using OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Please select a PBCheck JSON configuration file",
                    Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.ConfigFile = openFileDialog.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            return Properties.Settings.Default.ConfigFile;
        }

        private void FrmPBCheck_Load(object sender, EventArgs e)
        {
            RefreshChecks(false);
            RefreshConfiguration();
        }

        private void RefreshConfiguration()
        {
            if (conf == null)
            {
                string configFile = GetConfigFile(false);
                conf = Config.LoadFromFile(configFile);
            }
            tvConfig.Nodes.Clear();
            var missingSW = tvConfig.Nodes.Add("Missing Software Checks");
            foreach (var sw in conf.DesiredSoftware)
            {
                missingSW.Nodes.Add(sw);
            }
            var missingDirs = tvConfig.Nodes.Add("Missing Directories Check");
            foreach (var dir in conf.DesiredDirectories)
            {
                missingDirs.Nodes.Add(dir);
            }
            var missingExe = tvConfig.Nodes.Add("Missing Executables in Path Check");
            foreach (var exe in conf.DesiredExeInPath)
            {
                missingExe.Nodes.Add(exe);
            }
            tvConfig.ExpandAll();
        }

        private void RefreshChecks(bool forceConfigFileSelection)
        {
            // Load configuration
            string configFile = GetConfigFile(forceConfigFileSelection);
            if (configFile.Length == 0)
            {
                Application.Exit();
            }
            conf = Config.LoadFromFile(configFile);
            // Clear on-screen results
            tvHints.Nodes.Clear();
            lbInstalledSoftware.Items.Clear();
            // Check for missing software
            var installedSW = Software.GetInstalledSoftware();
            foreach (var sw in installedSW)
            {
                lbInstalledSoftware.Items.Add(sw);
            }
            var missingSW = Checks.CheckForMissingSoftware(installedSW, conf.DesiredSoftware);
            if (missingSW.Count > 0)
            {
                var nodeSW = tvHints.Nodes.Add($"Missing Software ({missingSW.Count})");
                foreach (var sw in missingSW)
                {
                    nodeSW.Nodes.Add(sw);
                }
            }
            // Check for missing directories
            var missingDirs = Checks.CheckForMissingDirectories(conf.DesiredDirectories);
            if (missingDirs.Count > 0)
            {
                var nodeDirs = tvHints.Nodes.Add($"Missing Directories ({missingDirs.Count})");
                foreach (var dir in missingDirs)
                {
                    nodeDirs.Nodes.Add(dir);
                }
            }
            // Check for missing executables in PATH
            var missingExe = Checks.CheckForMissingExeInPath(conf.DesiredExeInPath);
            if (missingExe.Count > 0)
            {
                var nodeExe = tvHints.Nodes.Add($"Missing Executables in Path ({missingExe.Count})");
                foreach (var exe in missingExe)
                {
                    nodeExe.Nodes.Add(exe);
                }
            }
            tvHints.ExpandAll();
            // Status report
            var errorCount = missingSW.Count + missingDirs.Count + missingExe.Count;
            if (errorCount == 1)
            {
                tssStatus.Text = "There is one non-compliance";
                tssStatus.ForeColor = Color.Red;
            }
            else if (errorCount > 0)
            {
                tssStatus.Text = $"There are {errorCount} non-compliances";
                tssStatus.ForeColor = Color.Red;
            }
            else
            {
                tssStatus.Text = "All checks are satisfied";
                tssStatus.ForeColor = Color.Green;
            }
        }

        private void lbInstalledSoftware_DoubleClick(object sender, EventArgs e)
        {
            var selection = lbInstalledSoftware.SelectedItem;
            if (selection != null)
            {
                Clipboard.SetText(selection.ToString());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openConfigurationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshChecks(true);
        }

        private void pbPBSE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bernardi.cloud/");
        }

        private void aboutPBCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new FrmAbout();
            about.ShowDialog();
        }

        private void lbInstalledSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbInstalledSoftware.SelectedItem is string selected && selected.Trim().Length > 0)
            {
                tbSoftwareToAdd.Text = selected;
            }
        }

        private void btAddSoftware_Click(object sender, EventArgs e)
        {
            if (tbSoftwareToAdd.Text is string selected && selected.Trim().Length > 0)
            {
                conf.AddDesiredSoftware(tbSoftwareToAdd.Text);
                conf.SaveToFile(GetConfigFile(false));
                MessageBox.Show($"{selected} was added to the desired software check list.");
            }
        }

        // Borrowed from https://stackoverflow.com/a/17546909
        private static DialogResult ShowInputDialog(string caption, ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = caption;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void btAddSoftwareCheck_Click(object sender, EventArgs e)
        {
            string sw = "";
            if (ShowInputDialog("Missing Software To Check", ref sw) == DialogResult.OK)
            {
                conf.AddDesiredSoftware(sw);
                conf.SaveToFile(GetConfigFile(false));
                RefreshConfiguration();
            }
        }

        private void btAddDirectoryCheck_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    conf.AddDesiredDirectory(fbd.SelectedPath);
                    conf.SaveToFile(GetConfigFile(false));
                    RefreshConfiguration();
                }
            }
        }

        private void btAddExeCheck_Click(object sender, EventArgs e)
        {
            string exe = "";
            if (ShowInputDialog("Missing Exe In Path To Check", ref exe) == DialogResult.OK)
            {
                conf.AddDesiredExeInPath(exe);
                conf.SaveToFile(GetConfigFile(false));
                RefreshConfiguration();
            }
        }

        private void btRemoveCheck_Click(object sender, EventArgs e)
        {
            var selection = tvConfig.SelectedNode;
            if (selection.Parent == null)
            {
                return;
            }
            if (MessageBox.Show("Do you really want to delete the selected check?", "Check Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var parent = selection.Parent.Text;
                if (parent == MISSING_SW_CHECKS)
                {
                    conf.DesiredSoftware.Remove(selection.Text);
                    conf.SaveToFile(GetConfigFile(false));
                    RefreshConfiguration();
                }
                else if (parent == MISSING_DIR_CHECKS)
                {
                    conf.DesiredDirectories.Remove(selection.Text);
                    conf.SaveToFile(GetConfigFile(false));
                    RefreshConfiguration();
                }
                else if (parent == MISSING_EXE_CHECKS)
                {
                    conf.DesiredExeInPath.Remove(selection.Text);
                    conf.SaveToFile(GetConfigFile(false));
                    RefreshConfiguration();
                }
            }
        }
    }
}
