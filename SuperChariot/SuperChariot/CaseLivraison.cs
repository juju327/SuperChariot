using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SuperChariot
{
    public class CaseLivraison : CaseEntrepot
    {
        public CaseLivraison(int x, int y, String texte, Boolean libre) :
            base(Color.MediumAquamarine, x, y, texte, libre)
        {
            Libre = libre;
        }
    }
}
