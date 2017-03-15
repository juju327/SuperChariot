using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SuperChariot
{
    class CaseRayon : CaseEntrepot
    {
        public CaseRayon(int x, int y, String texte) :
            base(Color.RoyalBlue, x, y, texte, false)
        {
        }



    }
}
