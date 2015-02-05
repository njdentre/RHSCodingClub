namespace RHSCodingClub02
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabStudentCourse = new System.Windows.Forms.TabControl();
            this.tabPageStudentCourse = new System.Windows.Forms.TabPage();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.grdStudent = new System.Windows.Forms.DataGridView();
            this.tabPageCourse = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabStudentCourse.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RHSCodingClub02.Properties.Resources.rhs_logo_01;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabStudentCourse
            // 
            this.tabStudentCourse.Controls.Add(this.tabPageStudentCourse);
            this.tabStudentCourse.Controls.Add(this.tabPageStudent);
            this.tabStudentCourse.Controls.Add(this.tabPageCourse);
            this.tabStudentCourse.Location = new System.Drawing.Point(12, 168);
            this.tabStudentCourse.Name = "tabStudentCourse";
            this.tabStudentCourse.SelectedIndex = 0;
            this.tabStudentCourse.Size = new System.Drawing.Size(771, 368);
            this.tabStudentCourse.TabIndex = 1;
            // 
            // tabPageStudentCourse
            // 
            this.tabPageStudentCourse.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudentCourse.Name = "tabPageStudentCourse";
            this.tabPageStudentCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentCourse.Size = new System.Drawing.Size(763, 342);
            this.tabPageStudentCourse.TabIndex = 0;
            this.tabPageStudentCourse.Text = "Student / Course";
            this.tabPageStudentCourse.UseVisualStyleBackColor = true;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.Controls.Add(this.btnDelete);
            this.tabPageStudent.Controls.Add(this.btnEdit);
            this.tabPageStudent.Controls.Add(this.btnAdd);
            this.tabPageStudent.Controls.Add(this.grdStudent);
            this.tabPageStudent.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(763, 342);
            this.tabPageStudent.TabIndex = 1;
            this.tabPageStudent.Text = "Student";
            this.tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // grdStudent
            // 
            this.grdStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudent.Location = new System.Drawing.Point(6, 6);
            this.grdStudent.Name = "grdStudent";
            this.grdStudent.Size = new System.Drawing.Size(670, 330);
            this.grdStudent.TabIndex = 1;
            // 
            // tabPageCourse
            // 
            this.tabPageCourse.Location = new System.Drawing.Point(4, 22);
            this.tabPageCourse.Name = "tabPageCourse";
            this.tabPageCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourse.Size = new System.Drawing.Size(763, 342);
            this.tabPageCourse.TabIndex = 2;
            this.tabPageCourse.Text = "Course";
            this.tabPageCourse.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(682, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(682, 35);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit...";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(682, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 548);
            this.Controls.Add(this.tabStudentCourse);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "RHS Coding Club";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabStudentCourse.ResumeLayout(false);
            this.tabPageStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabStudentCourse;
        private System.Windows.Forms.TabPage tabPageStudentCourse;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.TabPage tabPageCourse;
        private System.Windows.Forms.DataGridView grdStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}

