using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoClasses.Classes
{
    internal class Chaise
    {
        #region "Attributs"
        private string _model;
        private string _couleur;
        private string _matière;
        private int _nbrDePieds;
        #endregion
        
        # region "Propriétés"
        public string Model { get => _model; set => _model = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }
        public string Matière { get => _matière; set => _matière = value; }
        public int NbrDePieds { get => _nbrDePieds; set => _nbrDePieds = value; }
        #endregion

        #region "Constructeurs"
        public Chaise()
        {

        }

        public Chaise(string model, string couleur, string matière, int nbrDePieds)
        {
            Model = model;
            Couleur = couleur;
            Matière = matière;
            NbrDePieds = nbrDePieds;
        }
        #endregion

        #region Méthodes
        public string Affiche()
        {
            return $"Je suis une Chaise en {_matière} {_couleur}, avec {_nbrDePieds} pieds";
        }
        #endregion
    }

}
