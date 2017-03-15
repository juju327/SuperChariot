using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SuperChariot
{
    public class CaseAllee : CaseEntrepot
    {
        public CaseAllee(int x, int y, String texte, Boolean libre) :
            base(Color.White, x, y, texte, libre)
        {
        }

    }
}
