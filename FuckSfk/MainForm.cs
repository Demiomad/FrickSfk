using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuckSfk
{
    public partial class MainForm : Form
    {
        private static CancellationTokenSource _cts;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitCts()
        {
            _cts = new CancellationTokenSource();

            _cts.Token.Register(() =>
            {
                Log("Operation was canceled.");
            });
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.ShowNewFolderButton = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dirBox.Text = dialog.SelectedPath;
                }
            }
        }

        private void delBakChk_CheckedChanged(object sender, EventArgs e)
        {
            if (delBakChk.Checked)
            {
                var dialog = MessageBox.Show(".veg.bak files are automatically generated backup files.\n" +
                    "If you remove them and something goes wrong with the project, that's on you.\n\n" +
                    "Are you sure you want to remove the .veg.bak files?", "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                delBakChk.Checked = dialog == DialogResult.Yes;
            }
        }

        private void Log(string text)
            => Invoke((Action)(() => logBox.AppendText($"{text}\n")));

        private async void cleanBtn_Click(object sender, EventArgs e)
        {
            int DeleteFilesWithExt(string path, string ext)
            {
                int deletedCount = 0;
                if (_cts.Token.IsCancellationRequested) return deletedCount;

                string[] files;

                try
                {
                    files = Directory.GetFiles(path, ext);
                }
                catch (UnauthorizedAccessException) { return deletedCount; }

                foreach (var file in files)
                {
                    if (_cts.Token.IsCancellationRequested) return deletedCount;

                    try
                    {
                        Log($"Delete: {file}");
                        File.Delete(file);
                        Log($"Success: {file}");
                        deletedCount++;
                    }
                    catch (Exception ex)
                    {
                        Log($"Failed: {file} ({ex.Message})");
                    }
                }

                if (incSubdirs.Checked)
                {
                    try
                    {
                        var dirs = Directory.GetDirectories(path);

                        foreach (var dir in dirs)
                            deletedCount += DeleteFilesWithExt(dir, ext);
                    }
                    catch (Exception ex)
                    {
                        Log($"Failed: {ex.Message}");
                    }
                }

                return deletedCount;
            }

            int DeleteEverything(string path)
            {
                int total = 0;
                Log($"--- {DateTime.Now:HH:mm:ss} ---");

                if (delSfkChk.Checked)
                    total += DeleteFilesWithExt(path, "*.sfk");

                if (delSfapChk.Checked)
                    total += DeleteFilesWithExt(path, "*.sfap0");

                if (delBakChk.Checked)
                    total += DeleteFilesWithExt(path, "*.veg.bak");

                return total;
            }

            if (string.IsNullOrEmpty(dirBox.Text))
            {
                MessageBox.Show("Please enter something!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(dirBox.Text))
            {
                MessageBox.Show("That directory doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var deletePath = Path.GetFullPath(dirBox.Text);

            var dialog = MessageBox.Show("Are you sure you want to delete those files?\n\n" +
                ".sfk files are waveform cache files, basically the cache for the waveforms.\n" +
                ".sfap0 files are render cache files, basically when you import a .VEG as a media item and VEGAS renders it.\n" +
                ".veg.bak files are project backups, so if something goes wrong with the project, that's on you if you deleted them.", "Wait!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                InitCts();

                await Task.Run(() =>
                {
                    var total = DeleteEverything(deletePath);
                    Log($"Deleted {total} file(s) in total");
                });
            }
        }

        private void clearLogBtn_Click(object sender, EventArgs e)
        {
            logBox.Clear();
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {
            logBox.ScrollToCaret();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(logBox.Text)) return;

            Clipboard.SetText(logBox.Text);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (_cts == null)
                return;

            var dialog = MessageBox.Show("Are you sure you want to stop the current operation?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
                _cts.Cancel();
        }
    }
}
