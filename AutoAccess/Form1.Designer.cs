
namespace AutoAccess
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.creaTabellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ricercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanceaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vardaTabeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENToolStripMenuItem,
            this.cHECKToolStripMenuItem,
            this.mODIFYToolStripMenuItem,
            this.cLOSEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // cHECKToolStripMenuItem
            // 
            this.cHECKToolStripMenuItem.Name = "cHECKToolStripMenuItem";
            this.cHECKToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cHECKToolStripMenuItem.Text = "CHECK";
            this.cHECKToolStripMenuItem.Click += new System.EventHandler(this.cHECKToolStripMenuItem_Click);
            // 
            // cLOSEToolStripMenuItem
            // 
            this.cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            this.cLOSEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cLOSEToolStripMenuItem.Text = "CLOSE";
            this.cLOSEToolStripMenuItem.Click += new System.EventHandler(this.cLOSEToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // mODIFYToolStripMenuItem
            // 
            this.mODIFYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaTabellaToolStripMenuItem,
            this.inserisciToolStripMenuItem,
            this.ricercaToolStripMenuItem,
            this.scanceaToolStripMenuItem,
            this.vardaTabeaToolStripMenuItem});
            this.mODIFYToolStripMenuItem.Name = "mODIFYToolStripMenuItem";
            this.mODIFYToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.mODIFYToolStripMenuItem.Text = "MODIFY";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 100);
            this.textBox1.TabIndex = 2;
            // 
            // creaTabellaToolStripMenuItem
            // 
            this.creaTabellaToolStripMenuItem.Name = "creaTabellaToolStripMenuItem";
            this.creaTabellaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creaTabellaToolStripMenuItem.Text = "Crea tabea";
            this.creaTabellaToolStripMenuItem.Click += new System.EventHandler(this.creaTabellaToolStripMenuItem_Click);
            // 
            // inserisciToolStripMenuItem
            // 
            this.inserisciToolStripMenuItem.Name = "inserisciToolStripMenuItem";
            this.inserisciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserisciToolStripMenuItem.Text = "Inserisi roba";
            this.inserisciToolStripMenuItem.Click += new System.EventHandler(this.inserisciToolStripMenuItem_Click);
            // 
            // ricercaToolStripMenuItem
            // 
            this.ricercaToolStripMenuItem.Name = "ricercaToolStripMenuItem";
            this.ricercaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ricercaToolStripMenuItem.Text = "Serca roba";
            this.ricercaToolStripMenuItem.Click += new System.EventHandler(this.ricercaToolStripMenuItem_Click);
            // 
            // scanceaToolStripMenuItem
            // 
            this.scanceaToolStripMenuItem.Name = "scanceaToolStripMenuItem";
            this.scanceaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scanceaToolStripMenuItem.Text = "Scancea";
            this.scanceaToolStripMenuItem.Click += new System.EventHandler(this.scanceaToolStripMenuItem_Click);
            // 
            // vardaTabeaToolStripMenuItem
            // 
            this.vardaTabeaToolStripMenuItem.Name = "vardaTabeaToolStripMenuItem";
            this.vardaTabeaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vardaTabeaToolStripMenuItem.Text = "Varda tabea";
            this.vardaTabeaToolStripMenuItem.Click += new System.EventHandler(this.vardaTabeaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 153);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHECKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem creaTabellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ricercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanceaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vardaTabeaToolStripMenuItem;
    }
}

