namespace Anagramme_TP2
{
    public partial class Form1 : Form
    {
        private String[] tabMots;  // tableau des mots
        private const int nbMax = 5; // nombre d'essai max (constant)
        private int nbRestant = nbMax; // nombre d'essai restant
        private String motMystere; // mot qui faut trouver
        private String motTester; // mot que je joueur à texter
        private int nbPartie = 1; // numéro de la partie
        Random rnd = new Random(); // pour utiliser random

        // fonction pour bloquer l'utilisation du bouton
        public bool Enabled { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        // initialiser le tableau des mots
        private void initialisation()
        {
            tabMots = new string[] { "ELEPHANT", "ALPHABET", "TORTUE", "VOITURE", "SOLEIL" };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialisation();
            nouvellePartie();
        }

        // mélanger le mot a trouver
        private String melanger(String chaine)
        {
            String newChaine;
            char[] caractere = chaine.ToCharArray();

            int nbLettre = chaine.Length;
            for (int i = 0; i < nbLettre; i++)
            {
                int id = rnd.Next(nbLettre);
                char caracTemp = caractere[i];
                caractere[i] = caractere[id];
                caractere[id] = caracTemp;
            }

            newChaine = new String(caractere);

            return newChaine;

        }

        // choix du mot mistere et le melanger
        private void nouvellePartie()
        {
            int id = rnd.Next(tabMots.Length);
            motMystere = tabMots[id];

            labMot.Text = melanger(motMystere);
            labNB.Text = nbMax.ToString();
            nbRestant = nbMax;

            // supprimer se qu'il se trouve dans la listBox essai et dans la textBox propostion
            lbxEssais.Items.Clear();
            txtPropo.Text = "";
        }

        // quand le mot est correct, affichage de la MessageBox
        private void motCorrect()
        {
            const string message = "Bravo, veut tu rejouer ?";
            const string caption = "Gagné !";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                nouvellePartie();
            }

        }

        // quand le mot est incorrect
        private void motIncorrect()
        {
            nbRestant--;
            labNB.Text = nbRestant.ToString();
            lbxEssais.Items.Add(motTester);

            // si plus d'essai alors proposer de rejouer
            if (nbRestant == 0)
            {
                lbxHistorique.Items.Add("Partie " + nbPartie.ToString() + " - " + motMystere + " - Perdue - 5 essais");

                string message = "Perdu!! Le mot était " + motMystere + ". Tu veux rejouer ?";
                const string caption = "Perdu !";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    nouvellePartie();
                    nbPartie++;
                }
            }
        }

        // clicker sur le bouton tester, test le mot rentrer par l'utilisateur avec le mot mystere
        private void btnTester_Click(object sender, EventArgs e)
        {
            motTester = txtPropo.Text.ToUpper();

            if (motTester == motMystere)
            {
                lbxHistorique.Items.Add("Partie " + nbPartie.ToString() + " - " + motMystere + " - Gagné - " + (6 - nbRestant).ToString() + " essais");
                motCorrect();
                nbPartie++;
            }
            else
            {
                motIncorrect();
            }

            txtPropo.Clear();
        }

        // clicker sur le bouton rejouer, affichage de la MessageBox
        private void btnRejouer_Click(object sender, EventArgs e)
        {
            string message = "Ceci annulera la partie en cours, es-tu sûr ?";
            const string caption = "Recommencer une partie";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                nouvellePartie();
                lbxHistorique.Items.Add("Partie " + nbPartie.ToString() + " - " + motMystere + " - Perdue - " + (6 - nbRestant).ToString() + " essais");
                nbPartie++;
            }
        }

        // clicker sur le bouton quitter, affichage de la MessageBox
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            const string message = "Es-tu sûr de vouloir quitter ?";
            const string caption = "Quitter le jeu";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        // textBox proposition
        private void txtPropo_TextChanged(object sender, EventArgs e)
        {
            // pour que quand on écrit ça soit directement en majuscule
            this.txtPropo.Text = txtPropo.Text.ToUpper();
            this.txtPropo.SelectionStart = this.txtPropo.Text.Length;

            // desactiver le bouton quand la textBox proposition est vide (dans la consection Enabled = false)
            if (txtPropo.Text != "")
            {
                btnTester.Enabled = true;
            }
            else
            {
                btnTester.Enabled = false;
            }
        }
    }
}