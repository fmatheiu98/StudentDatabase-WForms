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
    public partial class CautareStudent : Form
    {
        public string sir;
        StudentEntities db;
        public CautareStudent()
        {
            InitializeComponent();
        }

        private void CautareStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtCautCNP.Text))
                {
                    MessageBox.Show("Scrieti CNP-ul studentului pe care il cautati.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCautCNP.Focus();
                    e.Cancel = true;
                    return;
                }
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void CautareStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            sir = txtCautCNP.Text;
        }
    }
}
