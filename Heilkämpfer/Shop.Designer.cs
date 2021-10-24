
namespace Heilkämpfer
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.liBxShop = new System.Windows.Forms.ListBox();
            this.liBoxInv = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGold = new System.Windows.Forms.Label();
            this.lbStats = new System.Windows.Forms.Label();
            this.btBuy = new System.Windows.Forms.Button();
            this.btLeave = new System.Windows.Forms.Button();
            this.btHeal = new System.Windows.Forms.Button();
            this.lbHP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // liBxShop
            // 
            this.liBxShop.FormattingEnabled = true;
            this.liBxShop.ItemHeight = 30;
            this.liBxShop.Location = new System.Drawing.Point(30, 115);
            this.liBxShop.Name = "liBxShop";
            this.liBxShop.Size = new System.Drawing.Size(160, 274);
            this.liBxShop.TabIndex = 0;
            this.liBxShop.SelectedIndexChanged += new System.EventHandler(this.liBxShop_SelectedIndexChanged);
            // 
            // liBoxInv
            // 
            this.liBoxInv.FormattingEnabled = true;
            this.liBoxInv.ItemHeight = 30;
            this.liBoxInv.Location = new System.Drawing.Point(526, 115);
            this.liBoxInv.Name = "liBoxInv";
            this.liBoxInv.Size = new System.Drawing.Size(160, 274);
            this.liBoxInv.TabIndex = 0;
            this.liBoxInv.SelectedIndexChanged += new System.EventHandler(this.liBoxInv_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(521, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory:";
            // 
            // lbGold
            // 
            this.lbGold.AutoSize = true;
            this.lbGold.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbGold.Location = new System.Drawing.Point(521, 402);
            this.lbGold.Name = "lbGold";
            this.lbGold.Size = new System.Drawing.Size(61, 30);
            this.lbGold.TabIndex = 1;
            this.lbGold.Text = "Gold:";
            // 
            // lbStats
            // 
            this.lbStats.AutoSize = true;
            this.lbStats.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbStats.Location = new System.Drawing.Point(220, 115);
            this.lbStats.Name = "lbStats";
            this.lbStats.Size = new System.Drawing.Size(27, 30);
            this.lbStats.TabIndex = 1;
            this.lbStats.Text = "lb";
            // 
            // btBuy
            // 
            this.btBuy.Enabled = false;
            this.btBuy.Location = new System.Drawing.Point(303, 352);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(123, 37);
            this.btBuy.TabIndex = 2;
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // btLeave
            // 
            this.btLeave.Location = new System.Drawing.Point(291, 449);
            this.btLeave.Name = "btLeave";
            this.btLeave.Size = new System.Drawing.Size(151, 37);
            this.btLeave.TabIndex = 2;
            this.btLeave.Text = "Leave Shop";
            this.btLeave.UseVisualStyleBackColor = true;
            this.btLeave.Click += new System.EventHandler(this.btLeave_Click);
            // 
            // btHeal
            // 
            this.btHeal.Location = new System.Drawing.Point(303, 399);
            this.btHeal.Name = "btHeal";
            this.btHeal.Size = new System.Drawing.Size(123, 37);
            this.btHeal.TabIndex = 2;
            this.btHeal.Text = "use now";
            this.btHeal.UseVisualStyleBackColor = true;
            this.btHeal.Visible = false;
            this.btHeal.Click += new System.EventHandler(this.btHeal_Click);
            // 
            // lbHP
            // 
            this.lbHP.AutoSize = true;
            this.lbHP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbHP.Location = new System.Drawing.Point(521, 449);
            this.lbHP.Name = "lbHP";
            this.lbHP.Size = new System.Drawing.Size(47, 30);
            this.lbHP.TabIndex = 1;
            this.lbHP.Text = "HP:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Heilkämpfer.Properties.Resources.Magic;
            this.pictureBox1.Location = new System.Drawing.Point(30, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 90);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Armor.png");
            this.imageList1.Images.SetKeyName(1, "Weapons.png");
            this.imageList1.Images.SetKeyName(2, "Magic.png");
            this.imageList1.Images.SetKeyName(3, "Potions.png");
            this.imageList1.Images.SetKeyName(4, "Healer.png");
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(787, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btHeal);
            this.Controls.Add(this.btLeave);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHP);
            this.Controls.Add(this.lbGold);
            this.Controls.Add(this.lbStats);
            this.Controls.Add(this.liBoxInv);
            this.Controls.Add(this.liBxShop);
            this.Font = new System.Drawing.Font("Papyrus", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liBxShop;
        private System.Windows.Forms.ListBox liBoxInv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGold;
        private System.Windows.Forms.Label lbStats;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.Button btLeave;
        private System.Windows.Forms.Button btHeal;
        private System.Windows.Forms.Label lbHP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}