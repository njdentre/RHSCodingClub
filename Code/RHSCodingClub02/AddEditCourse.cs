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
    public enum CourseOperation
    {
        Add,
        Edit
    };

    public partial class frmAddEditCourse : Form
    {
        private CourseOperation m_AddEdit;
        private int m_Id;

        public CourseOperation AddEdit
        {
            set
            {
                m_AddEdit = value;
                if (m_AddEdit == CourseOperation.Add)
                {
                    this.Text = "Add Course";
                }
                else
                {
                    this.Text = "Edit Course";
                }
            }
        }

        public int Id
        {
            set { m_Id = value; }
        }

        public string CourseName
        {
            set { txtCourseName.Text = value; }
        }

        public string Level
        {
            set { txtLevel.Text = value; }
        }

        public frmAddEditCourse()
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
            if (txtCourseName.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a course name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLevel.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a last name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (m_AddEdit == CourseOperation.Add)
            {
                LinqLayer.AddCourse(txtCourseName.Text, txtLevel.Text);
            }
            else
            {
                LinqLayer.UpdateCourse(m_Id, txtCourseName.Text, txtLevel.Text);
            }

            this.Close();
        }
    }
}
