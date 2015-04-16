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
    public enum StudentOperation
    {
        Add,
        Edit
    };

    public partial class frmAddEditStudent : Form
    {
        private StudentOperation m_AddEdit;
        private int m_Id;

        public StudentOperation AddEdit
        {
            set
            {
                m_AddEdit = value;
                if (m_AddEdit == StudentOperation.Add)
                {
                    this.Text = "Add Student";
                }
                else
                {
                    this.Text = "Edit Student";
                }
            }
        }

        public int Id
        {
            set { m_Id = value; }
        }

        public string FirstName
        {
            set { txtFirstName.Text = value; }
        }

        public string LastName
        {
            set { txtLastName.Text = value; }
        }

        public frmAddEditStudent()
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
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a first name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a last name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (m_AddEdit == StudentOperation.Add)
            {
                LinqLayer.AddStudent(txtFirstName.Text, txtLastName.Text);
            }
            else
            {
                LinqLayer.UpdateStudentName(m_Id, txtFirstName.Text, txtLastName.Text);
            }

            this.Close();
        }
    }
}
