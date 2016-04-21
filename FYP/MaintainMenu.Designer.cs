namespace Login
{
    partial class MaintainMenu
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
            this.tab_food = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_N = new System.Windows.Forms.CheckBox();
            this.chk_Y = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_FoodType = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_Search = new System.Windows.Forms.Label();
            this.btn_cancelFood = new System.Windows.Forms.Button();
            this.txt_imgName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_foodshortName = new System.Windows.Forms.TextBox();
            this.lab_foodshortName = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_maintain = new System.Windows.Forms.Button();
            this.combo_foodType = new System.Windows.Forms.ComboBox();
            this.combo_isShow = new System.Windows.Forms.ComboBox();
            this.num_dQty = new System.Windows.Forms.NumericUpDown();
            this.num_qty = new System.Windows.Forms.NumericUpDown();
            this.num_SPrice = new System.Windows.Forms.NumericUpDown();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.lab_isShow = new System.Windows.Forms.Label();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_dQty = new System.Windows.Forms.Label();
            this.lab_qty = new System.Windows.Forms.Label();
            this.lab_SPrice = new System.Windows.Forms.Label();
            this.lab_Price = new System.Windows.Forms.Label();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.lab_FName = new System.Windows.Forms.Label();
            this.txt_FID = new System.Windows.Forms.TextBox();
            this.lab_FID = new System.Windows.Forms.Label();
            this.DGW_show = new System.Windows.Forms.DataGridView();
            this.lab_FoodName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_food.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_show)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_food
            // 
            this.tab_food.BackColor = System.Drawing.Color.Transparent;
            this.tab_food.Controls.Add(this.splitContainer1);
            this.tab_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_food.Location = new System.Drawing.Point(4, 39);
            this.tab_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_food.Name = "tab_food";
            this.tab_food.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_food.Size = new System.Drawing.Size(1175, 721);
            this.tab_food.TabIndex = 0;
            this.tab_food.Text = "Food";
            this.tab_food.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lab_Search);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Azure;
            this.splitContainer1.Panel2.Controls.Add(this.btn_cancelFood);
            this.splitContainer1.Panel2.Controls.Add(this.txt_imgName);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.txt_foodshortName);
            this.splitContainer1.Panel2.Controls.Add(this.lab_foodshortName);
            this.splitContainer1.Panel2.Controls.Add(this.btn_save);
            this.splitContainer1.Panel2.Controls.Add(this.btn_add);
            this.splitContainer1.Panel2.Controls.Add(this.btn_maintain);
            this.splitContainer1.Panel2.Controls.Add(this.combo_foodType);
            this.splitContainer1.Panel2.Controls.Add(this.combo_isShow);
            this.splitContainer1.Panel2.Controls.Add(this.num_dQty);
            this.splitContainer1.Panel2.Controls.Add(this.num_qty);
            this.splitContainer1.Panel2.Controls.Add(this.num_SPrice);
            this.splitContainer1.Panel2.Controls.Add(this.num_price);
            this.splitContainer1.Panel2.Controls.Add(this.lab_isShow);
            this.splitContainer1.Panel2.Controls.Add(this.lab_type);
            this.splitContainer1.Panel2.Controls.Add(this.lab_dQty);
            this.splitContainer1.Panel2.Controls.Add(this.lab_qty);
            this.splitContainer1.Panel2.Controls.Add(this.lab_SPrice);
            this.splitContainer1.Panel2.Controls.Add(this.lab_Price);
            this.splitContainer1.Panel2.Controls.Add(this.txt_FName);
            this.splitContainer1.Panel2.Controls.Add(this.lab_FName);
            this.splitContainer1.Panel2.Controls.Add(this.txt_FID);
            this.splitContainer1.Panel2.Controls.Add(this.lab_FID);
            this.splitContainer1.Panel2.Controls.Add(this.DGW_show);
            this.splitContainer1.Panel2.Controls.Add(this.lab_FoodName);
            this.splitContainer1.Size = new System.Drawing.Size(1169, 717);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_N);
            this.groupBox2.Controls.Add(this.chk_Y);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.groupBox2.Location = new System.Drawing.Point(11, 393);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(237, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show:";
            // 
            // chk_N
            // 
            this.chk_N.AutoSize = true;
            this.chk_N.Location = new System.Drawing.Point(20, 66);
            this.chk_N.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_N.Name = "chk_N";
            this.chk_N.Size = new System.Drawing.Size(46, 28);
            this.chk_N.TabIndex = 1;
            this.chk_N.Text = "N";
            this.chk_N.UseVisualStyleBackColor = true;
            this.chk_N.CheckedChanged += new System.EventHandler(this.chk_N_CheckedChanged);
            // 
            // chk_Y
            // 
            this.chk_Y.AutoSize = true;
            this.chk_Y.Location = new System.Drawing.Point(20, 32);
            this.chk_Y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Y.Name = "chk_Y";
            this.chk_Y.Size = new System.Drawing.Size(43, 28);
            this.chk_Y.TabIndex = 0;
            this.chk_Y.Text = "Y";
            this.chk_Y.UseVisualStyleBackColor = true;
            this.chk_Y.CheckedChanged += new System.EventHandler(this.chk_Y_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_FoodType);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.groupBox1.Location = new System.Drawing.Point(9, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(243, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Type:";
            // 
            // btn_FoodType
            // 
            this.btn_FoodType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_FoodType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FoodType.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.btn_FoodType.Location = new System.Drawing.Point(3, 212);
            this.btn_FoodType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FoodType.Name = "btn_FoodType";
            this.btn_FoodType.Size = new System.Drawing.Size(237, 36);
            this.btn_FoodType.TabIndex = 8;
            this.btn_FoodType.Text = "Add Type";
            this.btn_FoodType.UseVisualStyleBackColor = true;
            this.btn_FoodType.Click += new System.EventHandler(this.btn_FoodType_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 30);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food Name:";
            // 
            // lab_Search
            // 
            this.lab_Search.AutoSize = true;
            this.lab_Search.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lab_Search.Location = new System.Drawing.Point(5, 2);
            this.lab_Search.Name = "lab_Search";
            this.lab_Search.Size = new System.Drawing.Size(84, 30);
            this.lab_Search.TabIndex = 2;
            this.lab_Search.Text = "Search";
            // 
            // btn_cancelFood
            // 
            this.btn_cancelFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelFood.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_cancelFood.Location = new System.Drawing.Point(728, 695);
            this.btn_cancelFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelFood.Name = "btn_cancelFood";
            this.btn_cancelFood.Size = new System.Drawing.Size(120, 42);
            this.btn_cancelFood.TabIndex = 32;
            this.btn_cancelFood.Text = "Cancel";
            this.btn_cancelFood.UseVisualStyleBackColor = true;
            this.btn_cancelFood.Visible = false;
            this.btn_cancelFood.Click += new System.EventHandler(this.btn_cancelFood_Click);
            // 
            // txt_imgName
            // 
            this.txt_imgName.Location = new System.Drawing.Point(24, 406);
            this.txt_imgName.Name = "txt_imgName";
            this.txt_imgName.Size = new System.Drawing.Size(100, 30);
            this.txt_imgName.TabIndex = 31;
            this.txt_imgName.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(25, 496);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_foodshortName
            // 
            this.txt_foodshortName.Enabled = false;
            this.txt_foodshortName.Location = new System.Drawing.Point(208, 539);
            this.txt_foodshortName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_foodshortName.Name = "txt_foodshortName";
            this.txt_foodshortName.Size = new System.Drawing.Size(593, 30);
            this.txt_foodshortName.TabIndex = 27;
            // 
            // lab_foodshortName
            // 
            this.lab_foodshortName.AutoSize = true;
            this.lab_foodshortName.Location = new System.Drawing.Point(204, 516);
            this.lab_foodshortName.Name = "lab_foodshortName";
            this.lab_foodshortName.Size = new System.Drawing.Size(172, 25);
            this.lab_foodshortName.TabIndex = 26;
            this.lab_foodshortName.Text = "Food Short Name:";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_save.Location = new System.Drawing.Point(587, 695);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 42);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_add.Location = new System.Drawing.Point(820, 490);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(141, 78);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_maintain
            // 
            this.btn_maintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maintain.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.btn_maintain.Location = new System.Drawing.Point(820, 601);
            this.btn_maintain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_maintain.Name = "btn_maintain";
            this.btn_maintain.Size = new System.Drawing.Size(141, 78);
            this.btn_maintain.TabIndex = 24;
            this.btn_maintain.Text = "Maintain";
            this.btn_maintain.UseVisualStyleBackColor = true;
            this.btn_maintain.Click += new System.EventHandler(this.btn_maintain_Click);
            // 
            // combo_foodType
            // 
            this.combo_foodType.Enabled = false;
            this.combo_foodType.FormattingEnabled = true;
            this.combo_foodType.Location = new System.Drawing.Point(27, 695);
            this.combo_foodType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_foodType.Name = "combo_foodType";
            this.combo_foodType.Size = new System.Drawing.Size(301, 33);
            this.combo_foodType.TabIndex = 20;
            // 
            // combo_isShow
            // 
            this.combo_isShow.Enabled = false;
            this.combo_isShow.FormattingEnabled = true;
            this.combo_isShow.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.combo_isShow.Location = new System.Drawing.Point(395, 695);
            this.combo_isShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_isShow.Name = "combo_isShow";
            this.combo_isShow.Size = new System.Drawing.Size(121, 33);
            this.combo_isShow.TabIndex = 19;
            // 
            // num_dQty
            // 
            this.num_dQty.Enabled = false;
            this.num_dQty.Location = new System.Drawing.Point(587, 627);
            this.num_dQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_dQty.Name = "num_dQty";
            this.num_dQty.Size = new System.Drawing.Size(120, 30);
            this.num_dQty.TabIndex = 18;
            // 
            // num_qty
            // 
            this.num_qty.Enabled = false;
            this.num_qty.Location = new System.Drawing.Point(395, 627);
            this.num_qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_qty.Name = "num_qty";
            this.num_qty.Size = new System.Drawing.Size(120, 30);
            this.num_qty.TabIndex = 17;
            // 
            // num_SPrice
            // 
            this.num_SPrice.DecimalPlaces = 1;
            this.num_SPrice.Enabled = false;
            this.num_SPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_SPrice.Location = new System.Drawing.Point(207, 627);
            this.num_SPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_SPrice.Name = "num_SPrice";
            this.num_SPrice.Size = new System.Drawing.Size(120, 30);
            this.num_SPrice.TabIndex = 16;
            // 
            // num_price
            // 
            this.num_price.DecimalPlaces = 1;
            this.num_price.Enabled = false;
            this.num_price.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_price.Location = new System.Drawing.Point(27, 627);
            this.num_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(120, 30);
            this.num_price.TabIndex = 15;
            // 
            // lab_isShow
            // 
            this.lab_isShow.AutoSize = true;
            this.lab_isShow.Location = new System.Drawing.Point(389, 672);
            this.lab_isShow.Name = "lab_isShow";
            this.lab_isShow.Size = new System.Drawing.Size(82, 25);
            this.lab_isShow.TabIndex = 13;
            this.lab_isShow.Text = "isShow:";
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Location = new System.Drawing.Point(21, 672);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(113, 25);
            this.lab_type.TabIndex = 11;
            this.lab_type.Text = "Food Type:";
            // 
            // lab_dQty
            // 
            this.lab_dQty.AutoSize = true;
            this.lab_dQty.Location = new System.Drawing.Point(583, 603);
            this.lab_dQty.Name = "lab_dQty";
            this.lab_dQty.Size = new System.Drawing.Size(110, 25);
            this.lab_dQty.TabIndex = 10;
            this.lab_dQty.Text = "D Quantity:";
            // 
            // lab_qty
            // 
            this.lab_qty.AutoSize = true;
            this.lab_qty.Location = new System.Drawing.Point(389, 603);
            this.lab_qty.Name = "lab_qty";
            this.lab_qty.Size = new System.Drawing.Size(91, 25);
            this.lab_qty.TabIndex = 9;
            this.lab_qty.Text = "Quantity:";
            // 
            // lab_SPrice
            // 
            this.lab_SPrice.AutoSize = true;
            this.lab_SPrice.Location = new System.Drawing.Point(203, 603);
            this.lab_SPrice.Name = "lab_SPrice";
            this.lab_SPrice.Size = new System.Drawing.Size(132, 25);
            this.lab_SPrice.TabIndex = 8;
            this.lab_SPrice.Text = "Special Price:";
            // 
            // lab_Price
            // 
            this.lab_Price.AutoSize = true;
            this.lab_Price.Location = new System.Drawing.Point(21, 603);
            this.lab_Price.Name = "lab_Price";
            this.lab_Price.Size = new System.Drawing.Size(62, 25);
            this.lab_Price.TabIndex = 7;
            this.lab_Price.Text = "Price:";
            // 
            // txt_FName
            // 
            this.txt_FName.Enabled = false;
            this.txt_FName.Location = new System.Drawing.Point(205, 462);
            this.txt_FName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(593, 30);
            this.txt_FName.TabIndex = 6;
            // 
            // lab_FName
            // 
            this.lab_FName.AutoSize = true;
            this.lab_FName.Location = new System.Drawing.Point(201, 438);
            this.lab_FName.Name = "lab_FName";
            this.lab_FName.Size = new System.Drawing.Size(120, 25);
            this.lab_FName.TabIndex = 5;
            this.lab_FName.Text = "Food Name:";
            // 
            // txt_FID
            // 
            this.txt_FID.Enabled = false;
            this.txt_FID.Location = new System.Drawing.Point(24, 462);
            this.txt_FID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FID.Name = "txt_FID";
            this.txt_FID.Size = new System.Drawing.Size(140, 30);
            this.txt_FID.TabIndex = 4;
            // 
            // lab_FID
            // 
            this.lab_FID.AutoSize = true;
            this.lab_FID.Location = new System.Drawing.Point(20, 438);
            this.lab_FID.Name = "lab_FID";
            this.lab_FID.Size = new System.Drawing.Size(87, 25);
            this.lab_FID.TabIndex = 3;
            this.lab_FID.Text = "Food ID:";
            // 
            // DGW_show
            // 
            this.DGW_show.AllowUserToAddRows = false;
            this.DGW_show.AllowUserToDeleteRows = false;
            this.DGW_show.BackgroundColor = System.Drawing.Color.Azure;
            this.DGW_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_show.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGW_show.Location = new System.Drawing.Point(0, 30);
            this.DGW_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGW_show.Name = "DGW_show";
            this.DGW_show.ReadOnly = true;
            this.DGW_show.RowTemplate.Height = 27;
            this.DGW_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW_show.Size = new System.Drawing.Size(1017, 387);
            this.DGW_show.TabIndex = 2;
            this.DGW_show.SelectionChanged += new System.EventHandler(this.DGW_show_SelectionChanged);
            // 
            // lab_FoodName
            // 
            this.lab_FoodName.AutoSize = true;
            this.lab_FoodName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_FoodName.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.lab_FoodName.Location = new System.Drawing.Point(0, 0);
            this.lab_FoodName.Name = "lab_FoodName";
            this.lab_FoodName.Size = new System.Drawing.Size(202, 30);
            this.lab_FoodName.TabIndex = 1;
            this.lab_FoodName.Text = "Food Information:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_food);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1183, 764);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // MaintainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1183, 764);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MaintainMenu";
            this.Text = "MaintainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintainMenu_Load);
            this.tab_food.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_show)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_food;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_N;
        private System.Windows.Forms.CheckBox chk_Y;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_FoodType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_Search;
        private System.Windows.Forms.Button btn_cancelFood;
        private System.Windows.Forms.TextBox txt_imgName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_foodshortName;
        private System.Windows.Forms.Label lab_foodshortName;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_maintain;
        public System.Windows.Forms.ComboBox combo_foodType;
        private System.Windows.Forms.ComboBox combo_isShow;
        private System.Windows.Forms.NumericUpDown num_dQty;
        private System.Windows.Forms.NumericUpDown num_qty;
        private System.Windows.Forms.NumericUpDown num_SPrice;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.Label lab_isShow;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_dQty;
        private System.Windows.Forms.Label lab_qty;
        private System.Windows.Forms.Label lab_SPrice;
        private System.Windows.Forms.Label lab_Price;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label lab_FName;
        private System.Windows.Forms.TextBox txt_FID;
        private System.Windows.Forms.Label lab_FID;
        private System.Windows.Forms.DataGridView DGW_show;
        private System.Windows.Forms.Label lab_FoodName;
        private System.Windows.Forms.TabControl tabControl1;



    }
}