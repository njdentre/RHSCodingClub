using RHSCodingClub02.DAL;
using RHSCodingClub02.DTO;
using RHSCodingClub02.Linq;
using System;
using System.Collections.Generic;
using System.Configuration; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHSCodingClub02
{
    public partial class frmMain : Form
    {
        int m_NewRowIndex = -1;
        int m_grdStudent_SelectedRowIndex = -1;
        int m_grdStudent_SelectedRowId = -1;
        string m_dbLayer = ConfigurationManager.AppSettings["databaseLayer"];
        bool m_editWithGridView = ConfigurationManager.AppSettings["editWithGridView"].ToLower() == "true";
        
        public frmMain()
        {
            InitializeComponent();
            LoadStudentGrid();
            LoadCourseGrid();
            LoadStudentCourseGrid();

            //set new row index
            m_NewRowIndex = grdStudent.NewRowIndex;
        }

        #region Student Methods

        private void LoadStudentGrid()
        {
            DataTable studentResults = null;
            switch (m_dbLayer)
            {
                case "linq":
                    studentResults = LinqLayer.GetAllStudents();
                    break;
                case "lightweight":
                    studentResults = StudentDAL.SearchStudent();
                    break;
                default:
                    break;
            }

            grdStudent.DataSource = null;
            grdStudent.DataSource = studentResults;
            grdStudent.Columns["Id"].Visible = false;
            grdStudent.Columns["isDeleted"].Visible = false;
        }

        private void grdStudent_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (m_editWithGridView)
            {
                if (grdStudent.RowCount > 0)
                {
                    if (grdStudent.CurrentRow != null)
                    {
                        LinqLayer.UpdateStudentName(Convert.ToInt32(grdStudent.Rows[grdStudent.CurrentRow.Index].Cells["Id"].Value), grdStudent.Rows[grdStudent.CurrentRow.Index].Cells["First Name"].Value.ToString(), grdStudent.Rows[grdStudent.CurrentRow.Index].Cells["Last Name"].Value.ToString());
                    }
                }
            }
        }

        private void grdStudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (m_editWithGridView)
            {
                if (m_NewRowIndex < grdStudent.NewRowIndex)
                {
                    LinqLayer.AddStudent(grdStudent["First Name", m_NewRowIndex].Value.ToString(), grdStudent["Last Name", m_NewRowIndex].Value.ToString());
                    m_NewRowIndex = grdStudent.NewRowIndex;
                }
            }
        }

        private void grdStudent_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (m_editWithGridView)
            {
                if (m_grdStudent_SelectedRowId >= 0)
                {
                    LinqLayer.DeleteStudent(m_grdStudent_SelectedRowId);
                    m_grdStudent_SelectedRowId = -1;
                }
            }
        }

        private void grdStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (m_editWithGridView)
            {
                //we will use this event to allow us to track the current selected row if indeed a row is selected
                if (grdStudent.SelectedRows.Count > 0)
                {
                    m_grdStudent_SelectedRowId = Convert.ToInt32(grdStudent.Rows[grdStudent.SelectedRows[0].Index].Cells["Id"].Value);
                }
            }
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            //LinqLayer.AddStudent("Fred", "Flintstone");

            frmAddEditStudent addEditStudentForm = new frmAddEditStudent();
            addEditStudentForm.AddEdit = StudentOperation.Add;
            addEditStudentForm.Id = -1;
            addEditStudentForm.FirstName = "";
            addEditStudentForm.LastName = "";
            addEditStudentForm.ShowDialog();
            LoadStudentGrid();
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            if (grdStudent.SelectedRows.Count > 0)
            {
                frmAddEditStudent addEditStudentForm = new frmAddEditStudent();
                addEditStudentForm.AddEdit = StudentOperation.Edit;
                addEditStudentForm.Id = Convert.ToInt32(grdStudent.Rows[grdStudent.SelectedRows[0].Index].Cells["Id"].Value);
                addEditStudentForm.FirstName = grdStudent.Rows[grdStudent.SelectedRows[0].Index].Cells["First Name"].Value.ToString();
                addEditStudentForm.LastName = grdStudent.Rows[grdStudent.SelectedRows[0].Index].Cells["Last Name"].Value.ToString();
                addEditStudentForm.ShowDialog();
                LoadStudentGrid();
            }
            else
            {
                MessageBox.Show("You must select a student record to edit.", "Edit Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (grdStudent.SelectedRows.Count > 0)
            {
                LinqLayer.DeleteStudent(Convert.ToInt32(grdStudent.Rows[grdStudent.SelectedRows[0].Index].Cells["Id"].Value));
                LoadStudentGrid();
            }
            else
            {
                MessageBox.Show("You must select a student record to delete.", "Delete Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Course Methods

        private void LoadCourseGrid()
        {
            DataTable courseResults = null;
            switch (m_dbLayer)
            {
                case "linq":
                    courseResults = LinqLayer.GetAllCourses();
                    break;
                case "lightweight":
                    courseResults = StudentDAL.SearchStudent();
                    break;
                default:
                    break;
            }

            grdCourse.DataSource = null;
            grdCourse.DataSource = courseResults;
            grdCourse.Columns["Id"].Visible = false;
            grdCourse.Columns["isDeleted"].Visible = false;
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            frmAddEditCourse addEditCourseForm = new frmAddEditCourse();
            addEditCourseForm.AddEdit = CourseOperation.Add;
            addEditCourseForm.Id = -1;
            addEditCourseForm.CourseName = "";
            addEditCourseForm.Level = "";
            addEditCourseForm.ShowDialog();
            LoadCourseGrid();
        }

        private void btnCourseEdit_Click(object sender, EventArgs e)
        {
            if (grdCourse.SelectedRows.Count > 0)
            {
                frmAddEditCourse addEditCourseForm = new frmAddEditCourse();
                addEditCourseForm.AddEdit = CourseOperation.Edit;
                addEditCourseForm.Id = Convert.ToInt32(grdCourse.Rows[grdCourse.SelectedRows[0].Index].Cells["Id"].Value);
                addEditCourseForm.CourseName = grdCourse.Rows[grdCourse.SelectedRows[0].Index].Cells["Course Name"].Value.ToString();
                addEditCourseForm.Level = grdCourse.Rows[grdCourse.SelectedRows[0].Index].Cells["Level"].Value.ToString();
                addEditCourseForm.ShowDialog();
                LoadCourseGrid();
            }
            else
            {
                MessageBox.Show("You must select a course record to edit.", "Edit Course Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            if (grdCourse.SelectedRows.Count > 0)
            {
                LinqLayer.DeleteCourse(Convert.ToInt32(grdCourse.Rows[grdCourse.SelectedRows[0].Index].Cells["Id"].Value));
                LoadCourseGrid();
            }
            else
            {
                MessageBox.Show("You must select a course record to delete.", "Delete Course Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Student Course Methods

        private void LoadStudentCourseGrid()
        {
            DataTable studentCourseResults = null;
            switch (m_dbLayer)
            {
                case "linq":
                    studentCourseResults = LinqLayer.GetAllStudentCourses();
                    break;
                case "lightweight":
                    studentCourseResults = StudentDAL.SearchStudent();
                    break;
                default:
                    break;
            }

            grdStudentCourse.DataSource = null;
            grdStudentCourse.DataSource = studentCourseResults;
            grdStudentCourse.Columns["Student Name"].Width = 200;
            grdStudentCourse.Columns["Course (Level)"].Width = 200;
            grdStudentCourse.Columns["StudentCourseId"].Visible = false;
            grdStudentCourse.Columns["StudentId"].Visible = false;
            grdStudentCourse.Columns["CourseId"].Visible = false;
            grdStudentCourse.Columns["isDeleted"].Visible = false;
        }

        private void btnStudentCourseAdd_Click(object sender, EventArgs e)
        {
            frmAddEditStudentCourse addEditStudentCourseForm = new frmAddEditStudentCourse();
            addEditStudentCourseForm.AddEdit = StudentCourseOperation.Add;
            addEditStudentCourseForm.StudentCourseId = -1;
            addEditStudentCourseForm.StudentId = -1;
            addEditStudentCourseForm.CourseId = -1;
            addEditStudentCourseForm.Mark = "0";
            addEditStudentCourseForm.ShowDialog();
            LoadStudentCourseGrid();
        }

        private void btnStudentCourseEdit_Click(object sender, EventArgs e)
        {
            if (grdStudentCourse.SelectedRows.Count > 0)
            {
                frmAddEditStudentCourse addEditStudentCourseForm = new frmAddEditStudentCourse();
                addEditStudentCourseForm.AddEdit = StudentCourseOperation.Edit;
                addEditStudentCourseForm.StudentCourseId = Convert.ToInt32(grdStudentCourse.Rows[grdStudentCourse.SelectedRows[0].Index].Cells["StudentCourseId"].Value);
                addEditStudentCourseForm.StudentId = Convert.ToInt32(grdStudentCourse.Rows[grdStudentCourse.SelectedRows[0].Index].Cells["StudentId"].Value);
                addEditStudentCourseForm.CourseId = Convert.ToInt32(grdStudentCourse.Rows[grdStudentCourse.SelectedRows[0].Index].Cells["CourseId"].Value);
                addEditStudentCourseForm.Mark = grdStudentCourse.Rows[grdStudentCourse.SelectedRows[0].Index].Cells["Mark"].Value.ToString();
                addEditStudentCourseForm.ShowDialog();
                LoadStudentCourseGrid();
            }
            else
            {
                MessageBox.Show("You must select a student course record to edit.", "Edit Student Course Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStudentCourseDelete_Click(object sender, EventArgs e)
        {
            if (grdStudentCourse.SelectedRows.Count > 0)
            {
                LinqLayer.DeleteStudentCourse(Convert.ToInt32(grdStudentCourse.Rows[grdStudentCourse.SelectedRows[0].Index].Cells["StudentCourseId"].Value));
                LoadStudentCourseGrid();
            }
            else
            {
                MessageBox.Show("You must select a student course record to delete.", "Delete Student Course Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

    }
}
