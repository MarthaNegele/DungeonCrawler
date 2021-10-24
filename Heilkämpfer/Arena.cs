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
    public partial class Arena : Form
    {
        List<string[]> liInventory;
        int iHP, iMaxHp, iMobHP, iMaxMobHP, iDam, iAnz;
        List<int> liRemUses;
        string sMob;
        Random rand = new Random();
        bool bGameOver = false;
        List<int[]> liDam2;
        int[] iMobDam;
        string sDam;
        bool foughtBravely = true;
        string[] it;

        public Arena(string mob, int mobHp, int[] dam, int hp, int maxHP, List<string[]> liInv, string hero)
        {
            InitializeComponent();

            //Mob
            sMob = mob;
            lbEnemy.Text = sMob;
            iMobHP = mobHp;
            iMaxMobHP = mobHp;
            iMobDam = dam;

            //Hero
            lbHero.Text = hero;
            iHP = hp;
            iMaxHp = maxHP;

            liInventory = liInv;
            liRemUses = new List<int>();
            liDam2 = new List<int[]>();

            if (liInventory.Count >= 1)
            {
                //foreach (string[] it in liInventory)
                //{ 
                    for (int j = 0; j < liInventory.Count; j++)
                {
                    it = new string[5];
                   it[0] = liInventory[j][0];
                    it[1] = liInventory[j][1];
                    it[2] = liInventory[j][2];
                    it[3] = liInventory[j][3];
                    it[4] = liInventory[j][4];

                    liBxInv.Items.Add(it[0]);

                    //damage int[]
                    string[] saDam = it[2].Split('|');
                    int[] iDam = new int[3];
                    for (int i = 0; i < saDam.Length; i++)
                    {
                        iDam[i] = Convert.ToInt32(saDam[i]);
                    }
                    liDam2.Add(iDam);

                    liRemUses.Add(Convert.ToInt32(it[4]));
                }

            }
            //weapon	name	        Cost	Dmg	    crit value	Crit multiplier	Bludgeoning	Piercing	Slashing
            //weapon	Unarmed strike	0	    1|3|0	20	        2	            1	        0	        0	

            liBxInv.Items.Add("Fist");
            int[] idam = { 1, 3, 0};
            liDam2.Add(idam);
            liRemUses.Add(100);
            liBxInv.SelectedIndex = 0;

            updateHP();

            //weil ich nicht jedes mal "liBxFight.Items.Add" schreiben will. "do something" > "do x" > "dox"
            dox("You fight against " + sMob + "!");
            if (rand.Next(2) == 0)
                dox("You get the first turn.");
            else
            {
                dox(sMob + " strikes first!");
                mobStrikes();
            }
        }


        

        private void dox(string s)
        {
            liBxFight.Items.Add(s);
            liBxFight.SelectedIndex = liBxFight.Items.Count - 1;
        }

        private void liBxInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateStats();
        }

        private void btUse_Click(object sender, EventArgs e)
        {
            iAnz = liBxInv.SelectedIndex;

            //potion
            if (liRemUses[iAnz] == -1)
            {
                heal();
            }
            //weapon
            else
            {
                strike();
            }

            updateHP();
            updateStats();
            if (iMobHP <= 0)
            {
                dox("You won!");
                liBxInv.Enabled = false;
                btUse.Enabled = false;
                btRun.Text = "Leave";
            }
            else
                mobStrikes();
        }

        private int rollDice(int[] dice)
        {
            int dam = 0;
            //dam 2d6+2 > a d(b) + c
            int a, b, c, e;
            a = dice[0];
            b = dice[1];
            c = dice[2];

            for (int i = 1; i <= a; i++)
            {
                e = d(b);
                dam += e;
                // dox(i.ToString() + ". die: " + e.ToString());
            }
            dam += c;
            //dox("+ " + c.ToString() + " = " + dam.ToString());
            return dam;
        }

        private int d(int i)
        {
            return rand.Next(i) + 1;
        }

        private void heal()
        {
            iDam = rollDice(liDam2[iAnz]);

            removeItem();

            dox("You heal for " + iDam + " HP.");
            iHP += iDam;
            if (iHP > iMaxHp)
                iHP = iMaxHp;
        }

        private void strike()
        {
            iDam = rollDice(liDam2[iAnz]);

            if (liBxInv.SelectedItem.ToString() != "Fist")
            {
                int uses = liRemUses[iAnz];
                uses--;
                liRemUses[iAnz] = uses;
                liInventory[iAnz][4] = uses.ToString();
                foreach (string[] s in liInventory)
                    dox(s[0] + ", remUses: " + s[4]);
            }
            if (liRemUses[iAnz] == 0)
            {
                removeItem();
            }
            dox("You deal " + iDam + " damage.");
            iMobHP -= iDam;
        }

        private void mobStrikes()
        {
            //   iDam = rand.Next(iMinMobDam, iMaxMobDam + 1);
            iDam = rollDice(iMobDam);

            dox(sMob + " deals " + iDam + " damage.");
            iHP -= iDam;
            updateHP();
            if (iHP <= 0)
            {
                dox("You are dead.");
                liBxInv.Enabled = false;
                btUse.Enabled = false;
                btRun.Text = "Leave";
                bGameOver = true;
            }
        }

        private void updateStats()
        {
            if (liBxInv.SelectedIndex >= 0)
            {
                iAnz = liBxInv.SelectedIndex;
                btUse.Enabled = true;

                if (liRemUses[iAnz] == -1)
                {
                    sDam = "Heal for ";
                }
                else
                {
                    sDam = "Damage: ";
                }

                int a, b, c, min, max;
                a = liDam2[iAnz][0];
                b = liDam2[iAnz][1];
                c = liDam2[iAnz][2];

                min = a + c;
                max = a * b + c;

                lbStats.Text =
                    liBxInv.SelectedItem + Environment.NewLine +
                    "Remaining Uses:   " + liRemUses[iAnz] + Environment.NewLine +
                    sDam + min.ToString() + "-" + max.ToString() + " (" + a.ToString() + "d" + b.ToString() + "+" + c.ToString() + ")";
            }
            else
            {
                lbStats.Text = "";
                btUse.Enabled = false;
            }
        }

        private void removeItem()
        {
            liBxInv.Items.RemoveAt(iAnz);
            liDam2.RemoveAt(iAnz);
            liRemUses.RemoveAt(iAnz);
            liInventory.RemoveAt(iAnz);
        }

        private void updateHP()
        {
            lbMobHP.Text = "HP: " + iMobHP + "/" + iMaxMobHP;
            lbHeroHP.Text = "HP: " + iHP + "/" + iMaxHp;
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            if (btRun.Text == "Run")
                foughtBravely = false;
            this.Close();
        }

        #region publics

        public bool getFoughtBravely()
        {
            return foughtBravely;
        }
        public bool getGameOver()
        {
            return bGameOver;
        }
        public int getHP()
        {
            return iHP;
        }

        public List<string[]> getInv()
        {
            return liInventory;
        }
        #endregion
    }
}
