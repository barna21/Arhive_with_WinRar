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
        Thread Thread_DEZARHIVARE;

        public string FolderDezArhivat = @"C:\Users\Barni\Desktop\GitHub\ArhiveWinRar\WinRar\bin\Debug\archive.rar";
        public string DeArhivat = @"C:\Users\Barni\Downloads\03Toamna\";

        private string PassArhivare = "d2Zd3nxmYF8STv*7bHVQnZpudC8MgK%ZuqdkKDNGM5TMuUp89";

        private void button1_Click(object sender, EventArgs e)
        {
            //string folder = Application.StartupPath + "/archive.rar";
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
            startInfo.Arguments = string.Format("a -ep1 -m5 \"{0}\" \"{1}\"",
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
            listViewRar.FullRowSelect = true;
            CheckForIllegalCrossThreadCalls = false;

            string loadData = File.ReadAllText("location.loc");
            string[] loadFoxusLocation = loadData.Split('|');

            txtBoxLocationLoad.Text = loadFoxusLocation[0];
            txtBoxDezRar.Text = loadFoxusLocation[1];
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

                    string targetArchiveName = txtBoxLocationLoad.Text + "/" + listViewFolders.Items[x].SubItems[0].Text + "",
                    targetFile = listViewFolders.Items[x].SubItems[1].Text;
                    ProcessStartInfo startInfo = new ProcessStartInfo("WinRAR.exe");
                    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    //startInfo.Arguments = string.Format("a -m5 \"{0}\" \"{1}\"", targetArchiveName, targetFile);
                    startInfo.Arguments = string.Format("a -ep1 -m5 -pd2Zd3nxmYF8STv*7bHVQnZpudC8MgK%ZuqdkKDNGM5TMuUp89 \"{0}\" \"{1}\"", targetArchiveName, targetFile);

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

                    //Stergere FOLDER
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

                    //redenumire fara extensie
                    if (File.Exists(targetFile + ".rar"))
                    {
                        try
                        {
                            System.IO.File.Move(targetFile + ".rar", targetFile + ".k");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
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
                    startInfo.Arguments = string.Format("a -ep1 -m5 \"{0}\" \"{1}\"",
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
            File.WriteAllText("location.loc", txtBoxLocationLoad.Text + "|" + txtBoxDezRar.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText("location.loc", txtBoxLocationLoad.Text + "|" + txtBoxDezRar.Text);
        }

        private void btnLoadRar_Click(object sender, EventArgs e)
        {
            //add RAR
            DirectoryInfo FileNm = new DirectoryInfo(txtBoxDezRar.Text);
            var filename = FileNm.GetFiles("*.k");
            listViewRar.Items.Clear();

            foreach (FileInfo f in filename)
            {
                //listViewRar.Items.Add(f.ToString());
                ListViewItem item = new ListViewItem(f.ToString());
                item.SubItems.Add(txtBoxDezRar.Text + "/" + f.ToString());
                listViewRar.Items.Add(item);
            }

            lblArhiveGasite.Text = listViewRar.Items.Count.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread_DEZARHIVARE = new Thread(DEZARHIVARE);
            Thread_DEZARHIVARE.Start();
        }

        public void DEZARHIVARE()
        {
            checkBoxStergereDupaDezRAR.Enabled = false;

            if (txtBoxLimitaDez.Text == "0")
            {
                LimitatOrNot = 0;
                progressBarDezarhivare.Maximum = listViewRar.Items.Count;
                DezarhivarePropriuzisa();
            }
            else
            {
                LimitatOrNot = 1;
                progressBarDezarhivare.Maximum = Convert.ToInt32(txtBoxLimitaDez.Text);
                DezarhivarePropriuzisa();
            }

            checkBoxStergereDupaDezRAR.Enabled = true;
        }

        public void DezarhivarePropriuzisa()
        {
            if (LimitatOrNot == 0)
            {
                for (int x = 0; x < listViewRar.Items.Count; x++)
                {
                    listViewRar.SelectedItems.Clear();

                    progressBarDezarhivare.Value = x + 1;
                    lblDezarhivati.Text = Convert.ToString(x + 1);

                    this.Focus();
                    listViewRar.Focus();

                    listViewRar.Items[x].Selected = true;
                    listViewRar.Items[x].Focused = true;
                    listViewRar.Select();
                    listViewRar.EnsureVisible(x);

                    string denumire = listViewRar.Items[x].SubItems[0].Text;
                    string denumireFaraExt = denumire.Remove(denumire.Length - 4, 4);
                    string targetArchiveName = txtBoxLocationLoad.Text + "/" + denumireFaraExt,
                    targetFile = listViewRar.Items[x].SubItems[1].Text;
                    //ProcessStartInfo startInfo = new ProcessStartInfo("WinRAR.exe");
                    //startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    //startInfo.Arguments = string.Format("a -ibck \"{0}\" \"{1}\"", targetArchiveName, targetFile);
                    // startInfo.Arguments = string.Format("x -s \"{0}\" \"{1}\"", targetArchiveName, targetFile);

                    //System.Diagnostics.Process P_WinRar = new System.Diagnostics.Process();
                    //P_WinRar.StartInfo.FileName = @"C:\Program Files\WinRAR\WinRAR.exe";
                    //P_WinRar.StartInfo.CreateNoWindow = false;



                    //P_WinRar.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", targetFile, targetArchiveName);
                    //P_WinRar.EnableRaisingEvents = true;
                    //P_WinRar.Start();

                    //string targetArchiveName = txtBoxLocationLoad.Text + "/" + listViewRar.Items[x].SubItems[0].Text,
                    //targetFile = listViewRar.Items[x].SubItems[1].Text;
                    ProcessStartInfo startInfo = new ProcessStartInfo("WinRAR.exe");
                    startInfo.CreateNoWindow = false;
                    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    ////startInfo.Arguments = string.Format("x -ibck \"{0}\" \"{1}\"", targetArchiveName, targetFile);
                    startInfo.Arguments = string.Format("x -o+ -pd2Zd3nxmYF8STv*7bHVQnZpudC8MgK%ZuqdkKDNGM5TMuUp89 \"{0}\" \"{1}\"", targetFile, txtBoxDezRar.Text);
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
                        if (File.Exists(txtBoxLocationLoad.Text + "/" + listViewRar.Items[x].SubItems[0].Text + ".rar"))
                        {
                            try
                            {
                                Directory.Delete(txtBoxLocationLoad.Text + "/" + listViewRar.Items[x].SubItems[0].Text, true);
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
                for (int x = 0; x < Convert.ToInt32(txtBoxLimitaDez.Text); x++)
                {
                    listViewRar.SelectedItems.Clear();

                    progressBarDezarhivare.Value = x + 1;
                    lblDezarhivati.Text = Convert.ToString(x + 1);

                    this.Focus();
                    listViewRar.Focus();

                    listViewRar.Items[x].Selected = true;
                    listViewRar.Items[x].Focused = true;
                    listViewRar.Select();
                    listViewRar.EnsureVisible(x);

                    //string targetArchiveName = txtBoxLocationLoad.Text + "/" + listViewRar.Items[x].SubItems[0].Text,
                    //targetFile = listViewRar.Items[x].SubItems[1].Text;
                    //myString = myString.Remove(myString.Length - 3, 3);
                    string denumire = listViewRar.Items[x].SubItems[0].Text;
                    string denumireFaraExt = denumire.Remove(denumire.Length - 4, 4);
                    string targetArchiveName = txtBoxLocationLoad.Text + "/" + denumireFaraExt,
                    targetFile = listViewRar.Items[x].SubItems[1].Text;
                    //ProcessStartInfo startInfo = new ProcessStartInfo("WinRAR.exe");
                    //startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    //startInfo.Arguments = string.Format("a -ibck \"{0}\" \"{1}\"", targetArchiveName, targetFile);
                    // startInfo.Arguments = string.Format("x -s \"{0}\" \"{1}\"", targetArchiveName, targetFile);

                    //System.Diagnostics.Process P_WinRar = new System.Diagnostics.Process();
                    //P_WinRar.StartInfo.FileName = @"C:\Program Files\WinRAR\WinRAR.exe";
                    //P_WinRar.StartInfo.CreateNoWindow = false;

                    

                    //P_WinRar.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", targetFile, targetArchiveName);
                    //P_WinRar.EnableRaisingEvents = true;
                    //P_WinRar.Start();

                    //string targetArchiveName = txtBoxLocationLoad.Text + "/" + listViewRar.Items[x].SubItems[0].Text,
                    //targetFile = listViewRar.Items[x].SubItems[1].Text;
                    ProcessStartInfo startInfo = new ProcessStartInfo("WinRAR.exe");
                    startInfo.CreateNoWindow = false;
                    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                    ////startInfo.Arguments = string.Format("x -ibck \"{0}\" \"{1}\"", targetArchiveName, targetFile);
                    startInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", targetFile, txtBoxDezRar.Text);
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
                        if (File.Exists(txtBoxLocationLoad.Text + "/" + listViewRar.Items[x].SubItems[0].Text + ".rar"))
                        {
                            try
                            {
                                Directory.Delete(txtBoxLocationLoad.Text + "/" + listViewRar.Items[x].SubItems[0].Text, true);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
            }

            MessageBox.Show("Dezarhivarea s-a terminat cu succes", "Arhivare completa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            progressBarDezarhivare.Value = 0;
            checkBoxStergereDupaDezRAR.Enabled = true;
        }
    }
}
