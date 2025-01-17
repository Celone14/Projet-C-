using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2_school_
{
    public partial class FormClasse : Form
    {
        public FormClasse()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            using (var db = new DbScolaireContext())
            {
                Classe classe = new Classe();
                classe.Libelle = textlibelle.Text;

                db.Classes.Add(classe);
                db.SaveChanges();
                refresh();
            }
        }
        public void refresh()
        {
            dataGridView1.DataSource = null;
            using (var db = new DbScolaireContext())
            {
                dataGridView1.DataSource = db.Classes.ToList();
            }
        }

        private void FormClasse_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
