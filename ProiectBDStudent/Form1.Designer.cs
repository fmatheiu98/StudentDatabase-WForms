namespace ProiectBDStudent
{
    partial class Form1
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
            this.btnReincarcaBD = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bursaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReincarcaBD
            // 
            this.btnReincarcaBD.Location = new System.Drawing.Point(373, 369);
            this.btnReincarcaBD.Name = "btnReincarcaBD";
            this.btnReincarcaBD.Size = new System.Drawing.Size(115, 23);
            this.btnReincarcaBD.TabIndex = 13;
            this.btnReincarcaBD.Text = "&ReincarcaBD";
            this.btnReincarcaBD.UseVisualStyleBackColor = true;
            this.btnReincarcaBD.Click += new System.EventHandler(this.btnReincarcaBD_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(593, 369);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(75, 23);
            this.btnIesire.TabIndex = 12;
            this.btnIesire.Text = "&Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(248, 369);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 11;
            this.btnCauta.Text = "&Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(167, 369);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 10;
            this.btnSterge.Text = "&Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(86, 369);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "&Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(5, 369);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "&Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.codSDataGridViewTextBoxColumn,
            this.bursaDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.studentiBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(663, 351);
            this.dataGridView.TabIndex = 7;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // codSDataGridViewTextBoxColumn
            // 
            this.codSDataGridViewTextBoxColumn.DataPropertyName = "CodS";
            this.codSDataGridViewTextBoxColumn.HeaderText = "CodS";
            this.codSDataGridViewTextBoxColumn.Name = "codSDataGridViewTextBoxColumn";
            // 
            // bursaDataGridViewTextBoxColumn
            // 
            this.bursaDataGridViewTextBoxColumn.DataPropertyName = "Bursa";
            this.bursaDataGridViewTextBoxColumn.HeaderText = "Bursa";
            this.bursaDataGridViewTextBoxColumn.Name = "bursaDataGridViewTextBoxColumn";
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataSource = typeof(ProiectBDStudent.Studenti);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 411);
            this.Controls.Add(this.btnReincarcaBD);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReincarcaBD;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bursaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentiBindingSource;
    }
}

