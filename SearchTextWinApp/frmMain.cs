using SearchTextWinApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchTextWinApp
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class frmMain : Form
    {
        private int _gvLineNo = 0;
        private List<SearchResult> _searchResult = new List<SearchResult>();

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
        }

        /// <summary>
        /// Browser button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.Filter = "Text Files (*.txt)|*.txt";
                ofd.Multiselect = false;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;

                DialogResult dlgResult = ofd.ShowDialog();

                if (dlgResult == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        /// <summary>
        /// Search button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearchValue.Text))
                {
                    throw new Exception("Search value is empty.");
                }

                _searchResult.Clear();
                progressBar.Value = 0;
                progressBar.Step = 0;

                backgroundWorker.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }

        }

        private void ShowMessage(string errorMessage)
        {
            if (errorMessage == null)
            {
                return;
            }

            MessageBox.Show(this, errorMessage, "Search Text Application", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Clear button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            dtGrid.Rows.Clear();
            _searchResult.Clear();
            progressBar.Step = 0;
            progressBar.Value = 0;
            _gvLineNo = 0;
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVersion version = new frmVersion();
            version.StartPosition = FormStartPosition.CenterParent;
            DialogResult dialogRes = version.ShowDialog(this);

            if (dialogRes == DialogResult.Cancel || 
                dialogRes == DialogResult.Yes)
            {
                version.Close();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // get list of dir in computer
                List<DriveInfo> listDir = DriveInfo.GetDrives().ToList();

                List<string> allDirList = new List<string>();

                // Get all directory list from the machine
                //foreach (DriveInfo dir in listDir)
                //{
                //    List<string> outputDirList = new List<string>();

                //    Utility.GetAllDir(dir.Name, outputDirList);

                //    if (outputDirList.Count > 0)
                //    {
                //        allDirList.AddRange(outputDirList);
                //    }
                //}

                List<string> outputDirList = new List<string>();

                Utility.GetAllDir(@"C:\Users\HP\Desktop\", outputDirList);

                if (outputDirList.Count > 0)
                {
                    allDirList.AddRange(outputDirList);
                }

                // Get all text file list in all dir
                List<string> fileList = new List<string>();

                foreach (string dir in allDirList)
                {
                    List<string> curDirFileList = Utility.GetAllFilesInDir(dir);

                    if (curDirFileList.Count > 0)
                    {
                        fileList.AddRange(curDirFileList);
                    }
                }

                progressBar.Invoke((MethodInvoker)delegate
                {
                    progressBar.Step = fileList.Count();
                });

                List<SearchResult> searchResultList = new List<SearchResult>();
                int stepCnt = 0;

                foreach (string file in fileList)
                {
                    try
                    {
                        using (StreamReader streamReader = new StreamReader(file))
                        {
                            string lineData = null;
                            int lineNo = 0;

                            while ((lineData = streamReader.ReadLine()) != null)
                            {
                                lineNo++;


                                if (rbtContain.Checked)
                                {
                                    if (lineData.Contains(txtSearchValue.Text))
                                    {
                                        SearchResult result = new SearchResult()
                                        {
                                            LineNo = lineNo,
                                            Data = lineData,
                                            FilePath = file
                                        };

                                        _searchResult.Add(result);
                                    }
                                }
                                else
                                {
                                    if (lineData.Equals(txtSearchValue.Text, StringComparison.Ordinal))
                                    {
                                        SearchResult result = new SearchResult()
                                        {
                                            LineNo = lineNo,
                                            Data = lineData
                                        };

                                        _searchResult.Add(result);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    backgroundWorker.ReportProgress(++stepCnt);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.PerformStep();
            });
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (_searchResult.Count > 0)
                {
                    for (int i = 1; i <= _searchResult.Count; i++)
                    {
                        _gvLineNo++;

                        dtGrid.Rows.Add(_gvLineNo,
                                        _searchResult[i - 1].LineNo,
                                        _searchResult[i - 1].Data,
                                        _searchResult[i - 1].FilePath);
                    }
                }
                else
                {
                    ShowMessage("Not found!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
