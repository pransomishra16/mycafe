namespace MYCAFE
{
    partial class UserOrder
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
            label6 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            ItemsGV = new DataGridView();
            Category = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bell MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(880, 2);
            label6.Name = "label6";
            label6.Size = new Size(28, 25);
            label6.TabIndex = 8;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.OutlineButton;
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(Category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(106, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 511);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(356, 473);
            button2.Name = "button2";
            button2.Size = new Size(183, 23);
            button2.TabIndex = 17;
            button2.Text = "Place The Order";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(254, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(463, 168);
            dataGridView1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepPink;
            label4.Location = new Point(345, 266);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 15;
            label4.Text = "Your Order";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 214);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Quantity";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(63, 266);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Add Cart";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 171);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Seller_Name";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 124);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Order_Number";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepPink;
            label3.Location = new Point(604, 469);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 10;
            label3.Text = "Order Amount";
            // 
            // ItemsGV
            // 
            ItemsGV.BackgroundColor = SystemColors.ControlLightLight;
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsGV.Location = new Point(254, 69);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.RowTemplate.Height = 25;
            ItemsGV.Size = new Size(463, 168);
            ItemsGV.TabIndex = 5;
            ItemsGV.CellContentClick += ItemsGV_CellContentClick;
            // 
            // Category
            // 
            Category.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "Tea", "Coffe", "Cold-Drink", "Vadapaav", "Samosa", "Misal", "Poha", "Upit", "potato bhaji", "Kanda bhaji", "Gulab-Jamun", "Tari-Poha", "Paan", "Daal wada" });
            Category.Location = new Point(41, 69);
            Category.Name = "Category";
            Category.RightToLeft = RightToLeft.No;
            Category.Size = new Size(179, 34);
            Category.TabIndex = 3;
            Category.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(323, 26);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 2;
            label1.Text = "Place Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepPink;
            label2.Font = new Font("Bodoni MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 499);
            label2.Name = "label2";
            label2.Size = new Size(87, 29);
            label2.TabIndex = 10;
            label2.Text = "Logout";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 99);
            button3.Name = "button3";
            button3.Size = new Size(86, 23);
            button3.TabIndex = 18;
            button3.Text = "Item";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 153);
            button4.Name = "button4";
            button4.Size = new Size(86, 23);
            button4.TabIndex = 19;
            button4.Text = "User";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UserOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(971, 571);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private DataGridView ItemsGV;
        private ComboBox Category;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
    }
}