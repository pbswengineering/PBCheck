using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBCheck
{
    public partial class FrmPBCheck : Form
    {
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
    }
}
