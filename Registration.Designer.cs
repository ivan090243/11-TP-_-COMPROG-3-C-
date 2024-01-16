namespace TASKPERFORMANCE_COMPROG3
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            this.TXTSTUDENTID = new System.Windows.Forms.TextBox();
            this.CBPROGRAM = new System.Windows.Forms.ComboBox();
            this.CBGENDER = new System.Windows.Forms.ComboBox();
            this.TXTLASTNAME = new System.Windows.Forms.TextBox();
            this.TXTFIRSTNAME = new System.Windows.Forms.TextBox();
            this.TXTMIDDLENAME = new System.Windows.Forms.TextBox();
            this.TXTAGE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DGCLUBMEMBER = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.BTREGISTER = new System.Windows.Forms.Button();
            this.BTUPDATE = new System.Windows.Forms.Button();
            this.BTREFRESH = new System.Windows.Forms.Button();
            this.clubDBDataSet = new TASKPERFORMANCE_COMPROG3.ClubDBDataSet();
            this.clubMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubMembersTableAdapter = new TASKPERFORMANCE_COMPROG3.ClubDBDataSetTableAdapters.ClubMembersTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGCLUBMEMBER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubMembersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTSTUDENTID
            // 
            this.TXTSTUDENTID.Location = new System.Drawing.Point(27, 30);
            this.TXTSTUDENTID.Name = "TXTSTUDENTID";
            this.TXTSTUDENTID.Size = new System.Drawing.Size(183, 20);
            this.TXTSTUDENTID.TabIndex = 1;
            this.TXTSTUDENTID.TextChanged += new System.EventHandler(this.TXTSTUDENTID_TextChanged);
            // 
            // CBPROGRAM
            // 
            this.CBPROGRAM.FormattingEnabled = true;
            this.CBPROGRAM.Location = new System.Drawing.Point(476, 30);
            this.CBPROGRAM.Name = "CBPROGRAM";
            this.CBPROGRAM.Size = new System.Drawing.Size(221, 21);
            this.CBPROGRAM.TabIndex = 2;
            this.CBPROGRAM.SelectedIndexChanged += new System.EventHandler(this.CBPROGRAM_SelectedIndexChanged);
            // 
            // CBGENDER
            // 
            this.CBGENDER.FormattingEnabled = true;
            this.CBGENDER.Location = new System.Drawing.Point(280, 170);
            this.CBGENDER.Name = "CBGENDER";
            this.CBGENDER.Size = new System.Drawing.Size(183, 21);
            this.CBGENDER.TabIndex = 3;
            this.CBGENDER.SelectedIndexChanged += new System.EventHandler(this.CBGENDER_SelectedIndexChanged);
            // 
            // TXTLASTNAME
            // 
            this.TXTLASTNAME.Location = new System.Drawing.Point(27, 103);
            this.TXTLASTNAME.Name = "TXTLASTNAME";
            this.TXTLASTNAME.Size = new System.Drawing.Size(183, 20);
            this.TXTLASTNAME.TabIndex = 5;
            this.TXTLASTNAME.TextChanged += new System.EventHandler(this.TXTLASTNAME_TextChanged);
            // 
            // TXTFIRSTNAME
            // 
            this.TXTFIRSTNAME.Location = new System.Drawing.Point(280, 103);
            this.TXTFIRSTNAME.Name = "TXTFIRSTNAME";
            this.TXTFIRSTNAME.Size = new System.Drawing.Size(183, 20);
            this.TXTFIRSTNAME.TabIndex = 7;
            this.TXTFIRSTNAME.TextChanged += new System.EventHandler(this.TXTFIRSTNAME_TextChanged);
            // 
            // TXTMIDDLENAME
            // 
            this.TXTMIDDLENAME.Location = new System.Drawing.Point(514, 103);
            this.TXTMIDDLENAME.Name = "TXTMIDDLENAME";
            this.TXTMIDDLENAME.Size = new System.Drawing.Size(183, 20);
            this.TXTMIDDLENAME.TabIndex = 9;
            this.TXTMIDDLENAME.TextChanged += new System.EventHandler(this.TXTMIDDLENAME_TextChanged);
            // 
            // TXTAGE
            // 
            this.TXTAGE.Location = new System.Drawing.Point(27, 170);
            this.TXTAGE.Name = "TXTAGE";
            this.TXTAGE.Size = new System.Drawing.Size(183, 20);
            this.TXTAGE.TabIndex = 13;
            this.TXTAGE.TextChanged += new System.EventHandler(this.TXTAGE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "STUDENT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "PROGRAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "LAST NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "FIRST NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "MIDDLE NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "AGE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "GENDER";
            // 
            // DGCLUBMEMBER
            // 
            this.DGCLUBMEMBER.AutoGenerateColumns = false;
            this.DGCLUBMEMBER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCLUBMEMBER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DGCLUBMEMBER.DataSource = this.clubMembersBindingSource;
            this.DGCLUBMEMBER.Location = new System.Drawing.Point(27, 226);
            this.DGCLUBMEMBER.Name = "DGCLUBMEMBER";
            this.DGCLUBMEMBER.Size = new System.Drawing.Size(844, 194);
            this.DGCLUBMEMBER.TabIndex = 21;
            this.DGCLUBMEMBER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCLUBMEMBER_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "LIST OF THE CLUB MEMBER";
            // 
            // BTREGISTER
            // 
            this.BTREGISTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTREGISTER.Location = new System.Drawing.Point(923, 12);
            this.BTREGISTER.Name = "BTREGISTER";
            this.BTREGISTER.Size = new System.Drawing.Size(98, 35);
            this.BTREGISTER.TabIndex = 23;
            this.BTREGISTER.Text = "REGISTER";
            this.BTREGISTER.UseVisualStyleBackColor = true;
            this.BTREGISTER.Click += new System.EventHandler(this.BTREGISTER_Click);
            // 
            // BTUPDATE
            // 
            this.BTUPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTUPDATE.Location = new System.Drawing.Point(923, 65);
            this.BTUPDATE.Name = "BTUPDATE";
            this.BTUPDATE.Size = new System.Drawing.Size(98, 35);
            this.BTUPDATE.TabIndex = 24;
            this.BTUPDATE.Text = "UPDATE";
            this.BTUPDATE.UseVisualStyleBackColor = true;
            this.BTUPDATE.Click += new System.EventHandler(this.BTUPDATE_Click);
            // 
            // BTREFRESH
            // 
            this.BTREFRESH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTREFRESH.Location = new System.Drawing.Point(923, 235);
            this.BTREFRESH.Name = "BTREFRESH";
            this.BTREFRESH.Size = new System.Drawing.Size(98, 35);
            this.BTREFRESH.TabIndex = 25;
            this.BTREFRESH.Text = "REFRESH";
            this.BTREFRESH.UseVisualStyleBackColor = true;
            this.BTREFRESH.Click += new System.EventHandler(this.BTREFRESH_Click);
            // 
            // clubDBDataSet
            // 
            this.clubDBDataSet.DataSetName = "ClubDBDataSet";
            this.clubDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubMembersBindingSource
            // 
            this.clubMembersBindingSource.DataMember = "ClubMembers";
            this.clubMembersBindingSource.DataSource = this.clubDBDataSet;
            // 
            // clubMembersTableAdapter
            // 
            this.clubMembersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn4.HeaderText = "MiddleName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn5.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn6.HeaderText = "Age";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Program";
            this.dataGridViewTextBoxColumn8.HeaderText = "Program";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.BTREFRESH);
            this.Controls.Add(this.BTUPDATE);
            this.Controls.Add(this.BTREGISTER);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DGCLUBMEMBER);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTAGE);
            this.Controls.Add(this.TXTMIDDLENAME);
            this.Controls.Add(this.TXTFIRSTNAME);
            this.Controls.Add(this.TXTLASTNAME);
            this.Controls.Add(this.CBGENDER);
            this.Controls.Add(this.CBPROGRAM);
            this.Controls.Add(this.TXTSTUDENTID);
            this.Name = "Registration";
            this.Text = "FRMREGISTRATION";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCLUBMEMBER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubMembersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTSTUDENTID;
        private System.Windows.Forms.ComboBox CBPROGRAM;
        private System.Windows.Forms.ComboBox CBGENDER;
        private System.Windows.Forms.TextBox TXTLASTNAME;
        private System.Windows.Forms.TextBox TXTFIRSTNAME;
        private System.Windows.Forms.TextBox TXTMIDDLENAME;
        private System.Windows.Forms.TextBox TXTAGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGCLUBMEMBER;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTREGISTER;
        private System.Windows.Forms.Button BTUPDATE;
        private System.Windows.Forms.Button BTREFRESH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramDataGridViewTextBoxColumn;
        private ClubDBDataSet clubDBDataSet;
        private System.Windows.Forms.BindingSource clubMembersBindingSource;
        private ClubDBDataSetTableAdapters.ClubMembersTableAdapter clubMembersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

