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
        int nbCells = 26;
        public Entrepot()
        {
            InitializeComponent();
            panel = new TableLayoutPanel();
            initTable();
            this.Controls.Add(panel);
        }

        private void initTable()
        {
            panel.Dock = DockStyle.Fill;
            panel.ColumnCount = nbCells;
            panel.RowCount = nbCells;
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            // lignes
            for (int i = 0; i < nbCells; i++)
            {
                // colonnes
                for (int j = 0; j < nbCells; j++)
                {
                    Label texte;
                    if (j == 0 && i > 0)
                        texte = new Label()
                    {
                        Text = "" + i,
                        BackColor = Color.Bisque,
                        Size = new Size(45, 30)
                    };

                    else if (i == 0 && j > 0)
                        texte = new Label()
                        {
                            Text = "" + j,
                            BackColor = Color.Bisque,
                            Size = new Size(45, 30)
                        };

                    else if (j == 1 && i > 0)
                        texte = new Label()
                        {
                            Text = "",
                            BackColor = Color.MediumAquamarine,
                            Size = new Size(45, 30)
                        };


                    else if (i!= 1 && i != 25 && i%2 == 1 && ((j>2 && j<12) || (j>14 && j<24)))
                        texte = new Label()
                        {
                            Text = "",
                            BackColor = Color.RoyalBlue,
                            Size = new Size(45, 30)
                        };

                    else
                        texte = new Label()
                        {
                            Text = "",
                            BackColor = Color.White,
                            Size = new Size(45, 30)
                        };
                    panel.Controls.Add(texte, j, i);
                }

            }


        }
    }
}
