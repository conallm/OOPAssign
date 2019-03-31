namespace OOPAssign
{
    partial class Entry
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddLec = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowStu = new System.Windows.Forms.Button();
            this.btnShowLec = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(173, 44);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(145, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddLec
            // 
            this.btnAddLec.Location = new System.Drawing.Point(173, 90);
            this.btnAddLec.Name = "btnAddLec";
            this.btnAddLec.Size = new System.Drawing.Size(145, 23);
            this.btnAddLec.TabIndex = 3;
            this.btnAddLec.Text = "Add Lecturer";
            this.btnAddLec.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(77, 151);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(283, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search Lecturer/Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnShowStu
            // 
            this.btnShowStu.Location = new System.Drawing.Point(77, 228);
            this.btnShowStu.Name = "btnShowStu";
            this.btnShowStu.Size = new System.Drawing.Size(172, 23);
            this.btnShowStu.TabIndex = 6;
            this.btnShowStu.Text = "Show All Students";
            this.btnShowStu.UseVisualStyleBackColor = true;
            // 
            // btnShowLec
            // 
            this.btnShowLec.Location = new System.Drawing.Point(283, 228);
            this.btnShowLec.Name = "btnShowLec";
            this.btnShowLec.Size = new System.Drawing.Size(145, 23);
            this.btnShowLec.TabIndex = 7;
            this.btnShowLec.Text = "Show All Lecturers";
            this.btnShowLec.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(173, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowLec);
            this.Controls.Add(this.btnShowStu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddLec);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "AddStudent";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddLec;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowStu;
        private System.Windows.Forms.Button btnShowLec;
        private System.Windows.Forms.Button btnClose;
    }
}

