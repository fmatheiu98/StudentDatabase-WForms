using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBDStudent
{
    public partial class frmModificaStudent : Form
    {
        StudentEntities db;
        public frmModificaStudent(Studenti obj)
        {
            InitializeComponent();
            db = new StudentEntities();
            studentiBindingSource.DataSource = obj;
            db.Studentis.Attach(studentiBindingSource.Current as Studenti);           
        }

        private void frmAdaugaModificaStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmModificaStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
