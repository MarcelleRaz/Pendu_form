using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuPendu
{
    public partial class Form1 : Form
    {
        private int nbpartie;
        private int nbpoint;
        private int nbvictoire;
        private string nom;
        private Random rand;
        private ListeDeMots mot;
        private int essai;
        private char[] motenchar;
        private char[] motsslettre;
        private string motatrouver;

        #region constructeur
        public Form1()
        {
            InitializeComponent();
            textbienvenue.ForeColor = Color.BlueViolet;
            textbienvenue.Text = "Bienvenue dans le jeu Pendu";
            nbpartie = 0;
            nbpoint = 0;
            nbvictoire = 0;
            nom = "";
            mot = new ListeDeMots();
            rand = new Random();
        }
        #endregion
        #region start methods
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        #endregion

        #region innitialiser le jeu
        private void textname_MouseLeave(object sender, EventArgs e)
        {
            nom = textname.Text;
            MessageBox.Show("Bonjour " + nom + "!\nCliquez sur 'Nouvelle partie' pour débuter le jeu.");
        }
        private void initialiser_Click(object sender, EventArgs e)
        {
            nbpartie++;
            textbienvenue.Text = "";
            initPendu();
            jouer();
        }
        public void initPendu()
        {
            txtpartie.Text = Convert.ToString(nbpartie);
            txtpoint.Text = Convert.ToString(nbpoint);
            txtvictoire.Text = Convert.ToString(nbvictoire);
            motatrouver = "";
            essai = 0;
            motsslettre = null;
            motenchar = null;
            textlettre.Text = null;
            textmot.Text = null;
            txtmotsslettre.Text = "";
        }
        #endregion
        #region jeu
        public string jouer()
        {
            int x = rand.Next(0, 9);
            textbienvenue.ForeColor = Color.Brown;
            textbienvenue.Text = $"Je suis un mot à {mot.Lismots[x].Length} caractères";
            textdefinition.Text=mot.choixdeMot(Convert.ToString(x));
            motatrouver = mot.Lismots[x];
            motsslettre = new char[mot.Lismots[x].Length];
            motenchar = new char[mot.Lismots[x].Length];
            txtmotatrouver.Text = "Le mot à trouver est: ";
            for (int i = 0; i < mot.Lismots[x].Length; i++)
            {
                motsslettre[i] = '_';
                txtmotsslettre.Text += $"{ motsslettre[i]} ";
            }
            txtessai.Text = "Vous avez droit à 5 essais pour gagner la partie.";
            motenchar = motLettres(mot.Lismots[x]);
            return motatrouver;
        }
        public char[] motLettres(string mot)
        {
            char[] motenLettres = mot.ToCharArray();
            return motenLettres;
        }
        public char choisirlettre()
        {
            string choixlettre = textlettre.Text;
            textmot.Text = string.Empty;
            char lettre =' ';
            
            bool erreur = veriflettre(choixlettre);
            if (erreur == false)
            {
                lettre = Convert.ToChar(choixlettre);
                convertenlettre(lettre);
            }
            
            return lettre;
        }
        public bool veriflettre(string choixlettre)
        {
            bool erreur;
            if (choixlettre.All(char.IsDigit) || choixlettre.Length != 1)
            {
                erreur = true;
                erreurchoixlettre(erreur);
            }
            else
            {
                erreur = false;
            }

            return erreur;
        }
        public void erreurchoixlettre(bool erreur)
        {
            while (erreur == true)
            {
                erreur = false;
                essai--;
                txtessai.Text="Erreur de saisie. Veuillez saisir seulement une lettre!";
            }
        }
        public char[] convertenlettre(char lettre)
        {
            txtmotatrouver.Text = "Le mot à trouver est: ";
            txtmotsslettre.Text = null;
            for (int i = 0; i < motenchar.Length; i++)
            {
                if (motenchar[i] == lettre)
                {
                    motsslettre[i] = lettre;
                }
                txtmotsslettre.Text += $"{ motsslettre[i]} ";
            }
            string reponse = string.Join("", motsslettre);
            verifmot(reponse);
            return motsslettre;
        }
        public void devinerMot()
        {
            textlettre.Text = null;
            verifmot(textmot.Text);
        }
        public void verifmot(string reponse)
        {
            if (reponse != motatrouver && essai >= 5)
            {
                txtmotatrouver.Text ="Le mot était: ";
                txtmotsslettre.Text = motatrouver;
                txtessai.ForeColor = Color.Red;
                txtessai.Text="Vous êtes pendu!";
            }
            if (reponse.Equals(motatrouver))
            {
                nbpoint++;
                txtessai.Text = "Bravo! Vous avez trouvé le mot!";
                txtessai.ForeColor = Color.Green;
                nbvictoire = nbpartie / 3;
            }
            if (reponse != motatrouver && essai < 5)
            {
                txtessai.Text=$"Vous avez encore {5 - essai} essai!";
            }
        }
        #endregion
        #region valider le choix
        private void bValider_Click(object sender, EventArgs e)
        {
            if (essai < 5)
            {
                essai = essai + 1;
                if (textlettre.Text != "")
                {
                    choisirlettre();
                }
                if (textmot.Text != "" && textlettre.Text != "")
                {
                    choisirlettre();
                }
                if (textlettre.Text == "" && textmot.Text != "")
                {
                    devinerMot();
                }
            }
            else
            {
                string reponse = string.Join("", motsslettre);
                verifmot(reponse);
            }
        }
        #endregion
        #region quitter le jeu
        private void Quitter_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        #endregion
    }
}
