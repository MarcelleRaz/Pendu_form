
namespace JeuPendu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Initialiser = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtvictoire = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpoint = new System.Windows.Forms.Label();
            this.txtpartie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.texterreur = new System.Windows.Forms.Label();
            this.radiomot = new System.Windows.Forms.RadioButton();
            this.radioLettre = new System.Windows.Forms.RadioButton();
            this.textmot = new System.Windows.Forms.TextBox();
            this.textlettre = new System.Windows.Forms.TextBox();
            this.textdefinition = new System.Windows.Forms.Label();
            this.txtessai = new System.Windows.Forms.Label();
            this.txtmotsslettre = new System.Windows.Forms.Label();
            this.txtmotatrouver = new System.Windows.Forms.Label();
            this.textbienvenue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Initialiser
            // 
            this.Initialiser.Location = new System.Drawing.Point(467, 42);
            this.Initialiser.Name = "Initialiser";
            this.Initialiser.Size = new System.Drawing.Size(182, 29);
            this.Initialiser.TabIndex = 0;
            this.Initialiser.Text = "Nouvelle partie";
            this.Initialiser.UseVisualStyleBackColor = true;
            this.Initialiser.Click += new System.EventHandler(this.initialiser_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(467, 89);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(182, 29);
            this.Quitter.TabIndex = 1;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(25, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 20);
            this.name.TabIndex = 2;
            this.name.Text = "Nom:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtvictoire);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpoint);
            this.groupBox1.Controls.Add(this.txtpartie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joueur";
            // 
            // txtvictoire
            // 
            this.txtvictoire.AutoSize = true;
            this.txtvictoire.BackColor = System.Drawing.SystemColors.Window;
            this.txtvictoire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtvictoire.Location = new System.Drawing.Point(126, 146);
            this.txtvictoire.Margin = new System.Windows.Forms.Padding(3);
            this.txtvictoire.Name = "txtvictoire";
            this.txtvictoire.Size = new System.Drawing.Size(2, 22);
            this.txtvictoire.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Victoires:";
            // 
            // txtpoint
            // 
            this.txtpoint.AutoSize = true;
            this.txtpoint.BackColor = System.Drawing.SystemColors.Window;
            this.txtpoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtpoint.Location = new System.Drawing.Point(126, 112);
            this.txtpoint.Margin = new System.Windows.Forms.Padding(3);
            this.txtpoint.Name = "txtpoint";
            this.txtpoint.Size = new System.Drawing.Size(2, 22);
            this.txtpoint.TabIndex = 5;
            // 
            // txtpartie
            // 
            this.txtpartie.AutoSize = true;
            this.txtpartie.BackColor = System.Drawing.SystemColors.Window;
            this.txtpartie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtpartie.Location = new System.Drawing.Point(126, 79);
            this.txtpartie.Margin = new System.Windows.Forms.Padding(3);
            this.txtpartie.Name = "txtpartie";
            this.txtpartie.Size = new System.Drawing.Size(2, 22);
            this.txtpartie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Points:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parties:";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(126, 39);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(180, 27);
            this.textname.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.texterreur);
            this.groupBox2.Controls.Add(this.radiomot);
            this.groupBox2.Controls.Add(this.radioLettre);
            this.groupBox2.Controls.Add(this.textmot);
            this.groupBox2.Controls.Add(this.textlettre);
            this.groupBox2.Controls.Add(this.textdefinition);
            this.groupBox2.Controls.Add(this.txtessai);
            this.groupBox2.Controls.Add(this.txtmotsslettre);
            this.groupBox2.Controls.Add(this.txtmotatrouver);
            this.groupBox2.Controls.Add(this.textbienvenue);
            this.groupBox2.Location = new System.Drawing.Point(21, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 229);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jeu";
            // 
            // texterreur
            // 
            this.texterreur.AutoSize = true;
            this.texterreur.ForeColor = System.Drawing.Color.Red;
            this.texterreur.Location = new System.Drawing.Point(325, 136);
            this.texterreur.Name = "texterreur";
            this.texterreur.Size = new System.Drawing.Size(0, 20);
            this.texterreur.TabIndex = 8;
            // 
            // radiomot
            // 
            this.radiomot.AutoSize = true;
            this.radiomot.Location = new System.Drawing.Point(325, 74);
            this.radiomot.Name = "radiomot";
            this.radiomot.Size = new System.Drawing.Size(131, 24);
            this.radiomot.TabIndex = 7;
            this.radiomot.TabStop = true;
            this.radiomot.Text = "Deviner le mot:";
            this.radiomot.UseVisualStyleBackColor = true;
            this.radiomot.CheckedChanged += new System.EventHandler(this.radiomot_CheckedChanged);
            // 
            // radioLettre
            // 
            this.radioLettre.AutoSize = true;
            this.radioLettre.Location = new System.Drawing.Point(325, 33);
            this.radioLettre.Name = "radioLettre";
            this.radioLettre.Size = new System.Drawing.Size(151, 24);
            this.radioLettre.TabIndex = 6;
            this.radioLettre.TabStop = true;
            this.radioLettre.Text = "Deviner une lettre:";
            this.radioLettre.UseVisualStyleBackColor = true;
            this.radioLettre.CheckedChanged += new System.EventHandler(this.radioLettre_CheckedChanged);
            // 
            // textmot
            // 
            this.textmot.Location = new System.Drawing.Point(499, 72);
            this.textmot.Name = "textmot";
            this.textmot.Size = new System.Drawing.Size(107, 27);
            this.textmot.TabIndex = 4;
            // 
            // textlettre
            // 
            this.textlettre.Location = new System.Drawing.Point(499, 32);
            this.textlettre.Name = "textlettre";
            this.textlettre.Size = new System.Drawing.Size(107, 27);
            this.textlettre.TabIndex = 4;
            // 
            // textdefinition
            // 
            this.textdefinition.AutoSize = true;
            this.textdefinition.Location = new System.Drawing.Point(19, 111);
            this.textdefinition.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.textdefinition.Name = "textdefinition";
            this.textdefinition.Size = new System.Drawing.Size(0, 20);
            this.textdefinition.TabIndex = 3;
            // 
            // txtessai
            // 
            this.txtessai.AutoSize = true;
            this.txtessai.Location = new System.Drawing.Point(25, 193);
            this.txtessai.Name = "txtessai";
            this.txtessai.Size = new System.Drawing.Size(0, 20);
            this.txtessai.TabIndex = 3;
            // 
            // txtmotsslettre
            // 
            this.txtmotsslettre.AutoSize = true;
            this.txtmotsslettre.Location = new System.Drawing.Point(25, 91);
            this.txtmotsslettre.Name = "txtmotsslettre";
            this.txtmotsslettre.Size = new System.Drawing.Size(0, 20);
            this.txtmotsslettre.TabIndex = 2;
            // 
            // txtmotatrouver
            // 
            this.txtmotatrouver.AutoSize = true;
            this.txtmotatrouver.Location = new System.Drawing.Point(25, 72);
            this.txtmotatrouver.Name = "txtmotatrouver";
            this.txtmotatrouver.Size = new System.Drawing.Size(0, 20);
            this.txtmotatrouver.TabIndex = 1;
            // 
            // textbienvenue
            // 
            this.textbienvenue.AutoSize = true;
            this.textbienvenue.Location = new System.Drawing.Point(25, 39);
            this.textbienvenue.Name = "textbienvenue";
            this.textbienvenue.Size = new System.Drawing.Size(0, 20);
            this.textbienvenue.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Initialiser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Initialiser;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtpartie;
        private System.Windows.Forms.Label txtpoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label textbienvenue;
        private System.Windows.Forms.Label txtmotatrouver;
        private System.Windows.Forms.Label txtmotsslettre;
        private System.Windows.Forms.Label txtessai;
        private System.Windows.Forms.TextBox textlettre;
        private System.Windows.Forms.Label txtvictoire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textmot;
        private System.Windows.Forms.RadioButton radiomot;
        private System.Windows.Forms.RadioButton radioLettre;
        private System.Windows.Forms.Label textdefinition;
        private System.Windows.Forms.Label texterreur;
    }
}

