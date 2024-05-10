namespace WindowsFormsApp1
{
    partial class Form2
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.تعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کالاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خریدوفروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.موجودیکالاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سودوزیانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gheymat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // تعToolStripMenuItem
            // 
            this.تعToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشتریToolStripMenuItem,
            this.کالاToolStripMenuItem});
            this.تعToolStripMenuItem.Name = "تعToolStripMenuItem";
            this.تعToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.تعToolStripMenuItem.Text = "تعاریف";
            // 
            // مشتریToolStripMenuItem
            // 
            this.مشتریToolStripMenuItem.Name = "مشتریToolStripMenuItem";
            this.مشتریToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.مشتریToolStripMenuItem.Text = "مشتری";
            this.مشتریToolStripMenuItem.Click += new System.EventHandler(this.مشتریToolStripMenuItem_Click);
            // 
            // کالاToolStripMenuItem
            // 
            this.کالاToolStripMenuItem.Name = "کالاToolStripMenuItem";
            this.کالاToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.کالاToolStripMenuItem.Text = "کالا";
            this.کالاToolStripMenuItem.Click += new System.EventHandler(this.کالاToolStripMenuItem_Click);
            // 
            // عملیاتToolStripMenuItem
            // 
            this.عملیاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خریدوفروشToolStripMenuItem,
            this.فروشToolStripMenuItem});
            this.عملیاتToolStripMenuItem.Name = "عملیاتToolStripMenuItem";
            this.عملیاتToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.عملیاتToolStripMenuItem.Text = "عملیات";
            // 
            // خریدوفروشToolStripMenuItem
            // 
            this.خریدوفروشToolStripMenuItem.Name = "خریدوفروشToolStripMenuItem";
            this.خریدوفروشToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.خریدوفروشToolStripMenuItem.Text = "خرید";
            // 
            // فروشToolStripMenuItem
            // 
            this.فروشToolStripMenuItem.Name = "فروشToolStripMenuItem";
            this.فروشToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.فروشToolStripMenuItem.Text = "فروش";
            // 
            // گزارشاتToolStripMenuItem
            // 
            this.گزارشاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.موجودیکالاToolStripMenuItem,
            this.سودوزیانToolStripMenuItem});
            this.گزارشاتToolStripMenuItem.Name = "گزارشاتToolStripMenuItem";
            this.گزارشاتToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.گزارشاتToolStripMenuItem.Text = "گزارشات";
            // 
            // موجودیکالاToolStripMenuItem
            // 
            this.موجودیکالاToolStripMenuItem.Name = "موجودیکالاToolStripMenuItem";
            this.موجودیکالاToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.موجودیکالاToolStripMenuItem.Text = "موجودی کالا";
            // 
            // سودوزیانToolStripMenuItem
            // 
            this.سودوزیانToolStripMenuItem.Name = "سودوزیانToolStripMenuItem";
            this.سودوزیانToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.سودوزیانToolStripMenuItem.Text = "سود و زیان";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعToolStripMenuItem,
            this.عملیاتToolStripMenuItem,
            this.گزارشاتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره برگه خرید:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاریخ:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(325, 8);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 51);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "کد مشتری:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "نام مشتری:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "تلفن:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "نشانی:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(52, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(247, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(52, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 20);
            this.textBox4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 130);
            this.panel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(401, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "کد کالا:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "نام کالا:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "قیمت:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "تعداد:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 20);
            this.button3.TabIndex = 0;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "موجودی کالا:";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(247, 14);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(120, 20);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(247, 42);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(134, 20);
            this.textBox6.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(232, 83);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(134, 20);
            this.textBox8.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(28, 42);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(131, 20);
            this.textBox5.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(28, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "درج در سبد خرید>>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(12, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 144);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.tedad,
            this.gheymat,
            this.kol});
            this.dataGridView1.Location = new System.Drawing.Point(512, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 187);
            this.dataGridView1.TabIndex = 2;
            // 
            // code
            // 
            this.code.HeaderText = "کد کالا";
            this.code.Name = "code";
            // 
            // name
            // 
            this.name.HeaderText = "نام کالا";
            this.name.Name = "name";
            // 
            // tedad
            // 
            this.tedad.HeaderText = "تعداد ";
            this.tedad.Name = "tedad";
            // 
            // gheymat
            // 
            this.gheymat.HeaderText = "قیمت واحد";
            this.gheymat.Name = "gheymat";
            // 
            // kol
            // 
            this.kol.HeaderText = "قیمت کل";
            this.kol.Name = "kol";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.textBox9);
            this.panel4.Controls.Add(this.textBox13);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(512, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 85);
            this.panel4.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(5, 10);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(107, 20);
            this.textBox9.TabIndex = 2;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(306, 10);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(120, 20);
            this.textBox13.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(432, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "مبلغ قابل پرداخت:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(980, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "خروج";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "تومان:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(709, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "چاپ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(512, 338);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(141, 35);
            this.text.TabIndex = 5;
            this.text.Text = "ثبت برگه خرید";
            this.text.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(902, 338);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 35);
            this.button8.TabIndex = 4;
            this.button8.Text = "پاک کردن";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 391);
            this.ControlBox = false;
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn gheymat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kol;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کالاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خریدوفروشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فروشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem موجودیکالاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سودوزیانToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button text;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}