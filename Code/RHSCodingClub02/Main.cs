using RHSCodingClub02.DAL;
using RHSCodingClub02.DTO;
using System;
using System.Collections.Generic;
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
        public frmMain()
        {
            InitializeComponent();

            List<StudentDTO> studentResults = StudentDAL.SearchStudent();

            grdStudent.DataSource = studentResults;
            grdStudent.Columns["Id"].Visible = false;
            grdStudent.Columns["isDeleted"].Visible = false;
            grdStudent.Columns["isNew"].Visible = false;
            grdStudent.Columns["firstName"].HeaderText = "First Name";
            grdStudent.Columns["lastName"].HeaderText = "Last Name";
        }
    }
}
