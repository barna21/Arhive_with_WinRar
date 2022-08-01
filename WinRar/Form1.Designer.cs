namespace WinRar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxLocationLoad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadFolders = new System.Windows.Forms.Button();
            this.listViewFolders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lblPacientiGasiti = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxArhivePac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxDeleteFolder = new System.Windows.Forms.CheckBox();
            this.btnArhiveLoop = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArhivatiCount = new System.Windows.Forms.Label();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewRar = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBarDezarhivare = new System.Windows.Forms.ProgressBar();
            this.lblDezarhivati = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDezRar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLoadRar = new System.Windows.Forms.Button();
            this.checkBoxStergereDupaDezRAR = new System.Windows.Forms.CheckBox();
            this.txtBoxLimitaDez = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblArhiveGasite = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPaGReCript = new System.Windows.Forms.TabPage();
            this.listViewReArch = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prgBarReArch = new System.Windows.Forms.ProgressBar();
            this.lblDoneReArch = new System.Windows.Forms.Label();
            this.btnSaveReArch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxPathReArch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnReArch = new System.Windows.Forms.Button();
            this.btnLoadReArch = new System.Windows.Forms.Button();
            this.checkBoxDeleteReArch = new System.Windows.Forms.CheckBox();
            this.txtBoxFirstReArch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPacAvaibleReArch = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPaGReCript.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dezarhivare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(867, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Arhivare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBoxLocationLoad
            // 
            this.txtBoxLocationLoad.Location = new System.Drawing.Point(96, 8);
            this.txtBoxLocationLoad.Name = "txtBoxLocationLoad";
            this.txtBoxLocationLoad.Size = new System.Drawing.Size(700, 20);
            this.txtBoxLocationLoad.TabIndex = 2;
            this.txtBoxLocationLoad.Text = "\\\\10.200.10.65\\Archive\\XVI\\2014-12-06";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder cautare:";
            // 
            // btnLoadFolders
            // 
            this.btnLoadFolders.Location = new System.Drawing.Point(873, 6);
            this.btnLoadFolders.Name = "btnLoadFolders";
            this.btnLoadFolders.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFolders.TabIndex = 4;
            this.btnLoadFolders.Text = "Load folders";
            this.btnLoadFolders.UseVisualStyleBackColor = true;
            this.btnLoadFolders.Click += new System.EventHandler(this.btnLoadFolders_Click);
            // 
            // listViewFolders
            // 
            this.listViewFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewFolders.HideSelection = false;
            this.listViewFolders.Location = new System.Drawing.Point(8, 31);
            this.listViewFolders.Name = "listViewFolders";
            this.listViewFolders.Size = new System.Drawing.Size(689, 331);
            this.listViewFolders.TabIndex = 5;
            this.listViewFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFolders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume folder:";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 776;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pacienti gasiti:";
            // 
            // lblPacientiGasiti
            // 
            this.lblPacientiGasiti.AutoSize = true;
            this.lblPacientiGasiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientiGasiti.Location = new System.Drawing.Point(798, 42);
            this.lblPacientiGasiti.Name = "lblPacientiGasiti";
            this.lblPacientiGasiti.Size = new System.Drawing.Size(15, 16);
            this.lblPacientiGasiti.TabIndex = 7;
            this.lblPacientiGasiti.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arhiveaza primii:";
            // 
            // txtBoxArhivePac
            // 
            this.txtBoxArhivePac.Location = new System.Drawing.Point(792, 144);
            this.txtBoxArhivePac.Name = "txtBoxArhivePac";
            this.txtBoxArhivePac.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArhivePac.TabIndex = 9;
            this.txtBoxArhivePac.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(898, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "pacienti";
            // 
            // checkBoxDeleteFolder
            // 
            this.checkBoxDeleteFolder.AutoSize = true;
            this.checkBoxDeleteFolder.Location = new System.Drawing.Point(706, 170);
            this.checkBoxDeleteFolder.Name = "checkBoxDeleteFolder";
            this.checkBoxDeleteFolder.Size = new System.Drawing.Size(162, 17);
            this.checkBoxDeleteFolder.TabIndex = 11;
            this.checkBoxDeleteFolder.Text = "Dupa arhivare sterge folderul";
            this.checkBoxDeleteFolder.UseVisualStyleBackColor = true;
            // 
            // btnArhiveLoop
            // 
            this.btnArhiveLoop.Location = new System.Drawing.Point(841, 193);
            this.btnArhiveLoop.Name = "btnArhiveLoop";
            this.btnArhiveLoop.Size = new System.Drawing.Size(101, 23);
            this.btnArhiveLoop.TabIndex = 12;
            this.btnArhiveLoop.Text = "Arhivare LISTA";
            this.btnArhiveLoop.UseVisualStyleBackColor = true;
            this.btnArhiveLoop.Click += new System.EventHandler(this.btnArhiveLoop_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 368);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(945, 18);
            this.progressBar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pacienti arhivati:";
            // 
            // lblArhivatiCount
            // 
            this.lblArhivatiCount.AutoSize = true;
            this.lblArhivatiCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArhivatiCount.Location = new System.Drawing.Point(798, 74);
            this.lblArhivatiCount.Name = "lblArhivatiCount";
            this.lblArhivatiCount.Size = new System.Drawing.Size(15, 16);
            this.lblArhivatiCount.TabIndex = 15;
            this.lblArhivatiCount.Text = "0";
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(802, 6);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(65, 23);
            this.btnSaveLocation.TabIndex = 16;
            this.btnSaveLocation.Text = "Save";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPaGReCript);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 420);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.listViewFolders);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.lblArhivatiCount);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnSaveLocation);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtBoxLocationLoad);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnArhiveLoop);
            this.tabPage1.Controls.Add(this.btnLoadFolders);
            this.tabPage1.Controls.Add(this.checkBoxDeleteFolder);
            this.tabPage1.Controls.Add(this.txtBoxArhivePac);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblPacientiGasiti);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arhivare";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.listViewRar);
            this.tabPage2.Controls.Add(this.progressBarDezarhivare);
            this.tabPage2.Controls.Add(this.lblDezarhivati);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtBoxDezRar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.btnLoadRar);
            this.tabPage2.Controls.Add(this.checkBoxStergereDupaDezRAR);
            this.tabPage2.Controls.Add(this.txtBoxLimitaDez);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lblArhiveGasite);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dezarhivare";
            // 
            // listViewRar
            // 
            this.listViewRar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewRar.HideSelection = false;
            this.listViewRar.Location = new System.Drawing.Point(11, 32);
            this.listViewRar.Name = "listViewRar";
            this.listViewRar.Size = new System.Drawing.Size(689, 331);
            this.listViewRar.TabIndex = 20;
            this.listViewRar.UseCompatibleStateImageBehavior = false;
            this.listViewRar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nume folder:";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Path";
            this.columnHeader4.Width = 776;
            // 
            // progressBarDezarhivare
            // 
            this.progressBarDezarhivare.Location = new System.Drawing.Point(6, 369);
            this.progressBarDezarhivare.Name = "progressBarDezarhivare";
            this.progressBarDezarhivare.Size = new System.Drawing.Size(945, 18);
            this.progressBarDezarhivare.TabIndex = 28;
            // 
            // lblDezarhivati
            // 
            this.lblDezarhivati.AutoSize = true;
            this.lblDezarhivati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDezarhivati.Location = new System.Drawing.Point(810, 75);
            this.lblDezarhivati.Name = "lblDezarhivati";
            this.lblDezarhivati.Size = new System.Drawing.Size(15, 16);
            this.lblDezarhivati.TabIndex = 30;
            this.lblDezarhivati.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(805, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Pacienti dezarhivati:";
            // 
            // txtBoxDezRar
            // 
            this.txtBoxDezRar.Location = new System.Drawing.Point(99, 9);
            this.txtBoxDezRar.Name = "txtBoxDezRar";
            this.txtBoxDezRar.Size = new System.Drawing.Size(700, 20);
            this.txtBoxDezRar.TabIndex = 17;
            this.txtBoxDezRar.Text = "\\\\10.200.10.65\\Archive\\XVI\\2014-12-06";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cautare arhivare:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(844, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Dezarhivare LISTA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLoadRar
            // 
            this.btnLoadRar.Location = new System.Drawing.Point(876, 7);
            this.btnLoadRar.Name = "btnLoadRar";
            this.btnLoadRar.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRar.TabIndex = 19;
            this.btnLoadRar.Text = "Load RAR";
            this.btnLoadRar.UseVisualStyleBackColor = true;
            this.btnLoadRar.Click += new System.EventHandler(this.btnLoadRar_Click);
            // 
            // checkBoxStergereDupaDezRAR
            // 
            this.checkBoxStergereDupaDezRAR.AutoSize = true;
            this.checkBoxStergereDupaDezRAR.Location = new System.Drawing.Point(709, 171);
            this.checkBoxStergereDupaDezRAR.Name = "checkBoxStergereDupaDezRAR";
            this.checkBoxStergereDupaDezRAR.Size = new System.Drawing.Size(174, 17);
            this.checkBoxStergereDupaDezRAR.TabIndex = 26;
            this.checkBoxStergereDupaDezRAR.Text = "Dupa dezarhivare sterge arhiva";
            this.checkBoxStergereDupaDezRAR.UseVisualStyleBackColor = true;
            // 
            // txtBoxLimitaDez
            // 
            this.txtBoxLimitaDez.Location = new System.Drawing.Point(813, 145);
            this.txtBoxLimitaDez.Name = "txtBoxLimitaDez";
            this.txtBoxLimitaDez.Size = new System.Drawing.Size(88, 20);
            this.txtBoxLimitaDez.TabIndex = 24;
            this.txtBoxLimitaDez.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(906, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "pacienti";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(710, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pacienti gasiti:";
            // 
            // lblArhiveGasite
            // 
            this.lblArhiveGasite.AutoSize = true;
            this.lblArhiveGasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArhiveGasite.Location = new System.Drawing.Point(810, 43);
            this.lblArhiveGasite.Name = "lblArhiveGasite";
            this.lblArhiveGasite.Size = new System.Drawing.Size(15, 16);
            this.lblArhiveGasite.TabIndex = 22;
            this.lblArhiveGasite.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(706, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Dezarhiveaza primii:";
            // 
            // tabPaGReCript
            // 
            this.tabPaGReCript.Controls.Add(this.listViewReArch);
            this.tabPaGReCript.Controls.Add(this.prgBarReArch);
            this.tabPaGReCript.Controls.Add(this.lblDoneReArch);
            this.tabPaGReCript.Controls.Add(this.btnSaveReArch);
            this.tabPaGReCript.Controls.Add(this.label11);
            this.tabPaGReCript.Controls.Add(this.txtBoxPathReArch);
            this.tabPaGReCript.Controls.Add(this.label13);
            this.tabPaGReCript.Controls.Add(this.btnReArch);
            this.tabPaGReCript.Controls.Add(this.btnLoadReArch);
            this.tabPaGReCript.Controls.Add(this.checkBoxDeleteReArch);
            this.tabPaGReCript.Controls.Add(this.txtBoxFirstReArch);
            this.tabPaGReCript.Controls.Add(this.label14);
            this.tabPaGReCript.Controls.Add(this.label15);
            this.tabPaGReCript.Controls.Add(this.lblPacAvaibleReArch);
            this.tabPaGReCript.Controls.Add(this.label17);
            this.tabPaGReCript.Location = new System.Drawing.Point(4, 22);
            this.tabPaGReCript.Name = "tabPaGReCript";
            this.tabPaGReCript.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaGReCript.Size = new System.Drawing.Size(956, 394);
            this.tabPaGReCript.TabIndex = 2;
            this.tabPaGReCript.Text = "Re-Cript arhivare";
            this.tabPaGReCript.UseVisualStyleBackColor = true;
            // 
            // listViewReArch
            // 
            this.listViewReArch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listViewReArch.HideSelection = false;
            this.listViewReArch.Location = new System.Drawing.Point(11, 32);
            this.listViewReArch.Name = "listViewReArch";
            this.listViewReArch.Size = new System.Drawing.Size(689, 331);
            this.listViewReArch.TabIndex = 35;
            this.listViewReArch.UseCompatibleStateImageBehavior = false;
            this.listViewReArch.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nume folder:";
            this.columnHeader5.Width = 137;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Path";
            this.columnHeader6.Width = 776;
            // 
            // prgBarReArch
            // 
            this.prgBarReArch.Location = new System.Drawing.Point(6, 369);
            this.prgBarReArch.Name = "prgBarReArch";
            this.prgBarReArch.Size = new System.Drawing.Size(945, 18);
            this.prgBarReArch.TabIndex = 43;
            // 
            // lblDoneReArch
            // 
            this.lblDoneReArch.AutoSize = true;
            this.lblDoneReArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoneReArch.Location = new System.Drawing.Point(810, 75);
            this.lblDoneReArch.Name = "lblDoneReArch";
            this.lblDoneReArch.Size = new System.Drawing.Size(15, 16);
            this.lblDoneReArch.TabIndex = 45;
            this.lblDoneReArch.Text = "0";
            // 
            // btnSaveReArch
            // 
            this.btnSaveReArch.Location = new System.Drawing.Point(805, 7);
            this.btnSaveReArch.Name = "btnSaveReArch";
            this.btnSaveReArch.Size = new System.Drawing.Size(65, 23);
            this.btnSaveReArch.TabIndex = 46;
            this.btnSaveReArch.Text = "Save";
            this.btnSaveReArch.UseVisualStyleBackColor = true;
            this.btnSaveReArch.Click += new System.EventHandler(this.btnSaveReArch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(710, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Pacienti re-arhivati:";
            // 
            // txtBoxPathReArch
            // 
            this.txtBoxPathReArch.Location = new System.Drawing.Point(99, 9);
            this.txtBoxPathReArch.Name = "txtBoxPathReArch";
            this.txtBoxPathReArch.Size = new System.Drawing.Size(700, 20);
            this.txtBoxPathReArch.TabIndex = 32;
            this.txtBoxPathReArch.Text = "\\\\10.200.10.65\\Archive\\XVI\\2014-12-06";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Cautare arhivare:";
            // 
            // btnReArch
            // 
            this.btnReArch.Location = new System.Drawing.Point(844, 194);
            this.btnReArch.Name = "btnReArch";
            this.btnReArch.Size = new System.Drawing.Size(101, 23);
            this.btnReArch.TabIndex = 42;
            this.btnReArch.Text = "RE-Arhivare LISTA";
            this.btnReArch.UseVisualStyleBackColor = true;
            this.btnReArch.Click += new System.EventHandler(this.btnReArch_Click);
            // 
            // btnLoadReArch
            // 
            this.btnLoadReArch.Location = new System.Drawing.Point(876, 7);
            this.btnLoadReArch.Name = "btnLoadReArch";
            this.btnLoadReArch.Size = new System.Drawing.Size(75, 23);
            this.btnLoadReArch.TabIndex = 34;
            this.btnLoadReArch.Text = "Load RAR";
            this.btnLoadReArch.UseVisualStyleBackColor = true;
            this.btnLoadReArch.Click += new System.EventHandler(this.btnLoadReArch_Click);
            // 
            // checkBoxDeleteReArch
            // 
            this.checkBoxDeleteReArch.AutoSize = true;
            this.checkBoxDeleteReArch.Location = new System.Drawing.Point(709, 171);
            this.checkBoxDeleteReArch.Name = "checkBoxDeleteReArch";
            this.checkBoxDeleteReArch.Size = new System.Drawing.Size(174, 17);
            this.checkBoxDeleteReArch.TabIndex = 41;
            this.checkBoxDeleteReArch.Text = "Dupa dezarhivare sterge arhiva";
            this.checkBoxDeleteReArch.UseVisualStyleBackColor = true;
            // 
            // txtBoxFirstReArch
            // 
            this.txtBoxFirstReArch.Location = new System.Drawing.Point(813, 145);
            this.txtBoxFirstReArch.Name = "txtBoxFirstReArch";
            this.txtBoxFirstReArch.Size = new System.Drawing.Size(88, 20);
            this.txtBoxFirstReArch.TabIndex = 39;
            this.txtBoxFirstReArch.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(906, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "pacienti";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(710, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Pacienti gasiti:";
            // 
            // lblPacAvaibleReArch
            // 
            this.lblPacAvaibleReArch.AutoSize = true;
            this.lblPacAvaibleReArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacAvaibleReArch.Location = new System.Drawing.Point(810, 43);
            this.lblPacAvaibleReArch.Name = "lblPacAvaibleReArch";
            this.lblPacAvaibleReArch.Size = new System.Drawing.Size(15, 16);
            this.lblPacAvaibleReArch.TabIndex = 37;
            this.lblPacAvaibleReArch.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(706, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Dezarhiveaza primii:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 420);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arhivare XVI - v. 1.10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPaGReCript.ResumeLayout(false);
            this.tabPaGReCript.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBoxLocationLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadFolders;
        private System.Windows.Forms.ListView listViewFolders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPacientiGasiti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxArhivePac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxDeleteFolder;
        private System.Windows.Forms.Button btnArhiveLoop;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblArhivatiCount;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewRar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ProgressBar progressBarDezarhivare;
        private System.Windows.Forms.Label lblDezarhivati;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxDezRar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLoadRar;
        private System.Windows.Forms.CheckBox checkBoxStergereDupaDezRAR;
        private System.Windows.Forms.TextBox txtBoxLimitaDez;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblArhiveGasite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPaGReCript;
        private System.Windows.Forms.ListView listViewReArch;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ProgressBar prgBarReArch;
        private System.Windows.Forms.Label lblDoneReArch;
        private System.Windows.Forms.Button btnSaveReArch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxPathReArch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnReArch;
        private System.Windows.Forms.Button btnLoadReArch;
        private System.Windows.Forms.CheckBox checkBoxDeleteReArch;
        private System.Windows.Forms.TextBox txtBoxFirstReArch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPacAvaibleReArch;
        private System.Windows.Forms.Label label17;
    }
}

