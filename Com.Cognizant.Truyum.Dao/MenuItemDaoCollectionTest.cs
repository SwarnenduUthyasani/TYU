using System.Linq;

using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoCollectionTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("MenuItemDaoCollectionTest Main");
        }

        public void TestGetMenuItemListAdmin()
        {
            IMenuItemDao menuItemDao = new MenuItemDaoCollection();

            List<MenuItem> itemsPresent = menuItemDao.GetMenuItemListAdmin();

            foreach(MenuItem x in itemsPresent)
            {
                Console.WriteLine($""+x.id+"  "+x.name + "  " +x.price + "  " +x.active + "  " +x.dateOfLaunch + "  " +x.category + "  " +x.freeDelivery);
            }
        }

        public void TestGetMenuItemListCustomer()
        {
            IMenuItemDao menuItemDao = new MenuItemDaoCollection();

            List<MenuItem> itemsAvailable = menuItemDao.GetMenuItemListCustomer();

            foreach (MenuItem y in itemsAvailable)
            {
                Console.WriteLine($"" + y.id + "  " + y.name + "  " + y.price + "  " + y.active + "  " + y.dateOfLaunch + "  " + y.category + "  " + y.freeDelivery);
            }
        }

        public void TestModifyMenuItem() 
        {
            MenuItem newItem = new MenuItem(4, "Ice Cream", 27.00f, false, DateOnly.Parse("02/05/2026"), "Desserts", true);

            IMenuItemDao menuItemDao = new MenuItemDaoCollection();

            menuItemDao.ModifyMenuItem(newItem);

            MenuItem updatedItem = menuItemDao.GetMenuItem(newItem.id);

            Console.WriteLine($"" + updatedItem.id + "  " + updatedItem.name + "  " + updatedItem.price + "  " + updatedItem.active + "  " + updatedItem.dateOfLaunch + "  " + updatedItem.category + "  " + updatedItem.freeDelivery);
        }

        public void TestGetMenuItem() {
            Console.WriteLine("TestGetMenuItemListOrderAdmin");
        }
    }
}
