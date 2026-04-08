namespace lab8_2
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tlpBtnsProducts = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tlpSearchProducts = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.boxSearchProduct = new System.Windows.Forms.TextBox();
            this.tabDishes = new System.Windows.Forms.TabPage();
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.tlpBtnsDishes = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveDish = new System.Windows.Forms.Button();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.tlpSearchDishes = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearchDish = new System.Windows.Forms.Label();
            this.boxSearchDish = new System.Windows.Forms.TextBox();
            this.tabRecipes = new System.Windows.Forms.TabPage();
            this.splitContainerRecipes = new System.Windows.Forms.SplitContainer();
            this.dgvDishesList = new System.Windows.Forms.DataGridView();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveIngredient = new System.Windows.Forms.Button();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.boxDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveMenu = new System.Windows.Forms.Button();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.dataSet = new lab8_2.DataSetNew();
            this.dishIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishIngredientsTableAdapter = new lab8_2.DataSetNewTableAdapters.DishIngredientsTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tlpBtnsProducts.SuspendLayout();
            this.tlpSearchProducts.SuspendLayout();
            this.tabDishes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.tlpBtnsDishes.SuspendLayout();
            this.tlpSearchDishes.SuspendLayout();
            this.tabRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).BeginInit();
            this.splitContainerRecipes.Panel1.SuspendLayout();
            this.splitContainerRecipes.Panel2.SuspendLayout();
            this.splitContainerRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishIngredientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProducts);
            this.tabControl.Controls.Add(this.tabDishes);
            this.tabControl.Controls.Add(this.tabRecipes);
            this.tabControl.Controls.Add(this.tabMenu);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(929, 512);
            this.tabControl.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.BackColor = System.Drawing.Color.Transparent;
            this.tabProducts.Controls.Add(this.dgvProducts);
            this.tabProducts.Controls.Add(this.tlpBtnsProducts);
            this.tabProducts.Controls.Add(this.tlpSearchProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 30);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(921, 478);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "📦 Продукты";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(3, 53);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(915, 372);
            this.dgvProducts.TabIndex = 2;
            // 
            // tlpBtnsProducts
            // 
            this.tlpBtnsProducts.ColumnCount = 3;
            this.tlpBtnsProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBtnsProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBtnsProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBtnsProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBtnsProducts.Controls.Add(this.btnSaveProduct, 2, 0);
            this.tlpBtnsProducts.Controls.Add(this.btnDeleteProduct, 1, 0);
            this.tlpBtnsProducts.Controls.Add(this.btnAddProduct, 0, 0);
            this.tlpBtnsProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBtnsProducts.Location = new System.Drawing.Point(3, 425);
            this.tlpBtnsProducts.Name = "tlpBtnsProducts";
            this.tlpBtnsProducts.RowCount = 1;
            this.tlpBtnsProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBtnsProducts.Size = new System.Drawing.Size(915, 50);
            this.tlpBtnsProducts.TabIndex = 1;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveProduct.BackColor = System.Drawing.Color.MistyRose;
            this.btnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProduct.FlatAppearance.BorderSize = 0;
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Location = new System.Drawing.Point(701, 8);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(123, 33);
            this.btnSaveProduct.TabIndex = 6;
            this.btnSaveProduct.Text = "💾 Сохранить";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Location = new System.Drawing.Point(403, 8);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(109, 33);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "🗑 Удалить";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduct.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Location = new System.Drawing.Point(92, 8);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 33);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "➕ Добавить";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tlpSearchProducts
            // 
            this.tlpSearchProducts.ColumnCount = 2;
            this.tlpSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSearchProducts.Controls.Add(this.lblSearchProduct, 0, 0);
            this.tlpSearchProducts.Controls.Add(this.boxSearchProduct, 1, 0);
            this.tlpSearchProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpSearchProducts.Location = new System.Drawing.Point(3, 3);
            this.tlpSearchProducts.Name = "tlpSearchProducts";
            this.tlpSearchProducts.RowCount = 1;
            this.tlpSearchProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchProducts.Size = new System.Drawing.Size(915, 50);
            this.tlpSearchProducts.TabIndex = 0;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Location = new System.Drawing.Point(34, 14);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(83, 21);
            this.lblSearchProduct.TabIndex = 0;
            this.lblSearchProduct.Text = "🔍 Поиск:";
            // 
            // boxSearchProduct
            // 
            this.boxSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSearchProduct.Location = new System.Drawing.Point(154, 10);
            this.boxSearchProduct.Name = "boxSearchProduct";
            this.boxSearchProduct.Size = new System.Drawing.Size(758, 29);
            this.boxSearchProduct.TabIndex = 1;
            this.boxSearchProduct.TextChanged += new System.EventHandler(this.boxSearchProduct_TextChanged);
            // 
            // tabDishes
            // 
            this.tabDishes.Controls.Add(this.dgvDishes);
            this.tabDishes.Controls.Add(this.tlpBtnsDishes);
            this.tabDishes.Controls.Add(this.tlpSearchDishes);
            this.tabDishes.Location = new System.Drawing.Point(4, 30);
            this.tabDishes.Name = "tabDishes";
            this.tabDishes.Padding = new System.Windows.Forms.Padding(3);
            this.tabDishes.Size = new System.Drawing.Size(921, 478);
            this.tabDishes.TabIndex = 1;
            this.tabDishes.Text = "🍽 Блюда";
            this.tabDishes.UseVisualStyleBackColor = true;
            // 
            // dgvDishes
            // 
            this.dgvDishes.AllowUserToAddRows = false;
            this.dgvDishes.AllowUserToDeleteRows = false;
            this.dgvDishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDishes.Location = new System.Drawing.Point(3, 53);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.Size = new System.Drawing.Size(915, 372);
            this.dgvDishes.TabIndex = 3;
            // 
            // tlpBtnsDishes
            // 
            this.tlpBtnsDishes.ColumnCount = 3;
            this.tlpBtnsDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBtnsDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBtnsDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBtnsDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBtnsDishes.Controls.Add(this.btnSaveDish, 2, 0);
            this.tlpBtnsDishes.Controls.Add(this.btnDeleteDish, 1, 0);
            this.tlpBtnsDishes.Controls.Add(this.btnAddDish, 0, 0);
            this.tlpBtnsDishes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBtnsDishes.Location = new System.Drawing.Point(3, 425);
            this.tlpBtnsDishes.Name = "tlpBtnsDishes";
            this.tlpBtnsDishes.RowCount = 1;
            this.tlpBtnsDishes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBtnsDishes.Size = new System.Drawing.Size(915, 50);
            this.tlpBtnsDishes.TabIndex = 2;
            // 
            // btnSaveDish
            // 
            this.btnSaveDish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveDish.BackColor = System.Drawing.Color.MistyRose;
            this.btnSaveDish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveDish.FlatAppearance.BorderSize = 0;
            this.btnSaveDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDish.Location = new System.Drawing.Point(701, 8);
            this.btnSaveDish.Name = "btnSaveDish";
            this.btnSaveDish.Size = new System.Drawing.Size(123, 33);
            this.btnSaveDish.TabIndex = 6;
            this.btnSaveDish.Text = "💾 Сохранить";
            this.btnSaveDish.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDish
            // 
            this.btnDeleteDish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteDish.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteDish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDish.FlatAppearance.BorderSize = 0;
            this.btnDeleteDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDish.Location = new System.Drawing.Point(403, 8);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(109, 33);
            this.btnDeleteDish.TabIndex = 5;
            this.btnDeleteDish.Text = "🗑 Удалить";
            this.btnDeleteDish.UseVisualStyleBackColor = false;
            // 
            // btnAddDish
            // 
            this.btnAddDish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDish.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddDish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDish.FlatAppearance.BorderSize = 0;
            this.btnAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDish.Location = new System.Drawing.Point(92, 8);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(120, 33);
            this.btnAddDish.TabIndex = 3;
            this.btnAddDish.Text = "➕ Добавить";
            this.btnAddDish.UseVisualStyleBackColor = false;
            // 
            // tlpSearchDishes
            // 
            this.tlpSearchDishes.ColumnCount = 2;
            this.tlpSearchDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSearchDishes.Controls.Add(this.lblSearchDish, 0, 0);
            this.tlpSearchDishes.Controls.Add(this.boxSearchDish, 1, 0);
            this.tlpSearchDishes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpSearchDishes.Location = new System.Drawing.Point(3, 3);
            this.tlpSearchDishes.Name = "tlpSearchDishes";
            this.tlpSearchDishes.RowCount = 1;
            this.tlpSearchDishes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchDishes.Size = new System.Drawing.Size(915, 50);
            this.tlpSearchDishes.TabIndex = 1;
            // 
            // lblSearchDish
            // 
            this.lblSearchDish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchDish.AutoSize = true;
            this.lblSearchDish.Location = new System.Drawing.Point(34, 14);
            this.lblSearchDish.Name = "lblSearchDish";
            this.lblSearchDish.Size = new System.Drawing.Size(83, 21);
            this.lblSearchDish.TabIndex = 0;
            this.lblSearchDish.Text = "🔍 Поиск:";
            // 
            // boxSearchDish
            // 
            this.boxSearchDish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSearchDish.Location = new System.Drawing.Point(154, 10);
            this.boxSearchDish.Name = "boxSearchDish";
            this.boxSearchDish.Size = new System.Drawing.Size(758, 29);
            this.boxSearchDish.TabIndex = 1;
            this.boxSearchDish.TextChanged += new System.EventHandler(this.boxSearchDish_TextChanged);
            // 
            // tabRecipes
            // 
            this.tabRecipes.Controls.Add(this.splitContainerRecipes);
            this.tabRecipes.Controls.Add(this.tableLayoutPanel1);
            this.tabRecipes.Location = new System.Drawing.Point(4, 30);
            this.tabRecipes.Name = "tabRecipes";
            this.tabRecipes.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecipes.Size = new System.Drawing.Size(921, 478);
            this.tabRecipes.TabIndex = 2;
            this.tabRecipes.Text = "📜 Рецепты";
            this.tabRecipes.UseVisualStyleBackColor = true;
            // 
            // splitContainerRecipes
            // 
            this.splitContainerRecipes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipes.IsSplitterFixed = true;
            this.splitContainerRecipes.Location = new System.Drawing.Point(3, 3);
            this.splitContainerRecipes.Name = "splitContainerRecipes";
            // 
            // splitContainerRecipes.Panel1
            // 
            this.splitContainerRecipes.Panel1.Controls.Add(this.dgvDishesList);
            // 
            // splitContainerRecipes.Panel2
            // 
            this.splitContainerRecipes.Panel2.Controls.Add(this.dgvIngredients);
            this.splitContainerRecipes.Size = new System.Drawing.Size(915, 422);
            this.splitContainerRecipes.SplitterDistance = 350;
            this.splitContainerRecipes.TabIndex = 0;
            // 
            // dgvDishesList
            // 
            this.dgvDishesList.AllowUserToAddRows = false;
            this.dgvDishesList.AllowUserToDeleteRows = false;
            this.dgvDishesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDishesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDishesList.Location = new System.Drawing.Point(0, 0);
            this.dgvDishesList.Name = "dgvDishesList";
            this.dgvDishesList.ReadOnly = true;
            this.dgvDishesList.Size = new System.Drawing.Size(348, 420);
            this.dgvDishesList.TabIndex = 0;
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            this.dgvIngredients.AllowUserToDeleteRows = false;
            this.dgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIngredients.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngredients.Location = new System.Drawing.Point(0, 0);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.Size = new System.Drawing.Size(559, 420);
            this.dgvIngredients.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveIngredient, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteIngredient, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddIngredient, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 425);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSaveIngredient
            // 
            this.btnSaveIngredient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveIngredient.BackColor = System.Drawing.Color.MistyRose;
            this.btnSaveIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveIngredient.FlatAppearance.BorderSize = 0;
            this.btnSaveIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveIngredient.Location = new System.Drawing.Point(701, 8);
            this.btnSaveIngredient.Name = "btnSaveIngredient";
            this.btnSaveIngredient.Size = new System.Drawing.Size(123, 33);
            this.btnSaveIngredient.TabIndex = 7;
            this.btnSaveIngredient.Text = "💾 Сохранить";
            this.btnSaveIngredient.UseVisualStyleBackColor = false;
            this.btnSaveIngredient.Click += new System.EventHandler(this.btnSaveIngredient_Click);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteIngredient.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteIngredient.FlatAppearance.BorderSize = 0;
            this.btnDeleteIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteIngredient.Location = new System.Drawing.Point(403, 8);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(109, 33);
            this.btnDeleteIngredient.TabIndex = 6;
            this.btnDeleteIngredient.Text = "🗑 Удалить";
            this.btnDeleteIngredient.UseVisualStyleBackColor = false;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddIngredient.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIngredient.FlatAppearance.BorderSize = 0;
            this.btnAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngredient.Location = new System.Drawing.Point(92, 8);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(120, 33);
            this.btnAddIngredient.TabIndex = 4;
            this.btnAddIngredient.Text = "➕ Добавить";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.dgvMenu);
            this.tabMenu.Controls.Add(this.tableLayoutPanel3);
            this.tabMenu.Controls.Add(this.tableLayoutPanel2);
            this.tabMenu.Location = new System.Drawing.Point(4, 30);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(921, 478);
            this.tabMenu.TabIndex = 3;
            this.tabMenu.Text = "📅 Меню";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(3, 53);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(915, 372);
            this.dgvMenu.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.boxDate, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(915, 50);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // boxDate
            // 
            this.boxDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxDate.Location = new System.Drawing.Point(357, 10);
            this.boxDate.Name = "boxDate";
            this.boxDate.Size = new System.Drawing.Size(200, 29);
            this.boxDate.TabIndex = 1;
            this.boxDate.ValueChanged += new System.EventHandler(this.boxDate_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnSaveMenu, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteMenu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddMenu, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 425);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(915, 50);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveMenu.BackColor = System.Drawing.Color.MistyRose;
            this.btnSaveMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveMenu.FlatAppearance.BorderSize = 0;
            this.btnSaveMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMenu.Location = new System.Drawing.Point(701, 8);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(123, 33);
            this.btnSaveMenu.TabIndex = 6;
            this.btnSaveMenu.Text = "💾 Сохранить";
            this.btnSaveMenu.UseVisualStyleBackColor = false;
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteMenu.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMenu.FlatAppearance.BorderSize = 0;
            this.btnDeleteMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMenu.Location = new System.Drawing.Point(403, 8);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(109, 33);
            this.btnDeleteMenu.TabIndex = 5;
            this.btnDeleteMenu.Text = "🗑 Удалить";
            this.btnDeleteMenu.UseVisualStyleBackColor = false;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMenu.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMenu.FlatAppearance.BorderSize = 0;
            this.btnAddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMenu.Location = new System.Drawing.Point(92, 8);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(120, 33);
            this.btnAddMenu.TabIndex = 3;
            this.btnAddMenu.Text = "➕ Добавить";
            this.btnAddMenu.UseVisualStyleBackColor = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishIngredientsBindingSource
            // 
            this.dishIngredientsBindingSource.DataMember = "DishIngredients";
            this.dishIngredientsBindingSource.DataSource = this.dataSet;
            // 
            // dishIngredientsTableAdapter
            // 
            this.dishIngredientsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 512);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Админ панель";
            this.tabControl.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tlpBtnsProducts.ResumeLayout(false);
            this.tlpSearchProducts.ResumeLayout(false);
            this.tlpSearchProducts.PerformLayout();
            this.tabDishes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.tlpBtnsDishes.ResumeLayout(false);
            this.tlpSearchDishes.ResumeLayout(false);
            this.tlpSearchDishes.PerformLayout();
            this.tabRecipes.ResumeLayout(false);
            this.splitContainerRecipes.Panel1.ResumeLayout(false);
            this.splitContainerRecipes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).EndInit();
            this.splitContainerRecipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishIngredientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabDishes;
        private System.Windows.Forms.TabPage tabRecipes;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TableLayoutPanel tlpBtnsProducts;
        private System.Windows.Forms.TableLayoutPanel tlpSearchProducts;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.TextBox boxSearchProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvDishes;
        private System.Windows.Forms.TableLayoutPanel tlpBtnsDishes;
        private System.Windows.Forms.Button btnSaveDish;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.TableLayoutPanel tlpSearchDishes;
        private System.Windows.Forms.Label lblSearchDish;
        private System.Windows.Forms.TextBox boxSearchDish;
        private System.Windows.Forms.SplitContainer splitContainerRecipes;
        private System.Windows.Forms.DataGridView dgvDishesList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private DataSetNew dataSet;
        private System.Windows.Forms.BindingSource dishIngredientsBindingSource;
        private DataSetNewTableAdapters.DishIngredientsTableAdapter dishIngredientsTableAdapter;
        private System.Windows.Forms.Button btnSaveIngredient;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker boxDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSaveMenu;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnAddMenu;
    }
}