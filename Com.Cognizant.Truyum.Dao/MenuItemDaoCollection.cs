using Com.Cognizant.Truyum.Model;
using System.Globalization;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoCollection : IMenuItemDao
    {
        private List<MenuItem> menuItemList { get; } = new List<MenuItem>();

        public MenuItemDaoCollection()
        {
            if(menuItemList.Count == 0) 
            {
                MenuItem item1 = new MenuItem(1, "Sandwich", 99.00f, true, DateOnly.Parse("15/03/2026"), "Main Course", true);
                MenuItem item2 = new MenuItem(2, "Burger", 129.00f, true, DateOnly.Parse("23/12/2026"), "Main Course", false);
                MenuItem item3 = new MenuItem(3, "Pizza", 149.00f, true, DateOnly.Parse("21/08/2027"), "Main Course", false);
                MenuItem item4 = new MenuItem(4, "French Fries", 57.00f, false, DateOnly.Parse("02/07/2026"), "Starters", true);
                MenuItem item5 = new MenuItem(5, "Chocolate Brownie", 32.00f, true, DateOnly.Parse("02/11/2025"), "Dessert", true);
                menuItemList.Add(item1);
                menuItemList.Add(item2);
                menuItemList.Add(item3);
                menuItemList.Add(item4);
                menuItemList.Add(item5);
               // Console.WriteLine("Running MenuItemCollection Cons.................");
            }        
        }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            return menuItemList;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> availableMenuIemList = new List<MenuItem>();

            foreach (MenuItem item in menuItemList) {
                if (item.active && item.dateOfLaunch > DateOnly.FromDateTime(DateTime.Today))
                {
                    availableMenuIemList.Add(item);
                }
            }
            return availableMenuIemList;
        }

        public void ModifyMenuItem(MenuItem menuItem)
        {
            var theItem = menuItemList.FirstOrDefault(x => x.id == menuItem.id);

            if (theItem != null)
            {
                menuItemList[menuItemList.IndexOf(theItem)] = menuItem;
            }
        }
        public MenuItem GetMenuItem(long menuItemId)
        {            
            MenuItem getItem = menuItemList.FirstOrDefault(x => x.id == menuItemId);
            return getItem;
        }
    }
}
