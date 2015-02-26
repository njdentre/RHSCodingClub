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
        public frmMain()
        {
            InitializeComponent();

            string dbLayer = ConfigurationManager.AppSettings["databaseLayer"];

            DataTable studentResults = null;
            switch(dbLayer)
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
        }
    }
}
