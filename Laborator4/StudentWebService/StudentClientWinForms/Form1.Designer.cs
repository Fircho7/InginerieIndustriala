namespace StudentClientWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblSpecializare;

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtSpecializare;

        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnCauta;

        private System.Windows.Forms.ListBox listBoxStudenti;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblSpecializare = new System.Windows.Forms.Label();

            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtSpecializare = new System.Windows.Forms.TextBox();

            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();

            this.listBoxStudenti = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            // lblID
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 16);
            this.lblID.Text = "ID:";

            // txtID
            this.txtID.Location = new System.Drawing.Point(130, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 22);

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(20, 60);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(47, 16);
            this.lblNume.Text = "Nume:";

            // txtNume
            this.txtNume.Location = new System.Drawing.Point(130, 57);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(220, 22);

            // lblPrenume
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(20, 95);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(65, 16);
            this.lblPrenume.Text = "Prenume:";

            // txtPrenume
            this.txtPrenume.Location = new System.Drawing.Point(130, 92);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(220, 22);

            // lblSpecializare
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.Location = new System.Drawing.Point(20, 130);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(84, 16);
            this.lblSpecializare.Text = "Specializare:";

            // txtSpecializare
            this.txtSpecializare.Location = new System.Drawing.Point(130, 127);
            this.txtSpecializare.Name = "txtSpecializare";
            this.txtSpecializare.Size = new System.Drawing.Size(220, 22);

            // btnAdauga
            this.btnAdauga.Location = new System.Drawing.Point(20, 175);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(150, 35);
            this.btnAdauga.Text = "Adaugare student";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);

            // btnAfisare
            this.btnAfisare.Location = new System.Drawing.Point(185, 175);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(150, 35);
            this.btnAfisare.Text = "Afisare studenti";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);

            // btnCauta
            this.btnCauta.Location = new System.Drawing.Point(350, 175);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(150, 35);
            this.btnCauta.Text = "Cautare student";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);

            // listBoxStudenti
            this.listBoxStudenti.FormattingEnabled = true;
            this.listBoxStudenti.ItemHeight = 16;
            this.listBoxStudenti.Location = new System.Drawing.Point(20, 230);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(620, 180);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 440);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblSpecializare);

            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtSpecializare);

            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnCauta);

            this.Controls.Add(this.listBoxStudenti);

            this.Name = "Form1";
            this.Text = "Gestionare Studenti";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}