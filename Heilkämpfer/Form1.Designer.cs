
namespace Heilkämpfer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btArena = new System.Windows.Forms.Button();
            this.btMagicShop = new System.Windows.Forms.Button();
            this.btWeaponShop = new System.Windows.Forms.Button();
            this.btPotionsShop = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.lbHeadline = new System.Windows.Forms.Label();
            this.lbStats = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btHeal = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btArmor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btArena
            // 
            this.btArena.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btArena.BackgroundImage = global::Heilkämpfer.Properties.Resources.Arena;
            this.btArena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btArena.Enabled = false;
            this.btArena.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btArena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btArena.ForeColor = System.Drawing.Color.Black;
            this.btArena.Location = new System.Drawing.Point(16, 33);
            this.btArena.Margin = new System.Windows.Forms.Padding(7);
            this.btArena.Name = "btArena";
            this.btArena.Size = new System.Drawing.Size(371, 195);
            this.btArena.TabIndex = 0;
            this.btArena.Text = "Enter Arena";
            this.btArena.UseVisualStyleBackColor = false;
            this.btArena.Click += new System.EventHandler(this.btArena_Click);
            // 
            // btMagicShop
            // 
            this.btMagicShop.Enabled = false;
            this.btMagicShop.Image = global::Heilkämpfer.Properties.Resources.Magic;
            this.btMagicShop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMagicShop.Location = new System.Drawing.Point(514, 559);
            this.btMagicShop.Margin = new System.Windows.Forms.Padding(7);
            this.btMagicShop.Name = "btMagicShop";
            this.btMagicShop.Size = new System.Drawing.Size(160, 125);
            this.btMagicShop.TabIndex = 0;
            this.btMagicShop.Text = "Magic Shop";
            this.btMagicShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMagicShop.UseVisualStyleBackColor = true;
            this.btMagicShop.Click += new System.EventHandler(this.btMagicShop_Click);
            // 
            // btWeaponShop
            // 
            this.btWeaponShop.Enabled = false;
            this.btWeaponShop.Image = global::Heilkämpfer.Properties.Resources.Weapons;
            this.btWeaponShop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btWeaponShop.Location = new System.Drawing.Point(563, 362);
            this.btWeaponShop.Margin = new System.Windows.Forms.Padding(7);
            this.btWeaponShop.Name = "btWeaponShop";
            this.btWeaponShop.Size = new System.Drawing.Size(160, 125);
            this.btWeaponShop.TabIndex = 0;
            this.btWeaponShop.Text = "Weaponsmith";
            this.btWeaponShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWeaponShop.UseVisualStyleBackColor = true;
            this.btWeaponShop.Click += new System.EventHandler(this.btWeaponShop_Click);
            // 
            // btPotionsShop
            // 
            this.btPotionsShop.Enabled = false;
            this.btPotionsShop.Image = global::Heilkämpfer.Properties.Resources.Potions;
            this.btPotionsShop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPotionsShop.Location = new System.Drawing.Point(16, 559);
            this.btPotionsShop.Margin = new System.Windows.Forms.Padding(7);
            this.btPotionsShop.Name = "btPotionsShop";
            this.btPotionsShop.Size = new System.Drawing.Size(160, 125);
            this.btPotionsShop.TabIndex = 0;
            this.btPotionsShop.Text = "Potions";
            this.btPotionsShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPotionsShop.UseVisualStyleBackColor = true;
            this.btPotionsShop.Click += new System.EventHandler(this.btPotionsShop_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(780, 659);
            this.btClose.Margin = new System.Windows.Forms.Padding(7);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(168, 36);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Quit";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(780, 609);
            this.btSave.Margin = new System.Windows.Forms.Padding(7);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(168, 36);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save Game";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(780, 559);
            this.btLoad.Margin = new System.Windows.Forms.Padding(7);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(168, 36);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "Load Game";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // lbHeadline
            // 
            this.lbHeadline.AutoSize = true;
            this.lbHeadline.BackColor = System.Drawing.Color.Black;
            this.lbHeadline.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeadline.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbHeadline.Location = new System.Drawing.Point(753, 53);
            this.lbHeadline.Name = "lbHeadline";
            this.lbHeadline.Size = new System.Drawing.Size(179, 30);
            this.lbHeadline.TabIndex = 1;
            this.lbHeadline.Text = "Welcome, Warrior!";
            // 
            // lbStats
            // 
            this.lbStats.AutoSize = true;
            this.lbStats.BackColor = System.Drawing.Color.Black;
            this.lbStats.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbStats.Location = new System.Drawing.Point(753, 83);
            this.lbStats.Name = "lbStats";
            this.lbStats.Size = new System.Drawing.Size(0, 30);
            this.lbStats.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 2;
            // 
            // btHeal
            // 
            this.btHeal.Enabled = false;
            this.btHeal.Image = global::Heilkämpfer.Properties.Resources.Healer;
            this.btHeal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btHeal.Location = new System.Drawing.Point(62, 334);
            this.btHeal.Name = "btHeal";
            this.btHeal.Size = new System.Drawing.Size(160, 125);
            this.btHeal.TabIndex = 3;
            this.btHeal.Text = "Heal to Full";
            this.btHeal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHeal.UseVisualStyleBackColor = true;
            this.btHeal.Click += new System.EventHandler(this.btHeal_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(780, 509);
            this.btNew.Margin = new System.Windows.Forms.Padding(7);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(168, 36);
            this.btNew.TabIndex = 0;
            this.btNew.Text = "New Game";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btArmor
            // 
            this.btArmor.Enabled = false;
            this.btArmor.Image = global::Heilkämpfer.Properties.Resources.Armor;
            this.btArmor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btArmor.Location = new System.Drawing.Point(572, 165);
            this.btArmor.Margin = new System.Windows.Forms.Padding(7);
            this.btArmor.Name = "btArmor";
            this.btArmor.Size = new System.Drawing.Size(160, 125);
            this.btArmor.TabIndex = 0;
            this.btArmor.Text = "Armorer";
            this.btArmor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btArmor.UseVisualStyleBackColor = true;
            this.btArmor.Click += new System.EventHandler(this.btArmor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Heilkämpfer.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.btHeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStats);
            this.Controls.Add(this.lbHeadline);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btPotionsShop);
            this.Controls.Add(this.btArmor);
            this.Controls.Add(this.btWeaponShop);
            this.Controls.Add(this.btMagicShop);
            this.Controls.Add(this.btArena);
            this.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btArena;
        private System.Windows.Forms.Button btMagicShop;
        private System.Windows.Forms.Button btWeaponShop;
        private System.Windows.Forms.Button btPotionsShop;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Label lbHeadline;
        private System.Windows.Forms.Label lbStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHeal;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btArmor;
    }
}

