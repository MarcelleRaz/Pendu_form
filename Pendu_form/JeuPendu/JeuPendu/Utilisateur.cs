using System;
using System.Collections.Generic;
using System.Text;

namespace JeuPendu
{
    public class Utilisateur
    {
        private string nom;
        private string[,] infoUser;
        private static int nbcard;
        public Utilisateur()
        {
            infoUser = new string[1, 4];
        }
        public string Nom { get => nom; set => nom = value; }
        public static int Nbcard { get => nbcard; set => nbcard = value; }
        public string[,] InfoUser { get => infoUser; set => infoUser = value; }
    }
}
