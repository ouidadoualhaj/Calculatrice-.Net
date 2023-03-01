namespace Calculatrice
{
    partial class Calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ecran = new System.Windows.Forms.TextBox();
            this.chiff8 = new System.Windows.Forms.Button();
            this.chiff9 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.chiff6 = new System.Windows.Forms.Button();
            this.chiff5 = new System.Windows.Forms.Button();
            this.egale = new System.Windows.Forms.Button();
            this.double0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.moins = new System.Windows.Forms.Button();
            this.chiff3 = new System.Windows.Forms.Button();
            this.chiff2 = new System.Windows.Forms.Button();
            this.chiff0 = new System.Windows.Forms.Button();
            this.chiff1 = new System.Windows.Forms.Button();
            this.chiff4 = new System.Windows.Forms.Button();
            this.chiff7 = new System.Windows.Forms.Button();
            this.produit = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.effacer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ecran
            // 
            this.ecran.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecran.Location = new System.Drawing.Point(12, 10);
            this.ecran.Name = "ecran";
            this.ecran.ReadOnly = true;
            this.ecran.Size = new System.Drawing.Size(485, 31);
            this.ecran.TabIndex = 0;
            this.ecran.Text = "0";
            this.ecran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ecran.TextChanged += new System.EventHandler(this.ecran_TextChanged);
            // 
            // chiff8
            // 
            this.chiff8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff8.Location = new System.Drawing.Point(109, 59);
            this.chiff8.Name = "chiff8";
            this.chiff8.Size = new System.Drawing.Size(81, 36);
            this.chiff8.TabIndex = 1;
            this.chiff8.Text = "8";
            this.chiff8.UseVisualStyleBackColor = false;
            this.chiff8.Click += new System.EventHandler(this.chiff8_Click);
            // 
            // chiff9
            // 
            this.chiff9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff9.Location = new System.Drawing.Point(208, 59);
            this.chiff9.Name = "chiff9";
            this.chiff9.Size = new System.Drawing.Size(81, 36);
            this.chiff9.TabIndex = 2;
            this.chiff9.Text = "9";
            this.chiff9.UseVisualStyleBackColor = false;
            this.chiff9.Click += new System.EventHandler(this.chiff9_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.Highlight;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(304, 108);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(94, 36);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // chiff6
            // 
            this.chiff6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff6.Location = new System.Drawing.Point(208, 108);
            this.chiff6.Name = "chiff6";
            this.chiff6.Size = new System.Drawing.Size(81, 36);
            this.chiff6.TabIndex = 5;
            this.chiff6.Text = "6";
            this.chiff6.UseVisualStyleBackColor = false;
            this.chiff6.Click += new System.EventHandler(this.chiff6_Click);
            // 
            // chiff5
            // 
            this.chiff5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff5.Location = new System.Drawing.Point(109, 108);
            this.chiff5.Name = "chiff5";
            this.chiff5.Size = new System.Drawing.Size(81, 36);
            this.chiff5.TabIndex = 4;
            this.chiff5.Text = "5";
            this.chiff5.UseVisualStyleBackColor = false;
            this.chiff5.Click += new System.EventHandler(this.button6_Click);
            // 
            // egale
            // 
            this.egale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.egale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egale.Location = new System.Drawing.Point(304, 213);
            this.egale.Name = "egale";
            this.egale.Size = new System.Drawing.Size(193, 36);
            this.egale.TabIndex = 12;
            this.egale.Text = "=";
            this.egale.UseVisualStyleBackColor = false;
            this.egale.Click += new System.EventHandler(this.egale_Click);
            // 
            // double0
            // 
            this.double0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.double0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.double0.Location = new System.Drawing.Point(208, 213);
            this.double0.Name = "double0";
            this.double0.Size = new System.Drawing.Size(81, 36);
            this.double0.TabIndex = 11;
            this.double0.Text = "00";
            this.double0.UseVisualStyleBackColor = false;
            this.double0.Click += new System.EventHandler(this.double0_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ControlDark;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(109, 213);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(81, 36);
            this.point.TabIndex = 10;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // moins
            // 
            this.moins.BackColor = System.Drawing.SystemColors.Highlight;
            this.moins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moins.Location = new System.Drawing.Point(304, 161);
            this.moins.Name = "moins";
            this.moins.Size = new System.Drawing.Size(94, 36);
            this.moins.TabIndex = 9;
            this.moins.Text = "-";
            this.moins.UseVisualStyleBackColor = false;
            this.moins.Click += new System.EventHandler(this.moins_Click);
            // 
            // chiff3
            // 
            this.chiff3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff3.Location = new System.Drawing.Point(208, 161);
            this.chiff3.Name = "chiff3";
            this.chiff3.Size = new System.Drawing.Size(81, 36);
            this.chiff3.TabIndex = 8;
            this.chiff3.Text = "3";
            this.chiff3.UseVisualStyleBackColor = false;
            this.chiff3.Click += new System.EventHandler(this.chiff3_Click);
            // 
            // chiff2
            // 
            this.chiff2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff2.Location = new System.Drawing.Point(109, 161);
            this.chiff2.Name = "chiff2";
            this.chiff2.Size = new System.Drawing.Size(81, 36);
            this.chiff2.TabIndex = 7;
            this.chiff2.Text = "2";
            this.chiff2.UseVisualStyleBackColor = false;
            this.chiff2.Click += new System.EventHandler(this.chiff2_Click);
            // 
            // chiff0
            // 
            this.chiff0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff0.Location = new System.Drawing.Point(12, 213);
            this.chiff0.Name = "chiff0";
            this.chiff0.Size = new System.Drawing.Size(81, 36);
            this.chiff0.TabIndex = 16;
            this.chiff0.Text = "0";
            this.chiff0.UseVisualStyleBackColor = false;
            this.chiff0.Click += new System.EventHandler(this.chiff0_Click);
            // 
            // chiff1
            // 
            this.chiff1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff1.Location = new System.Drawing.Point(12, 161);
            this.chiff1.Name = "chiff1";
            this.chiff1.Size = new System.Drawing.Size(81, 36);
            this.chiff1.TabIndex = 15;
            this.chiff1.Text = "1";
            this.chiff1.UseVisualStyleBackColor = false;
            this.chiff1.Click += new System.EventHandler(this.chiff1_Click);
            // 
            // chiff4
            // 
            this.chiff4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff4.Location = new System.Drawing.Point(12, 108);
            this.chiff4.Name = "chiff4";
            this.chiff4.Size = new System.Drawing.Size(81, 36);
            this.chiff4.TabIndex = 14;
            this.chiff4.Text = "4";
            this.chiff4.UseVisualStyleBackColor = false;
            this.chiff4.Click += new System.EventHandler(this.chiff4_Click);
            // 
            // chiff7
            // 
            this.chiff7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.chiff7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiff7.Location = new System.Drawing.Point(12, 59);
            this.chiff7.Name = "chiff7";
            this.chiff7.Size = new System.Drawing.Size(81, 36);
            this.chiff7.TabIndex = 13;
            this.chiff7.Text = "7";
            this.chiff7.UseVisualStyleBackColor = false;
            this.chiff7.Click += new System.EventHandler(this.chiff7_Click);
            // 
            // produit
            // 
            this.produit.BackColor = System.Drawing.SystemColors.Highlight;
            this.produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit.Location = new System.Drawing.Point(404, 161);
            this.produit.Name = "produit";
            this.produit.Size = new System.Drawing.Size(93, 36);
            this.produit.TabIndex = 19;
            this.produit.Text = "X";
            this.produit.UseVisualStyleBackColor = false;
            this.produit.Click += new System.EventHandler(this.produit_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.Highlight;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(404, 108);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(93, 36);
            this.division.TabIndex = 18;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // effacer
            // 
            this.effacer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effacer.Location = new System.Drawing.Point(304, 59);
            this.effacer.Name = "effacer";
            this.effacer.Size = new System.Drawing.Size(193, 36);
            this.effacer.TabIndex = 17;
            this.effacer.Text = "CE";
            this.effacer.UseVisualStyleBackColor = false;
            this.effacer.Click += new System.EventHandler(this.effacer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.produit);
            this.panel1.Controls.Add(this.division);
            this.panel1.Controls.Add(this.effacer);
            this.panel1.Controls.Add(this.chiff0);
            this.panel1.Controls.Add(this.chiff1);
            this.panel1.Controls.Add(this.chiff4);
            this.panel1.Controls.Add(this.chiff7);
            this.panel1.Controls.Add(this.egale);
            this.panel1.Controls.Add(this.double0);
            this.panel1.Controls.Add(this.point);
            this.panel1.Controls.Add(this.moins);
            this.panel1.Controls.Add(this.chiff3);
            this.panel1.Controls.Add(this.chiff2);
            this.panel1.Controls.Add(this.plus);
            this.panel1.Controls.Add(this.chiff6);
            this.panel1.Controls.Add(this.chiff5);
            this.panel1.Controls.Add(this.chiff9);
            this.panel1.Controls.Add(this.chiff8);
            this.panel1.Controls.Add(this.ecran);
            this.panel1.Location = new System.Drawing.Point(47, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 266);
            this.panel1.TabIndex = 20;
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Calculatrice";
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.Calculatrice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ecran;
        private System.Windows.Forms.Button chiff8;
        private System.Windows.Forms.Button chiff9;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button chiff6;
        private System.Windows.Forms.Button chiff5;
        private System.Windows.Forms.Button egale;
        private System.Windows.Forms.Button double0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button moins;
        private System.Windows.Forms.Button chiff3;
        private System.Windows.Forms.Button chiff2;
        private System.Windows.Forms.Button chiff0;
        private System.Windows.Forms.Button chiff1;
        private System.Windows.Forms.Button chiff4;
        private System.Windows.Forms.Button chiff7;
        private System.Windows.Forms.Button produit;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button effacer;
        private System.Windows.Forms.Panel panel1;
    }
}

