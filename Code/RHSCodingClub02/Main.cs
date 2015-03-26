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

        public frmMain()
        {
            InitializeComponent();

            string dbLayer = ConfigurationManager.AppSettings["databaseLayer"];

            DataTable studentResults = null;
            switch (dbLayer)
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

            grdStudent.DataSource = studentResults;
            grdStudent.Columns["Id"].Visible = false;
            grdStudent.Columns["isDeleted"].Visible = false;
            //set new row index
            m_NewRowIndex = grdStudent.NewRowIndex;
            ////set selected row index
            //m_grdStudent_SelectedRowIndex = -1;
        }

        private void grdStudent_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == m_NewRowIndex)
            //{
            //    MessageBox.Show("New data added (" + grdStudent["First Name", e.RowIndex].Value.ToString() + " " + grdStudent["Last Name", e.RowIndex].Value.ToString() + ").");
            //}
        }

        private void grdStudent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //m_NewRowIndex = grdStudent.NewRowIndex;
            if (m_NewRowIndex < grdStudent.NewRowIndex)
            {
                //MessageBox.Show("New data added (" + grdStudent["First Name", m_NewRowIndex].Value.ToString() + " " + grdStudent["Last Name", m_NewRowIndex].Value.ToString() + ").");
                LinqLayer.AddStudent(grdStudent["First Name", m_NewRowIndex].Value.ToString(), grdStudent["Last Name", m_NewRowIndex].Value.ToString());
                m_NewRowIndex = grdStudent.NewRowIndex;
            }
        }

        private void grdStudent_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (m_grdStudent_SelectedRowId >= 0)
            {
                LinqLayer.DeleteStudent(m_grdStudent_SelectedRowId);
                m_grdStudent_SelectedRowId = -1;
            }
        }

        private void grdStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (grdStudent.SelectedRows.Count > 0)
            {
                m_grdStudent_SelectedRowIndex = grdStudent.SelectedRows[0].Index;
                m_grdStudent_SelectedRowId = Convert.ToInt32(grdStudent.Rows[grdStudent.SelectedRows[0].Index].Cells["Id"].Value);
                //MessageBox.Show("Select, Row Index -> " + grdStudent.SelectedRows[0].Index.ToString() + ", Student ID - > " + grdStudent.Rows[grdStudent.SelectedRows[0].Index].Cells["Id"].Value.ToString());
            }
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            LinqLayer.AddStudent("Fred", "Flintstone");
        }
    }
}
