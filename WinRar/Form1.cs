using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinRar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread Thread_ARHIVARE;

        public string FolderDezArhivat = @"C:\Users\Barni\Downloads\03Toamna.rar";
        public string DeArhivat = @"C:\Users\Barni\Downloads\03Toamna\";

        private void button1_Click(object sender, EventArgs e)
        {
            string folder = Application.StartupPath + @"Xfolder";
            System.Diagnostics.Process P_WinRar = new System.Diagnostics.Process();
            P_WinRar.StartInfo.FileName = @"C:\Program Files\WinRAR\WinRAR.exe";
            P_WinRar.StartInfo.CreateNoWindow = false;
            P_WinRar.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", FolderDezArhivat, @"C:\Users\Barni\Desktop\GitHub\WinRar\WinRar\bin\Debug\Xfolder\");
            P_WinRar.EnableRaisingEvents = true;
            P_WinRar.Start();
            //MessageBox.Show("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string targetArchiveName = @"archive.rar",
            targetFile = @"C:\Users\Barni\Downloads\ArhivaTest\patient_AMS 4034";
            ProcessStartInfo startInfo = new ProcessStartInfo("WinRAR.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            startInfo.Arguments = string.Format("a -m5 \"{0}\" \"{1}\"",
                                  targetArchiveName, targetFile);
            try
            {
                // Start the process with the info we specified.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();


                }
            }
            catch
            {
                {
                    MessageBox.Show("Error Open");
                }
            }

            MessageBox.Show("Done");
        }

        private void btnLoadFolders_Click(object sender, EventArgs e)
        {
            listViewFolders.Items.Clear();
            
            var directories = Directory.GetDirectories(txtBoxLocationLoad.Text);

            for(int z = 0; z < directories.Length; z++)
            {

                string lastFolderName = Path.GetFileName(directories[z]);

                ListViewItem item = new ListViewItem(lastFolderName);
                item.SubItems.Add(directories[z]);
                listViewFolders.Items.Add(item);
            }

            lblPacientiGasiti.Text = listViewFolders.Items.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewFolders.FullRowSelect = true;
            CheckForIllegalCrossThreadCalls = false;

            txtBoxLocationLoad.Text = File.ReadAllText("location.loc");
        }

        private void btnArhiveLoop_Click(object sender, EventArgs e)
        {
            Thread_ARHIVARE = new Thread(arhivareThread);
            Thread_ARHIVARE.Start();

            //arhivareThread();
        }

        public void arhivareThread()
        {
            checkBoxDeleteFolder.Enabled = false;

            if(txtBoxArhivePac.Text == "0")
            {
                LimitatOrNot = 0;
                progressBar.Maximum = listViewFolders.Items.Count;
                ArhivarePropriuzisa();
            }
            else
            {
                LimitatOrNot = 1;
                progressBar.Maximum = Convert.ToInt32(txtBoxArhivePac.Text);
                ArhivarePropriuzisa();
            }

            checkBoxDeleteFolder.Enabled = true;
        }

        public int LimitatOrNot;

        public void ArhivarePropriuzisa()
        {
            if (LimitatOrNot == 0)
            {
                for (int x = 0; x < listViewFolders.Items.Count; x++)
                {
                    listViewFolders.SelectedItems.Clear();

                    progressBar.Value = x + 1;
                    lblArhivatiCount.Text = Convert.ToString(x + 1);

                    this.Focus();
                    listViewFolders.Focus();

                    listViewFolders.Items[x].Selected = true;
                    listViewFolders.Items[x].Focused = true;
                    listViewFolders.Select();
                    listViewFolders.EnsureVisible(x);

                    string targetArchiveName = txtBoxLocationLoad.Text + "/" + listViewFolders.Items[x].SubItems[0].Text + ".rar",
                    targetFile = listViewFolders.Items[x].SubItems[1].Text;
                    ProcessStartInfo startInfo = new ProcessStartInfo("WinRAR.exe");
                    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    //startInfo.Arguments = string.Format("a -m5 \"{0}\" \"{1}\"", targetArchiveName, targetFile);
                    startInfo.Arguments = string.Format("a -ep1 -m5 \"{0}\" \"{1}\"", targetArchiveName, targetFile);

                    try
                    {
                        // Start the process with the info we specified.
                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();
                        }
                    }
                    catch
                    {
                        {
                            MessageBox.Show("Error Open");
                        }
                    }

                    if (checkBoxDeleteFolder.Checked == true)
                    {
                        if (File.Exists(txtBoxLocationLoad.Text + "/" + listViewFolders.Items[x].SubItems[0].Text + ".rar"))
                        {
                            try
                            {
                                Directory.Delete(txtBoxLocationLoad.Text + "/" + listViewFolders.Items[x].SubItems[0].Text, true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
            }
            else
            {
                for (int x = 0; x < Convert.ToInt32(txtBoxArhivePac.Text); x++)
                {
                    listViewFolders.SelectedItems.Clear();

                    progressBar.Value = x + 1;
                    lblArhivatiCount.Text = Convert.ToString(x + 1);

                    this.Focus();
                    listViewFolders.Focus();

                    listViewFolders.Items[x].Selected = true;
                    listViewFolders.Items[x].Focused = true;
                    listViewFolders.Select();
                    listViewFolders.EnsureVisible(x);

                    string targetArchiveName = txtBoxLocationLoad.Text + "/" + listViewFolders.Items[x].SubItems[0].Text + ".rar",
                    targetFile = listViewFolders.Items[x].SubItems[1].Text;
                    ProcessStartInfo startInfo = new ProcessStartInfo("WinRAR.exe");
                    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    startInfo.Arguments = string.Format("a -m5 \"{0}\" \"{1}\"",
                                          targetArchiveName, targetFile);
                    try
                    {
                        // Start the process with the info we specified.
                        using (Process exeProcess = Process.Start(startInfo))
                        {
                            exeProcess.WaitForExit();
                        }
                    }
                    catch
                    {
                        {
                            MessageBox.Show("Error Open");
                        }
                    }

                    if (checkBoxDeleteFolder.Checked == true)
                    {
                        if (File.Exists(txtBoxLocationLoad.Text + "/" + listViewFolders.Items[x].SubItems[0].Text + ".rar"))
                        {
                            try
                            {
                                Directory.Delete(txtBoxLocationLoad.Text + "/" + listViewFolders.Items[x].SubItems[0].Text, true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
            }

            MessageBox.Show("Arhivarea s-a terminat cu succes", "Arhivare completa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            progressBar.Value = 0;
            checkBoxDeleteFolder.Enabled = true;
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            File.WriteAllText("location.loc", txtBoxLocationLoad.Text);
        }
    }
}
