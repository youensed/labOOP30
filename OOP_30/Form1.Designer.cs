namespace OOP_30
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.tbNewDir = new System.Windows.Forms.TextBox();
            this.tbRemoveDir = new System.Windows.Forms.TextBox();
            this.tbDeleteFile = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbUpload = new System.Windows.Forms.TextBox();
            this.btnGetFileSize = new System.Windows.Forms.Button();
            this.tbnCreate = new System.Windows.Forms.Button();
            this.btnRemoveDir = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDownload = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbOldName = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.FadList = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Хост:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ім\'я користувача:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Операції з FTP";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(167, 12);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(264, 26);
            this.tbHost.TabIndex = 5;
            this.tbHost.Text = "ftp://";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(167, 44);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(264, 26);
            this.tbUser.TabIndex = 6;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(167, 76);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(264, 26);
            this.tbPass.TabIndex = 7;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbFileSize
            // 
            this.tbFileSize.Location = new System.Drawing.Point(314, 159);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.Size = new System.Drawing.Size(264, 26);
            this.tbFileSize.TabIndex = 8;
            this.tbFileSize.Text = "/";
            // 
            // tbNewDir
            // 
            this.tbNewDir.Location = new System.Drawing.Point(314, 200);
            this.tbNewDir.Name = "tbNewDir";
            this.tbNewDir.Size = new System.Drawing.Size(264, 26);
            this.tbNewDir.TabIndex = 9;
            this.tbNewDir.Text = "/";
            // 
            // tbRemoveDir
            // 
            this.tbRemoveDir.Location = new System.Drawing.Point(316, 238);
            this.tbRemoveDir.Name = "tbRemoveDir";
            this.tbRemoveDir.Size = new System.Drawing.Size(262, 26);
            this.tbRemoveDir.TabIndex = 10;
            this.tbRemoveDir.Text = "/";
            // 
            // tbDeleteFile
            // 
            this.tbDeleteFile.Location = new System.Drawing.Point(314, 282);
            this.tbDeleteFile.Name = "tbDeleteFile";
            this.tbDeleteFile.Size = new System.Drawing.Size(264, 26);
            this.tbDeleteFile.TabIndex = 11;
            this.tbDeleteFile.Text = "/";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(437, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(146, 90);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Підключитися";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbUpload
            // 
            this.tbUpload.Location = new System.Drawing.Point(313, 398);
            this.tbUpload.Name = "tbUpload";
            this.tbUpload.Size = new System.Drawing.Size(264, 26);
            this.tbUpload.TabIndex = 13;
            this.tbUpload.Text = "/";
            // 
            // btnGetFileSize
            // 
            this.btnGetFileSize.Location = new System.Drawing.Point(13, 160);
            this.btnGetFileSize.Name = "btnGetFileSize";
            this.btnGetFileSize.Size = new System.Drawing.Size(182, 26);
            this.btnGetFileSize.TabIndex = 14;
            this.btnGetFileSize.Text = "Розмір файлу";
            this.btnGetFileSize.UseVisualStyleBackColor = true;
            this.btnGetFileSize.Click += new System.EventHandler(this.btnGetFileSize_Click);
            // 
            // tbnCreate
            // 
            this.tbnCreate.Location = new System.Drawing.Point(13, 201);
            this.tbnCreate.Name = "tbnCreate";
            this.tbnCreate.Size = new System.Drawing.Size(182, 26);
            this.tbnCreate.TabIndex = 15;
            this.tbnCreate.Text = "Створити католог";
            this.tbnCreate.UseVisualStyleBackColor = true;
            this.tbnCreate.Click += new System.EventHandler(this.tbnCreate_Click);
            // 
            // btnRemoveDir
            // 
            this.btnRemoveDir.Location = new System.Drawing.Point(13, 242);
            this.btnRemoveDir.Name = "btnRemoveDir";
            this.btnRemoveDir.Size = new System.Drawing.Size(182, 26);
            this.btnRemoveDir.TabIndex = 16;
            this.btnRemoveDir.Text = "Видалити каталог";
            this.btnRemoveDir.UseVisualStyleBackColor = true;
            this.btnRemoveDir.Click += new System.EventHandler(this.btnRemoveDir_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(13, 283);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(182, 26);
            this.btnDeleteFile.TabIndex = 17;
            this.btnDeleteFile.Text = "Видалити файл";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 398);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(182, 26);
            this.btnUpload.TabIndex = 18;
            this.btnUpload.Text = "Завантажити на FTP";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Файл:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Каталог:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Каталог:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Файл:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 405);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Каталог:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 491);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Шлях:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(78, 483);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(500, 26);
            this.textBox10.TabIndex = 25;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(12, 439);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(182, 26);
            this.btnDownload.TabIndex = 27;
            this.btnDownload.Text = "Завантажити";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 446);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Файл:";
            // 
            // tbDownload
            // 
            this.tbDownload.Location = new System.Drawing.Point(313, 439);
            this.tbDownload.Name = "tbDownload";
            this.tbDownload.Size = new System.Drawing.Size(264, 26);
            this.tbDownload.TabIndex = 28;
            this.tbDownload.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 324);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 32;
            this.label12.Text = "Поточне ім\'я:";
            // 
            // tbOldName
            // 
            this.tbOldName.Location = new System.Drawing.Point(313, 324);
            this.tbOldName.Name = "tbOldName";
            this.tbOldName.Size = new System.Drawing.Size(264, 26);
            this.tbOldName.TabIndex = 31;
            this.tbOldName.Text = "/";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(13, 324);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(182, 58);
            this.btnRename.TabIndex = 30;
            this.btnRename.Text = "Перейменувати";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(313, 366);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(264, 26);
            this.tbNewName.TabIndex = 33;
            this.tbNewName.Text = "/";
            // 
            // FadList
            // 
            this.FadList.FormattingEnabled = true;
            this.FadList.ItemHeight = 19;
            this.FadList.Location = new System.Drawing.Point(590, 12);
            this.FadList.Name = "FadList";
            this.FadList.Size = new System.Drawing.Size(400, 498);
            this.FadList.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 363);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 19);
            this.label13.TabIndex = 35;
            this.label13.Text = "Нове ім\'я:";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(17, 548);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(973, 26);
            this.btnSaveSettings.TabIndex = 36;
            this.btnSaveSettings.Text = "Зберегти налаштування";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(17, 516);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(973, 26);
            this.btnLoadSettings.TabIndex = 37;
            this.btnLoadSettings.Text = "Завантажити налаштування";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 584);
            this.Controls.Add(this.btnLoadSettings);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.FadList);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbOldName);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDownload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnRemoveDir);
            this.Controls.Add(this.tbnCreate);
            this.Controls.Add(this.btnGetFileSize);
            this.Controls.Add(this.tbUpload);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbDeleteFile);
            this.Controls.Add(this.tbRemoveDir);
            this.Controls.Add(this.tbNewDir);
            this.Controls.Add(this.tbFileSize);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FtpClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbFileSize;
        private System.Windows.Forms.TextBox tbNewDir;
        private System.Windows.Forms.TextBox tbRemoveDir;
        private System.Windows.Forms.TextBox tbDeleteFile;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbUpload;
        private System.Windows.Forms.Button btnGetFileSize;
        private System.Windows.Forms.Button tbnCreate;
        private System.Windows.Forms.Button btnRemoveDir;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDownload;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbOldName;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.ListBox FadList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnLoadSettings;
    }
}

