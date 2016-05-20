namespace Calcolatrice
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.sommaButt = new System.Windows.Forms.Button();
            this.divisioneButt = new System.Windows.Forms.Button();
            this.sottrazioneButt = new System.Windows.Forms.Button();
            this.aTxt = new System.Windows.Forms.TextBox();
            this.bTxt = new System.Windows.Forms.TextBox();
            this.eTxt = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.fTxt = new System.Windows.Forms.TextBox();
            this.cTxt = new System.Windows.Forms.TextBox();
            this.dTxt = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.result3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hTxt = new System.Windows.Forms.TextBox();
            this.gTxt = new System.Windows.Forms.TextBox();
            this.result4 = new System.Windows.Forms.TextBox();
            this.moltButt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sommaButt
            // 
            this.sommaButt.Location = new System.Drawing.Point(12, 29);
            this.sommaButt.Name = "sommaButt";
            this.sommaButt.Size = new System.Drawing.Size(85, 23);
            this.sommaButt.TabIndex = 0;
            this.sommaButt.Text = "Somma";
            this.sommaButt.UseVisualStyleBackColor = true;
            this.sommaButt.Click += new System.EventHandler(this.sommaButt_Click);
            // 
            // divisioneButt
            // 
            this.divisioneButt.Location = new System.Drawing.Point(12, 130);
            this.divisioneButt.Name = "divisioneButt";
            this.divisioneButt.Size = new System.Drawing.Size(85, 23);
            this.divisioneButt.TabIndex = 1;
            this.divisioneButt.Text = "Divisione";
            this.divisioneButt.UseVisualStyleBackColor = true;
            this.divisioneButt.Click += new System.EventHandler(this.divisioneButt_Click);
            // 
            // sottrazioneButt
            // 
            this.sottrazioneButt.Location = new System.Drawing.Point(12, 78);
            this.sottrazioneButt.Name = "sottrazioneButt";
            this.sottrazioneButt.Size = new System.Drawing.Size(85, 23);
            this.sottrazioneButt.TabIndex = 2;
            this.sottrazioneButt.Text = "Sottrazione";
            this.sottrazioneButt.UseVisualStyleBackColor = true;
            this.sottrazioneButt.Click += new System.EventHandler(this.sottrazioneButt_Click);
            // 
            // aTxt
            // 
            this.aTxt.Location = new System.Drawing.Point(122, 29);
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(72, 20);
            this.aTxt.TabIndex = 3;
            // 
            // bTxt
            // 
            this.bTxt.Location = new System.Drawing.Point(223, 29);
            this.bTxt.Name = "bTxt";
            this.bTxt.Size = new System.Drawing.Size(74, 20);
            this.bTxt.TabIndex = 4;
            // 
            // eTxt
            // 
            this.eTxt.Location = new System.Drawing.Point(122, 133);
            this.eTxt.Name = "eTxt";
            this.eTxt.Size = new System.Drawing.Size(72, 20);
            this.eTxt.TabIndex = 5;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(335, 29);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 6;
            // 
            // fTxt
            // 
            this.fTxt.Location = new System.Drawing.Point(223, 133);
            this.fTxt.Name = "fTxt";
            this.fTxt.Size = new System.Drawing.Size(74, 20);
            this.fTxt.TabIndex = 7;
            // 
            // cTxt
            // 
            this.cTxt.Location = new System.Drawing.Point(122, 81);
            this.cTxt.Name = "cTxt";
            this.cTxt.Size = new System.Drawing.Size(72, 20);
            this.cTxt.TabIndex = 8;
            // 
            // dTxt
            // 
            this.dTxt.Location = new System.Drawing.Point(223, 80);
            this.dTxt.Name = "dTxt";
            this.dTxt.Size = new System.Drawing.Size(74, 20);
            this.dTxt.TabIndex = 9;
            // 
            // result2
            // 
            this.result2.Location = new System.Drawing.Point(335, 81);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(100, 20);
            this.result2.TabIndex = 10;
            // 
            // result3
            // 
            this.result3.Location = new System.Drawing.Point(335, 132);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(100, 20);
            this.result3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = ":";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // hTxt
            // 
            this.hTxt.Location = new System.Drawing.Point(223, 187);
            this.hTxt.Name = "hTxt";
            this.hTxt.Size = new System.Drawing.Size(74, 20);
            this.hTxt.TabIndex = 18;
            // 
            // gTxt
            // 
            this.gTxt.Location = new System.Drawing.Point(122, 187);
            this.gTxt.Name = "gTxt";
            this.gTxt.Size = new System.Drawing.Size(72, 20);
            this.gTxt.TabIndex = 19;
            // 
            // result4
            // 
            this.result4.Location = new System.Drawing.Point(335, 187);
            this.result4.Name = "result4";
            this.result4.Size = new System.Drawing.Size(100, 20);
            this.result4.TabIndex = 20;
            // 
            // moltButt
            // 
            this.moltButt.Location = new System.Drawing.Point(12, 185);
            this.moltButt.Name = "moltButt";
            this.moltButt.Size = new System.Drawing.Size(85, 23);
            this.moltButt.TabIndex = 21;
            this.moltButt.Text = "Moltiplicazione";
            this.moltButt.UseVisualStyleBackColor = true;
            this.moltButt.Click += new System.EventHandler(this.moltButt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 262);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.moltButt);
            this.Controls.Add(this.result4);
            this.Controls.Add(this.gTxt);
            this.Controls.Add(this.hTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.dTxt);
            this.Controls.Add(this.cTxt);
            this.Controls.Add(this.fTxt);
            this.Controls.Add(this.result);
            this.Controls.Add(this.eTxt);
            this.Controls.Add(this.bTxt);
            this.Controls.Add(this.aTxt);
            this.Controls.Add(this.sottrazioneButt);
            this.Controls.Add(this.divisioneButt);
            this.Controls.Add(this.sommaButt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sommaButt;
        private System.Windows.Forms.Button divisioneButt;
        private System.Windows.Forms.Button sottrazioneButt;
        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.TextBox bTxt;
        private System.Windows.Forms.TextBox eTxt;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox fTxt;
        private System.Windows.Forms.TextBox cTxt;
        private System.Windows.Forms.TextBox dTxt;
        private System.Windows.Forms.TextBox result2;
        private System.Windows.Forms.TextBox result3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hTxt;
        private System.Windows.Forms.TextBox gTxt;
        private System.Windows.Forms.TextBox result4;
        private System.Windows.Forms.Button moltButt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

