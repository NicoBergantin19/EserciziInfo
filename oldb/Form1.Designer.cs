
namespace oldb
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.testcon = new System.Windows.Forms.Button();
            this.creaclienti = new System.Windows.Forms.Button();
            this.nuovocl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testcon
            // 
            this.testcon.Location = new System.Drawing.Point(570, 12);
            this.testcon.Name = "testcon";
            this.testcon.Size = new System.Drawing.Size(75, 23);
            this.testcon.TabIndex = 0;
            this.testcon.Text = "connessione";
            this.testcon.UseVisualStyleBackColor = true;
            this.testcon.Click += new System.EventHandler(this.testcon_Click);
            // 
            // creaclienti
            // 
            this.creaclienti.Location = new System.Drawing.Point(570, 67);
            this.creaclienti.Name = "creaclienti";
            this.creaclienti.Size = new System.Drawing.Size(75, 23);
            this.creaclienti.TabIndex = 1;
            this.creaclienti.Text = "clienti";
            this.creaclienti.UseVisualStyleBackColor = true;
            this.creaclienti.Click += new System.EventHandler(this.creaclienti_Click);
            // 
            // nuovocl
            // 
            this.nuovocl.Location = new System.Drawing.Point(523, 158);
            this.nuovocl.Name = "nuovocl";
            this.nuovocl.Size = new System.Drawing.Size(75, 23);
            this.nuovocl.TabIndex = 2;
            this.nuovocl.Text = "aggiungi";
            this.nuovocl.UseVisualStyleBackColor = true;
            this.nuovocl.Click += new System.EventHandler(this.nuovocl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 388);
            this.Controls.Add(this.nuovocl);
            this.Controls.Add(this.creaclienti);
            this.Controls.Add(this.testcon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testcon;
        private System.Windows.Forms.Button creaclienti;
        private System.Windows.Forms.Button nuovocl;
    }
}

