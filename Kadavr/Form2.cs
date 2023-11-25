using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadavr
{
    public partial class Form2 : Form
    {
        MapController map;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            map = new MapController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kadavr_Game kadavr_Game = new Kadavr_Game();
            //this.Hide();
            //this.Owner = kadavr_Game;
            //kadavr_Game.ShowDialog();
        }

        private void Kadavr_Menu_Paint(object sender, PaintEventArgs e)
        {
            Graphics demos = e.Graphics;
            map.DrawMaps(demos);

            Rectangle button_start = new Rectangle(590, 335, 100, 50);
            demos.FillRectangle(Brushes.Brown, button_start);
        }
    }
}
