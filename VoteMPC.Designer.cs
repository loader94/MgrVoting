namespace MgrVoting
{
    partial class Vote
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
            this.radioButtonAD = new System.Windows.Forms.RadioButton();
            this.radioButtonAZ = new System.Windows.Forms.RadioButton();
            this.radioButtonJKM = new System.Windows.Forms.RadioButton();
            this.radioButtonDT = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonoddajglos = new System.Windows.Forms.Button();
            this.buttonsprawdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonAD
            // 
            this.radioButtonAD.AutoSize = true;
            this.radioButtonAD.Location = new System.Drawing.Point(12, 29);
            this.radioButtonAD.Name = "radioButtonAD";
            this.radioButtonAD.Size = new System.Drawing.Size(89, 17);
            this.radioButtonAD.TabIndex = 0;
            this.radioButtonAD.TabStop = true;
            this.radioButtonAD.Text = "Andrzej Duda";
            this.radioButtonAD.UseVisualStyleBackColor = true;
            // 
            // radioButtonAZ
            // 
            this.radioButtonAZ.AutoSize = true;
            this.radioButtonAZ.Location = new System.Drawing.Point(12, 52);
            this.radioButtonAZ.Name = "radioButtonAZ";
            this.radioButtonAZ.Size = new System.Drawing.Size(104, 17);
            this.radioButtonAZ.TabIndex = 1;
            this.radioButtonAZ.TabStop = true;
            this.radioButtonAZ.Text = "Adrian Zandberg";
            this.radioButtonAZ.UseVisualStyleBackColor = true;
            // 
            // radioButtonJKM
            // 
            this.radioButtonJKM.AutoSize = true;
            this.radioButtonJKM.Location = new System.Drawing.Point(12, 75);
            this.radioButtonJKM.Name = "radioButtonJKM";
            this.radioButtonJKM.Size = new System.Drawing.Size(125, 17);
            this.radioButtonJKM.TabIndex = 2;
            this.radioButtonJKM.TabStop = true;
            this.radioButtonJKM.Text = "Janusz Korwin-Mikke";
            this.radioButtonJKM.UseVisualStyleBackColor = true;
            // 
            // radioButtonDT
            // 
            this.radioButtonDT.AutoSize = true;
            this.radioButtonDT.Location = new System.Drawing.Point(12, 98);
            this.radioButtonDT.Name = "radioButtonDT";
            this.radioButtonDT.Size = new System.Drawing.Size(86, 17);
            this.radioButtonDT.TabIndex = 3;
            this.radioButtonDT.TabStop = true;
            this.radioButtonDT.Text = "Donald Tusk";
            this.radioButtonDT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz, kto powinien zostać prezydentem";
            // 
            // buttonoddajglos
            // 
            this.buttonoddajglos.Location = new System.Drawing.Point(12, 121);
            this.buttonoddajglos.Name = "buttonoddajglos";
            this.buttonoddajglos.Size = new System.Drawing.Size(75, 23);
            this.buttonoddajglos.TabIndex = 5;
            this.buttonoddajglos.Text = "Oddaj głos";
            this.buttonoddajglos.UseVisualStyleBackColor = true;
            this.buttonoddajglos.Click += new System.EventHandler(this.buttonoddajglos_Click);
            // 
            // buttonsprawdz
            // 
            this.buttonsprawdz.Location = new System.Drawing.Point(12, 150);
            this.buttonsprawdz.Name = "buttonsprawdz";
            this.buttonsprawdz.Size = new System.Drawing.Size(75, 42);
            this.buttonsprawdz.TabIndex = 6;
            this.buttonsprawdz.Text = "Sprawdź wyniki";
            this.buttonsprawdz.UseVisualStyleBackColor = true;
            this.buttonsprawdz.Click += new System.EventHandler(this.buttonsprawdz_Click);
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 261);
            this.Controls.Add(this.buttonsprawdz);
            this.Controls.Add(this.buttonoddajglos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonDT);
            this.Controls.Add(this.radioButtonJKM);
            this.Controls.Add(this.radioButtonAZ);
            this.Controls.Add(this.radioButtonAD);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vote";
            this.Text = "Głosowanie MPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAD;
        private System.Windows.Forms.RadioButton radioButtonAZ;
        private System.Windows.Forms.RadioButton radioButtonJKM;
        private System.Windows.Forms.RadioButton radioButtonDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonoddajglos;
        private System.Windows.Forms.Button buttonsprawdz;
    }
}

