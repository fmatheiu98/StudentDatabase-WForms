namespace ProiectBDStudent
{
    partial class frmAdaugaModificaStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBursaStudent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodSStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCNPStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresaStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBursaStudent
            // 
            this.txtBursaStudent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "Bursa", true));
            this.txtBursaStudent.Location = new System.Drawing.Point(56, 139);
            this.txtBursaStudent.Name = "txtBursaStudent";
            this.txtBursaStudent.Size = new System.Drawing.Size(289, 20);
            this.txtBursaStudent.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bursa:";
            // 
            // txtCodSStudent
            // 
            this.txtCodSStudent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "CodS", true));
            this.txtCodSStudent.Location = new System.Drawing.Point(56, 113);
            this.txtCodSStudent.Name = "txtCodSStudent";
            this.txtCodSStudent.Size = new System.Drawing.Size(289, 20);
            this.txtCodSStudent.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CodS:";
            // 
            // txtCNPStudent
            // 
            this.txtCNPStudent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "CNP", true));
            this.txtCNPStudent.Location = new System.Drawing.Point(56, 87);
            this.txtCNPStudent.Name = "txtCNPStudent";
            this.txtCNPStudent.Size = new System.Drawing.Size(289, 20);
            this.txtCNPStudent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CNP:";
            // 
            // txtAdresaStudent
            // 
            this.txtAdresaStudent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "Adresa", true));
            this.txtAdresaStudent.Location = new System.Drawing.Point(56, 61);
            this.txtAdresaStudent.Name = "txtAdresaStudent";
            this.txtAdresaStudent.Size = new System.Drawing.Size(289, 20);
            this.txtAdresaStudent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adresa:";
            // 
            // txtNumeStudent
            // 
            this.txtNumeStudent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "Nume", true));
            this.txtNumeStudent.Location = new System.Drawing.Point(56, 35);
            this.txtNumeStudent.Name = "txtNumeStudent";
            this.txtNumeStudent.Size = new System.Drawing.Size(289, 20);
            this.txtNumeStudent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nume:";
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalveaza.Location = new System.Drawing.Point(270, 165);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.btnSalveaza.TabIndex = 5;
            this.btnSalveaza.Text = "&Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataSource = typeof(ProiectBDStudent.Studenti);
            // 
            // frmAdaugaModificaStudent
            // 
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 227);
            this.Controls.Add(this.txtBursaStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodSStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCNPStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresaStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalveaza);
            this.MaximizeBox = false;
            this.Name = "frmAdaugaModificaStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adauga Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdaugaModificaStudent_FormClosing);
            this.Load += new System.EventHandler(this.frmAdaugaModificaStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBursaStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodSStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCNPStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresaStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.BindingSource studentiBindingSource;
    }
}