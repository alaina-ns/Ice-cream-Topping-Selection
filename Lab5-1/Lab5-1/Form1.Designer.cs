namespace Lab5_1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sugarConeRadioButton = new System.Windows.Forms.RadioButton();
            this.waffleConeRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flavorsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toppingsListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Lab5_1.Properties.Resources.creami;
            this.pictureBox1.Location = new System.Drawing.Point(62, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cone Type:";
            // 
            // sugarConeRadioButton
            // 
            this.sugarConeRadioButton.AutoSize = true;
            this.sugarConeRadioButton.Checked = true;
            this.sugarConeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sugarConeRadioButton.Location = new System.Drawing.Point(99, 205);
            this.sugarConeRadioButton.Name = "sugarConeRadioButton";
            this.sugarConeRadioButton.Size = new System.Drawing.Size(90, 19);
            this.sugarConeRadioButton.TabIndex = 2;
            this.sugarConeRadioButton.TabStop = true;
            this.sugarConeRadioButton.Text = "Sugar Cone";
            this.sugarConeRadioButton.UseVisualStyleBackColor = true;
            // 
            // waffleConeRadioButton
            // 
            this.waffleConeRadioButton.AutoSize = true;
            this.waffleConeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waffleConeRadioButton.Location = new System.Drawing.Point(195, 205);
            this.waffleConeRadioButton.Name = "waffleConeRadioButton";
            this.waffleConeRadioButton.Size = new System.Drawing.Size(91, 19);
            this.waffleConeRadioButton.TabIndex = 3;
            this.waffleConeRadioButton.TabStop = true;
            this.waffleConeRadioButton.Text = "Waffle Cone";
            this.waffleConeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ice Cream Flavor:";
            // 
            // flavorsComboBox
            // 
            this.flavorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flavorsComboBox.FormattingEnabled = true;
            this.flavorsComboBox.Location = new System.Drawing.Point(151, 249);
            this.flavorsComboBox.Name = "flavorsComboBox";
            this.flavorsComboBox.Size = new System.Drawing.Size(121, 21);
            this.flavorsComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toppings:";
            // 
            // toppingsListBox
            // 
            this.toppingsListBox.FormattingEnabled = true;
            this.toppingsListBox.Location = new System.Drawing.Point(153, 288);
            this.toppingsListBox.Name = "toppingsListBox";
            this.toppingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.toppingsListBox.Size = new System.Drawing.Size(120, 95);
            this.toppingsListBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(39, 419);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(211, 419);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 502);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.toppingsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flavorsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.waffleConeRadioButton);
            this.Controls.Add(this.sugarConeRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Joe\'s Ice Cream Emporium";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sugarConeRadioButton;
        private System.Windows.Forms.RadioButton waffleConeRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox flavorsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox toppingsListBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
    }
}

