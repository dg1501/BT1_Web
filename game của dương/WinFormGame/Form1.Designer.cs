namespace WinFormGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstEnemies;
        private System.Windows.Forms.Label lblScore;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstEnemies = new System.Windows.Forms.ListBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(12, 12);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(150, 22);
            this.txtWord.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(170, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstEnemies
            // 
            this.lstEnemies.ItemHeight = 16;
            this.lstEnemies.Location = new System.Drawing.Point(12, 40);
            this.lstEnemies.Name = "lstEnemies";
            this.lstEnemies.Size = new System.Drawing.Size(233, 100);
            this.lstEnemies.TabIndex = 2;
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(12, 150);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(150, 23);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Điểm: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(336, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "GAME CỦA DƯƠNG";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(759, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstEnemies);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Typing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
