namespace ProiectBDStudent
{
    partial class CautareStudent
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
            this.btnCauta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCautCNP = new System.Windows.Forms.TextBox();
            this.studentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCauta
            // 
            this.btnCauta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCauta.Location = new System.Drawing.Point(250, 79);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 6;
            this.btnCauta.Text = "&Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dati CNP student:";
            // 
            // txtCautCNP
            // 
            this.txtCautCNP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentiBindingSource, "CNP", true));
            this.txtCautCNP.Location = new System.Drawing.Point(119, 33);
            this.txtCautCNP.Name = "txtCautCNP";
            this.txtCautCNP.Size = new System.Drawing.Size(206, 20);
            this.txtCautCNP.TabIndex = 4;
            // 
            // studentiBindingSource
            // 
            this.studentiBindingSource.DataSource = typeof(ProiectBDStudent.Studenti);
            // 
            // CautareStudent
            // 
            this.AcceptButton = this.btnCauta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 151);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCautCNP);
            this.MaximizeBox = false;
            this.Name = "CautareStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cautare Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CautareStudent_FormClosing);
            this.Load += new System.EventHandler(this.CautareStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCautCNP;
        private System.Windows.Forms.BindingSource studentiBindingSource;
    }
}