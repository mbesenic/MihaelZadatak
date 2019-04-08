namespace MihaelZadatak
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
            this.gumbDodaj = new System.Windows.Forms.Button();
            this.spolGoveda = new System.Windows.Forms.TextBox();
            this.bojaGoveda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaGoveda = new System.Windows.Forms.ListBox();
            this.sortSpol = new System.Windows.Forms.Button();
            this.filtriranjeBoja = new System.Windows.Forms.Button();
            this.bojaFiltra = new System.Windows.Forms.TextBox();
            this.spolFiltar = new System.Windows.Forms.TextBox();
            this.filtriranjeSpola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gumbDodaj
            // 
            this.gumbDodaj.Location = new System.Drawing.Point(46, 79);
            this.gumbDodaj.Name = "gumbDodaj";
            this.gumbDodaj.Size = new System.Drawing.Size(75, 23);
            this.gumbDodaj.TabIndex = 0;
            this.gumbDodaj.Text = "Dodaj govedo";
            this.gumbDodaj.UseVisualStyleBackColor = true;
            this.gumbDodaj.Click += new System.EventHandler(this.gumbDodaj_Click);
            // 
            // spolGoveda
            // 
            this.spolGoveda.Location = new System.Drawing.Point(175, 42);
            this.spolGoveda.Name = "spolGoveda";
            this.spolGoveda.Size = new System.Drawing.Size(100, 20);
            this.spolGoveda.TabIndex = 2;
            // 
            // bojaGoveda
            // 
            this.bojaGoveda.Location = new System.Drawing.Point(36, 42);
            this.bojaGoveda.Name = "bojaGoveda";
            this.bojaGoveda.Size = new System.Drawing.Size(100, 20);
            this.bojaGoveda.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Boja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Spol:";
            // 
            // listaGoveda
            // 
            this.listaGoveda.FormattingEnabled = true;
            this.listaGoveda.Location = new System.Drawing.Point(325, 42);
            this.listaGoveda.Name = "listaGoveda";
            this.listaGoveda.Size = new System.Drawing.Size(333, 212);
            this.listaGoveda.TabIndex = 7;
            // 
            // sortSpol
            // 
            this.sortSpol.Location = new System.Drawing.Point(175, 79);
            this.sortSpol.Name = "sortSpol";
            this.sortSpol.Size = new System.Drawing.Size(144, 23);
            this.sortSpol.TabIndex = 8;
            this.sortSpol.Text = "Sortiraj po spolu";
            this.sortSpol.UseVisualStyleBackColor = true;
            this.sortSpol.Click += new System.EventHandler(this.sortSpol_Click);
            // 
            // filtriranjeBoja
            // 
            this.filtriranjeBoja.Location = new System.Drawing.Point(230, 165);
            this.filtriranjeBoja.Name = "filtriranjeBoja";
            this.filtriranjeBoja.Size = new System.Drawing.Size(75, 23);
            this.filtriranjeBoja.TabIndex = 9;
            this.filtriranjeBoja.Text = "Filtriraj boju";
            this.filtriranjeBoja.UseVisualStyleBackColor = true;
            this.filtriranjeBoja.Click += new System.EventHandler(this.filtriranjeBoja_Click);
            // 
            // bojaFiltra
            // 
            this.bojaFiltra.Location = new System.Drawing.Point(112, 167);
            this.bojaFiltra.Name = "bojaFiltra";
            this.bojaFiltra.Size = new System.Drawing.Size(100, 20);
            this.bojaFiltra.TabIndex = 10;
            // 
            // spolFiltar
            // 
            this.spolFiltar.Location = new System.Drawing.Point(112, 196);
            this.spolFiltar.Name = "spolFiltar";
            this.spolFiltar.Size = new System.Drawing.Size(100, 20);
            this.spolFiltar.TabIndex = 12;
            // 
            // filtriranjeSpola
            // 
            this.filtriranjeSpola.Location = new System.Drawing.Point(230, 194);
            this.filtriranjeSpola.Name = "filtriranjeSpola";
            this.filtriranjeSpola.Size = new System.Drawing.Size(75, 23);
            this.filtriranjeSpola.TabIndex = 11;
            this.filtriranjeSpola.Text = "Filtriraj spol";
            this.filtriranjeSpola.UseVisualStyleBackColor = true;
            this.filtriranjeSpola.Click += new System.EventHandler(this.filtriranjeSpola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 304);
            this.Controls.Add(this.spolFiltar);
            this.Controls.Add(this.filtriranjeSpola);
            this.Controls.Add(this.bojaFiltra);
            this.Controls.Add(this.filtriranjeBoja);
            this.Controls.Add(this.sortSpol);
            this.Controls.Add(this.listaGoveda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bojaGoveda);
            this.Controls.Add(this.spolGoveda);
            this.Controls.Add(this.gumbDodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbDodaj;
        private System.Windows.Forms.TextBox spolGoveda;
        private System.Windows.Forms.TextBox bojaGoveda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaGoveda;
        private System.Windows.Forms.Button sortSpol;
        private System.Windows.Forms.Button filtriranjeBoja;
        private System.Windows.Forms.TextBox bojaFiltra;
        private System.Windows.Forms.TextBox spolFiltar;
        private System.Windows.Forms.Button filtriranjeSpola;
    }
}

