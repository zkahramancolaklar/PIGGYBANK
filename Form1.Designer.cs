namespace PiggyBank
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnParaAt = new System.Windows.Forms.Button();
            this.btnkir = new System.Windows.Forms.Button();
            this.btnYapistir = new System.Windows.Forms.Button();
            this.cmbBankNote = new System.Windows.Forms.ComboBox();
            this.imgBankNote = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblToplamHacim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBankNote)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PiggyBank.Properties.Resources.bos;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnParaAt
            // 
            this.btnParaAt.Location = new System.Drawing.Point(194, 145);
            this.btnParaAt.Name = "btnParaAt";
            this.btnParaAt.Size = new System.Drawing.Size(75, 23);
            this.btnParaAt.TabIndex = 1;
            this.btnParaAt.Text = "Para At";
            this.btnParaAt.UseVisualStyleBackColor = true;
            this.btnParaAt.Click += new System.EventHandler(this.btnParaAt_Click);
            // 
            // btnkir
            // 
            this.btnkir.Location = new System.Drawing.Point(275, 145);
            this.btnkir.Name = "btnkir";
            this.btnkir.Size = new System.Drawing.Size(91, 23);
            this.btnkir.TabIndex = 2;
            this.btnkir.Text = "Kumbarayı Kır";
            this.btnkir.UseVisualStyleBackColor = true;
            this.btnkir.Visible = false;
            this.btnkir.Click += new System.EventHandler(this.btnkir_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.Location = new System.Drawing.Point(382, 9);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(127, 23);
            this.btnYapistir.TabIndex = 3;
            this.btnYapistir.Text = "Kumbarayı Yapıştır";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Visible = false;
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // cmbBankNote
            // 
            this.cmbBankNote.FormattingEnabled = true;
            this.cmbBankNote.Location = new System.Drawing.Point(198, 11);
            this.cmbBankNote.Name = "cmbBankNote";
            this.cmbBankNote.Size = new System.Drawing.Size(167, 21);
            this.cmbBankNote.TabIndex = 4;
            this.cmbBankNote.SelectedIndexChanged += new System.EventHandler(this.cmbBankNote_SelectedIndexChanged);
            // 
            // imgBankNote
            // 
            this.imgBankNote.Image = global::PiggyBank.Properties.Resources._200;
            this.imgBankNote.Location = new System.Drawing.Point(202, 46);
            this.imgBankNote.Name = "imgBankNote";
            this.imgBankNote.Size = new System.Drawing.Size(163, 69);
            this.imgBankNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBankNote.TabIndex = 5;
            this.imgBankNote.TabStop = false;
            this.imgBankNote.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(381, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 121);
            this.listBox1.TabIndex = 6;
            this.listBox1.Visible = false;
            // 
            // lblToplamHacim
            // 
            this.lblToplamHacim.AutoSize = true;
            this.lblToplamHacim.Location = new System.Drawing.Point(10, 180);
            this.lblToplamHacim.Name = "lblToplamHacim";
            this.lblToplamHacim.Size = new System.Drawing.Size(0, 13);
            this.lblToplamHacim.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplamHacim);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.imgBankNote);
            this.Controls.Add(this.cmbBankNote);
            this.Controls.Add(this.btnYapistir);
            this.Controls.Add(this.btnkir);
            this.Controls.Add(this.btnParaAt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBankNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnParaAt;
        private System.Windows.Forms.Button btnkir;
        private System.Windows.Forms.Button btnYapistir;
        private System.Windows.Forms.ComboBox cmbBankNote;
        private System.Windows.Forms.PictureBox imgBankNote;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblToplamHacim;
    }
}

