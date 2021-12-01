
namespace databaseAuto
{
    partial class Auto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciModificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ricercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ricercaVisualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt = new System.Windows.Forms.TextBox();
            this.modificaConSelezioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.inserisciModificaToolStripMenuItem,
            this.cancellaToolStripMenuItem,
            this.ricercaToolStripMenuItem,
            this.ricercaVisualizzaToolStripMenuItem,
            this.modificaConSelezioneToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // inserisciModificaToolStripMenuItem
            // 
            this.inserisciModificaToolStripMenuItem.Name = "inserisciModificaToolStripMenuItem";
            this.inserisciModificaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.inserisciModificaToolStripMenuItem.Text = "Inserisci modifica";
            this.inserisciModificaToolStripMenuItem.Click += new System.EventHandler(this.inserisciModificaToolStripMenuItem_Click);
            // 
            // cancellaToolStripMenuItem
            // 
            this.cancellaToolStripMenuItem.Name = "cancellaToolStripMenuItem";
            this.cancellaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cancellaToolStripMenuItem.Text = "Cancella";
            this.cancellaToolStripMenuItem.Click += new System.EventHandler(this.cancellaToolStripMenuItem_Click);
            // 
            // ricercaToolStripMenuItem
            // 
            this.ricercaToolStripMenuItem.Name = "ricercaToolStripMenuItem";
            this.ricercaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ricercaToolStripMenuItem.Text = "Ricerca";
            // 
            // ricercaVisualizzaToolStripMenuItem
            // 
            this.ricercaVisualizzaToolStripMenuItem.Name = "ricercaVisualizzaToolStripMenuItem";
            this.ricercaVisualizzaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ricercaVisualizzaToolStripMenuItem.Text = "Ricerca visualizza";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showListToolStripMenuItem,
            this.showTableToolStripMenuItem,
            this.showGridTableToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showListToolStripMenuItem
            // 
            this.showListToolStripMenuItem.Name = "showListToolStripMenuItem";
            this.showListToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showListToolStripMenuItem.Text = "Show list";
            this.showListToolStripMenuItem.Click += new System.EventHandler(this.showListToolStripMenuItem_Click);
            // 
            // showTableToolStripMenuItem
            // 
            this.showTableToolStripMenuItem.Name = "showTableToolStripMenuItem";
            this.showTableToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showTableToolStripMenuItem.Text = "Show table";
            this.showTableToolStripMenuItem.Click += new System.EventHandler(this.showTableToolStripMenuItem_Click);
            // 
            // showGridTableToolStripMenuItem
            // 
            this.showGridTableToolStripMenuItem.Name = "showGridTableToolStripMenuItem";
            this.showGridTableToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.showGridTableToolStripMenuItem.Text = "Show grid table";
            this.showGridTableToolStripMenuItem.Click += new System.EventHandler(this.showGridTableToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(13, 28);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(775, 285);
            this.txt.TabIndex = 1;
            // 
            // modificaConSelezioneToolStripMenuItem
            // 
            this.modificaConSelezioneToolStripMenuItem.Name = "modificaConSelezioneToolStripMenuItem";
            this.modificaConSelezioneToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.modificaConSelezioneToolStripMenuItem.Text = "Modifica con selezione";
            this.modificaConSelezioneToolStripMenuItem.Click += new System.EventHandler(this.modificaConSelezioneToolStripMenuItem_Click);
            // 
            // Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 319);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Auto";
            this.Text = "DBAUTO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciModificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ricercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ricercaVisualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaConSelezioneToolStripMenuItem;
    }
}

