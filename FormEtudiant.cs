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
    public partial class FormEtudiant : Form
    {
        public FormEtudiant()
        {
            InitializeComponent();
        }

        private void FormEtudiant_Load(object sender, EventArgs e)
        {
            using (var db = new DbScolaireContext())
            {
                comboBox1.DataSource = db.Classes.ToList();
                comboBox1.DisplayMember = "Libelle";
                comboBox1.DisplayMember = "Id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var  db = new DbScolaireContext())
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Nom = textNom.Text;
                etudiant.Prenom= textPrenom.Text;
                etudiant.IdClasse = (int)comboBox1.SelectedValue;
                etudiant.classe = (Classe)comboBox1.SelectedItem;

                db.Etudiants.Add(etudiant);
                db.SaveChanges();
            }
        }
        public void refresh()
        {
            dataGridView1.DataSource = null;
            using (var db = new DbScolaireContext())
            {
                dataGridView1.DataSource = db.Etudiants.Select(e => new viewEtudiant { Id = e.Id, Nom = e.Nom, Prenom = e.Prenom, classe= e.classe.Libelle }).ToList();
            }
        }
    }
}
