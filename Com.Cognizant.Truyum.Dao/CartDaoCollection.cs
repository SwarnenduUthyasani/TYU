using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartDaoCollection : ICartDao
    {
        private Dictionary<long, Cart> userCarts = new Dictionary<long, Cart>();

        public CartDaoCollection()
        {
            if (userCarts == null)
            {
                userCarts = new Dictionary<long, Cart>();
            }
        }

        public void AddCartItem(long userId, long menuItemId)
        {
            IMenuItemDao menuItemDao = new MenuItemDaoCollection();

            MenuItem menuItem = menuItemDao.GetMenuItem(menuItemId);

            if (userCarts.ContainsKey(userId))
            {
                userCarts[userId].menuItemList.Add(menuItem);
            }
            else
            {
                Cart cart = new Cart();
                cart.menuItemList.Add(menuItem);
                userCarts.Add(userId, cart);                
            }
        }

        public Cart GetAllCartItems(long userId)
        {
            Cart theCart = userCarts.GetValueOrDefault(userId);
            
            if (theCart == null || theCart.menuItemList == null || !theCart.menuItemList.Any())
            {
                throw new CartEmptyException();
            }
            
            theCart.total = theCart.menuItemList.Sum(x => x.price);
            return theCart;
        }

        public void RemoveCartItem(long userId, long menuItemId)
        {
           // List<MenuItem> theItems = userCarts[userId].menuItemList;

            foreach (var item in userCarts[userId].menuItemList)
            {
                if(item.id == menuItemId)
                {
                    userCarts[userId].menuItemList.Remove(item);
                    break;
                }
            }
        }
    }
}
