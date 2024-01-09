namespace MYCAFE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Password = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepPink;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(266, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 323);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bell MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(319, 0);
            label6.Name = "label6";
            label6.Size = new Size(28, 25);
            label6.TabIndex = 6;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bell MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(93, 126);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 5;
            label5.Text = "By Pranso Mishra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SpringGreen;
            label4.Font = new Font("Bell MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(62, 94);
            label4.Name = "label4";
            label4.Size = new Size(238, 25);
            label4.TabIndex = 5;
            label4.Text = "Cafe_Mangement_System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(75, 30);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 1;
            label1.Text = "Cafe GudLuck";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(9, 192);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 0;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(87, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(87, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Password.ForeColor = Color.FromArgb(255, 128, 128);
            Password.Location = new Point(12, 235);
            Password.Name = "Password";
            Password.Size = new Size(66, 17);
            Password.TabIndex = 3;
            Password.Text = "Password";
            Password.Click += label2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepPink;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(87, 272);
            button1.Name = "button1";
            button1.Size = new Size(80, 28);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(109, 303);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Guest";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 323);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(Password);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Password;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}