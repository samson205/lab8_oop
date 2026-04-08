using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab8_2
{
    public partial class CashierForm : Form
    {
        private DataSetNew ds = new DataSetNew();

        private DataSetNewTableAdapters.MenuTableAdapter menuAdapter = new DataSetNewTableAdapters.MenuTableAdapter();
        private DataSetNewTableAdapters.DishesTableAdapter dishesAdapter = new DataSetNewTableAdapters.DishesTableAdapter();
        private DataSetNewTableAdapters.OrdersTableAdapter ordersAdapter = new DataSetNewTableAdapters.OrdersTableAdapter();
        private DataSetNewTableAdapters.OrderItemsTableAdapter orderItemsAdapter = new DataSetNewTableAdapters.OrderItemsTableAdapter();

        private BindingSource bsCart = new BindingSource();
        private List<CartItem> cartItems = new List<CartItem>();

        public CashierForm()
        {
            InitializeComponent();
            try
            {
                SetupDataGridView();
                LoadMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при старте: " + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            bsCart.DataSource = cartItems;
            dgvOrder.DataSource = bsCart;

            dgvOrder.Columns["DishId"].Visible = false;
            dgvOrder.Columns["DishName"].HeaderText = "Блюдо";
            dgvOrder.Columns["Price"].HeaderText = "Цена";
            dgvOrder.Columns["Quantity"].HeaderText = "Кол-во";
            dgvOrder.Columns["Total"].HeaderText = "Сумма";

            foreach (DataGridViewColumn col in dgvOrder.Columns)
                col.ReadOnly = col.Name != "Quantity";
        }

        private void LoadMenu()
        {
            flpMenu.Controls.Clear();

            menuAdapter.Fill(ds.Menu);
            var todayMenu = ds.Menu.Where(m => m.Date == DateTime.Today).ToList();

            if (todayMenu.Count == 0)
            {
                flpMenu.Controls.Add(new Label { Text = "На сегодня меню пусто", AutoSize = true, ForeColor = Color.Gray });
                return;
            }

            dishesAdapter.Fill(ds.Dishes);

            foreach (var menuRow in todayMenu)
            {
                var dish = ds.Dishes.FirstOrDefault(d => d.Id == menuRow.DishId);
                if (dish == null) continue;

                var btn = new Button
                {
                    Text = $"{dish.Name}\n{dish.Price} ₽",
                    Width = 100,
                    Height = 100,
                    Margin = new Padding(5),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(100, 237, 242, 255),
                    ForeColor = Color.FromArgb(100, 45, 55, 72),
                    Font = new Font("Segoe UI", 12F),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = menuRow.DishId,
                    Cursor = Cursors.Hand,
                };
                btn.FlatAppearance.BorderSize = 1;
                btn.Click += BtnDish_Click;
                flpMenu.Controls.Add(btn);
            }
        }

        private void BtnDish_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null || btn.Tag == null) return;
            int dishId = (int)btn.Tag;

            var existing = cartItems.FirstOrDefault(c => c.DishId == dishId);
            if (existing != null)
            {
                existing.Quantity++;
            }
            else
            {
                var dish = ds.Dishes.First(d => d.Id == dishId);
                cartItems.Add(new CartItem
                {
                    DishId = dishId,
                    DishName = dish.Name,
                    Price = dish.Price
                });
            }
            bsCart.ResetBindings(false);
            UpdateTotal();
        }

        private void dgvOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvOrder.Columns[e.ColumnIndex].Name != "Quantity") return;
            var cellValue = dgvOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (cellValue != null && int.TryParse(cellValue.ToString(), out int qty) && qty >= 0)
            {
                cartItems[e.RowIndex].Quantity = qty;
                if (qty == 0) cartItems.RemoveAt(e.RowIndex);
            }

            bsCart.ResetBindings(false);
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            var total = cartItems.Sum(c => c.Total);
            lblTotal.Text = $"Итого: {total} ₽";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0) return;

            try
            {
                var orderRow = ds.Orders.NewOrdersRow();
                orderRow.OrderDate = DateTime.Now;
                orderRow.TotalAmount = cartItems.Sum(c => c.Total);
                ds.Orders.AddOrdersRow(orderRow);

                ordersAdapter.Update(ds.Orders);
                int newOrderId = orderRow.Id;

                foreach (var item in cartItems)
                {
                    var itemRow = ds.OrderItems.NewOrderItemsRow();
                    itemRow.OrderId = newOrderId;
                    itemRow.DishId = item.DishId;
                    itemRow.Quantity = item.Quantity;
                    ds.OrderItems.AddOrderItemsRow(itemRow);
                }
                orderItemsAdapter.Update(ds.OrderItems);

                MessageBox.Show($"Заказ #{newOrderId} пробит!\nСумма: {lblTotal.Text}", "Успех");
                cartItems.Clear();
                bsCart.ResetBindings(false);
                lblTotal.Text = "Итого: 0 ₽";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            lblTotal.Text = "Итого: 0 ₽";
            bsCart.ResetBindings(false);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            using (AdminForm admin = new AdminForm())
            {
                if (admin.ShowDialog() == DialogResult.OK || true)
                {
                    ds.Menu.Clear();
                    ds.Dishes.Clear();
                    LoadMenu();
                }
            }
        }
    }

    public class CartItem
    {
        public int DishId { get; set; }
        public string DishName { get; set; } = "";
        public int Price { get; set; }
        public int Quantity { get; set; } = 1;
        public int Total => Price * Quantity;
    }
}