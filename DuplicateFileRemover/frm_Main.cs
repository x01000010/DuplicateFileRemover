using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DuplicateFileRemover
{
    public partial class frm_Main : Form
    {
        private List<string> _fileList;
        private string _outFile = Path.Combine(Directory.GetCurrentDirectory(), "output.txt");

        public frm_Main()
        {
            InitializeComponent();
            if (__outputExists())
            {
                tb_Delete.Enabled = true;
            }
            tssl_Bottom_Status.Text = "=^_^=";
        }

        private List<string> __getFileListSingleDirectory(string directory)
        {
            return Directory.GetFiles(directory)
                    .Select(
                        f => new
                        {
                            FileName = f,
                            FileHash = Encoding.UTF8.GetString(new SHA1Managed()
                                                               .ComputeHash(new FileStream(f,
                                                                                FileMode.Open,
                                                                                FileAccess.Read)))
                        })
                    .GroupBy(f => f.FileHash)
                    .Select(g => new { FileHash = g.Key, Files = g.Select(z => z.FileName).ToList() })
                    .SelectMany(f => f.Files.Skip(1))
                    .ToList();
        }

        private bool __outputExists()
        {
            return File.Exists(_outFile);
        }

        private void __saveToFile(string s)
        {
            string newText = string.Format("{0}{1}", s, Environment.NewLine);
            File.AppendAllText(_outFile, newText);
        }

        private void __statusDone()
        {
            tssl_Bottom_Status.Text = "Done";
            ss_Bottom.Refresh();
        }

        private void __statusWorkning()
        {
            tssl_Bottom_Status.Text = "Working";
            ss_Bottom.Refresh();
        }

       

        private void tb_Delete_Click(object sender, EventArgs e)
        {
            __statusWorkning();
            try
            {
                var fileDump = File.ReadAllLines(_outFile);
                _fileList = new List<string>(fileDump);
                _fileList.ForEach(File.Delete);
                File.Delete(_outFile);
                __statusDone();
                MessageBox.Show(string.Format("Removed {0} duplicates", _fileList.Count.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void tb_Generate_Click(object sender, EventArgs e)
        {
            __statusWorkning();
            if (File.Exists(_outFile))
            {
                File.Delete(_outFile);
            }
            _fileList = __getFileListSingleDirectory(Directory.GetCurrentDirectory());
            _fileList.ForEach(__saveToFile);          
            __statusDone();
            MessageBox.Show(string.Format("Found {0} duplicates", _fileList.Count.ToString()));
            this.Close();
        }
    }
}