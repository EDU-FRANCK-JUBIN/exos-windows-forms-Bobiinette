namespace Hello_World
{
    partial class Form_Hotel
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
            this.pictureBox_hotel = new System.Windows.Forms.PictureBox();
            this.groupBox_roomCharges = new System.Windows.Forms.GroupBox();
            this.label_nbNights = new System.Windows.Forms.Label();
            this.label_dailyCharge = new System.Windows.Forms.Label();
            this.label_serviceRoomCharges = new System.Windows.Forms.Label();
            this.label_internetCharges = new System.Windows.Forms.Label();
            this.label_telephoneCharge = new System.Windows.Forms.Label();
            this.label_dailyParking = new System.Windows.Forms.Label();
            this.label_miscCharge = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hotel)).BeginInit();
            this.groupBox_roomCharges.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_hotel
            // 
            this.pictureBox_hotel.Location = new System.Drawing.Point(34, 21);
            this.pictureBox_hotel.Name = "pictureBox_hotel";
            this.pictureBox_hotel.Size = new System.Drawing.Size(180, 129);
            this.pictureBox_hotel.TabIndex = 0;
            this.pictureBox_hotel.TabStop = false;
            // 
            // groupBox_roomCharges
            // 
            this.groupBox_roomCharges.Controls.Add(this.textBox7);
            this.groupBox_roomCharges.Controls.Add(this.textBox6);
            this.groupBox_roomCharges.Controls.Add(this.textBox5);
            this.groupBox_roomCharges.Controls.Add(this.textBox4);
            this.groupBox_roomCharges.Controls.Add(this.textBox3);
            this.groupBox_roomCharges.Controls.Add(this.textBox2);
            this.groupBox_roomCharges.Controls.Add(this.textBox1);
            this.groupBox_roomCharges.Controls.Add(this.label_miscCharge);
            this.groupBox_roomCharges.Controls.Add(this.label_dailyParking);
            this.groupBox_roomCharges.Controls.Add(this.label_telephoneCharge);
            this.groupBox_roomCharges.Controls.Add(this.label_internetCharges);
            this.groupBox_roomCharges.Controls.Add(this.label_serviceRoomCharges);
            this.groupBox_roomCharges.Controls.Add(this.label_dailyCharge);
            this.groupBox_roomCharges.Controls.Add(this.label_nbNights);
            this.groupBox_roomCharges.Location = new System.Drawing.Point(277, 21);
            this.groupBox_roomCharges.Name = "groupBox_roomCharges";
            this.groupBox_roomCharges.Size = new System.Drawing.Size(295, 213);
            this.groupBox_roomCharges.TabIndex = 1;
            this.groupBox_roomCharges.TabStop = false;
            this.groupBox_roomCharges.Text = "Room Charges";
            // 
            // label_nbNights
            // 
            this.label_nbNights.AutoSize = true;
            this.label_nbNights.Location = new System.Drawing.Point(164, 20);
            this.label_nbNights.Name = "label_nbNights";
            this.label_nbNights.Size = new System.Drawing.Size(89, 13);
            this.label_nbNights.TabIndex = 0;
            this.label_nbNights.Text = "Number of Nights";
            // 
            // label_dailyCharge
            // 
            this.label_dailyCharge.AutoSize = true;
            this.label_dailyCharge.Location = new System.Drawing.Point(164, 47);
            this.label_dailyCharge.Name = "label_dailyCharge";
            this.label_dailyCharge.Size = new System.Drawing.Size(67, 13);
            this.label_dailyCharge.TabIndex = 1;
            this.label_dailyCharge.Text = "Daily Charge";
            // 
            // label_serviceRoomCharges
            // 
            this.label_serviceRoomCharges.AutoSize = true;
            this.label_serviceRoomCharges.Location = new System.Drawing.Point(164, 74);
            this.label_serviceRoomCharges.Name = "label_serviceRoomCharges";
            this.label_serviceRoomCharges.Size = new System.Drawing.Size(111, 13);
            this.label_serviceRoomCharges.TabIndex = 2;
            this.label_serviceRoomCharges.Text = "Room Service Charge";
            // 
            // label_internetCharges
            // 
            this.label_internetCharges.AutoSize = true;
            this.label_internetCharges.Location = new System.Drawing.Point(164, 103);
            this.label_internetCharges.Name = "label_internetCharges";
            this.label_internetCharges.Size = new System.Drawing.Size(80, 13);
            this.label_internetCharges.TabIndex = 3;
            this.label_internetCharges.Text = "Internet Charge";
            // 
            // label_telephoneCharge
            // 
            this.label_telephoneCharge.AutoSize = true;
            this.label_telephoneCharge.Location = new System.Drawing.Point(164, 130);
            this.label_telephoneCharge.Name = "label_telephoneCharge";
            this.label_telephoneCharge.Size = new System.Drawing.Size(95, 13);
            this.label_telephoneCharge.TabIndex = 4;
            this.label_telephoneCharge.Text = "Telephone Charge";
            // 
            // label_dailyParking
            // 
            this.label_dailyParking.AutoSize = true;
            this.label_dailyParking.Location = new System.Drawing.Point(164, 157);
            this.label_dailyParking.Name = "label_dailyParking";
            this.label_dailyParking.Size = new System.Drawing.Size(69, 13);
            this.label_dailyParking.TabIndex = 5;
            this.label_dailyParking.Text = "Daily Parking";
            // 
            // label_miscCharge
            // 
            this.label_miscCharge.AutoSize = true;
            this.label_miscCharge.Location = new System.Drawing.Point(164, 184);
            this.label_miscCharge.Name = "label_miscCharge";
            this.label_miscCharge.Size = new System.Drawing.Size(69, 13);
            this.label_miscCharge.TabIndex = 6;
            this.label_miscCharge.Text = "Misc. Charge";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(7, 157);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(7, 184);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Total Charges";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(81, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "15% Discount";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Location = new System.Drawing.Point(34, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Room Charges";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(7, 20);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(7, 47);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(7, 74);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Charges";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Additionnal Charges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SubTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "7.00% Tax";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(387, 36);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(361, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL CHARGES";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(387, 82);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 9;
            // 
            // Form_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_roomCharges);
            this.Controls.Add(this.pictureBox_hotel);
            this.Name = "Form_Hotel";
            this.Text = "Hotel Grande Room";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hotel)).EndInit();
            this.groupBox_roomCharges.ResumeLayout(false);
            this.groupBox_roomCharges.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_hotel;
        private System.Windows.Forms.GroupBox groupBox_roomCharges;
        private System.Windows.Forms.Label label_miscCharge;
        private System.Windows.Forms.Label label_dailyParking;
        private System.Windows.Forms.Label label_telephoneCharge;
        private System.Windows.Forms.Label label_internetCharges;
        private System.Windows.Forms.Label label_serviceRoomCharges;
        private System.Windows.Forms.Label label_dailyCharge;
        private System.Windows.Forms.Label label_nbNights;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
    }
}