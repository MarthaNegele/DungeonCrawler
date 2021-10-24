using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heilkämpfer
{
    public partial class ChooseOpponent : Form
    {
        List<string> liMobHP, liXP, liCash;
        List<string[]> liInv, liDam;
        int iAnz, iHP, iMaxHP;
        string sHero;

        bool bOk = true;
        bool bGO;
        bool ranAway = false;

        public ChooseOpponent(List<string[]> mobs, List<string[]> inv, int hp, int maxHp, string hero)
        {
            InitializeComponent();

            liMobHP = new List<string>();
            liXP = new List<string>();
            liDam = new List<string[]>();
            liCash = new List<string>();
            liInv = inv;
            iHP = hp;
            iMaxHP = maxHp;
            sHero = hero;

            foreach (string[] it in mobs)
            {
                listBox1.Items.Add(it[0]);
                liMobHP.Add(it[1]);
                liXP.Add(it[2]);
                liDam.Add(it[3].Split('|'));
                liCash.Add(it[4]);
            }

            label1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            iAnz = listBox1.SelectedIndex;
            string x, y, z;
            x = liDam[iAnz][0];
            y = liDam[iAnz][1];
            z = liDam[iAnz][2];


            int a, b, c, min, max;
            a = Convert.ToInt32(x);
            b = Convert.ToInt32(y);
            c = Convert.ToInt32(z);

            min = a + c;
            max = a * b + c;

            label1.Text =
                listBox1.SelectedItem + Environment.NewLine +
                    "HP:      " + liMobHP[iAnz] + Environment.NewLine +
                    "Damage:  " + min.ToString() + "-" + max.ToString() + " (" + x + "d" + y + "+" + z + ")"
                    + Environment.NewLine + Environment.NewLine +
                    "Reward:  " + Environment.NewLine +
                    liCash[iAnz] + " Gold" + Environment.NewLine +
                    liXP[iAnz] + " XP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mobHp = Convert.ToInt32(liMobHP[iAnz]);
            int[] iDam = new int[3];

            for (int i = 0; i < liDam[iAnz].Length; i++)
            {
                iDam[i] = Convert.ToInt32(liDam[iAnz][i]);
            }

            string mob = listBox1.SelectedItem.ToString();

            Arena arena = new Arena(mob, mobHp, iDam, iHP, iMaxHP, liInv, sHero);
            //this.Visible = false;

            arena.ShowDialog();
            if (!arena.getFoughtBravely())
                ranAway = true;
            bGO = arena.getGameOver();
            liInv = arena.getInv();
            iHP = arena.getHP();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bOk = false;
            this.Close();
        }

        public bool getOK()
        {
            return bOk;
        }

        public bool getRanAway()
        {
            return ranAway;
        }
        public bool getGameOver()
        {
            return bGO;
        }

        public int getHP()
        {
            return iHP;
        }

        public List<string[]> getInv()
        {
            return liInv;
        }

        public int GetXP()
        {
            return Convert.ToInt32(liXP[iAnz]);
        }

        public int GetReward()
        {
            return Convert.ToInt32(liCash[iAnz]);
        }
    }
}
