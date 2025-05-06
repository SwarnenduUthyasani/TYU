
using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartDaoCollectionTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("CartDaoCollectionTest Main");
        }

        public void TestAddCartItem()
        {
            ICartDao cartDao = new CartDaoCollection();
            cartDao.AddCartItem(1,2);
            cartDao.AddCartItem(1,1);
            Cart cart = cartDao.GetAllCartItems(1);
            Console.WriteLine("Total price of the cart : "+cart.total);
        }

        public void TestGetAllCartItems()
        {        }

        public void TestRemoveCartItem()
        {
            try
            {
                ICartDao cartDao = new CartDaoCollection();
                cartDao.AddCartItem(1, 2);
                //cartDao.AddCartItem(1, 1);
                cartDao.RemoveCartItem(1, 2);
                Cart cart = cartDao.GetAllCartItems(1);
                Console.WriteLine("Total price of the cart : " + cart.total);
            }
            catch (CartEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
