﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
        Thread Thread_ReArchWithPass;
        Thread Thread_ReDenumire;

        public string FolderDezArhivat = @"C:\Users\Barni\Desktop\GitHub\ArhiveWinRar\WinRar\bin\Debug\archive.rar";
        public string DeArhivat = @"C:\Users\Barni\Downloads\03Toamna\";
        public int StopUtilitar = 0;

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
            listViewReArch.FullRowSelect = true;

            CheckForIllegalCrossThreadCalls = false;

            string loadData = File.ReadAllText("location.loc");
            string[] loadFoxusLocation = loadData.Split('|');

            try
            {
                txtBoxLocationLoad.Text = loadFoxusLocation[0];
                txtBoxDezRar.Text = loadFoxusLocation[1];
                txtBoxPathReArch.Text = loadFoxusLocation[2];
            }
            catch
            {

            }
        }

        private void btnArhiveLoop_Click(object sender, EventArgs e)
        {
            Thread_ARHIVARE = new Thread(arhivareThread);
            Thread_ARHIVARE.Start();

            btnStopArhivare.Enabled = true;
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
                progressBar.Maximum = listViewFolders.Items.Count;
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
                    if (checkBoxArhivareViz.Checked == true)
                    {
                        startInfo.WindowStyle = ProcessWindowStyle.Normal;
                    }
                    else
                    {
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    }

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

                    if (StopUtilitar == 1)
                    {
                        break;

                        MessageBox.Show("Orire fortata!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    if (checkBoxArhivareViz.Checked == true)
                    {
                        startInfo.WindowStyle = ProcessWindowStyle.Normal;
                    }
                    else
                    {
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    }

                    startInfo.Arguments = string.Format("a -ep1 -m5 -pd2Zd3nxmYF8STv*7bHVQnZpudC8MgK%ZuqdkKDNGM5TMuUp89 \"{0}\" \"{1}\"",
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

                    //stergere folder
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

                    if (StopUtilitar == 1)
                    {
                        break;

                        MessageBox.Show("Orire fortata!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            MessageBox.Show("Arhivarea s-a terminat cu succes", "Arhivare completa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            progressBar.Value = 0;
            checkBoxDeleteFolder.Enabled = true;
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            File.WriteAllText("location.loc", txtBoxLocationLoad.Text + "|" + txtBoxDezRar.Text + "|" + txtBoxPathReArch.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText("location.loc", txtBoxLocationLoad.Text + "|" + txtBoxDezRar.Text + "|" + txtBoxPathReArch.Text);
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

            btnStopDezarhivare.Enabled = true;
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
                progressBarDezarhivare.Maximum = listViewRar.Items.Count;
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
                    startInfo.WindowStyle = ProcessWindowStyle.Normal;
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

                    if (checkBoxStergereDupaDezRAR.Checked == true)
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

                    if (StopUtilitar == 1)
                    {
                        break;

                        MessageBox.Show("Orire fortata!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    startInfo.WindowStyle = ProcessWindowStyle.Normal;
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

                    if (checkBoxStergereDupaDezRAR.Checked == true)
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

                    if (StopUtilitar == 1)
                    {
                        break;

                        MessageBox.Show("Orire fortata!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            MessageBox.Show("Dezarhivarea s-a terminat cu succes", "Arhivare completa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            progressBarDezarhivare.Value = 0;
            checkBoxStergereDupaDezRAR.Enabled = true;
        }

        private void btnLoadReArch_Click(object sender, EventArgs e)
        {
            try
            {
                //add RAR
                DirectoryInfo FileNm = new DirectoryInfo(txtBoxPathReArch.Text);
                var filename = FileNm.GetFiles("*.rar");
                listViewReArch.Items.Clear();

                foreach (FileInfo f in filename)
                {
                    //listViewRar.Items.Add(f.ToString());
                    ListViewItem item = new ListViewItem(f.ToString());
                    item.SubItems.Add(txtBoxPathReArch.Text + "/" + f.ToString());
                    listViewReArch.Items.Add(item);
                }

                lblPacAvaibleReArch.Text = listViewReArch.Items.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSaveReArch_Click(object sender, EventArgs e)
        {
            File.WriteAllText("location.loc", txtBoxLocationLoad.Text + "|" + txtBoxDezRar.Text + "|" + txtBoxPathReArch.Text);
        }

        private void btnReArch_Click(object sender, EventArgs e)
        {
            try
            {
                Thread_ReArchWithPass = new Thread(reArhivareWithPass);
                Thread_ReArchWithPass.Start();

                btnStopRearhivareCript.Enabled = true;
            }
            catch
            {

            }
        }

        private void reArhivareWithPass()
        {
            try
            {
                checkBoxDeleteReArch.Enabled = false;

                if (txtBoxFirstReArch.Text == "0")
                {
                    LimitatOrNot = 0;
                    prgBarReArch.Maximum = Convert.ToInt32(listViewReArch.Items.Count);
                    ReArch_Propriuzisa();
                }
                else
                {
                    LimitatOrNot = 1;
                    prgBarReArch.Maximum = Convert.ToInt32(listViewReArch.Items.Count);
                    ReArch_Propriuzisa();
                }

                checkBoxDeleteReArch.Enabled = true;
            }
            catch
            {

            }
        }

        private void ReArch_Propriuzisa()
        {
            try
            {
                if (LimitatOrNot == 0)
                {
                    for (int x = 0; x < listViewReArch.Items.Count; x++)
                    {
                        //DEZARHIVARE

                        listViewReArch.SelectedItems.Clear();

                        prgBarReArch.Value = x + 1;
                        lblDoneReArch.Text = Convert.ToString(x + 1);

                        this.Focus();
                        listViewReArch.Focus();

                        listViewReArch.Items[x].Selected = true;
                        listViewReArch.Items[x].Focused = true;
                        listViewReArch.Select();
                        listViewReArch.EnsureVisible(x);

                        string denumire = listViewReArch.Items[x].SubItems[0].Text;
                        string denumireFaraExt = denumire.Remove(denumire.Length - 4, 4);
                        string targetArchiveName = txtBoxPathReArch.Text + "/" + denumireFaraExt,
                        targetFile = listViewReArch.Items[x].SubItems[1].Text;
                        
                        ProcessStartInfo startInfo = new ProcessStartInfo("WinRAR.exe");
                        startInfo.CreateNoWindow = false;
                        if (checkBoxArhivareVizibila.Checked == true)
                        {
                            startInfo.WindowStyle = ProcessWindowStyle.Normal;
                        }
                        else
                        {
                            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        }

                        startInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", targetFile, txtBoxPathReArch.Text);
                        
                        try
                        {
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

                        if (checkBoxDeleteReArch.Checked == true)
                        {
                            string fisierVerificat = txtBoxPathReArch.Text + "/" + listViewReArch.Items[x].SubItems[0].Text;
                            if (File.Exists(fisierVerificat))
                            {
                                try
                                {
                                    string fisierDelete = txtBoxPathReArch.Text + "/" + listViewReArch.Items[x].SubItems[0].Text;
                                    File.Delete(fisierDelete);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                        }

                        //RE-ARHIVARE CU PAROLA
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        ProcessStartInfo startInfoReArch = new ProcessStartInfo("WinRAR.exe");

                        if (checkBoxArhivareVizibila.Checked == true)
                        {
                            startInfoReArch.WindowStyle = ProcessWindowStyle.Normal;
                        }
                        else
                        {
                            startInfoReArch.WindowStyle = ProcessWindowStyle.Hidden;
                        }

                        startInfoReArch.Arguments = string.Format("a -ep1 -m5 -pd2Zd3nxmYF8STv*7bHVQnZpudC8MgK%ZuqdkKDNGM5TMuUp89 \"{0}\" \"{1}\"", targetFile, targetArchiveName);

                        try
                        {
                            using (Process exeProcess2 = Process.Start(startInfoReArch))
                            {
                                exeProcess2.WaitForExit();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        //Stergere FOLDER
                        if (checkBoxDeleteReArch.Checked == true)
                        {
                            string locatieDeVerificat = txtBoxPathReArch.Text + "/" + listViewReArch.Items[x].SubItems[0].Text;
                            if (File.Exists(locatieDeVerificat))
                            {
                                try
                                {
                                    string folderDeSters = txtBoxPathReArch.Text + "/" + listViewReArch.Items[x].SubItems[0].Text;
                                    Directory.Delete(targetArchiveName, true);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                        }

                        //redenumire fara extensie
                        string redenumireCriptat = targetFile;
                        if (File.Exists(redenumireCriptat))
                        {
                            try
                            {
                                //myString = myString.Substring(0, myString.Length-3);
                                string FileInitial = redenumireCriptat;
                                string FileRezultat = targetFile.Substring(0, targetFile.Length - 4) + ".k";
                                System.IO.File.Move(FileInitial, FileRezultat);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }

                        if (StopUtilitar == 1)
                        {
                            break;

                            MessageBox.Show("Orire fortata!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else //DE REVERIFICAT LINIE CU LINIE
                {
                    for (int x = 0; x < Convert.ToInt32(txtBoxFirstReArch.Text); x++)
                    {
                        listViewReArch.SelectedItems.Clear();

                        prgBarReArch.Value = x + 1;
                        lblDoneReArch.Text = Convert.ToString(x + 1);

                        this.Focus();
                        listViewReArch.Focus();

                        listViewReArch.Items[x].Selected = true;
                        listViewReArch.Items[x].Focused = true;
                        listViewReArch.Select();
                        listViewReArch.EnsureVisible(x);

                        string denumire = listViewReArch.Items[x].SubItems[0].Text;
                        string denumireFaraExt = denumire.Remove(denumire.Length - 4, 4);
                        string targetArchiveName = txtBoxPathReArch.Text + "/" + denumireFaraExt,
                        targetFile = listViewReArch.Items[x].SubItems[1].Text;

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

                        if (checkBoxDeleteReArch.Checked == true)
                        {
                            if (File.Exists(txtBoxPathReArch.Text + "/" + listViewReArch.Items[x].SubItems[0].Text + ".rar"))
                            {
                                try
                                {
                                    Directory.Delete(txtBoxPathReArch.Text + "/" + listViewReArch.Items[x].SubItems[0].Text, true);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                        }

                        //Rearhivare date extrase

                        listViewReArch.SelectedItems.Clear();

                        prgBarReArch.Value = x + 1;
                        lblDoneReArch.Text = Convert.ToString(x + 1);

                        this.Focus();
                        listViewReArch.Focus();

                        listViewReArch.Items[x].Selected = true;
                        listViewReArch.Items[x].Focused = true;
                        listViewReArch.Select();
                        listViewReArch.EnsureVisible(x);

                        ProcessStartInfo startInfoCripta = new ProcessStartInfo("WinRAR.exe");
                        startInfoCripta.WindowStyle = ProcessWindowStyle.Maximized;
                        startInfoCripta.Arguments = string.Format("a -ep1 -m5 -pd2Zd3nxmYF8STv*7bHVQnZpudC8MgK%ZuqdkKDNGM5TMuUp89 \"{0}\" \"{1}\"",
                                              targetArchiveName, targetFile);
                        try
                        {
                            // Start the process with the info we specified.
                            using (Process exeProcess = Process.Start(startInfoCripta))
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

                        //stergere folder
                        if (checkBoxDeleteReArch.Checked == true)
                        {
                            if (File.Exists(txtBoxPathReArch.Text + "/" + listViewReArch.Items[x].SubItems[0].Text + ".rar"))
                            {
                                try
                                {
                                    Directory.Delete(txtBoxPathReArch.Text + "/" + listViewReArch.Items[x].SubItems[0].Text, true);
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

                        if (StopUtilitar == 1)
                        {
                            break;

                            MessageBox.Show("Orire fortata!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Task terminat cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblDoneReArch_Click(object sender, EventArgs e)
        {

        }

        private void btnStopArhivare_Click(object sender, EventArgs e)
        {
            StopUtilitar = 1;
            btnStopArhivare.Enabled = false;
        }

        private void btnStopDezarhivare_Click(object sender, EventArgs e)
        {
            StopUtilitar = 1;
            btnStopDezarhivare.Enabled = false;
        }

        private void btnStopRearhivareCript_Click(object sender, EventArgs e)
        {
            StopUtilitar = 1;
            btnStopRearhivareCript.Enabled = false;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewReArch.Items.Count > 0)
                {
                    Thread_ReDenumire = new Thread(redenumire_Propriuzisa);
                    Thread_ReDenumire.Start();
                }
                else
                {
                    MessageBox.Show("Nu sunt foldere incarcate in aplicatie pentru verificare de redenumire", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        public void redenumire_Propriuzisa()
        {
            try
            {
                for (int i = 0; i < listViewReArch.Items.Count; i++)
                {
                    this.Focus();
                    listViewReArch.Focus();

                    listViewReArch.Items[i].Selected = true;
                    listViewReArch.Items[i].Focused = true;
                    listViewReArch.Select();
                    listViewReArch.EnsureVisible(i);

                    string getDenumireFile = listViewReArch.Items[i].SubItems[0].Text;
                    string getFilePath = listViewReArch.Items[i].SubItems[1].Text;

                    string getFilePathWithoutFileName =  System.IO.Directory.GetParent(getFilePath).FullName;

                    string[] numeVechiSplit = getDenumireFile.Split(new string[] { "patient" }, StringSplitOptions.None);

                    if (getDenumireFile.Contains("Repaired"))
                    {
                        System.IO.File.Move(getFilePath, getFilePathWithoutFileName + "/patient" + numeVechiSplit[1]);
                    }

                    listViewReArch.SelectedItems.Clear();

                    Thread.Sleep(244);
                }

                MessageBox.Show("Au fost redenumite toate fisierele cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)     
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
