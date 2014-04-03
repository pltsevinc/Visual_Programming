namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_calculate = new System.Windows.Forms.Button();
            this.radioButton_add = new System.Windows.Forms.RadioButton();
            this.radioButton_Subs = new System.Windows.Forms.RadioButton();
            this.radioButton_mult = new System.Windows.Forms.RadioButton();
            this.radioButton_div = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_value1 = new System.Windows.Forms.TextBox();
            this.textBox_value2 = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "value1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "value2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "result:";
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(93, 160);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(75, 23);
            this.button_calculate.TabIndex = 2;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // radioButton_add
            // 
            this.radioButton_add.AutoSize = true;
            this.radioButton_add.Checked = true;
            this.radioButton_add.Location = new System.Drawing.Point(6, 19);
            this.radioButton_add.Name = "radioButton_add";
            this.radioButton_add.Size = new System.Drawing.Size(48, 17);
            this.radioButton_add.TabIndex = 7;
            this.radioButton_add.TabStop = true;
            this.radioButton_add.Text = "ADD";
            this.radioButton_add.UseVisualStyleBackColor = true;
            this.radioButton_add.CheckedChanged += new System.EventHandler(this.button_calculate_Click);
            // 
            // radioButton_Subs
            // 
            this.radioButton_Subs.AutoSize = true;
            this.radioButton_Subs.Location = new System.Drawing.Point(6, 43);
            this.radioButton_Subs.Name = "radioButton_Subs";
            this.radioButton_Subs.Size = new System.Drawing.Size(54, 17);
            this.radioButton_Subs.TabIndex = 8;
            this.radioButton_Subs.Text = "SUBS";
            this.radioButton_Subs.UseVisualStyleBackColor = true;
            this.radioButton_Subs.CheckedChanged += new System.EventHandler(this.button_calculate_Click);
            // 
            // radioButton_mult
            // 
            this.radioButton_mult.AutoSize = true;
            this.radioButton_mult.Location = new System.Drawing.Point(6, 68);
            this.radioButton_mult.Name = "radioButton_mult";
            this.radioButton_mult.Size = new System.Drawing.Size(55, 17);
            this.radioButton_mult.TabIndex = 9;
            this.radioButton_mult.Text = "MULT";
            this.radioButton_mult.UseVisualStyleBackColor = true;
            this.radioButton_mult.CheckedChanged += new System.EventHandler(this.button_calculate_Click);
            // 
            // radioButton_div
            // 
            this.radioButton_div.AutoSize = true;
            this.radioButton_div.Location = new System.Drawing.Point(6, 92);
            this.radioButton_div.Name = "radioButton_div";
            this.radioButton_div.Size = new System.Drawing.Size(43, 17);
            this.radioButton_div.TabIndex = 10;
            this.radioButton_div.Text = "DIV";
            this.radioButton_div.UseVisualStyleBackColor = true;
            this.radioButton_div.CheckedChanged += new System.EventHandler(this.button_calculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_add);
            this.groupBox1.Controls.Add(this.radioButton_div);
            this.groupBox1.Controls.Add(this.radioButton_Subs);
            this.groupBox1.Controls.Add(this.radioButton_mult);
            this.groupBox1.Location = new System.Drawing.Point(187, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 117);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the operator";
            // 
            // textBox_value1
            // 
            this.textBox_value1.Location = new System.Drawing.Point(72, 33);
            this.textBox_value1.Name = "textBox_value1";
            this.textBox_value1.Size = new System.Drawing.Size(100, 20);
            this.textBox_value1.TabIndex = 12;
            // 
            // textBox_value2
            // 
            this.textBox_value2.Location = new System.Drawing.Point(72, 69);
            this.textBox_value2.Name = "textBox_value2";
            this.textBox_value2.Size = new System.Drawing.Size(100, 20);
            this.textBox_value2.TabIndex = 13;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(72, 110);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 16);
            this.label_result.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 228);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_value2);
            this.Controls.Add(this.textBox_value1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.RadioButton radioButton_add;
        private System.Windows.Forms.RadioButton radioButton_Subs;
        private System.Windows.Forms.RadioButton radioButton_mult;
        private System.Windows.Forms.RadioButton radioButton_div;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_value1;
        private System.Windows.Forms.TextBox textBox_value2;
        private System.Windows.Forms.Label label_result;
    }
}

