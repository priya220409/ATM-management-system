namespace ATM_
{
    partial class changepin
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Highlight;
            textBox1.Font = new Font("Segoe UI Symbol", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(-1, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(801, 69);
            textBox1.TabIndex = 3;
            textBox1.Text = "          ATM MANAGEMENT SYSTEM";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.HotTrack;
            textBox2.Location = new Point(237, 114);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 34);
            textBox2.TabIndex = 4;
            textBox2.Text = "NEW PIN";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(237, 154);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 33);
            textBox3.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = SystemColors.HotTrack;
            textBox5.Location = new Point(237, 204);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 34);
            textBox5.TabIndex = 7;
            textBox5.Text = "CONFIRM PIN";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(237, 244);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(251, 36);
            textBox6.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(377, 322);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 29;
            button1.Text = "log out";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(255, 322);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 30;
            button2.Text = "change";
            button2.UseVisualStyleBackColor = false;
            // 
            // changepin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "changepin";
            Text = "changepin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
    }
}
