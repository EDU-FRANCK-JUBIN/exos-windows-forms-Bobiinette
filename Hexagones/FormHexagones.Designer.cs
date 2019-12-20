namespace Hexagones
{
    partial class FormHexagones
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ouvrir = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.numericUpDown_bleu = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_vert = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_rouge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_bleu = new System.Windows.Forms.TrackBar();
            this.trackBar_vert = new System.Windows.Forms.TrackBar();
            this.trackBar_rouge = new System.Windows.Forms.TrackBar();
            this.label_id = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.label_r = new System.Windows.Forms.Label();
            this.label_q = new System.Windows.Forms.Label();
            this.lbr = new System.Windows.Forms.Label();
            this.lbq = new System.Windows.Forms.Label();
            this.button_animation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_bleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_rouge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 477);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_OnMouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_animation);
            this.groupBox1.Controls.Add(this.button_ouvrir);
            this.groupBox1.Controls.Add(this.button_enregistrer);
            this.groupBox1.Controls.Add(this.numericUpDown_bleu);
            this.groupBox1.Controls.Add(this.numericUpDown_vert);
            this.groupBox1.Controls.Add(this.numericUpDown_rouge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar_bleu);
            this.groupBox1.Controls.Add(this.trackBar_vert);
            this.groupBox1.Controls.Add(this.trackBar_rouge);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Controls.Add(this.lbid);
            this.groupBox1.Controls.Add(this.label_r);
            this.groupBox1.Controls.Add(this.label_q);
            this.groupBox1.Controls.Add(this.lbr);
            this.groupBox1.Controls.Add(this.lbq);
            this.groupBox1.Location = new System.Drawing.Point(548, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 477);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations de l\'hexagone";
            // 
            // button_ouvrir
            // 
            this.button_ouvrir.Location = new System.Drawing.Point(149, 430);
            this.button_ouvrir.Name = "button_ouvrir";
            this.button_ouvrir.Size = new System.Drawing.Size(75, 23);
            this.button_ouvrir.TabIndex = 13;
            this.button_ouvrir.Text = "Ouvrir";
            this.button_ouvrir.UseVisualStyleBackColor = true;
            this.button_ouvrir.Click += new System.EventHandler(this.button_ouvrir_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Location = new System.Drawing.Point(23, 430);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.button_enregistrer.TabIndex = 12;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // numericUpDown_bleu
            // 
            this.numericUpDown_bleu.Location = new System.Drawing.Point(197, 334);
            this.numericUpDown_bleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_bleu.Name = "numericUpDown_bleu";
            this.numericUpDown_bleu.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_bleu.TabIndex = 11;
            this.numericUpDown_bleu.ValueChanged += new System.EventHandler(this.numericUpDown_bleu_ValueChanged);
            // 
            // numericUpDown_vert
            // 
            this.numericUpDown_vert.Location = new System.Drawing.Point(99, 334);
            this.numericUpDown_vert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_vert.Name = "numericUpDown_vert";
            this.numericUpDown_vert.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_vert.TabIndex = 11;
            this.numericUpDown_vert.ValueChanged += new System.EventHandler(this.numericUpDown_vert_ValueChanged);
            // 
            // numericUpDown_rouge
            // 
            this.numericUpDown_rouge.Location = new System.Drawing.Point(7, 334);
            this.numericUpDown_rouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_rouge.Name = "numericUpDown_rouge";
            this.numericUpDown_rouge.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_rouge.TabIndex = 11;
            this.numericUpDown_rouge.ValueChanged += new System.EventHandler(this.numericUpDown_rouge_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bleu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rouge";
            // 
            // trackBar_bleu
            // 
            this.trackBar_bleu.Location = new System.Drawing.Point(197, 99);
            this.trackBar_bleu.Maximum = 255;
            this.trackBar_bleu.Name = "trackBar_bleu";
            this.trackBar_bleu.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_bleu.Size = new System.Drawing.Size(45, 229);
            this.trackBar_bleu.TabIndex = 6;
            this.trackBar_bleu.Scroll += new System.EventHandler(this.trackBar_bleu_Scroll);
            // 
            // trackBar_vert
            // 
            this.trackBar_vert.Location = new System.Drawing.Point(99, 99);
            this.trackBar_vert.Maximum = 255;
            this.trackBar_vert.Name = "trackBar_vert";
            this.trackBar_vert.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_vert.Size = new System.Drawing.Size(45, 229);
            this.trackBar_vert.TabIndex = 6;
            this.trackBar_vert.Scroll += new System.EventHandler(this.trackBar_vert_Scroll);
            // 
            // trackBar_rouge
            // 
            this.trackBar_rouge.Location = new System.Drawing.Point(7, 99);
            this.trackBar_rouge.Maximum = 255;
            this.trackBar_rouge.Name = "trackBar_rouge";
            this.trackBar_rouge.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_rouge.Size = new System.Drawing.Size(45, 229);
            this.trackBar_rouge.TabIndex = 6;
            this.trackBar_rouge.Scroll += new System.EventHandler(this.trackBar_rouge_Scroll);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(38, 54);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(13, 13);
            this.label_id.TabIndex = 5;
            this.label_id.Text = "0";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(7, 54);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(25, 13);
            this.lbid.TabIndex = 4;
            this.lbid.Text = "Id : ";
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.Location = new System.Drawing.Point(35, 37);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(0, 13);
            this.label_r.TabIndex = 3;
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.Location = new System.Drawing.Point(35, 19);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(0, 13);
            this.label_q.TabIndex = 2;
            // 
            // lbr
            // 
            this.lbr.AutoSize = true;
            this.lbr.Location = new System.Drawing.Point(6, 37);
            this.lbr.Name = "lbr";
            this.lbr.Size = new System.Drawing.Size(21, 13);
            this.lbr.TabIndex = 1;
            this.lbr.Text = "R :";
            // 
            // lbq
            // 
            this.lbq.AutoSize = true;
            this.lbq.Location = new System.Drawing.Point(7, 20);
            this.lbq.Name = "lbq";
            this.lbq.Size = new System.Drawing.Size(21, 13);
            this.lbq.TabIndex = 0;
            this.lbq.Text = "Q :";
            // 
            // button_animation
            // 
            this.button_animation.Location = new System.Drawing.Point(23, 454);
            this.button_animation.Name = "button_animation";
            this.button_animation.Size = new System.Drawing.Size(75, 23);
            this.button_animation.TabIndex = 14;
            this.button_animation.Text = "Animation";
            this.button_animation.UseVisualStyleBackColor = true;
            this.button_animation.Click += new System.EventHandler(this.button_animation_Click);
            // 
            // FormHexagones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormHexagones";
            this.Text = "Hexagones";
            this.Load += new System.EventHandler(this.FormHexagones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_bleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_rouge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.Label lbr;
        private System.Windows.Forms.Label lbq;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_bleu;
        private System.Windows.Forms.TrackBar trackBar_vert;
        private System.Windows.Forms.TrackBar trackBar_rouge;
        private System.Windows.Forms.NumericUpDown numericUpDown_bleu;
        private System.Windows.Forms.NumericUpDown numericUpDown_vert;
        private System.Windows.Forms.NumericUpDown numericUpDown_rouge;
        private System.Windows.Forms.Button button_ouvrir;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Button button_animation;
    }
}

