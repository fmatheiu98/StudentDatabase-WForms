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
    public partial class Form1 : Form
    {
        StudentEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new StudentEntities();
            studentiBindingSource.DataSource = db.Studentis.ToList();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (frmAdaugaModificaStudent frm = new frmAdaugaModificaStudent())
            {               
                if (frm.ShowDialog() == DialogResult.OK)
                    studentiBindingSource.DataSource = db.Studentis.ToList();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (studentiBindingSource.Current == null)
                return;
            using (frmModificaStudent frm = new frmModificaStudent(studentiBindingSource.Current as Studenti))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    studentiBindingSource.DataSource = db.Studentis.ToList();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (studentiBindingSource.Current != null)
            {
                if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Studentis.Remove(studentiBindingSource.Current as Studenti);
                    studentiBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            using (CautareStudent frm = new CautareStudent())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Studenti student = db.Studentis.FirstOrDefault(s => s.CNP == frm.sir);
                    if (student != null)
                    {                       
                        dataGridView.Update();
                        dataGridView.Refresh();
                        studentiBindingSource.DataSource = student;
                    }
                    else
                    {
                        MessageBox.Show("Studentul NU este in baza de date.", "Mesaj");
                    }
                }
            }
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReincarcaBD_Click(object sender, EventArgs e)
        {
            dataGridView.Update();
            dataGridView.Refresh();
            studentiBindingSource.DataSource = db.Studentis.ToList();
        }

    }
}
