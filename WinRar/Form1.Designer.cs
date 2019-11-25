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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dezarhivare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(830, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Arhivare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBoxLocationLoad
            // 
            this.txtBoxLocationLoad.Location = new System.Drawing.Point(96, 15);
            this.txtBoxLocationLoad.Name = "txtBoxLocationLoad";
            this.txtBoxLocationLoad.Size = new System.Drawing.Size(707, 20);
            this.txtBoxLocationLoad.TabIndex = 2;
            this.txtBoxLocationLoad.Text = "\\\\10.200.10.65\\Archive\\XVI\\2014-12-06";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder cautare:";
            // 
            // btnLoadFolders
            // 
            this.btnLoadFolders.Location = new System.Drawing.Point(877, 13);
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
            this.listViewFolders.Location = new System.Drawing.Point(12, 41);
            this.listViewFolders.Name = "listViewFolders";
            this.listViewFolders.Size = new System.Drawing.Size(678, 348);
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
            this.label2.Location = new System.Drawing.Point(696, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pacienti gasiti:";
            // 
            // lblPacientiGasiti
            // 
            this.lblPacientiGasiti.AutoSize = true;
            this.lblPacientiGasiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientiGasiti.Location = new System.Drawing.Point(787, 56);
            this.lblPacientiGasiti.Name = "lblPacientiGasiti";
            this.lblPacientiGasiti.Size = new System.Drawing.Size(16, 16);
            this.lblPacientiGasiti.TabIndex = 7;
            this.lblPacientiGasiti.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arhiveaza primii:";
            // 
            // txtBoxArhivePac
            // 
            this.txtBoxArhivePac.Location = new System.Drawing.Point(781, 158);
            this.txtBoxArhivePac.Name = "txtBoxArhivePac";
            this.txtBoxArhivePac.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArhivePac.TabIndex = 9;
            this.txtBoxArhivePac.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(887, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "pacienti";
            // 
            // checkBoxDeleteFolder
            // 
            this.checkBoxDeleteFolder.AutoSize = true;
            this.checkBoxDeleteFolder.Location = new System.Drawing.Point(695, 184);
            this.checkBoxDeleteFolder.Name = "checkBoxDeleteFolder";
            this.checkBoxDeleteFolder.Size = new System.Drawing.Size(162, 17);
            this.checkBoxDeleteFolder.TabIndex = 11;
            this.checkBoxDeleteFolder.Text = "Dupa arhivare sterge folderul";
            this.checkBoxDeleteFolder.UseVisualStyleBackColor = true;
            // 
            // btnArhiveLoop
            // 
            this.btnArhiveLoop.Location = new System.Drawing.Point(830, 207);
            this.btnArhiveLoop.Name = "btnArhiveLoop";
            this.btnArhiveLoop.Size = new System.Drawing.Size(101, 23);
            this.btnArhiveLoop.TabIndex = 12;
            this.btnArhiveLoop.Text = "Arhivare LISTA";
            this.btnArhiveLoop.UseVisualStyleBackColor = true;
            this.btnArhiveLoop.Click += new System.EventHandler(this.btnArhiveLoop_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 395);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(940, 18);
            this.progressBar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pacienti arhivati:";
            // 
            // lblArhivatiCount
            // 
            this.lblArhivatiCount.AutoSize = true;
            this.lblArhivatiCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArhivatiCount.Location = new System.Drawing.Point(787, 88);
            this.lblArhivatiCount.Name = "lblArhivatiCount";
            this.lblArhivatiCount.Size = new System.Drawing.Size(16, 16);
            this.lblArhivatiCount.TabIndex = 15;
            this.lblArhivatiCount.Text = "0";
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(806, 13);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(65, 23);
            this.btnSaveLocation.TabIndex = 16;
            this.btnSaveLocation.Text = "Save";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 420);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.lblArhivatiCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnArhiveLoop);
            this.Controls.Add(this.checkBoxDeleteFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxArhivePac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPacientiGasiti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewFolders);
            this.Controls.Add(this.btnLoadFolders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxLocationLoad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arhivare XVI - v. 1.04";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

