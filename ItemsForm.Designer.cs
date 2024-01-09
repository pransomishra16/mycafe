namespace MYCAFE
{
    partial class ItemsForm
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
            ItemsGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Category = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ItemsGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bell MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(905, 16);
            label6.Name = "label6";
            label6.Size = new Size(28, 25);
            label6.TabIndex = 20;
            label6.Text = "X";
            // 
            // ItemsGV
            // 
            ItemsGV.BackgroundColor = SystemColors.ControlLightLight;
            ItemsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemsGV.Location = new Point(286, 106);
            ItemsGV.Name = "ItemsGV";
            ItemsGV.RowTemplate.Height = 25;
            ItemsGV.Size = new Size(451, 310);
            ItemsGV.TabIndex = 5;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(37, 167);
            button4.Name = "button4";
            button4.Size = new Size(86, 23);
            button4.TabIndex = 24;
            button4.Text = "User";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(37, 113);
            button3.Name = "button3";
            button3.Size = new Size(86, 23);
            button3.TabIndex = 23;
            button3.Text = "Order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepPink;
            label2.Font = new Font("Bodoni MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(37, 513);
            label2.Name = "label2";
            label2.Size = new Size(87, 29);
            label2.TabIndex = 22;
            label2.Text = "Logout";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.OutlineButton;
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(ItemsGV);
            panel1.Controls.Add(Category);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(131, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 511);
            panel1.TabIndex = 21;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(165, 341);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 23;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(84, 341);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.DeepPink;
            label8.Location = new Point(461, 69);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 21;
            label8.Text = "Item List";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DeepPink;
            label7.Location = new Point(17, 214);
            label7.Name = "label7";
            label7.Size = new Size(78, 18);
            label7.TabIndex = 20;
            label7.Text = "Item_Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DeepPink;
            label5.Location = new Point(17, 172);
            label5.Name = "label5";
            label5.Size = new Size(36, 18);
            label5.TabIndex = 19;
            label5.Text = "Item";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepPink;
            label4.Location = new Point(17, 123);
            label4.Name = "label4";
            label4.Size = new Size(36, 18);
            label4.TabIndex = 18;
            label4.Text = "Item";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 214);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Quantity";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 341);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 172);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Seller_Name";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 128);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Order_Number";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 11;
            // 
            // Category
            // 
            Category.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "Tea", "Coffe", "Cold-Drink", "Vadapaav", "Samosa", "Misal", "Poha", "Upit", "potato bhaji", "Kanda bhaji", "Gulab-Jamun", "Tari-Poha", "Paan", "Daal wada" });
            Category.Location = new Point(101, 79);
            Category.Name = "Category";
            Category.RightToLeft = RightToLeft.No;
            Category.Size = new Size(179, 25);
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
            label1.Size = new Size(136, 25);
            label1.TabIndex = 2;
            label1.Text = "Manage Item";
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(971, 571);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemsForm";
            ((System.ComponentModel.ISupportInitialize)ItemsGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView ItemsGV;
        private Button button4;
        private Button button3;
        private Label label2;
        private Panel panel1;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox Category;
        private Label label1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label8;
        private Button button5;
        private Button button2;
    }
}