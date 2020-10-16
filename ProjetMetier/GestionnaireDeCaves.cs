using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            LesCaves.Add(unNomDeCave, lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            int nbBout = 0;
            foreach(Bouteille b in LesCaves[unNomDeCave])
            {
                nbBout++;
            }
            return nbBout;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            int nbBout = 0;
            foreach (Bouteille b in LesCaves[unNomDeCave])
            {
                if (b.LeVin.LaCouleur.NomCouleur == "Rouge")
                {
                    nbBout++;
                }
            }
            return nbBout;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            double valeur=0;
            foreach (Bouteille b in LesCaves[unNomDeCave])
            {
                valeur += b.LeVin.PrixDuVin * b.QuantiteBouteille;
            }
            return valeur;
        }
    }
}
