using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Heilkämpfer
{

    /*Hero				
Experience Points				
Lv 	    AtkB		XP	            Hp
1st 	1		        0	        10+2
2nd 	2        		1000	    add 1d10+2
3rd 	3	          	3000	
4th 	4		        6000	
5th 	5         		10000	
6th 	6&1     		15000	
7th 	7&2 	    	21000	
8th 	8&3      		28000	
9th 	9&4 		    36000	
10th 	10&5 	    	45000	
11th 	11&6&1  		55000	
12th 	12&7&2   		66000	
13th 	13&8&3 		    78000	
14th 	14&9&4 	    	91000	
15th 	15&10&5 		105000	
16th 	16&11&6&1 		120000	
17th 	17&12&7&2 		136000	
18th 	18&13&8&3 		153000	
19th 	19&14&9&4 		171000	
20th 	20&15&10&5 		190000	
*/


    public partial class Form1 : Form
    {
        StreamReader sr;
        Random rand = new Random();

        String sHero,sNextItem;
        string[] saData;
        List<string[]> liSaMobs, liSaWands, liSaWeapons,liSaArmor, liSaPotions, liSaInventory;
        int iLv, iXP, iMaxXP, iHP, iMaxHp, iCash, iG;
        int[] atkBon = { 1,0,0,0};
        string sLogSave = "Log.txt";
        string sLog = "Opened Game"+Environment.NewLine +DateTime.Now.ToString()+Environment.NewLine;


        int[] maxXP = { 0,
1000,
3000,
6000,
10000,
15000,
21000,
28000,
36000,
45000,
55000,
66000,
78000,
91000,
105000,
120000,
136000,
153000,
171000,
190000
};

        #region ToDoList
        //to do list
        //armorlist
        //multiple atk
        //ac
        //atk roll


        #endregion

        public Form1()
        {
            InitializeComponent();

            liSaMobs = new List<string[]>();
            liSaWands = new List<string[]>();
            liSaWeapons = new List<string[]>();
            liSaArmor = new List<string[]>();
            liSaPotions = new List<string[]>();
            liSaInventory = new List<string[]>();

            //label1 exists for testing purposes. 
            //(for checking if data is loaded correctly)


            //Read the list for mobs and items
            try
            {
                sr = new StreamReader("Mobs.csv");

                //Mobs
                sr.ReadLine();
                sr.ReadLine();          //stats headline 

                sNextItem = sr.ReadLine();
                while (sNextItem != "Magic Items;;;;")
                {
                    liSaMobs.Add(sNextItem.Split(';'));
                    sNextItem = sr.ReadLine();
                }

                //Magic Items - ist in sNextItem drin
                sr.ReadLine();          //stats headline

                sNextItem = sr.ReadLine();
                while (sNextItem != "Weapons;;;;")
                {
                    liSaWands.Add(sNextItem.Split(';'));
                    sNextItem = sr.ReadLine();
                }

                //Weapons - ist in sNextItem drin
                sr.ReadLine();          //stats headline
                sNextItem = sr.ReadLine();
                while (sNextItem != "Potions;;;;")
                {
                    liSaWeapons.Add(sNextItem.Split(';'));
                    sNextItem = sr.ReadLine();
                }

                //Potions
                sr.ReadLine();          //stats headline
                while (!sr.EndOfStream)
                {
                    sNextItem = sr.ReadLine();
                    liSaPotions.Add(sNextItem.Split(';'));
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //for appearance:
            lbHeadline.Text = "Welcome, Warrior!";
            lbStats.Text = "Start or load a game...";

        }

        #region buttons
        private void btNew_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadGame load = new LoadGame("Load Game", "");
            load.ShowDialog();

            if (load.getOK())
            {
                loadData(load.getData());
                updateLabel();
                enableButtons();
                checkForHeal();
                log("loaded game");
                log("Hero Name: " + sHero);
                log("lv " + iLv.ToString() + ", " + iXP.ToString() + "/" + iMaxXP.ToString()+" XP");
                log(iHP.ToString() + "/" + iMaxHp.ToString() + " HP, Gold: " + iCash.ToString());
                addInvToLog();

            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string inv = "";
            foreach (string[] s in liSaInventory)
            {
                foreach (string x in s)
                {
                    inv += "*" + x;
                }
                inv += "§";
            }
            string sToSend = sHero + ";" + iLv.ToString() + ";" + iXP.ToString() + ";" + iMaxXP.ToString() + ";"
                + iHP.ToString() + ";" + iMaxHp.ToString() + ";" + iCash.ToString() + ";" + inv;

            LoadGame save = new LoadGame("Save Game", sToSend);
            save.ShowDialog();
            if (save.getOK())
                log("saved game");
            addInvToLog();
        }

        private void btArena_Click(object sender, EventArgs e)
        {
            log("enter arena");
            addInvToLog();

            ChooseOpponent pickFight = new ChooseOpponent(liSaMobs, liSaInventory, iHP, iMaxHp, sHero);
            pickFight.ShowDialog();

            if (pickFight.getOK())
            {
                if (pickFight.getGameOver())
                {
                    log("Game Over" + Environment.NewLine);
                    iHP = 0;
                    updateLabel();
                    lbStats.Text += Environment.NewLine + Environment.NewLine + "GAME OVER";
                    btArena.Enabled = false;
                    btMagicShop.Enabled = false;
                    btPotionsShop.Enabled = false;
                    btWeaponShop.Enabled = false;
                    btHeal.Enabled = false;
                    btSave.Enabled = false;
                }
                else
                {
                    iHP = pickFight.getHP();
                    liSaInventory = pickFight.getInv();



                    if (!pickFight.getRanAway())
                    {
                        iXP += pickFight.GetXP();
                        if (iLv < maxXP.Length && iXP >= iMaxXP)
                        {
                            levelUp();
                        }
                        iCash += pickFight.GetReward();

                        //log(" returned from fight victoriously");
                        //log(sHero + "is lv" + iLv.ToString());
                        //log((iMaxXP - iXP).ToString() + "till next level");
                        //log("HP " + iHP.ToString() + "/" + iMaxHp.ToString() + ", Gold: " + iCash.ToString());

                    }
                    else
                    {
                        log(sHero + " fled from the fight");
                        log("HP " + iHP.ToString() + "/" + iMaxHp.ToString());
                    }
                   // addInvToLog();
                    updateLabel();
                    checkForHeal();
                }
            }
            else
                log(sHero + " did not pick a fight");
        }

        private void levelUp()
        {
            iLv++;
            iXP = iXP - iMaxXP;
            iMaxXP = maxXP[iLv];
            iMaxHp += 3 + rand.Next(10); //0-9, +1, +2con-mod
            iHP = iMaxHp;

            //atk bonus erhöhen
            for (int i = 0; i < atkBon.Length; i++)
            {
                int a = atkBon[i];
                if (a > 0)
                {
                    a++;
                    atkBon[i] = a;
                }
            }

            //erst nach der automatischen erhöhung den neuen wert starten, sonst gibts ne doppelerhöhung
            switch (iLv)
            {
                case 6:
                    atkBon[1] = 1;
                    break;
                case 11:
                    atkBon[2] = 1;
                    break;
                case 16:
                    atkBon[3] = 1;
                    break;
            }

            MessageBox.Show("Congratulations!" + Environment.NewLine + Environment.NewLine
                + "You raised to lv " + iLv + ".");
        }

        private void btHeal_Click(object sender, EventArgs e)
        {
            goToShop("Healer", liSaWeapons);
            //iCash -= iG;
            //iHP = iMaxHp;
            //log("healed to full. remaining Gold: "+iCash.ToString());
            //updateLabel();
            //checkForHeal();
        }

      

        private void btMagicShop_Click(object sender, EventArgs e)
        {
            goToShop("Magic Shop",liSaWands);
        }

        private void btWeaponShop_Click(object sender, EventArgs e)
        {
            goToShop("Weaponsmith",liSaWeapons);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btArmor_Click(object sender, EventArgs e)
        {
            goToShop("Armorer", liSaArmor);
        }

        private void btPotionsShop_Click(object sender, EventArgs e)
        {
            goToShop("Potions",liSaPotions);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        private void startGame()
        {
           
            NewGame newgame = new NewGame();
            newgame.ShowDialog();
            if (newgame.getOk())
            {
                sHero = newgame.getName();
                iLv = 1;
                iXP = 0;
                iMaxXP = 10;
                iCash = 15;
                iHP = 10;
                iMaxHp = 10;

                liSaInventory.Clear();
                string[] saMagicSpoon = { "Magic Spoon", "2", "1|4|2", "0", "10" };
                liSaInventory.Add(saMagicSpoon);
 
                //log("Start new game. Hero name: "+sHero);
                //addInvToLog();

                updateLabel();
                enableButtons();
                checkForHeal();
            }
        }

        private void loadData(string data)
        {
            saData = data.Split(';');

            sHero = saData[1];
            iLv = Convert.ToInt32(saData[2]);
            iXP = Convert.ToInt32(saData[3]);
            iMaxXP = Convert.ToInt32(saData[4]);

            iHP = Convert.ToInt32(saData[5]);
            iMaxHp = Convert.ToInt32(saData[6]);
            iCash = Convert.ToInt32(saData[7]);
            liSaInventory.Clear();

            //Inventory
            //split into items
            foreach (string item in saData[8].Split('§'))
            {
                //split item into sring[]
                string[] nextEntry = item.Split('*');
                string[] nextItem = new string[nextEntry.Length - 1]; //weil bei den items vor dem ersten wert der * steht
                for (int i = 0; i < nextItem.Length; i++)
                {
                    nextItem[i] = nextEntry[i + 1];
                }

                liSaInventory.Add(nextItem);
            }
            liSaInventory.RemoveAt(liSaInventory.Count - 1);//weil nach dem letzten item noch ein § steht. einheitlichkeit...
        }

        private void enableButtons()
        {
            btArena.Enabled = true;
            btMagicShop.Enabled = true;
            btPotionsShop.Enabled = true;
            btWeaponShop.Enabled = true;
            btSave.Enabled = true;
        }

        private void updateLabel()
        {
            lbHeadline.Text = sHero;
            lbStats.Text =
                "Level:  " + iLv + Environment.NewLine +
                "XP:     " + iXP + "/" + iMaxXP + Environment.NewLine +
                "HP:     " + iHP + "/" + iMaxHp + Environment.NewLine +
                "Gold:   " + iCash;
        }

        private void checkForHeal()
        {
            iG = iMaxHp - iHP;
            btHeal.Text = "Heal to Full" + Environment.NewLine +
                       iG + " Gold";

            if (iHP < iMaxHp && iG <= iCash)
            {
                btHeal.Enabled = true;
                //log("wounded, "+iG.ToString()+ " Gold to heal" );
            }
            else
            {
                btHeal.Enabled = false;
                //log("full hp or too little gold to heal to full");
            }
        }

        private void goToShop(string shopname, List<string[]> items)
        {
            //log("go to Shop: " + shopname + Environment.NewLine
            //+ iCash.ToString());
            //addInvToLog();
            
            Shop shop = new Shop(shopname, items, liSaInventory, iCash, iHP, iMaxHp);
            shop.ShowDialog();
            iCash = shop.GetCash();
            liSaInventory = shop.GetInventory();
            iHP = shop.GetHP();

            //log("Leave shop. Gold: "+iCash.ToString());
            //addInvToLog();
          

            updateLabel();
            checkForHeal();
        }

        private void log(string s)
        {
            //sLog+=s + Environment.NewLine;
        }

        private void addInvToLog()
        {
   //log("Items in Inventory:");
   //         foreach (string[] item in liSaInventory)
   //         { 
   //             log(item[0]+", "+item[1]+" uses, Dam: "+item[2]+", remUses: "+item[4] );
   //         }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           // log(DateTime.Now.ToString());
//log("Game Closed");

            //try
            //{
            //    StreamWriter writeLog = new StreamWriter(sLogSave,true);
            //    writeLog.WriteLine(sLog);
            //    writeLog.WriteLine();
            //    writeLog.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("failed to write log" + Environment.NewLine + ex.Message);
            //}
        }
    }
}