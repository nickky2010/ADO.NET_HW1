namespace ADO.NET_HW1
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.dataGridViewSessionResults = new System.Windows.Forms.DataGridView();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            this.labelSessionResults = new System.Windows.Forms.Label();
            this.comboBoxSelectGroups = new System.Windows.Forms.ComboBox();
            this.labelSelectGroups = new System.Windows.Forms.Label();
            this.labelExcellentStudents = new System.Windows.Forms.Label();
            this.labelLosersStudents = new System.Windows.Forms.Label();
            this.labelCountExcellent = new System.Windows.Forms.Label();
            this.labelCountLosers = new System.Windows.Forms.Label();
            this.labelAddGroup = new System.Windows.Forms.Label();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.labelCuratorSurname = new System.Windows.Forms.Label();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.textBoxCuratorSurname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(446, 217);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(479, 39);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.RowTemplate.Height = 24;
            this.dataGridViewGroups.Size = new System.Drawing.Size(307, 217);
            this.dataGridViewGroups.TabIndex = 1;
            // 
            // dataGridViewSessionResults
            // 
            this.dataGridViewSessionResults.AllowUserToAddRows = false;
            this.dataGridViewSessionResults.AllowUserToDeleteRows = false;
            this.dataGridViewSessionResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessionResults.Location = new System.Drawing.Point(12, 287);
            this.dataGridViewSessionResults.Name = "dataGridViewSessionResults";
            this.dataGridViewSessionResults.RowTemplate.Height = 24;
            this.dataGridViewSessionResults.Size = new System.Drawing.Size(446, 223);
            this.dataGridViewSessionResults.TabIndex = 2;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudents.Location = new System.Drawing.Point(185, 11);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(90, 25);
            this.labelStudents.TabIndex = 3;
            this.labelStudents.Text = "Students";
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroups.Location = new System.Drawing.Point(596, 11);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(76, 25);
            this.labelGroups.TabIndex = 4;
            this.labelGroups.Text = "Groups";
            // 
            // labelSessionResults
            // 
            this.labelSessionResults.AutoSize = true;
            this.labelSessionResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSessionResults.Location = new System.Drawing.Point(157, 259);
            this.labelSessionResults.Name = "labelSessionResults";
            this.labelSessionResults.Size = new System.Drawing.Size(152, 25);
            this.labelSessionResults.TabIndex = 5;
            this.labelSessionResults.Text = "Session Results";
            // 
            // comboBoxSelectGroups
            // 
            this.comboBoxSelectGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSelectGroups.FormattingEnabled = true;
            this.comboBoxSelectGroups.Location = new System.Drawing.Point(526, 287);
            this.comboBoxSelectGroups.Name = "comboBoxSelectGroups";
            this.comboBoxSelectGroups.Size = new System.Drawing.Size(201, 33);
            this.comboBoxSelectGroups.TabIndex = 6;
            this.comboBoxSelectGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectGroups_SelectedIndexChanged);
            // 
            // labelSelectGroups
            // 
            this.labelSelectGroups.AutoSize = true;
            this.labelSelectGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectGroups.Location = new System.Drawing.Point(559, 259);
            this.labelSelectGroups.Name = "labelSelectGroups";
            this.labelSelectGroups.Size = new System.Drawing.Size(136, 25);
            this.labelSelectGroups.TabIndex = 7;
            this.labelSelectGroups.Text = "Select Groups";
            // 
            // labelExcellentStudents
            // 
            this.labelExcellentStudents.AutoSize = true;
            this.labelExcellentStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExcellentStudents.Location = new System.Drawing.Point(474, 323);
            this.labelExcellentStudents.Name = "labelExcellentStudents";
            this.labelExcellentStudents.Size = new System.Drawing.Size(148, 20);
            this.labelExcellentStudents.TabIndex = 8;
            this.labelExcellentStudents.Text = "Excellent Students";
            // 
            // labelLosersStudents
            // 
            this.labelLosersStudents.AutoSize = true;
            this.labelLosersStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLosersStudents.Location = new System.Drawing.Point(474, 348);
            this.labelLosersStudents.Name = "labelLosersStudents";
            this.labelLosersStudents.Size = new System.Drawing.Size(137, 20);
            this.labelLosersStudents.TabIndex = 9;
            this.labelLosersStudents.Text = "Losers Students ";
            // 
            // labelCountExcellent
            // 
            this.labelCountExcellent.AutoSize = true;
            this.labelCountExcellent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountExcellent.Location = new System.Drawing.Point(644, 323);
            this.labelCountExcellent.Name = "labelCountExcellent";
            this.labelCountExcellent.Size = new System.Drawing.Size(0, 20);
            this.labelCountExcellent.TabIndex = 10;
            // 
            // labelCountLosers
            // 
            this.labelCountLosers.AutoSize = true;
            this.labelCountLosers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountLosers.Location = new System.Drawing.Point(644, 348);
            this.labelCountLosers.Name = "labelCountLosers";
            this.labelCountLosers.Size = new System.Drawing.Size(0, 20);
            this.labelCountLosers.TabIndex = 11;
            // 
            // labelAddGroup
            // 
            this.labelAddGroup.AutoSize = true;
            this.labelAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddGroup.Location = new System.Drawing.Point(565, 368);
            this.labelAddGroup.Name = "labelAddGroup";
            this.labelAddGroup.Size = new System.Drawing.Size(107, 25);
            this.labelAddGroup.TabIndex = 12;
            this.labelAddGroup.Text = "Add Group";
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddGroup.Location = new System.Drawing.Point(554, 478);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(118, 32);
            this.buttonAddGroup.TabIndex = 13;
            this.buttonAddGroup.Text = "Add Group";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // labelCuratorSurname
            // 
            this.labelCuratorSurname.AutoSize = true;
            this.labelCuratorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCuratorSurname.Location = new System.Drawing.Point(474, 455);
            this.labelCuratorSurname.Name = "labelCuratorSurname";
            this.labelCuratorSurname.Size = new System.Drawing.Size(135, 20);
            this.labelCuratorSurname.TabIndex = 15;
            this.labelCuratorSurname.Text = "Curator surname";
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroupName.Location = new System.Drawing.Point(474, 410);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(101, 20);
            this.labelGroupName.TabIndex = 14;
            this.labelGroupName.Text = "Group name";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGroupName.Location = new System.Drawing.Point(615, 403);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(171, 27);
            this.textBoxGroupName.TabIndex = 16;
            // 
            // textBoxCuratorSurname
            // 
            this.textBoxCuratorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCuratorSurname.Location = new System.Drawing.Point(615, 445);
            this.textBoxCuratorSurname.Name = "textBoxCuratorSurname";
            this.textBoxCuratorSurname.Size = new System.Drawing.Size(171, 27);
            this.textBoxCuratorSurname.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 522);
            this.Controls.Add(this.textBoxCuratorSurname);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.labelCuratorSurname);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.labelAddGroup);
            this.Controls.Add(this.labelCountLosers);
            this.Controls.Add(this.labelCountExcellent);
            this.Controls.Add(this.labelLosersStudents);
            this.Controls.Add(this.labelExcellentStudents);
            this.Controls.Add(this.labelSelectGroups);
            this.Controls.Add(this.comboBoxSelectGroups);
            this.Controls.Add(this.labelSessionResults);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.dataGridViewSessionResults);
            this.Controls.Add(this.dataGridViewGroups);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.DataGridView dataGridViewSessionResults;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.Label labelSessionResults;
        private System.Windows.Forms.ComboBox comboBoxSelectGroups;
        private System.Windows.Forms.Label labelSelectGroups;
        private System.Windows.Forms.Label labelExcellentStudents;
        private System.Windows.Forms.Label labelLosersStudents;
        private System.Windows.Forms.Label labelCountExcellent;
        private System.Windows.Forms.Label labelCountLosers;
        private System.Windows.Forms.Label labelAddGroup;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label labelCuratorSurname;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.TextBox textBoxCuratorSurname;
    }
}

