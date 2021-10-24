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
    public partial class LoadGame : Form
    {
        List<string> liSavedGames;
        bool bOk = true;
        StreamWriter save;
        StreamReader load;
        string sGameData;

        public LoadGame(string loadsave, string inv) //mitschicken: save or load. 
        {
            InitializeComponent();

            this.Text = loadsave;
            liSavedGames = new List<string>();

            sGameData = inv;

            if (loadsave == "Save Game")
            {
                btSave.Text = "Save";
                //sonderzeichen crashen das game beim laden (weil csv)
                lbError.Text = "Do not use the following:" + Environment.NewLine +
                    "    ;   |   §   *   &" + Environment.NewLine + Environment.NewLine +
                    "If you do, the game might crash upon loading.";
                groupBox1.Visible = true;

              //  lbError.Text += Environment.NewLine + inv;
            }
            else //load
            {
                btSave.Text = "Load";
            }

            //streamreader load files
            try
            {
                load = new StreamReader("saved Games.csv");
                while (!load.EndOfStream)
                {
                    string next = load.ReadLine();
                    liSavedGames.Add(next);
                    listBox1.Items.Add(next.Split(';')[0]);
                }
                load.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                btDelete.Enabled = true;
            }
            else
            {
                btDelete.Enabled = false;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }

        private void btWarning_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            if (btSave.Text == "Save") //save
            {
                if (textBox1.Text.Trim() == "")
                {
                    lbError.Text = "Please enter a name" + Environment.NewLine +
                        "or chose an existing game!";
                    groupBox1.Visible = true;
                }
                else
                {
                    if (listBox1.SelectedIndex >= 0)
                        liSavedGames[listBox1.SelectedIndex] = textBox1.Text + ";" + sGameData;
                    else
                        liSavedGames.Add(textBox1.Text + ";" + sGameData);
                    this.Close();
                }
            }
            else //load
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    sGameData = liSavedGames[listBox1.SelectedIndex];
                    this.Close();
                }
                else
                {
                    lbError.Text = "Select a game from the list!";
                    groupBox1.Visible = true;
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            liSavedGames.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            textBox1.Text = "";
            btDelete.Enabled = false;
        }

        private void btDone_Click(object sender, EventArgs e)
        {
            bOk = false;
            this.Close();
        }

        private void LoadGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeToFile();
        }

        private void writeToFile()
        {
            try
            {
                save = new StreamWriter("saved Games.csv", false);
                foreach (string s in liSavedGames)
                {
                    save.WriteLine(s);
                }

                save.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("an error occured" + Environment.NewLine + ex.Message);
            }
        }

        //public gets:
        public bool getOK()
        {
            return bOk;
        }

        //daten für load
        public string getData()
        {
            return sGameData;
        }
    }
}
