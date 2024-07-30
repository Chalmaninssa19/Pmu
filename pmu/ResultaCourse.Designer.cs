namespace pmu
{
    partial class ResultatCourse
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
            this.tableResultat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gagnant = new System.Windows.Forms.Label();
            this.prixGagant = new System.Windows.Forms.Label();
            this.perdant = new System.Windows.Forms.Label();
            this.numCheval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monnaie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // tableResultat
            // 
            this.tableResultat.AllowUserToOrderColumns = true;
            this.tableResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableResultat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCheval,
            this.rang,
            this.temps,
            this.difference,
            this.monnaie});
            this.tableResultat.Location = new System.Drawing.Point(57, 71);
            this.tableResultat.Name = "tableResultat";
            this.tableResultat.Size = new System.Drawing.Size(552, 150);
            this.tableResultat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESULTAT DU COURSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gagnant pari :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prix Gagnant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Perdant pari :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gagnant
            // 
            this.gagnant.AutoSize = true;
            this.gagnant.Location = new System.Drawing.Point(351, 257);
            this.gagnant.Name = "gagnant";
            this.gagnant.Size = new System.Drawing.Size(40, 13);
            this.gagnant.TabIndex = 5;
            this.gagnant.Text = "Parieur";
            // 
            // prixGagant
            // 
            this.prixGagant.AutoSize = true;
            this.prixGagant.Location = new System.Drawing.Point(351, 288);
            this.prixGagant.Name = "prixGagant";
            this.prixGagant.Size = new System.Drawing.Size(22, 13);
            this.prixGagant.TabIndex = 6;
            this.prixGagant.Text = "0.0";
            // 
            // perdant
            // 
            this.perdant.AutoSize = true;
            this.perdant.Location = new System.Drawing.Point(347, 321);
            this.perdant.Name = "perdant";
            this.perdant.Size = new System.Drawing.Size(40, 13);
            this.perdant.TabIndex = 7;
            this.perdant.Text = "Parieur";
            // 
            // numCheval
            // 
            this.numCheval.HeaderText = "Num cheval";
            this.numCheval.Name = "numCheval";
            // 
            // rang
            // 
            this.rang.HeaderText = "Rang";
            this.rang.Name = "rang";
            // 
            // temps
            // 
            this.temps.HeaderText = "Temps";
            this.temps.Name = "temps";
            // 
            // difference
            // 
            this.difference.HeaderText = "Difference";
            this.difference.Name = "difference";
            // 
            // monnaie
            // 
            this.monnaie.HeaderText = "Monnaie";
            this.monnaie.Name = "monnaie";
            // 
            // ResultatCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.perdant);
            this.Controls.Add(this.prixGagant);
            this.Controls.Add(this.gagnant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableResultat);
            this.Name = "ResultatCourse";
            this.Text = "ResultatCourse";
            this.Load += new System.EventHandler(this.ResultaCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableResultat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label gagnant;
        private System.Windows.Forms.Label prixGagant;
        private System.Windows.Forms.Label perdant;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCheval;
        private System.Windows.Forms.DataGridViewTextBoxColumn rang;
        private System.Windows.Forms.DataGridViewTextBoxColumn temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn difference;
        private System.Windows.Forms.DataGridViewTextBoxColumn monnaie;
    }
}