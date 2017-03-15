using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperChariot
{
    public partial class Entrepot : Form
    {
        TableLayoutPanel panel;
        CaseEntrepot[,] cases;
        List<Chariot> chariots;

        int nbCells = 26;
        int nbChariots = 5;

        public Entrepot()
        {
            InitializeComponent();
            initCases();
            initTable();
            initChariots();
        }

        private void initCases()
        {
            cases = new CaseEntrepot[nbCells - 1, nbCells - 1];

            for (int i = 0; i < cases.GetLength(0); i++)
                for (int j = 0; j < cases.GetLength(0); j++)

                    if (j == 0)
                        cases[i, j] = new CaseLivraison(i, j, "", true);

                    else if (i != 0 && i != 24 && i % 2 == 0 && ((j > 1 && j < 11) || (j > 13 && j < 23)))
                        cases[i, j] = new CaseRayon(i, j, "");

                    else
                        cases[i, j] = new CaseAllee(i, j, "", true);
        }

        private void initTable()
        {
            panel = new TableLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.ColumnCount = nbCells;
            panel.RowCount = nbCells;
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            for (int i = 0; i < nbCells; i++)
            {
                for (int j = 0; j < nbCells; j++)
                {
                    Label cellule;
                    if (j == 0 && i > 0)
                        cellule = new Label()
                    {
                        Text = "" + i,
                        BackColor = Color.Bisque,
                        Size = new Size(45, 30)
                    };

                    else if (i == 0 && j > 0)
                        cellule = new Label()
                        {
                            Text = "" + j,
                            BackColor = Color.Bisque,
                            Size = new Size(45, 30)
                        };

                    else if (i == 0 && j == 0)
                        cellule = new Label()
                        {
                            Text = "",
                            BackColor = Color.White,
                            Size = new Size(45, 30)
                        };

                    else
                    {
                        cellule = new Label()
                        {
                            Text = cases[i - 1, j - 1].Texte,
                            BackColor = cases[i - 1, j - 1].Couleur,
                            Size = new Size(45, 30)
                        };
                    }
                    panel.Controls.Add(cellule, j, i);
                }
            }
            this.Controls.Add(panel);

        }

        private void initChariots()
        {
            chariots = new List<Chariot>();

            // TODO : initialiser la liste avec des chariots et des positions

            // TODO : interaction avec l'utilisateur

            // TODO : finir le projet
        }
    }
}
