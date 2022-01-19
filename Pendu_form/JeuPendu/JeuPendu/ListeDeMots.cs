﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JeuPendu
{
    public class ListeDeMots
    {
        private List<string> lismots;
        public ListeDeMots()
        {
            lismots = new List<string>();
            lismots.Add("cahier");
            lismots.Add("banane");
            lismots.Add("canneberge");
            lismots.Add("butternut");
            lismots.Add("wagon");
            lismots.Add("ordinateur");
            lismots.Add("clavier");
            lismots.Add("decision");
            lismots.Add("ballader");
            lismots.Add("oxygène");
        }
        public List<string> Lismots { get => lismots; set => lismots = value; }
        public string choixdeMot(string choice)
        {
            string def = "";
            switch (choice)
            {
                case "0":
                    def="Je suis un fourniture de bureau, je perd de plus en plus mon usage avec la technologie.";
                    break;
                case "1":
                    def="Je suis un fruit, quand je suis verte, je suis est très riche en amidon, peu digeste pour l'organisme." + "\n" + "A mesure que je muri, je me recouvre de tâches et devient de plus en plus sucré.On me rencontre à longeur d'année dans les supermarchés.";
                    break;
                case "2":
                    def="Je suis un fruit rouge bien acide et très apprécié en accompagnement des repas de fête.";
                    break;
                case "3":
                    def="Je suis une courge bien sucrée quand je suis mûre.J'ai un nom en anglais.";
                    break;
                case "4":
                    def="Je suis la partie qui permet le transport dans un véhicule terrestre.";
                    break;
                case "5":
                    def="Je change de technologie bien souvent, on m'utilise de plus en plus avec le temps.";
                    break;
                case "6":
                    def="Je remplace de plus en plus le papier et le stylo, on m'utilise de plus en plus pour écrire." + "\n" + "Je suis une partie d'un tout.";
                    break;
                case "7":
                    def="Généralement on est obligé de passer par moi pour choisir. je suis un nom et non une action.";
                    break;
                case "8":
                    def="Durant les temps libres, dans les parcs, les villes, la cour, on me pratique. Je suis une action.";
                    break;
                case "9":
                    def="Je suis indispensable à tout être vivant. Je suis élémentaire et je suis partout.";
                    break;
            }
            return def;
        }
    }
}
