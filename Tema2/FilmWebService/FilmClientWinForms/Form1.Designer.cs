namespace FilmClientWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblRating;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.TextBox txtRating;

        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnFiltreaza;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnGoleste;

        private System.Windows.Forms.ListBox listBoxFilme;

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
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();

            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();

            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnFiltreaza = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnGoleste = new System.Windows.Forms.Button();

            this.listBoxFilme = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 25);
            this.lblId.Name = "lblId";
            this.lblId.Text = "ID:";

            this.txtId.Location = new System.Drawing.Point(100, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(220, 22);

            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(20, 60);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Text = "Titlu:";

            this.txtTitlu.Location = new System.Drawing.Point(100, 57);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(220, 22);

            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(20, 95);
            this.lblGen.Name = "lblGen";
            this.lblGen.Text = "Gen:";

            this.txtGen.Location = new System.Drawing.Point(100, 92);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(220, 22);

            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(20, 130);
            this.lblAn.Name = "lblAn";
            this.lblAn.Text = "An:";

            this.txtAn.Location = new System.Drawing.Point(100, 127);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(220, 22);

            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(20, 165);
            this.lblRating.Name = "lblRating";
            this.lblRating.Text = "Rating:";

            this.txtRating.Location = new System.Drawing.Point(100, 162);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(220, 22);

            this.btnAdauga.Location = new System.Drawing.Point(350, 20);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(150, 32);
            this.btnAdauga.Text = "Adauga film";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);

            this.btnModifica.Location = new System.Drawing.Point(350, 60);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(150, 32);
            this.btnModifica.Text = "Modifica film";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);

            this.btnSterge.Location = new System.Drawing.Point(350, 100);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(150, 32);
            this.btnSterge.Text = "Sterge film";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);

            this.btnAfiseaza.Location = new System.Drawing.Point(520, 20);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(150, 32);
            this.btnAfiseaza.Text = "Afiseaza filme";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);

            this.btnFiltreaza.Location = new System.Drawing.Point(520, 60);
            this.btnFiltreaza.Name = "btnFiltreaza";
            this.btnFiltreaza.Size = new System.Drawing.Size(150, 32);
            this.btnFiltreaza.Text = "Filtreaza dupa gen";
            this.btnFiltreaza.UseVisualStyleBackColor = true;
            this.btnFiltreaza.Click += new System.EventHandler(this.btnFiltreaza_Click);

            this.btnCauta.Location = new System.Drawing.Point(520, 100);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(150, 32);
            this.btnCauta.Text = "Cauta dupa titlu";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);

            this.btnGoleste.Location = new System.Drawing.Point(520, 140);
            this.btnGoleste.Name = "btnGoleste";
            this.btnGoleste.Size = new System.Drawing.Size(150, 32);
            this.btnGoleste.Text = "Goleste campurile";
            this.btnGoleste.UseVisualStyleBackColor = true;
            this.btnGoleste.Click += new System.EventHandler(this.btnGoleste_Click);

            this.listBoxFilme.FormattingEnabled = true;
            this.listBoxFilme.ItemHeight = 16;
            this.listBoxFilme.Location = new System.Drawing.Point(20, 210);
            this.listBoxFilme.Name = "listBoxFilme";
            this.listBoxFilme.Size = new System.Drawing.Size(650, 220);
            this.listBoxFilme.SelectedIndexChanged += new System.EventHandler(this.listBoxFilme_SelectedIndexChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 460);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblRating);

            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtRating);

            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnFiltreaza);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnGoleste);

            this.Controls.Add(this.listBoxFilme);

            this.Name = "Form1";
            this.Text = "Gestionare filme";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}