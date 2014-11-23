namespace PartyCalc
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
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabDinnerParty = new System.Windows.Forms.TabPage();
            this.tabBirthdayParty = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxBirthdayFancy = new System.Windows.Forms.CheckBox();
            this.numericUpDownBirthday = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfPeople = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tab.SuspendLayout();
            this.tabDinnerParty.SuspendLayout();
            this.tabBirthdayParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(40, 86);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(114, 17);
            this.fancyBox.TabIndex = 0;
            this.fancyBox.Text = "Decoração chique";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(40, 122);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(104, 17);
            this.healthyBox.TabIndex = 1;
            this.healthyBox.Text = "Opção saudável";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(45, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Pessoas";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(42, 164);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(33, 13);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "custo";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabDinnerParty);
            this.tab.Controls.Add(this.tabBirthdayParty);
            this.tab.Location = new System.Drawing.Point(-5, 3);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(387, 247);
            this.tab.TabIndex = 5;
            // 
            // tabDinnerParty
            // 
            this.tabDinnerParty.Controls.Add(this.numericUpDown1);
            this.tabDinnerParty.Controls.Add(this.costLabel);
            this.tabDinnerParty.Controls.Add(this.label1);
            this.tabDinnerParty.Controls.Add(this.fancyBox);
            this.tabDinnerParty.Controls.Add(this.healthyBox);
            this.tabDinnerParty.Location = new System.Drawing.Point(4, 22);
            this.tabDinnerParty.Name = "tabDinnerParty";
            this.tabDinnerParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinnerParty.Size = new System.Drawing.Size(379, 221);
            this.tabDinnerParty.TabIndex = 0;
            this.tabDinnerParty.Text = "DinnerParty";
            this.tabDinnerParty.UseVisualStyleBackColor = true;
            this.tabDinnerParty.Click += new System.EventHandler(this.tabDinnerParty_Click);
            // 
            // tabBirthdayParty
            // 
            this.tabBirthdayParty.Controls.Add(this.checkBox2);
            this.tabBirthdayParty.Controls.Add(this.checkBoxBirthdayFancy);
            this.tabBirthdayParty.Controls.Add(this.numericUpDownBirthday);
            this.tabBirthdayParty.Controls.Add(this.labelNumberOfPeople);
            this.tabBirthdayParty.Location = new System.Drawing.Point(4, 22);
            this.tabBirthdayParty.Name = "tabBirthdayParty";
            this.tabBirthdayParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabBirthdayParty.Size = new System.Drawing.Size(379, 221);
            this.tabBirthdayParty.TabIndex = 1;
            this.tabBirthdayParty.Text = "BirthdayParty";
            this.tabBirthdayParty.UseVisualStyleBackColor = true;
            this.tabBirthdayParty.Click += new System.EventHandler(this.tabBirthdayParty_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(170, 165);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBoxBirthdayFancy
            // 
            this.checkBoxBirthdayFancy.AutoSize = true;
            this.checkBoxBirthdayFancy.Checked = true;
            this.checkBoxBirthdayFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBirthdayFancy.Location = new System.Drawing.Point(170, 131);
            this.checkBoxBirthdayFancy.Name = "checkBoxBirthdayFancy";
            this.checkBoxBirthdayFancy.Size = new System.Drawing.Size(80, 17);
            this.checkBoxBirthdayFancy.TabIndex = 2;
            this.checkBoxBirthdayFancy.Text = "checkBox1";
            this.checkBoxBirthdayFancy.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBirthday
            // 
            this.numericUpDownBirthday.Location = new System.Drawing.Point(170, 84);
            this.numericUpDownBirthday.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownBirthday.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBirthday.Name = "numericUpDownBirthday";
            this.numericUpDownBirthday.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBirthday.TabIndex = 1;
            this.numericUpDownBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelNumberOfPeople
            // 
            this.labelNumberOfPeople.AutoSize = true;
            this.labelNumberOfPeople.Location = new System.Drawing.Point(167, 47);
            this.labelNumberOfPeople.Name = "labelNumberOfPeople";
            this.labelNumberOfPeople.Size = new System.Drawing.Size(102, 13);
            this.labelNumberOfPeople.TabIndex = 0;
            this.labelNumberOfPeople.Text = "Numero de Pessoas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 268);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabDinnerParty.ResumeLayout(false);
            this.tabDinnerParty.PerformLayout();
            this.tabBirthdayParty.ResumeLayout(false);
            this.tabBirthdayParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabDinnerParty;
        private System.Windows.Forms.TabPage tabBirthdayParty;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxBirthdayFancy;
        private System.Windows.Forms.NumericUpDown numericUpDownBirthday;
        private System.Windows.Forms.Label labelNumberOfPeople;
    }
}

