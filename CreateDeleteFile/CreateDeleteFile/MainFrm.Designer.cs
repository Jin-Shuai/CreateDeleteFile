namespace CreateDeleteFile
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudNightSecond = new System.Windows.Forms.NumericUpDown();
            this.nudNightMinute = new System.Windows.Forms.NumericUpDown();
            this.nudNightHour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNightDay = new System.Windows.Forms.TextBox();
            this.tbNightMonth = new System.Windows.Forms.TextBox();
            this.tbNightYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDaySecond = new System.Windows.Forms.NumericUpDown();
            this.nudDayMinute = new System.Windows.Forms.NumericUpDown();
            this.nudDayHour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDayDay = new System.Windows.Forms.TextBox();
            this.tbDayMonth = new System.Windows.Forms.TextBox();
            this.tbDayYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCreatePath = new System.Windows.Forms.TextBox();
            this.btnCreatePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTotalCapacity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCapacitySize = new System.Windows.Forms.TextBox();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGetWeight = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.nudRAM = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSelectFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tmrPath = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNightSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNightMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNightHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaySecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayHour)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1177, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudNightSecond);
            this.groupBox1.Controls.Add(this.nudNightMinute);
            this.groupBox1.Controls.Add(this.nudNightHour);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNightDay);
            this.groupBox1.Controls.Add(this.tbNightMonth);
            this.groupBox1.Controls.Add(this.tbNightYear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudDaySecond);
            this.groupBox1.Controls.Add(this.nudDayMinute);
            this.groupBox1.Controls.Add(this.nudDayHour);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDayDay);
            this.groupBox1.Controls.Add(this.tbDayMonth);
            this.groupBox1.Controls.Add(this.tbDayYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCreatePath);
            this.groupBox1.Controls.Add(this.btnCreatePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "定时创建文件";
            // 
            // nudNightSecond
            // 
            this.nudNightSecond.Location = new System.Drawing.Point(411, 322);
            this.nudNightSecond.Name = "nudNightSecond";
            this.nudNightSecond.Size = new System.Drawing.Size(86, 34);
            this.nudNightSecond.TabIndex = 19;
            // 
            // nudNightMinute
            // 
            this.nudNightMinute.Location = new System.Drawing.Point(275, 322);
            this.nudNightMinute.Name = "nudNightMinute";
            this.nudNightMinute.Size = new System.Drawing.Size(86, 34);
            this.nudNightMinute.TabIndex = 18;
            // 
            // nudNightHour
            // 
            this.nudNightHour.Location = new System.Drawing.Point(145, 322);
            this.nudNightHour.Name = "nudNightHour";
            this.nudNightHour.Size = new System.Drawing.Size(86, 34);
            this.nudNightHour.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "时        分         秒";
            // 
            // tbNightDay
            // 
            this.tbNightDay.Enabled = false;
            this.tbNightDay.Location = new System.Drawing.Point(409, 271);
            this.tbNightDay.Name = "tbNightDay";
            this.tbNightDay.Size = new System.Drawing.Size(86, 34);
            this.tbNightDay.TabIndex = 15;
            // 
            // tbNightMonth
            // 
            this.tbNightMonth.Enabled = false;
            this.tbNightMonth.Location = new System.Drawing.Point(275, 271);
            this.tbNightMonth.Name = "tbNightMonth";
            this.tbNightMonth.Size = new System.Drawing.Size(86, 34);
            this.tbNightMonth.TabIndex = 14;
            // 
            // tbNightYear
            // 
            this.tbNightYear.Enabled = false;
            this.tbNightYear.Location = new System.Drawing.Point(145, 270);
            this.tbNightYear.Name = "tbNightYear";
            this.tbNightYear.Size = new System.Drawing.Size(86, 34);
            this.tbNightYear.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "年        月         日";
            // 
            // nudDaySecond
            // 
            this.nudDaySecond.Location = new System.Drawing.Point(411, 206);
            this.nudDaySecond.Name = "nudDaySecond";
            this.nudDaySecond.Size = new System.Drawing.Size(86, 34);
            this.nudDaySecond.TabIndex = 11;
            // 
            // nudDayMinute
            // 
            this.nudDayMinute.Location = new System.Drawing.Point(275, 206);
            this.nudDayMinute.Name = "nudDayMinute";
            this.nudDayMinute.Size = new System.Drawing.Size(86, 34);
            this.nudDayMinute.TabIndex = 10;
            // 
            // nudDayHour
            // 
            this.nudDayHour.Location = new System.Drawing.Point(145, 206);
            this.nudDayHour.Name = "nudDayHour";
            this.nudDayHour.Size = new System.Drawing.Size(86, 34);
            this.nudDayHour.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "时        分         秒";
            // 
            // tbDayDay
            // 
            this.tbDayDay.Enabled = false;
            this.tbDayDay.Location = new System.Drawing.Point(409, 155);
            this.tbDayDay.Name = "tbDayDay";
            this.tbDayDay.Size = new System.Drawing.Size(86, 34);
            this.tbDayDay.TabIndex = 7;
            // 
            // tbDayMonth
            // 
            this.tbDayMonth.Enabled = false;
            this.tbDayMonth.Location = new System.Drawing.Point(275, 155);
            this.tbDayMonth.Name = "tbDayMonth";
            this.tbDayMonth.Size = new System.Drawing.Size(86, 34);
            this.tbDayMonth.TabIndex = 6;
            // 
            // tbDayYear
            // 
            this.tbDayYear.Enabled = false;
            this.tbDayYear.Location = new System.Drawing.Point(145, 154);
            this.tbDayYear.Name = "tbDayYear";
            this.tbDayYear.Size = new System.Drawing.Size(86, 34);
            this.tbDayYear.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "年        月         日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 144);
            this.label2.TabIndex = 3;
            this.label2.Text = "白班时间: \r\n\r\n\r\n\r\n\r\n夜班时间:";
            // 
            // tbCreatePath
            // 
            this.tbCreatePath.Enabled = false;
            this.tbCreatePath.Location = new System.Drawing.Point(157, 47);
            this.tbCreatePath.Name = "tbCreatePath";
            this.tbCreatePath.Size = new System.Drawing.Size(276, 34);
            this.tbCreatePath.TabIndex = 2;
            // 
            // btnCreatePath
            // 
            this.btnCreatePath.Location = new System.Drawing.Point(439, 47);
            this.btnCreatePath.Name = "btnCreatePath";
            this.btnCreatePath.Size = new System.Drawing.Size(89, 34);
            this.btnCreatePath.TabIndex = 1;
            this.btnCreatePath.Text = "...";
            this.btnCreatePath.UseVisualStyleBackColor = true;
            this.btnCreatePath.Click += new System.EventHandler(this.btnCreatePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件路劲:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTotalCapacity);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbCapacitySize);
            this.groupBox2.Controls.Add(this.tbCapacity);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnGetWeight);
            this.groupBox2.Controls.Add(this.btnSet);
            this.groupBox2.Controls.Add(this.nudDay);
            this.groupBox2.Controls.Add(this.nudRAM);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbSelectFile);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(591, 3);
            this.groupBox2.MaximumSize = new System.Drawing.Size(580, 480);
            this.groupBox2.MinimumSize = new System.Drawing.Size(580, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 480);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "根据硬盘容量删除文件";
            // 
            // tbTotalCapacity
            // 
            this.tbTotalCapacity.Enabled = false;
            this.tbTotalCapacity.Location = new System.Drawing.Point(137, 94);
            this.tbTotalCapacity.Name = "tbTotalCapacity";
            this.tbTotalCapacity.Size = new System.Drawing.Size(142, 34);
            this.tbTotalCapacity.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "磁盘容量:";
            // 
            // tbCapacitySize
            // 
            this.tbCapacitySize.Enabled = false;
            this.tbCapacitySize.Location = new System.Drawing.Point(137, 155);
            this.tbCapacitySize.Name = "tbCapacitySize";
            this.tbCapacitySize.Size = new System.Drawing.Size(142, 34);
            this.tbCapacitySize.TabIndex = 27;
            // 
            // tbCapacity
            // 
            this.tbCapacity.Enabled = false;
            this.tbCapacity.Location = new System.Drawing.Point(421, 94);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(149, 34);
            this.tbCapacity.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "剩余容量:";
            // 
            // btnGetWeight
            // 
            this.btnGetWeight.Location = new System.Drawing.Point(290, 146);
            this.btnGetWeight.Name = "btnGetWeight";
            this.btnGetWeight.Size = new System.Drawing.Size(280, 49);
            this.btnGetWeight.TabIndex = 22;
            this.btnGetWeight.Text = "获取文件大小";
            this.btnGetWeight.UseVisualStyleBackColor = true;
            this.btnGetWeight.Click += new System.EventHandler(this.btnGetWeight_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(12, 311);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(168, 49);
            this.btnSet.TabIndex = 21;
            this.btnSet.Text = "保存设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(63, 255);
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(86, 34);
            this.nudDay.TabIndex = 20;
            // 
            // nudRAM
            // 
            this.nudRAM.Location = new System.Drawing.Point(190, 208);
            this.nudRAM.Name = "nudRAM";
            this.nudRAM.Size = new System.Drawing.Size(86, 34);
            this.nudRAM.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(428, 72);
            this.label9.TabIndex = 10;
            this.label9.Text = "磁盘空间小于         G 时自动删除\r\n\r\n前         天前的文件!";
            // 
            // tbSelectFile
            // 
            this.tbSelectFile.Enabled = false;
            this.tbSelectFile.Location = new System.Drawing.Point(187, 40);
            this.tbSelectFile.Name = "tbSelectFile";
            this.tbSelectFile.Size = new System.Drawing.Size(319, 34);
            this.tbSelectFile.TabIndex = 8;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(512, 38);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(58, 34);
            this.btnSelectFile.TabIndex = 7;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "文件大小:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "选择图像文件:";
            // 
            // tmrPath
            // 
            this.tmrPath.Tick += new System.EventHandler(this.tmrPath_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1195, 530);
            this.MinimumSize = new System.Drawing.Size(1195, 530);
            this.Name = "MainFrm";
            this.Text = "文件操作";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNightSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNightMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNightHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaySecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayHour)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDayYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCreatePath;
        private System.Windows.Forms.Button btnCreatePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNightSecond;
        private System.Windows.Forms.NumericUpDown nudNightMinute;
        private System.Windows.Forms.NumericUpDown nudNightHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNightDay;
        private System.Windows.Forms.TextBox tbNightMonth;
        private System.Windows.Forms.TextBox tbNightYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDaySecond;
        private System.Windows.Forms.NumericUpDown nudDayMinute;
        private System.Windows.Forms.NumericUpDown nudDayHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDayDay;
        private System.Windows.Forms.TextBox tbDayMonth;
        private System.Windows.Forms.NumericUpDown nudRAM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSelectFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.Timer tmrPath;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGetWeight;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCapacitySize;
        private System.Windows.Forms.TextBox tbTotalCapacity;
        private System.Windows.Forms.Label label12;
    }
}

