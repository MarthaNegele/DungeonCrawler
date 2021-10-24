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
    public partial class NewGame : Form
    {

        bool bOk = false;
        string sName;

        public NewGame()
        {
            InitializeComponent();
            label1.Text = "Welcome, Warrior!" + Environment.NewLine +
                "What is your name?";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
                sName = "Unknown Warrior";
            else
                sName = textBox1.Text;

            bOk = true;
            this.Close();
        }

        public bool getOk()
        {
            return bOk;
        }

        public string getName()
        {
            return sName;
        }
    }
}
