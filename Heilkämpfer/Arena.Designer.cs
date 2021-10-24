
namespace Heilkämpfer
{
    partial class Arena
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
            this.liBxFight = new System.Windows.Forms.ListBox();
            this.lbHeroHP = new System.Windows.Forms.Label();
            this.lbEnemy = new System.Windows.Forms.Label();
            this.liBxInv = new System.Windows.Forms.ListBox();
            this.btUse = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.lbHero = new System.Windows.Forms.Label();
            this.lbMobHP = new System.Windows.Forms.Label();
            this.lbStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // liBxFight
            // 
            this.liBxFight.BackColor = System.Drawing.Color.Black;
            this.liBxFight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.liBxFight.FormattingEnabled = true;
            this.liBxFight.ItemHeight = 30;
            this.liBxFight.Location = new System.Drawing.Point(44, 117);
            this.liBxFight.Name = "liBxFight";
            this.liBxFight.Size = new System.Drawing.Size(895, 124);
            this.liBxFight.TabIndex = 0;
            // 
            // lbHeroHP
            // 
            this.lbHeroHP.AutoSize = true;
            this.lbHeroHP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbHeroHP.Location = new System.Drawing.Point(49, 60);
            this.lbHeroHP.Name = "lbHeroHP";
            this.lbHeroHP.Size = new System.Drawing.Size(43, 30);
            this.lbHeroHP.TabIndex = 1;
            this.lbHeroHP.Text = "HP";
            // 
            // lbEnemy
            // 
            this.lbEnemy.AutoSize = true;
            this.lbEnemy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbEnemy.Location = new System.Drawing.Point(516, 30);
            this.lbEnemy.Name = "lbEnemy";
            this.lbEnemy.Size = new System.Drawing.Size(75, 30);
            this.lbEnemy.TabIndex = 1;
            this.lbEnemy.Text = "Enemy";
            // 
            // liBxInv
            // 
            this.liBxInv.FormattingEnabled = true;
            this.liBxInv.ItemHeight = 30;
            this.liBxInv.Location = new System.Drawing.Point(51, 289);
            this.liBxInv.Name = "liBxInv";
            this.liBxInv.Size = new System.Drawing.Size(208, 274);
            this.liBxInv.TabIndex = 2;
            this.liBxInv.SelectedIndexChanged += new System.EventHandler(this.liBxInv_SelectedIndexChanged);
            // 
            // btUse
            // 
            this.btUse.Location = new System.Drawing.Point(283, 482);
            this.btUse.Name = "btUse";
            this.btUse.Size = new System.Drawing.Size(107, 36);
            this.btUse.TabIndex = 3;
            this.btUse.Text = "Use";
            this.btUse.UseVisualStyleBackColor = true;
            this.btUse.Click += new System.EventHandler(this.btUse_Click);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(283, 524);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(107, 36);
            this.btRun.TabIndex = 3;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // lbHero
            // 
            this.lbHero.AutoSize = true;
            this.lbHero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbHero.Location = new System.Drawing.Point(46, 30);
            this.lbHero.Name = "lbHero";
            this.lbHero.Size = new System.Drawing.Size(58, 30);
            this.lbHero.TabIndex = 1;
            this.lbHero.Text = "Hero";
            // 
            // lbMobHP
            // 
            this.lbMobHP.AutoSize = true;
            this.lbMobHP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbMobHP.Location = new System.Drawing.Point(516, 60);
            this.lbMobHP.Name = "lbMobHP";
            this.lbMobHP.Size = new System.Drawing.Size(43, 30);
            this.lbMobHP.TabIndex = 1;
            this.lbMobHP.Text = "HP";
            // 
            // lbStats
            // 
            this.lbStats.AutoSize = true;
            this.lbStats.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbStats.Location = new System.Drawing.Point(290, 294);
            this.lbStats.Name = "lbStats";
            this.lbStats.Size = new System.Drawing.Size(0, 30);
            this.lbStats.TabIndex = 4;
            // 
            // Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1008, 613);
            this.Controls.Add(this.lbStats);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.btUse);
            this.Controls.Add(this.liBxInv);
            this.Controls.Add(this.lbMobHP);
            this.Controls.Add(this.lbEnemy);
            this.Controls.Add(this.lbHero);
            this.Controls.Add(this.lbHeroHP);
            this.Controls.Add(this.liBxFight);
            this.Font = new System.Drawing.Font("Papyrus", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Arena";
            this.Text = "Arena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liBxFight;
        private System.Windows.Forms.Label lbHeroHP;
        private System.Windows.Forms.Label lbEnemy;
        private System.Windows.Forms.ListBox liBxInv;
        private System.Windows.Forms.Button btUse;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Label lbHero;
        private System.Windows.Forms.Label lbMobHP;
        private System.Windows.Forms.Label lbStats;
    }
}