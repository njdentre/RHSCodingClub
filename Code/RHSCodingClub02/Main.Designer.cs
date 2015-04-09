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
            this.tabStudentCourse = new System.Windows.Forms.TabControl();
            this.tabPageStudentCourse = new System.Windows.Forms.TabPage();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentEdit = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.grdStudent = new System.Windows.Forms.DataGridView();
            this.tabPageCourse = new System.Windows.Forms.TabPage();
            this.picRHS = new System.Windows.Forms.PictureBox();
            this.grdCourse = new System.Windows.Forms.DataGridView();
            this.btnCourseDelete = new System.Windows.Forms.Button();
            this.btnCourseEdit = new System.Windows.Forms.Button();
            this.btnCourseAdd = new System.Windows.Forms.Button();
            this.tabStudentCourse.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
            this.tabPageCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourse)).BeginInit();
            this.SuspendLayout();
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
            this.tabPageStudent.Controls.Add(this.btnStudentDelete);
            this.tabPageStudent.Controls.Add(this.btnStudentEdit);
            this.tabPageStudent.Controls.Add(this.btnStudentAdd);
            this.tabPageStudent.Controls.Add(this.grdStudent);
            this.tabPageStudent.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(763, 342);
            this.tabPageStudent.TabIndex = 1;
            this.tabPageStudent.Text = "Student";
            this.tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(682, 64);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStudentDelete.TabIndex = 4;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentEdit
            // 
            this.btnStudentEdit.Location = new System.Drawing.Point(682, 35);
            this.btnStudentEdit.Name = "btnStudentEdit";
            this.btnStudentEdit.Size = new System.Drawing.Size(75, 23);
            this.btnStudentEdit.TabIndex = 3;
            this.btnStudentEdit.Text = "Edit...";
            this.btnStudentEdit.UseVisualStyleBackColor = true;
            this.btnStudentEdit.Click += new System.EventHandler(this.btnStudentEdit_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(682, 6);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentAdd.TabIndex = 2;
            this.btnStudentAdd.Text = "Add...";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // grdStudent
            // 
            this.grdStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudent.Location = new System.Drawing.Point(6, 6);
            this.grdStudent.MultiSelect = false;
            this.grdStudent.Name = "grdStudent";
            this.grdStudent.Size = new System.Drawing.Size(670, 330);
            this.grdStudent.TabIndex = 1;
            this.grdStudent.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_RowEnter);
            this.grdStudent.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_RowLeave);
            this.grdStudent.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grdStudent_RowsRemoved);
            this.grdStudent.SelectionChanged += new System.EventHandler(this.grdStudent_SelectionChanged);
            // 
            // tabPageCourse
            // 
            this.tabPageCourse.Controls.Add(this.btnCourseDelete);
            this.tabPageCourse.Controls.Add(this.btnCourseEdit);
            this.tabPageCourse.Controls.Add(this.btnCourseAdd);
            this.tabPageCourse.Controls.Add(this.grdCourse);
            this.tabPageCourse.Location = new System.Drawing.Point(4, 22);
            this.tabPageCourse.Name = "tabPageCourse";
            this.tabPageCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourse.Size = new System.Drawing.Size(763, 342);
            this.tabPageCourse.TabIndex = 2;
            this.tabPageCourse.Text = "Course";
            this.tabPageCourse.UseVisualStyleBackColor = true;
            // 
            // picRHS
            // 
            this.picRHS.Image = global::RHSCodingClub02.Properties.Resources.rhs_logo_01;
            this.picRHS.Location = new System.Drawing.Point(12, 12);
            this.picRHS.Name = "picRHS";
            this.picRHS.Size = new System.Drawing.Size(771, 150);
            this.picRHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRHS.TabIndex = 0;
            this.picRHS.TabStop = false;
            // 
            // grdCourse
            // 
            this.grdCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCourse.Location = new System.Drawing.Point(6, 6);
            this.grdCourse.MultiSelect = false;
            this.grdCourse.Name = "grdCourse";
            this.grdCourse.Size = new System.Drawing.Size(670, 330);
            this.grdCourse.TabIndex = 2;
            // 
            // btnCourseDelete
            // 
            this.btnCourseDelete.Location = new System.Drawing.Point(682, 64);
            this.btnCourseDelete.Name = "btnCourseDelete";
            this.btnCourseDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCourseDelete.TabIndex = 7;
            this.btnCourseDelete.Text = "Delete";
            this.btnCourseDelete.UseVisualStyleBackColor = true;
            this.btnCourseDelete.Click += new System.EventHandler(this.btnCourseDelete_Click);
            // 
            // btnCourseEdit
            // 
            this.btnCourseEdit.Location = new System.Drawing.Point(682, 35);
            this.btnCourseEdit.Name = "btnCourseEdit";
            this.btnCourseEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCourseEdit.TabIndex = 6;
            this.btnCourseEdit.Text = "Edit...";
            this.btnCourseEdit.UseVisualStyleBackColor = true;
            this.btnCourseEdit.Click += new System.EventHandler(this.btnCourseEdit_Click);
            // 
            // btnCourseAdd
            // 
            this.btnCourseAdd.Location = new System.Drawing.Point(682, 6);
            this.btnCourseAdd.Name = "btnCourseAdd";
            this.btnCourseAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCourseAdd.TabIndex = 5;
            this.btnCourseAdd.Text = "Add...";
            this.btnCourseAdd.UseVisualStyleBackColor = true;
            this.btnCourseAdd.Click += new System.EventHandler(this.btnCourseAdd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 548);
            this.Controls.Add(this.tabStudentCourse);
            this.Controls.Add(this.picRHS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "RHS Coding Club";
            this.tabStudentCourse.ResumeLayout(false);
            this.tabPageStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).EndInit();
            this.tabPageCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRHS;
        private System.Windows.Forms.TabControl tabStudentCourse;
        private System.Windows.Forms.TabPage tabPageStudentCourse;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.TabPage tabPageCourse;
        private System.Windows.Forms.DataGridView grdStudent;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentEdit;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Button btnCourseDelete;
        private System.Windows.Forms.Button btnCourseEdit;
        private System.Windows.Forms.Button btnCourseAdd;
        private System.Windows.Forms.DataGridView grdCourse;
    }
}

