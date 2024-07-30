namespace pmu
{
    partial class Pmu
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
            this.startGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(736, 260);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(131, 63);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Starting Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.startGame);
            this.Name = "Pmu";
            this.Text = "PMU";
            this.Load += new System.EventHandler(this.Pmu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGame;
    }
}

