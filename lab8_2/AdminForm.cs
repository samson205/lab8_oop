using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_2
{
    public partial class AdminForm : Form
    {
        private DataSetNew ds = new DataSetNew();

        private DataSetNewTableAdapters.ProductsTableAdapter productsAdapter = new DataSetNewTableAdapters.ProductsTableAdapter();
        private DataSetNewTableAdapters.DishesTableAdapter dishesAdapter = new DataSetNewTableAdapters.DishesTableAdapter();
        private DataSetNewTableAdapters.DishIngredientsTableAdapter ingredientsAdapter = new DataSetNewTableAdapters.DishIngredientsTableAdapter();
        private DataSetNewTableAdapters.MenuTableAdapter menuAdapter = new DataSetNewTableAdapters.MenuTableAdapter();

        private BindingSource bsProducts = new BindingSource();
        private BindingSource bsDishes = new BindingSource();
        private BindingSource bsIngredients = new BindingSource();
        private BindingSource bsMenu = new BindingSource();

        public AdminForm()
        {
            InitializeComponent();
            LoadData();
            SetupBindings();
        }

        private void LoadData()
        {
            productsAdapter.Fill(ds.Products);
            dishesAdapter.Fill(ds.Dishes);
            ingredientsAdapter.Fill(ds.DishIngredients);
            menuAdapter.Fill(ds.Menu);
        }

        private void SetupBindings()
        {
            // Продукты
            bsProducts.DataSource = ds.Products;
            dgvProducts.DataSource = bsProducts;
            if (dgvProducts.Columns["Id"] != null) dgvProducts.Columns["Id"].Visible = false;
            if (dgvProducts.Columns["Name"] != null) dgvProducts.Columns["Name"].HeaderText = "Продукт";
            if (dgvProducts.Columns["Unit"] != null) dgvProducts.Columns["Unit"].HeaderText = "Ед. измерения";
            if (dgvProducts.Columns["Quantity"] != null) dgvProducts.Columns["Quantity"].HeaderText = "Кол-во";

            // Блюда
            bsDishes.DataSource = ds.Dishes;
            dgvDishes.DataSource = bsDishes;
            if (dgvDishes.Columns["Id"] != null) dgvDishes.Columns["Id"].Visible = false;
            if (dgvDishes.Columns["Name"] != null) dgvDishes.Columns["Name"].HeaderText = "Блюдо";
            if (dgvDishes.Columns["Price"] != null) dgvDishes.Columns["Price"].HeaderText = "Цена";

            // Ингредиенты
            dgvDishesList.DataSource = bsDishes;
            if (dgvDishesList.Columns["Id"] != null) dgvDishesList.Columns["Id"].Visible = false;
            if (dgvDishesList.Columns["Name"] != null) dgvDishesList.Columns["Name"].HeaderText = "Блюдо";
            if (dgvDishesList.Columns["Price"] != null) dgvDishesList.Columns["Price"].HeaderText = "Цена";

            dgvIngredients.AutoGenerateColumns = false;
            dgvIngredients.Columns.Clear();

            bsIngredients.DataSource = ds.DishIngredients;
            dgvIngredients.DataSource = bsIngredients;

            dgvIngredients.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "colProduct",
                HeaderText = "Продукт",
                DataPropertyName = "ProductId",
                DataSource = bsProducts,
                DisplayMember = "Name",
                ValueMember = "Id",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            });

            dgvIngredients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colQuantity",
                HeaderText = "Количество",
                DataPropertyName = "Quantity"
            });

            dgvIngredients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colUnit",
                HeaderText = "Ед. измерения",
                ReadOnly = true
            });

            bsDishes.CurrentChanged += bsDishes_CurrentChanged;
            bsDishes_CurrentChanged(null, null);
            dgvIngredients.CellFormatting += dgvIngredients_CellFormatting;

            // Меню
            dgvMenu.AutoGenerateColumns = false;
            dgvMenu.Columns.Clear();
            bsMenu.DataSource = ds.Menu;
            dgvMenu.DataSource = bsMenu;

            dgvMenu.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "colDish",
                HeaderText = "Блюдо",
                DataPropertyName = "DishId",
                DataSource = bsDishes,
                DisplayMember = "Name",
                ValueMember = "Id",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            });

            dgvMenu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colPrice",
                HeaderText = "Цена",
                ReadOnly = true
            });

            dgvMenu.CellFormatting += dgvMenu_CellFormatting;
            dgvMenu.CurrentCellDirtyStateChanged += dgvMenu_CurrentCellDirtyStateChanged;
            boxDate_ValueChanged(null, null);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var row = ds.Products.NewProductsRow();
            row.Name = "Новый продукт";
            row.Quantity = 0;
            row.Unit = "шт";
            ds.Products.AddProductsRow(row);

            bsProducts.MoveLast();
            dgvProducts.Focus();
            dgvProducts.BeginEdit(true);
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (bsDishes.Current is DataRowView dishRow)
            {
                int currentDishId = (int)dishRow["Id"];

                var row = ds.DishIngredients.NewDishIngredientsRow();
                row.DishId = currentDishId;
                row.Quantity = 1;

                if (ds.Products.Rows.Count > 0)
                {
                    row.ProductId = ds.Products[0].Id;
                }

                ds.DishIngredients.AddDishIngredientsRow(row);
                bsIngredients.MoveLast();
                dgvIngredients.Focus();

                dgvIngredients.CurrentCell = dgvIngredients.Rows[dgvIngredients.RowCount - 1].Cells[0];
                dgvIngredients.BeginEdit(true);
            }
            else
            {
                MessageBox.Show("Сначала выберите блюдо, в которое хотите добавить ингредиент!",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            var row = ds.Menu.NewMenuRow();
            row.Date = boxDate.Value.Date;
            if (ds.Menu.Rows.Count > 0)
            {
                row.DishId = ds.Dishes[0].Id;
            }
            ds.Menu.AddMenuRow(row);

            bsMenu.MoveLast();
            dgvMenu.Focus();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            Helper.SaveChanges(ds.Products, productsAdapter);
        }

        private void btnSaveIngredient_Click(object sender, EventArgs e)
        {
            Helper.SaveChanges(ds.DishIngredients, ingredientsAdapter);
        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            Helper.SaveChanges(ds.Menu, menuAdapter);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (bsProducts.Current == null) return;
            var result = MessageBox.Show("Вы уверены, что хотите удалить этот продукт?",
                                         "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bsProducts.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Невозможно удалить продукт",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.Products.RejectChanges();
                }
            }
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            if (bsIngredients.Current == null) return;
            var result = MessageBox.Show("Вы уверены, что хотите удалить этот ингредиент?",
                                         "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bsIngredients.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка:\n{ex.Message}",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.DishIngredients.RejectChanges();
                }
            }
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            if (bsMenu.Current == null) return;
            var result = MessageBox.Show("Вы уверены, что хотите удалить это блюдо из меню?",
                                         "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bsMenu.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка:\n{ex.Message}",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ds.Menu.RejectChanges();
                }
            }
        }

        private void boxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = boxSearchProduct.Text.Trim();
            bsProducts.Filter = string.IsNullOrEmpty(searchText) ? "" : $"Name LIKE '%{searchText}%'";
        }

        private void boxSearchDish_TextChanged(object sender, EventArgs e)
        {
            string searchText = boxSearchDish.Text.Trim();
            bsDishes.Filter = string.IsNullOrEmpty(searchText) ? "" : $"Name LIKE '%{searchText}%'";
        }

        private void bsDishes_CurrentChanged(object sender, EventArgs e)
        {
            if (bsDishes.Current is DataRowView rowView)
            {
                int dishId = (int)rowView.Row["Id"];
                bsIngredients.Filter = $"DishId = {dishId}";
            }
            else
            {
                bsIngredients.Filter = "DishId = -1";
            }
        }

        private void dgvIngredients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvIngredients.Columns[e.ColumnIndex].Name == "colUnit" && e.RowIndex >= 0)
            {
                var row = dgvIngredients.Rows[e.RowIndex];

                if (row.Cells["colProduct"].Value is int productId)
                {
                    var productRow = ds.Products.FindById(productId);
                    if (productRow != null)
                    {
                        e.Value = productRow.Unit;
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dgvMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMenu.Columns[e.ColumnIndex].Name == "colPrice" && e.RowIndex >= 0)
            {
                var row = dgvMenu.Rows[e.RowIndex];
                var cellValue = row.Cells["colDish"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int dishId = Convert.ToInt32(cellValue);
                    var dishRow = ds.Dishes.FindById(dishId);

                    if (dishRow != null)
                    {
                        if (!dishRow.IsNull("Price"))
                        {
                            e.Value = dishRow.Price.ToString();
                        }
                        else
                        {
                            e.Value = "0";
                        }
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dgvMenu_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentCell is DataGridViewComboBoxCell)
            {
                if (dgvMenu.IsCurrentCellDirty)
                {
                    dgvMenu.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    if (dgvMenu.CurrentRow != null)
                    {
                        dgvMenu.InvalidateRow(dgvMenu.CurrentRow.Index);
                    }
                }
            }
        }

        private void boxDate_ValueChanged(object sender, EventArgs e)
        {
            string selectedDate = boxDate.Value.ToString("dd.MM.yyyy");
            bsMenu.Filter = $"Date >= '{selectedDate} 00:00:00' AND Date <= '{selectedDate} 23:59:59'";
        }
    }
}
