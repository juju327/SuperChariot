using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SuperChariot
{
    public abstract class CaseEntrepot
    {
        public Color Couleur
        {
            get;
            protected set;
        }

        public int X
        {
            get;
            protected set;
        }

        public int Y
        {
            get;
            protected set;
        }

        public String Texte
        {
            get;
            protected set;
        }

        public Boolean Libre
        {
            get;
            protected set;
        }

        public void setLibre(bool libre)
        {
            Libre = libre;
        }

        public CaseEntrepot()
        {
            Couleur = Color.White;
            X = 0;
            Y = 0;
            Texte = "case vide";
        }

        public CaseEntrepot(Color couleur, int x, int y, String texte, Boolean libre)
        {
            Couleur = couleur;
            X = x;
            Y = y;
            Texte = texte;
        }

    }
}
