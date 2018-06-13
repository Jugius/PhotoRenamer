namespace PhotoRenamer.UserInterface
{
    partial class frmPhotoRenamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhotoRenamer));
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelDataFolder = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.lblPhotosDirectory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSepar3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangeFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSepar1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_format_BrdIdSeparator = new System.Windows.Forms.RadioButton();
            this.rad_format_BrdId = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panelDataFolder.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSeparator
            // 
            this.txtSeparator.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeparator.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSeparator.Location = new System.Drawing.Point(291, 81);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(63, 23);
            this.txtSeparator.TabIndex = 12;
            this.txtSeparator.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Разделитель (по умолчанию пробел)";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(317, 475);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 24);
            this.btnStart.TabIndex = 44;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnAbout);
            this.panel3.Controls.Add(this.btnMin);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(6, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(394, 31);
            this.panel3.TabIndex = 45;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnMin.Location = new System.Drawing.Point(309, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 31);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(66)))), ((int)(((byte)(57)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(66)))), ((int)(((byte)(57)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnClose.Location = new System.Drawing.Point(349, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDataFolder
            // 
            this.panelDataFolder.BackColor = System.Drawing.Color.Transparent;
            this.panelDataFolder.Controls.Add(this.tableLayoutPanel1);
            this.panelDataFolder.Controls.Add(this.label2);
            this.panelDataFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataFolder.Location = new System.Drawing.Point(6, 123);
            this.panelDataFolder.Name = "panelDataFolder";
            this.panelDataFolder.Padding = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.panelDataFolder.Size = new System.Drawing.Size(394, 71);
            this.panelDataFolder.TabIndex = 46;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.68929F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.310705F));
            this.tableLayoutPanel1.Controls.Add(this.btnChangeFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPhotosDirectory, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 29);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnChangeFolder
            // 
            this.btnChangeFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangeFolder.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnChangeFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeFolder.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeFolder.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnChangeFolder.Location = new System.Drawing.Point(357, 3);
            this.btnChangeFolder.Name = "btnChangeFolder";
            this.btnChangeFolder.Size = new System.Drawing.Size(23, 23);
            this.btnChangeFolder.TabIndex = 3;
            this.btnChangeFolder.Text = "...";
            this.btnChangeFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeFolder.UseVisualStyleBackColor = false;
            this.btnChangeFolder.Click += new System.EventHandler(this.btnChangeFolder_Click);
            // 
            // lblPhotosDirectory
            // 
            this.lblPhotosDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblPhotosDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhotosDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhotosDirectory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhotosDirectory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPhotosDirectory.Location = new System.Drawing.Point(3, 3);
            this.lblPhotosDirectory.Margin = new System.Windows.Forms.Padding(3);
            this.lblPhotosDirectory.Name = "lblPhotosDirectory";
            this.lblPhotosDirectory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhotosDirectory.Size = new System.Drawing.Size(348, 23);
            this.lblPhotosDirectory.TabIndex = 2;
            this.lblPhotosDirectory.Text = "Выберите папку";
            this.lblPhotosDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Папка с фотографиями подрядчика";
            // 
            // lblSepar3
            // 
            this.lblSepar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSepar3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSepar3.Location = new System.Drawing.Point(6, 121);
            this.lblSepar3.Name = "lblSepar3";
            this.lblSepar3.Size = new System.Drawing.Size(394, 2);
            this.lblSepar3.TabIndex = 47;
            this.lblSepar3.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(6, 31);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.panel4.Size = new System.Drawing.Size(394, 90);
            this.panel4.TabIndex = 48;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.65403F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.345972F));
            this.tableLayoutPanel2.Controls.Add(this.btnChangeFile, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFileName, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnChangeFile
            // 
            this.btnChangeFile.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangeFile.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnChangeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeFile.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeFile.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnChangeFile.Location = new System.Drawing.Point(357, 3);
            this.btnChangeFile.Name = "btnChangeFile";
            this.btnChangeFile.Size = new System.Drawing.Size(23, 23);
            this.btnChangeFile.TabIndex = 3;
            this.btnChangeFile.Text = "...";
            this.btnChangeFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeFile.UseVisualStyleBackColor = false;
            this.btnChangeFile.Click += new System.EventHandler(this.btnChangeFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFileName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFileName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblFileName.Location = new System.Drawing.Point(3, 3);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(3);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFileName.Size = new System.Drawing.Size(348, 23);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "Выберите файл";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Файл соответствий";
            // 
            // lblSepar1
            // 
            this.lblSepar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSepar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSepar1.Location = new System.Drawing.Point(6, 194);
            this.lblSepar1.Name = "lblSepar1";
            this.lblSepar1.Size = new System.Drawing.Size(394, 2);
            this.lblSepar1.TabIndex = 49;
            this.lblSepar1.Text = "label1";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(6, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 2);
            this.label4.TabIndex = 51;
            this.label4.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rad_format_BrdIdSeparator);
            this.panel1.Controls.Add(this.rad_format_BrdId);
            this.panel1.Controls.Add(this.txtSeparator);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 196);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.panel1.Size = new System.Drawing.Size(394, 116);
            this.panel1.TabIndex = 50;
            // 
            // rad_format_BrdIdSeparator
            // 
            this.rad_format_BrdIdSeparator.AutoSize = true;
            this.rad_format_BrdIdSeparator.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rad_format_BrdIdSeparator.Checked = true;
            this.rad_format_BrdIdSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_format_BrdIdSeparator.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rad_format_BrdIdSeparator.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rad_format_BrdIdSeparator.Location = new System.Drawing.Point(9, 58);
            this.rad_format_BrdIdSeparator.Name = "rad_format_BrdIdSeparator";
            this.rad_format_BrdIdSeparator.Size = new System.Drawing.Size(259, 18);
            this.rad_format_BrdIdSeparator.TabIndex = 3;
            this.rad_format_BrdIdSeparator.TabStop = true;
            this.rad_format_BrdIdSeparator.Text = "[# ПЛОСКОСТИ]разделитель[ТЕКСТ]";
            this.rad_format_BrdIdSeparator.UseVisualStyleBackColor = true;
            // 
            // rad_format_BrdId
            // 
            this.rad_format_BrdId.AutoSize = true;
            this.rad_format_BrdId.BackColor = System.Drawing.Color.Transparent;
            this.rad_format_BrdId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_format_BrdId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rad_format_BrdId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rad_format_BrdId.Location = new System.Drawing.Point(9, 32);
            this.rad_format_BrdId.Name = "rad_format_BrdId";
            this.rad_format_BrdId.Size = new System.Drawing.Size(128, 18);
            this.rad_format_BrdId.TabIndex = 2;
            this.rad_format_BrdId.Text = "[# ПЛОСКОСТИ]";
            this.rad_format_BrdId.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Формат имени файла для поиска:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(6, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(394, 155);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtStatus.Location = new System.Drawing.Point(7, 16);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(384, 136);
            this.txtStatus.TabIndex = 5;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAbout.Location = new System.Drawing.Point(269, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(40, 31);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "?";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmPhotoRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSepar1);
            this.Controls.Add(this.panelDataFolder);
            this.Controls.Add(this.lblSepar3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.LightSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhotoRenamer";
            this.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panelDataFolder.ResumeLayout(false);
            this.panelDataFolder.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelDataFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnChangeFolder;
        internal System.Windows.Forms.Label lblPhotosDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSepar3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnChangeFile;
        internal System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSepar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rad_format_BrdId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rad_format_BrdIdSeparator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAbout;
    }
}

