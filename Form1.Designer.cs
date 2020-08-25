namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serachBox = new System.Windows.Forms.TextBox();
            this.NameBOX = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.GradeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.studentID = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lineNum = new System.Windows.Forms.Label();
            this.PRE = new System.Windows.Forms.Button();
            this.NEXT = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(963, 51);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(116, 28);
            this.search.TabIndex = 0;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(707, 519);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // serachBox
            // 
            this.serachBox.Location = new System.Drawing.Point(765, 53);
            this.serachBox.Name = "serachBox";
            this.serachBox.Size = new System.Drawing.Size(192, 28);
            this.serachBox.TabIndex = 2;
            this.serachBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serachBox_KeyDown);
            // 
            // NameBOX
            // 
            this.NameBOX.Location = new System.Drawing.Point(767, 279);
            this.NameBOX.Name = "NameBOX";
            this.NameBOX.Size = new System.Drawing.Size(100, 28);
            this.NameBOX.TabIndex = 3;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(873, 279);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(100, 28);
            this.AgeBox.TabIndex = 4;
            // 
            // GradeBox
            // 
            this.GradeBox.Location = new System.Drawing.Point(979, 279);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(100, 28);
            this.GradeBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(976, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grade";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(767, 342);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(102, 51);
            this.Insert.TabIndex = 9;
            this.Insert.Text = "insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(873, 342);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 51);
            this.update.TabIndex = 10;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.BackColor = System.Drawing.SystemColors.Control;
            this.studentID.Location = new System.Drawing.Point(1092, 396);
            this.studentID.Name = "studentID";
            this.studentID.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.studentID.Size = new System.Drawing.Size(44, 48);
            this.studentID.TabIndex = 11;
            this.studentID.Text = "label";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(979, 342);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 50);
            this.delete.TabIndex = 12;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(762, 169);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label4.Size = new System.Drawing.Size(68, 48);
            this.label4.TabIndex = 13;
            this.label4.Text = "행 번호";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(836, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11F);
            this.label5.Location = new System.Drawing.Point(765, 98);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "range";
            // 
            // lineNum
            // 
            this.lineNum.AutoSize = true;
            this.lineNum.Location = new System.Drawing.Point(836, 184);
            this.lineNum.Name = "lineNum";
            this.lineNum.Size = new System.Drawing.Size(54, 18);
            this.lineNum.TabIndex = 16;
            this.lineNum.Text = "label6";
            // 
            // PRE
            // 
            this.PRE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PRE.Location = new System.Drawing.Point(157, 551);
            this.PRE.Name = "PRE";
            this.PRE.Size = new System.Drawing.Size(132, 55);
            this.PRE.TabIndex = 17;
            this.PRE.Text = "PRE";
            this.PRE.UseVisualStyleBackColor = true;
            this.PRE.Click += new System.EventHandler(this.PRE_Click);
            // 
            // NEXT
            // 
            this.NEXT.Location = new System.Drawing.Point(402, 551);
            this.NEXT.Name = "NEXT";
            this.NEXT.Size = new System.Drawing.Size(132, 55);
            this.NEXT.TabIndex = 18;
            this.NEXT.Text = "NEXT";
            this.NEXT.UseVisualStyleBackColor = true;
            this.NEXT.Click += new System.EventHandler(this.NEXT_Click);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(668, 561);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(54, 18);
            this.labelPage.TabIndex = 19;
            this.labelPage.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 633);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.NEXT);
            this.Controls.Add(this.PRE);
            this.Controls.Add(this.lineNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GradeBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.NameBOX);
            this.Controls.Add(this.serachBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox serachBox;
        private System.Windows.Forms.TextBox NameBOX;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox GradeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lineNum;
        private System.Windows.Forms.Button PRE;
        private System.Windows.Forms.Button NEXT;
        private System.Windows.Forms.Label labelPage;
    }
}

