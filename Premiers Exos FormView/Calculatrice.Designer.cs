namespace Hello_World
{
    partial class Calculatrice
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
            this.textBoxCalcul = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.buttonN0 = new System.Windows.Forms.Button();
            this.buttonN3 = new System.Windows.Forms.Button();
            this.buttonN2 = new System.Windows.Forms.Button();
            this.buttonN6 = new System.Windows.Forms.Button();
            this.buttonN5 = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonN9 = new System.Windows.Forms.Button();
            this.buttonN1 = new System.Windows.Forms.Button();
            this.buttonN8 = new System.Windows.Forms.Button();
            this.buttonN4 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonN7 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCalcul
            // 
            this.textBoxCalcul.Location = new System.Drawing.Point(13, 13);
            this.textBoxCalcul.Name = "textBoxCalcul";
            this.textBoxCalcul.Size = new System.Drawing.Size(181, 20);
            this.textBoxCalcul.TabIndex = 0;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Location = new System.Drawing.Point(13, 40);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(181, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEquals);
            this.groupBox1.Controls.Add(this.buttonPlus);
            this.groupBox1.Controls.Add(this.buttonMoins);
            this.groupBox1.Controls.Add(this.buttonMult);
            this.groupBox1.Controls.Add(this.buttonDiv);
            this.groupBox1.Controls.Add(this.buttonDec);
            this.groupBox1.Controls.Add(this.buttonN0);
            this.groupBox1.Controls.Add(this.buttonN3);
            this.groupBox1.Controls.Add(this.buttonN2);
            this.groupBox1.Controls.Add(this.buttonN6);
            this.groupBox1.Controls.Add(this.buttonN5);
            this.groupBox1.Controls.Add(this.buttonSign);
            this.groupBox1.Controls.Add(this.buttonN9);
            this.groupBox1.Controls.Add(this.buttonN1);
            this.groupBox1.Controls.Add(this.buttonN8);
            this.groupBox1.Controls.Add(this.buttonN4);
            this.groupBox1.Controls.Add(this.buttonBack);
            this.groupBox1.Controls.Add(this.buttonN7);
            this.groupBox1.Controls.Add(this.buttonC);
            this.groupBox1.Controls.Add(this.buttonCE);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(120, 160);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(32, 29);
            this.buttonEquals.TabIndex = 0;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(120, 124);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(32, 29);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMoins
            // 
            this.buttonMoins.Location = new System.Drawing.Point(120, 89);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(32, 29);
            this.buttonMoins.TabIndex = 0;
            this.buttonMoins.Text = "-";
            this.buttonMoins.UseVisualStyleBackColor = true;
            this.buttonMoins.Click += new System.EventHandler(this.buttonMoins_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(120, 54);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(32, 29);
            this.buttonMult.TabIndex = 0;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(120, 19);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(32, 29);
            this.buttonDiv.TabIndex = 0;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.Location = new System.Drawing.Point(82, 159);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(32, 29);
            this.buttonDec.TabIndex = 0;
            this.buttonDec.Text = ",";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // buttonN0
            // 
            this.buttonN0.Location = new System.Drawing.Point(44, 159);
            this.buttonN0.Name = "buttonN0";
            this.buttonN0.Size = new System.Drawing.Size(32, 29);
            this.buttonN0.TabIndex = 0;
            this.buttonN0.Text = "0";
            this.buttonN0.UseVisualStyleBackColor = true;
            this.buttonN0.Click += new System.EventHandler(this.buttonN0_Click);
            // 
            // buttonN3
            // 
            this.buttonN3.Location = new System.Drawing.Point(82, 124);
            this.buttonN3.Name = "buttonN3";
            this.buttonN3.Size = new System.Drawing.Size(32, 29);
            this.buttonN3.TabIndex = 0;
            this.buttonN3.Text = "3";
            this.buttonN3.UseVisualStyleBackColor = true;
            this.buttonN3.Click += new System.EventHandler(this.buttonN3_Click);
            // 
            // buttonN2
            // 
            this.buttonN2.Location = new System.Drawing.Point(44, 124);
            this.buttonN2.Name = "buttonN2";
            this.buttonN2.Size = new System.Drawing.Size(32, 29);
            this.buttonN2.TabIndex = 0;
            this.buttonN2.Text = "2";
            this.buttonN2.UseVisualStyleBackColor = true;
            this.buttonN2.Click += new System.EventHandler(this.buttonN2_Click);
            // 
            // buttonN6
            // 
            this.buttonN6.Location = new System.Drawing.Point(82, 89);
            this.buttonN6.Name = "buttonN6";
            this.buttonN6.Size = new System.Drawing.Size(32, 29);
            this.buttonN6.TabIndex = 0;
            this.buttonN6.Text = "6";
            this.buttonN6.UseVisualStyleBackColor = true;
            this.buttonN6.Click += new System.EventHandler(this.buttonN6_Click);
            // 
            // buttonN5
            // 
            this.buttonN5.Location = new System.Drawing.Point(44, 89);
            this.buttonN5.Name = "buttonN5";
            this.buttonN5.Size = new System.Drawing.Size(32, 29);
            this.buttonN5.TabIndex = 0;
            this.buttonN5.Text = "5";
            this.buttonN5.UseVisualStyleBackColor = true;
            this.buttonN5.Click += new System.EventHandler(this.buttonN5_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(6, 159);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(32, 29);
            this.buttonSign.TabIndex = 0;
            this.buttonSign.Text = "+-";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonN9
            // 
            this.buttonN9.Location = new System.Drawing.Point(82, 54);
            this.buttonN9.Name = "buttonN9";
            this.buttonN9.Size = new System.Drawing.Size(32, 29);
            this.buttonN9.TabIndex = 0;
            this.buttonN9.Text = "9";
            this.buttonN9.UseVisualStyleBackColor = true;
            this.buttonN9.Click += new System.EventHandler(this.buttonN9_Click);
            // 
            // buttonN1
            // 
            this.buttonN1.Location = new System.Drawing.Point(6, 124);
            this.buttonN1.Name = "buttonN1";
            this.buttonN1.Size = new System.Drawing.Size(32, 29);
            this.buttonN1.TabIndex = 0;
            this.buttonN1.Text = "1";
            this.buttonN1.UseVisualStyleBackColor = true;
            this.buttonN1.Click += new System.EventHandler(this.buttonN1_Click);
            // 
            // buttonN8
            // 
            this.buttonN8.Location = new System.Drawing.Point(44, 54);
            this.buttonN8.Name = "buttonN8";
            this.buttonN8.Size = new System.Drawing.Size(32, 29);
            this.buttonN8.TabIndex = 0;
            this.buttonN8.Text = "8";
            this.buttonN8.UseVisualStyleBackColor = true;
            this.buttonN8.Click += new System.EventHandler(this.buttonN8_Click);
            // 
            // buttonN4
            // 
            this.buttonN4.Location = new System.Drawing.Point(6, 89);
            this.buttonN4.Name = "buttonN4";
            this.buttonN4.Size = new System.Drawing.Size(32, 29);
            this.buttonN4.TabIndex = 0;
            this.buttonN4.Text = "4";
            this.buttonN4.UseVisualStyleBackColor = true;
            this.buttonN4.Click += new System.EventHandler(this.buttonN4_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(82, 19);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(32, 29);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "<--";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonN7
            // 
            this.buttonN7.Location = new System.Drawing.Point(6, 54);
            this.buttonN7.Name = "buttonN7";
            this.buttonN7.Size = new System.Drawing.Size(32, 29);
            this.buttonN7.TabIndex = 0;
            this.buttonN7.Text = "7";
            this.buttonN7.UseVisualStyleBackColor = true;
            this.buttonN7.Click += new System.EventHandler(this.buttonN7_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(44, 19);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(32, 29);
            this.buttonC.TabIndex = 0;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(6, 19);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(32, 29);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxCalcul);
            this.Name = "Calculatrice";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCalcul;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMoins;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Button buttonN0;
        private System.Windows.Forms.Button buttonN3;
        private System.Windows.Forms.Button buttonN2;
        private System.Windows.Forms.Button buttonN6;
        private System.Windows.Forms.Button buttonN5;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonN9;
        private System.Windows.Forms.Button buttonN1;
        private System.Windows.Forms.Button buttonN8;
        private System.Windows.Forms.Button buttonN4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonN7;
    }
}