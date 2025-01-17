namespace WinFormsApp2_school_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Nouveau = new ContextMenuStrip(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            classeToolStripMenuItem = new ToolStripMenuItem();
            etudiantToolStripMenuItem = new ToolStripMenuItem();
            rapportToolStripMenuItem = new ToolStripMenuItem();
            livreEtudiantToolStripMenuItem = new ToolStripMenuItem();
            fermerToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Nouveau
            // 
            Nouveau.Name = "Nouveau";
            Nouveau.Size = new Size(61, 4);
            Nouveau.Text = "Nouveau";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip1";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(123, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(122, 22);
            toolStripMenuItem1.Text = "Nouveau";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, rapportToolStripMenuItem, fermerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(895, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { classeToolStripMenuItem, etudiantToolStripMenuItem });
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(67, 20);
            nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // classeToolStripMenuItem
            // 
            classeToolStripMenuItem.Name = "classeToolStripMenuItem";
            classeToolStripMenuItem.Size = new Size(180, 22);
            classeToolStripMenuItem.Text = "Classe";
            classeToolStripMenuItem.Click += classeToolStripMenuItem_Click;
            // 
            // etudiantToolStripMenuItem
            // 
            etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            etudiantToolStripMenuItem.Size = new Size(180, 22);
            etudiantToolStripMenuItem.Text = "Etudiant";
            etudiantToolStripMenuItem.Click += etudiantToolStripMenuItem_Click;
            // 
            // rapportToolStripMenuItem
            // 
            rapportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { livreEtudiantToolStripMenuItem });
            rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            rapportToolStripMenuItem.Size = new Size(61, 20);
            rapportToolStripMenuItem.Text = "Rapport";
            // 
            // livreEtudiantToolStripMenuItem
            // 
            livreEtudiantToolStripMenuItem.Name = "livreEtudiantToolStripMenuItem";
            livreEtudiantToolStripMenuItem.Size = new Size(145, 22);
            livreEtudiantToolStripMenuItem.Text = "Liste etudiant";
            // 
            // fermerToolStripMenuItem
            // 
            fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            fermerToolStripMenuItem.Size = new Size(56, 20);
            fermerToolStripMenuItem.Text = "Fermer";
            fermerToolStripMenuItem.Click += fermerToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion scolaire";
            contextMenuStrip3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip Nouveau;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem rapportToolStripMenuItem;
        private ToolStripMenuItem fermerToolStripMenuItem;
        private ToolStripMenuItem classeToolStripMenuItem;
        private ToolStripMenuItem etudiantToolStripMenuItem;
        private ToolStripMenuItem livreEtudiantToolStripMenuItem;
    }
}
