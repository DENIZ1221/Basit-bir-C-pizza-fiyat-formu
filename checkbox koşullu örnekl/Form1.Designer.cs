namespace checkbox_koşullu_örnekl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            checkBox1Zeytin = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox4Mısır = new CheckBox();
            checkBox3Sosis = new CheckBox();
            checkBox2Sucuk = new CheckBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(111, 250);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 49);
            label1.Name = "label1";
            label1.Size = new Size(434, 20);
            label1.TabIndex = 1;
            label1.Text = "Sabit pizza fiyatı 75 tl.Eklemelerle beraber ücrette artış olacaktır.";
            // 
            // checkBox1Zeytin
            // 
            checkBox1Zeytin.AutoSize = true;
            checkBox1Zeytin.Location = new Point(6, 26);
            checkBox1Zeytin.Name = "checkBox1Zeytin";
            checkBox1Zeytin.Size = new Size(113, 24);
            checkBox1Zeytin.TabIndex = 2;
            checkBox1Zeytin.Text = "Zeytin(15TL)";
            checkBox1Zeytin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox4Mısır);
            groupBox1.Controls.Add(checkBox3Sosis);
            groupBox1.Controls.Add(checkBox1Zeytin);
            groupBox1.Controls.Add(checkBox2Sucuk);
            groupBox1.Location = new Point(105, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 155);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Malzemeler";
            // 
            // checkBox4Mısır
            // 
            checkBox4Mısır.AutoSize = true;
            checkBox4Mısır.Location = new Point(6, 116);
            checkBox4Mısır.Name = "checkBox4Mısır";
            checkBox4Mısır.Size = new Size(104, 24);
            checkBox4Mısır.TabIndex = 6;
            checkBox4Mısır.Text = "Mısır(10TL)";
            checkBox4Mısır.UseVisualStyleBackColor = true;
            // 
            // checkBox3Sosis
            // 
            checkBox3Sosis.AutoSize = true;
            checkBox3Sosis.Location = new Point(6, 86);
            checkBox3Sosis.Name = "checkBox3Sosis";
            checkBox3Sosis.Size = new Size(105, 24);
            checkBox3Sosis.TabIndex = 5;
            checkBox3Sosis.Text = "Sosis(20TL)";
            checkBox3Sosis.UseVisualStyleBackColor = true;
            // 
            // checkBox2Sucuk
            // 
            checkBox2Sucuk.AutoSize = true;
            checkBox2Sucuk.Location = new Point(6, 56);
            checkBox2Sucuk.Name = "checkBox2Sucuk";
            checkBox2Sucuk.Size = new Size(110, 24);
            checkBox2Sucuk.TabIndex = 4;
            checkBox2Sucuk.Text = "Sucuk(25TL)";
            checkBox2Sucuk.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 252);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckBox checkBox1Zeytin;
        private GroupBox groupBox1;
        private CheckBox checkBox4Mısır;
        private CheckBox checkBox3Sosis;
        private CheckBox checkBox2Sucuk;
        private TextBox textBox1;
    }
}
