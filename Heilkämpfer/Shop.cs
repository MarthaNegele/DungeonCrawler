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
    public partial class Shop : Form
    { 
        Random rand = new Random();

        string sDam = "Damage: ";
        List<string[]> liItems, liInventory;
        int iAnz, iCash, iZwischensumme, iHP, iMaxHp, iRand;
        List<int> liUses, liCost, liUses2, liCost2, liRemUses;
        List<int[]> liDam, liDam2;
        string[] newItem;

        public Shop(String sShopName, List<String[]> liItem, List<String[]> liInvent, int iCs, int hp, int maxHP)
        {
            InitializeComponent();

            this.Text = sShopName;
            iCash = iCs;
            iHP = hp;
            iMaxHp = maxHP;
            lbGold.Text = "Gold:  " + iCash;

            //check which shop it is
            switch(sShopName)
            {
                
                case "Armorer":
                    pictureBox1.Image = imageList1.Images[0];
                    break;
                case "Weaponsmith":
                    pictureBox1.Image = imageList1.Images[1];
                    break;
                case "Magic Shop":
                    pictureBox1.Image = imageList1.Images[2];
                    break;
case "Potions":
                    pictureBox1.Image = imageList1.Images[3];
                    break;
                case "Healer":
                    pictureBox1.Image = imageList1.Images[4];
                    break;
            }
            //Switch for shop name to repair items
            //repair cost=(cost/uses)*(uses-remUses)+(cost/uses)/2
            if (sShopName == "Potions")
            {
                btHeal.Visible = true;
                lbHP.Text = "HP:    " + iHP + "/" + iMaxHp;
                sDam = "Heal:   ";
            }
            else
            {
                lbHP.Text = "";
            }

            if (iHP == iMaxHp)
                btHeal.Enabled = false;

            //load items into shop
            liItems = liItem;
            liUses = new List<int>();
            liDam = new List<int[]>();
            liCost = new List<int>();

            foreach (string[] it in liItem)
            {
                liBxShop.Items.Add(it[0]);
                liUses.Add(Convert.ToInt32(it[1]));
                liDam.Add(splitDamage(it[2]));
                liCost.Add(Convert.ToInt32(it[3]));
            }

            //load items into inventory
            liInventory = liInvent;
            liUses2 = new List<int>();
            liDam2 = new List<int[]>();
            liCost2 = new List<int>();
            liRemUses = new List<int>();

            for (int i=0;i<liInventory.Count;i++)
            {
                string[] it = liInventory[i];
                liBoxInv.Items.Add(it[0]);
                addToInvList(it);
            }
            //foreach (string[] it in liInventory)
            //{
            //    liBoxInv.Items.Add(it[0]);
            //    addToInvList(it);
            //}
        }

        #region Index changed - display stats
        private void liBxShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liBxShop.SelectedIndex >= 0)
            {
                btBuy.Text = "Buy";
                showInfo(liBxShop, liBoxInv, liDam, liUses);
                lbStats.Text += liCost[iAnz];

                if (liCost[iAnz] > iCash)
                {
                    btBuy.Enabled = false;
                    btHeal.Enabled = false;
                } 
                else
                {
                btHeal.Enabled = true;
                }
            }
        }

        private void liBoxInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liBoxInv.SelectedIndex >= 0)
            { 
                btBuy.Text = "Sell";
                showInfo(liBoxInv, liBxShop, liDam2,liRemUses);
                iZwischensumme = liCost2[iAnz] / 2;
                lbStats.Text += iZwischensumme.ToString();
               
                btHeal.Enabled = false;
            }
        }


        private void showInfo(ListBox liBoActive, ListBox liBoPassive,List<int[]> dam, List<int> uses)
        {
            btBuy.Enabled = true;
            iAnz = liBoActive.SelectedIndex;
            liBoPassive.SelectedIndex = -1;

            //statistik für schaden berechnen. soll ich dafür eine eigene spalte in der liste machen?
            int a, b, c, min, max;

            a = dam[iAnz][0];
            b = dam[iAnz][1];
            c = dam[iAnz][2];

            min = a + c;
            max = a * b + c;

            lbStats.Text =
                liBoActive.SelectedItem + Environment.NewLine +
                "Uses:   " + uses[iAnz] + Environment.NewLine +
                sDam + min.ToString() + "-" + max.ToString() + " (" + a.ToString() + "d" + b.ToString() + "+" + c.ToString() + ")"
                 + Environment.NewLine +
                "Gold:   ";
        }

       #endregion

        private void btBuy_Click(object sender, EventArgs e)
        {
            if (btBuy.Text == "Buy")
            {
                newItem = new string[5];
                newItem[0] = liItems[iAnz][0];
                newItem[1] = liItems[iAnz][1];
                newItem[2] = liItems[iAnz][2];
                newItem[3] = liItems[iAnz][3];
                newItem[4] = liItems[iAnz][1];//beim einkaufen die max uses übernehmen
                                              //das führt sonst zu weirden bugs

 //add to inventory that will be sent back to main form
     //----!!!!----  hier werden plötzlich alle gleichartigen auf die neuen remaining uses upgedated
                liInventory.Add(newItem);

          
                //add to inventory lists in Shop
                liBoxInv.Items.Add(newItem[0]);
                addToInvList(newItem);

                iCash -= liCost[iAnz];
                if (liCost[iAnz] > iCash)
                {
                    btBuy.Enabled = false;
                    btHeal.Enabled = false;
                }
                //liBxShop.SelectedIndex = -1;
               
                //newItem = null; //ob das was bringt? - bringt nix
                 
}
            else //sell
            {
                //iAnz ist selected index vom Inventory
                liInventory.RemoveAt(iAnz);
                liUses2.RemoveAt(iAnz);
                liDam2.RemoveAt(iAnz);
                liCost2.RemoveAt(iAnz);
                liRemUses.RemoveAt(iAnz);
                liBoxInv.Items.Remove(liBoxInv.SelectedItem);
                iCash += iZwischensumme;

                lbStats.Text = "";

            }
            lbGold.Text = "Gold:  " + iCash;
        }

        private void addToInvList(string[] itemToAdd)
        {
            liUses2.Add(Convert.ToInt32(itemToAdd[1]));
            liDam2.Add(splitDamage(itemToAdd[2]));
            liCost2.Add(Convert.ToInt32(itemToAdd[3]));
                liRemUses.Add(Convert.ToInt32(itemToAdd[4]));
        }

        private int[] splitDamage(string sDam)
        {
            string[] saDam = sDam.Split('|');
            int[] iDam = new int[3];
            for (int i = 0; i < saDam.Length; i++)
            {
                iDam[i] = Convert.ToInt32(saDam[i]);
            }
            return iDam;
        }

        private void btHeal_Click(object sender, EventArgs e)
        {
            iRand =   liDam[iAnz][2];
            for (int i = 1; i <= liDam[iAnz][0]; i++)
            {
                iRand += rand.Next(liDam[iAnz][1]);
            }
            iHP += iRand;

            if (iHP >= iMaxHp)
            {
                iHP = iMaxHp;
                btHeal.Enabled = false;
            }

            iCash -= liCost[iAnz];

            if (liCost[iAnz] > iCash)
            {
                btBuy.Enabled = false;
                btHeal.Enabled = false;
            }

            lbGold.Text = "Gold:  " + iCash;
            lbHP.Text = "HP:    " + iHP + "/" + iMaxHp;
        }

        private void btLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //public vars
        #region public
        public List<String[]> GetInventory()
        {
            return liInventory;
        }

        public int GetCash()
        {
            return iCash;
        }

        public int GetHP()
        {
            return iHP;
        }
        #endregion
    }
}
