using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableBattleShips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var gr = e.Graphics;
            for (int i = 0; i < 11; i++)
            {
                // Vertical
                gr.DrawLine(Pens.Black, i * 30, 0, i * 30, 30 * 30);
                // Horizontal
                gr.DrawLine(Pens.Black, 0, i * 30, 30 * 30, i * 30);
            }
        }
    }
}
