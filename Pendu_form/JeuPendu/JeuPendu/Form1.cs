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
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private void initialiser_Click(object sender, EventArgs e)
        {
            nbpartie++;
            textname.Text=
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
            textlettre.Enabled=false;
            textmot.Enabled = false;
        }
        public string jouer()
        {
            nom = textname.Text;
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
            txtessai.Text = $"vous avez {5 - essai} essai pour deviner votre mot à {motatrouver.Length} caractères";
            string choixlettre = textlettre.Text;
            bool erreur = veriflettre(choixlettre);
            char lettre = ' ';
            while (erreur == true)
            {
                choixlettre = Console.ReadLine();
                erreur = veriflettre(choixlettre);
            }
            if (erreur == false)
            {
                lettre = Convert.ToChar(choixlettre);
                convertenlettre(lettre);
            }
            essai++;
            return lettre;
        }
        public bool veriflettre(string choixlettre)
        {
            bool erreur;
            if (choixlettre.All(char.IsDigit) || choixlettre.Length > 1 || choixlettre == null)
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
                texterreur.Text="Erreur de saisie. Veuillez saisir seulement une lettre:";
            }
        }
        public char[] convertenlettre(char lettre)
        {
            txtmotatrouver.Text = "Le mot à trouver est: ";
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
            txtessai.Text = $"vous avez {5 - essai} essai pour deviner votre mot à {motatrouver.Length} caractères";
            for (int i = 0; i < motsslettre.Count(); i++)
            {
                txtmotsslettre.Text+= motsslettre[i] + " ";
            }
            essai++;
            verifmot(textmot.Text);
        }
        public void verifmot(string reponse)
        {
            if (reponse != motatrouver && essai == 4)
            {
                txtmotatrouver.Text ="Le mot était: " + motatrouver;
                texterreur.Text="Vous êtes pendu!";
                initPendu();
            }
            if (reponse.Equals(motatrouver))
            {
                nbpoint++;
                texterreur.Text = "Bravo! Vous avez trouvé le mot!";
                texterreur.ForeColor = Color.Green;
                nbvictoire = nbpartie / 3;
                initPendu();
            }
            if (reponse != motatrouver && essai < 5)
            {
                texterreur.Text=$"Vous avez encore {5 - essai} essai!";
            }
        }
        private void Quitter_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void radioLettre_CheckedChanged(object sender, EventArgs e)
        {
            //this.Controls.Add(textlettre);
            textlettre.Enabled = true;
            choisirlettre();
        }

        private void radiomot_CheckedChanged(object sender, EventArgs e)
        {
            //this.Controls.Add(textmot);
            textlettre.Enabled = false;
            devinerMot();
        }
    }
}
