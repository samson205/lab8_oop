using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_2
{
    internal static class Helper
    {
        public static void SaveChanges(DataTable table, object adapter)
        {
            try
            {
                if (table.GetChanges() == null)
                {
                    return;
                }

                int rowsAffected = 0;

                if (adapter is DataSetNewTableAdapters.ProductsTableAdapter prodAdapter)
                {
                    rowsAffected = prodAdapter.Update((DataSetNew.ProductsDataTable)table);
                }
                else if (adapter is DataSetNewTableAdapters.DishesTableAdapter dishAdapter)
                {
                    rowsAffected = dishAdapter.Update((DataSetNew.DishesDataTable)table);
                }
                else if (adapter is DataSetNewTableAdapters.DishIngredientsTableAdapter ingAdapter)
                {
                    rowsAffected = ingAdapter.Update((DataSetNew.DishIngredientsDataTable)table);
                }
                else if (adapter is DataSetNewTableAdapters.MenuTableAdapter menuAdapter)
                {
                    rowsAffected = menuAdapter.Update((DataSetNew.MenuDataTable)table);
                }
                else
                {
                    throw new Exception("Неподдерживаемый тип адаптера");
                }

                MessageBox.Show($"Изменения успешно сохранены!\nИзменено строк: {rowsAffected}",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
