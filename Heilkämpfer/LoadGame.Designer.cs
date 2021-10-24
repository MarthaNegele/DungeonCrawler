
namespace Heilkämpfer
{
    partial class LoadGame
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btDone = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.btWarning = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(27, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 454);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btDone
            // 
            this.btDone.BackColor = System.Drawing.SystemColors.Control;
            this.btDone.ForeColor = System.Drawing.Color.Black;
            this.btDone.Location = new System.Drawing.Point(280, 539);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(132, 40);
            this.btDone.TabIndex = 1;
            this.btDone.Text = "Cancel";
            this.btDone.UseVisualStyleBackColor = false;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 37);
            this.textBox1.TabIndex = 2;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btDelete.Enabled = false;
            this.btDelete.ForeColor = System.Drawing.Color.Black;
            this.btDelete.Location = new System.Drawing.Point(280, 493);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(132, 40);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saved Games";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Control;
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Location = new System.Drawing.Point(280, 447);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(132, 40);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "button1";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Black;
            this.lbError.Location = new System.Drawing.Point(22, 28);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(59, 30);
            this.lbError.TabIndex = 5;
            this.lbError.Text = "label3";
            // 
            // btWarning
            // 
            this.btWarning.BackColor = System.Drawing.SystemColors.Control;
            this.btWarning.ForeColor = System.Drawing.Color.Black;
            this.btWarning.Location = new System.Drawing.Point(15, 349);
            this.btWarning.Name = "btWarning";
            this.btWarning.Size = new System.Drawing.Size(132, 40);
            this.btWarning.TabIndex = 1;
            this.btWarning.Text = "Understood";
            this.btWarning.UseVisualStyleBackColor = false;
            this.btWarning.Click += new System.EventHandler(this.btWarning_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.lbError);
            this.groupBox1.Controls.Add(this.btWarning);
            this.groupBox1.Location = new System.Drawing.Point(484, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 412);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(942, 617);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Papyrus", 14.25F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "LoadGame";
            this.Text = "LoadGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadGame_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btWarning;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}