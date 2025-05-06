using Com.Cognizant.Truyum.Dao;


namespace TruyumConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuItemDaoCollectionTest menuItemDaoCollectionTest = new MenuItemDaoCollectionTest();

            CartDaoCollectionTest cartDaoCollectionTest = new CartDaoCollectionTest();

            menuItemDaoCollectionTest.TestGetMenuItemListAdmin();

            Console.WriteLine("---------------------------------------------------------");

            menuItemDaoCollectionTest.TestGetMenuItemListCustomer();

            Console.WriteLine("---------------------------------------------------------");

            menuItemDaoCollectionTest.TestModifyMenuItem();

            Console.WriteLine("---------------------------------------------------------");

            cartDaoCollectionTest.TestAddCartItem();

            Console.WriteLine("---------------------------------------------------------");

            cartDaoCollectionTest.TestGetAllCartItems();

            Console.WriteLine("---------------------------------------------------------");

            cartDaoCollectionTest.TestRemoveCartItem();
        }
    }
}
