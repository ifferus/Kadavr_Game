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
        Sounds sound;
        SettingLevel level;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            map = new MapController();
            sound = new Sounds();
            level = new SettingLevel();
            sound.StopAllSounds();
            //sound.SoundsMainMenu();
        }

        private void Kadavr_Menu_Paint(object sender, PaintEventArgs e)
        {
            Graphics demos = e.Graphics;
            map.DrawMaps(demos);
        }

        private void gameStartButton_Click(object sender, EventArgs e)
        {
            Kadavr_Game kadavr_Game = new Kadavr_Game();
            kadavr_Game.cactusCount = this.level.cactusCount;
            kadavr_Game.wolfsCount = this.level.wolfsCount;
            kadavr_Game.speedWolfs = this.level.speedWolfs;
            this.Hide();
            this.Owner = kadavr_Game;
            sound.SoundsShoot();
            kadavr_Game.ShowDialog();
        }


        private void gameSettingsButton_Click(object sender, EventArgs e)
        {
            if (panelSetting.Visible == false)
            {
                panelSetting.Visible = true;
            }
            else{
                panelSetting.Visible = false;
            }
            sound.SoundsShoot();
        }

        private void gameRattingButton_Click(object sender, EventArgs e)
        {
            sound.SoundsShoot();
        }

        private void gameExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void easyLevelButton_Click(object sender, EventArgs e)
        {
            level.EasyLevel();
            panelSetting.Visible = false;
            sound.SoundsShoot();
        }

        private void mediumLevelButton_Click(object sender, EventArgs e)
        {
            level.MediumLevel();
            panelSetting.Visible = false;
            sound.SoundsShoot();
        }

        private void hardLevelButton_Click(object sender, EventArgs e)
        {
            level.HardLevel();
            panelSetting.Visible = false;
            sound.SoundsShoot();
        }

        private void labelLevel_Click(object sender, EventArgs e)
        {

        }
    }
}
