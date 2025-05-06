using Com.Cognizant.Truyum.Model;
using System;


namespace Com.Cognizant.Truyum.Dao
{
    internal interface IMenuItemDao
    {
        List<MenuItem> GetMenuItemListAdmin();
        List<MenuItem> GetMenuItemListCustomer();
        void ModifyMenuItem(MenuItem menuItem);
        MenuItem GetMenuItem(long menuItemId);

    }
}
