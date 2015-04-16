using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RHSCodingClub02.Linq;

namespace RHSCodingClub02
{
    public enum StudentCourseOperation
    {
        Add,
        Edit
    };

    public partial class frmAddEditStudentCourse : Form
    {
        private StudentCourseOperation m_AddEdit;
        private int m_StudentCourseId;
        private int m_StudentId;
        private int m_CourseId;

        public StudentCourseOperation AddEdit
        {
            set
            {
                m_AddEdit = value;
                if (m_AddEdit == StudentCourseOperation.Add)
                {
                    this.Text = "Add Student Course";
                }
                else
                {
                    this.Text = "Edit Student Course";
                }
            }
        }

        public int StudentCourseId
        {
            set { m_StudentCourseId = value; }
        }

        public int StudentId
        {
            set
            {
                m_StudentId = value;

                DataTable dtStudentComboList = LinqLayer.GetStudentComboList();
                //if adding a new record include the select option
                if (m_StudentId == -1)
                {
                    DataRow drRow = dtStudentComboList.NewRow();
                    drRow["Id"] = -1;
                    drRow["StudentName"] = "-- Select Student Name --";
                    dtStudentComboList.Rows.InsertAt(drRow, 0);
                }
                cboStudentName.DataSource = dtStudentComboList;
                cboStudentName.DisplayMember = "StudentName";
                cboStudentName.ValueMember = "Id";

                //if editing a record set the student combobox
                if (m_StudentId != -1)
                {
                    cboStudentName.SelectedValue = m_StudentId.ToString();
                }
            }
        }

        public int CourseId
        {
            set
            {
                m_CourseId = value;

                DataTable dtCourseComboList = LinqLayer.GetCourseComboList();
                //if adding a new record include the select option
                if (m_CourseId == -1)
                {
                    DataRow drRow = dtCourseComboList.NewRow();
                    drRow["Id"] = -1;
                    drRow["NameLevel"] = "-- Select Course Name --";
                    dtCourseComboList.Rows.InsertAt(drRow, 0);
                }
                cboCourse.DataSource = dtCourseComboList;
                cboCourse.DisplayMember = "NameLevel";
                cboCourse.ValueMember = "Id";

                //if editing a record set the student combobox
                if (m_CourseId != -1)
                {
                    cboCourse.SelectedValue = m_CourseId.ToString();
                }
            }
        }

        public string Mark
        {
            set { txtMark.Text = value; }
        }

        public frmAddEditStudentCourse()
        {
            InitializeComponent();
            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboStudentName.Text.Trim() == "-- Select Student Name --")
            {
                MessageBox.Show("You must select a student name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboCourse.Text.Trim() == "-- Select Course Name --")
            {
                MessageBox.Show("You must select a course.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (m_AddEdit == StudentCourseOperation.Add)
            {
                LinqLayer.AddStudentCourse(Convert.ToInt32(cboStudentName.SelectedValue), Convert.ToInt32(cboCourse.SelectedValue), Convert.ToInt32(txtMark.Text));
            }
            else
            {
                LinqLayer.UpdateStudentCourse(m_StudentCourseId, Convert.ToInt32(cboStudentName.SelectedValue), Convert.ToInt32(cboCourse.SelectedValue), Convert.ToInt32(txtMark.Text));
            }

            this.Close();
        }
    }
}
