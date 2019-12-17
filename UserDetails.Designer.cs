namespace Hello_World
{
    partial class UserDetails
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("fred");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("freddy");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("root_PHILIPPE");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetails));
            this.groupBox_userDetails = new System.Windows.Forms.GroupBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.listBox_cities = new System.Windows.Forms.ListBox();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_both = new System.Windows.Forms.RadioButton();
            this.checkBox_csharp = new System.Windows.Forms.CheckBox();
            this.checkBox_java = new System.Windows.Forms.CheckBox();
            this.checkBox_javapas = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_userDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_userDetails
            // 
            this.groupBox_userDetails.Controls.Add(this.textBox_address);
            this.groupBox_userDetails.Controls.Add(this.textBox_name);
            this.groupBox_userDetails.Controls.Add(this.label_address);
            this.groupBox_userDetails.Controls.Add(this.label_name);
            this.groupBox_userDetails.Location = new System.Drawing.Point(33, 45);
            this.groupBox_userDetails.Name = "groupBox_userDetails";
            this.groupBox_userDetails.Size = new System.Drawing.Size(200, 100);
            this.groupBox_userDetails.TabIndex = 0;
            this.groupBox_userDetails.TabStop = false;
            this.groupBox_userDetails.Text = "User Detail";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(16, 20);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(19, 67);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(45, 13);
            this.label_address.TabIndex = 1;
            this.label_address.Text = "Address";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(82, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(82, 59);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(100, 20);
            this.textBox_address.TabIndex = 3;
            // 
            // listBox_cities
            // 
            this.listBox_cities.FormattingEnabled = true;
            this.listBox_cities.Items.AddRange(new object[] {
            "Evry",
            "Toulouse",
            "Ribaute les Tavernes",
            "Strasbourg",
            "Lézan"});
            this.listBox_cities.Location = new System.Drawing.Point(33, 188);
            this.listBox_cities.Name = "listBox_cities";
            this.listBox_cities.Size = new System.Drawing.Size(120, 95);
            this.listBox_cities.TabIndex = 1;
            this.listBox_cities.SelectedIndexChanged += new System.EventHandler(this.listBox_cities_SelectedIndexChanged);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(439, 57);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(48, 17);
            this.radioButton_male.TabIndex = 2;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(439, 104);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(59, 17);
            this.radioButton_female.TabIndex = 3;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_both
            // 
            this.radioButton_both.AutoSize = true;
            this.radioButton_both.Location = new System.Drawing.Point(439, 81);
            this.radioButton_both.Name = "radioButton_both";
            this.radioButton_both.Size = new System.Drawing.Size(47, 17);
            this.radioButton_both.TabIndex = 4;
            this.radioButton_both.TabStop = true;
            this.radioButton_both.Text = "Both";
            this.radioButton_both.UseVisualStyleBackColor = true;
            // 
            // checkBox_csharp
            // 
            this.checkBox_csharp.AutoSize = true;
            this.checkBox_csharp.Location = new System.Drawing.Point(439, 188);
            this.checkBox_csharp.Name = "checkBox_csharp";
            this.checkBox_csharp.Size = new System.Drawing.Size(40, 17);
            this.checkBox_csharp.TabIndex = 5;
            this.checkBox_csharp.Text = "C#";
            this.checkBox_csharp.UseVisualStyleBackColor = true;
            // 
            // checkBox_java
            // 
            this.checkBox_java.AutoSize = true;
            this.checkBox_java.Location = new System.Drawing.Point(439, 212);
            this.checkBox_java.Name = "checkBox_java";
            this.checkBox_java.Size = new System.Drawing.Size(49, 17);
            this.checkBox_java.TabIndex = 6;
            this.checkBox_java.Text = "Java";
            this.checkBox_java.UseVisualStyleBackColor = true;
            // 
            // checkBox_javapas
            // 
            this.checkBox_javapas.AutoSize = true;
            this.checkBox_javapas.Location = new System.Drawing.Point(439, 236);
            this.checkBox_javapas.Name = "checkBox_javapas";
            this.checkBox_javapas.Size = new System.Drawing.Size(66, 17);
            this.checkBox_javapas.TabIndex = 7;
            this.checkBox_javapas.Text = "Javapas";
            this.checkBox_javapas.UseVisualStyleBackColor = true;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(439, 306);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 8;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(33, 341);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "Fred";
            treeNode9.Text = "fred";
            treeNode10.Name = "Freddy";
            treeNode10.Text = "freddy";
            treeNode11.Name = "root";
            treeNode11.Text = "Root";
            treeNode12.Name = "PHILIPPE";
            treeNode12.Text = "root_PHILIPPE";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 76);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkBox_javapas);
            this.Controls.Add(this.checkBox_java);
            this.Controls.Add(this.checkBox_csharp);
            this.Controls.Add(this.radioButton_both);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.listBox_cities);
            this.Controls.Add(this.groupBox_userDetails);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.groupBox_userDetails.ResumeLayout(false);
            this.groupBox_userDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_userDetails;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ListBox listBox_cities;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_both;
        private System.Windows.Forms.CheckBox checkBox_csharp;
        private System.Windows.Forms.CheckBox checkBox_java;
        private System.Windows.Forms.CheckBox checkBox_javapas;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}