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
    public partial class frmAdaugaModificaStudent : Form
    {
        StudentEntities db;
        public frmAdaugaModificaStudent()
        {
            InitializeComponent();
            db = new StudentEntities();
            studentiBindingSource.DataSource = new Studenti();          
            db.Studentis.Add(studentiBindingSource.Current as Studenti);
        }

        private void frmAdaugaModificaStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtCNPStudent.Text))
                {
                    MessageBox.Show("Scrieti CNP-ul studentului.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCNPStudent.Focus();
                    e.Cancel = true;
                    return;
                }
                if(txtCNPStudent.TextLength != 13)
                {
                    MessageBox.Show("CNP-ul trebuie sa aiba 13 cifre!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCNPStudent.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void frmAdaugaModificaStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
