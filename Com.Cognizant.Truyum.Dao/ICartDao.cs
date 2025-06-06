﻿using Com.Cognizant.Truyum.Model;
using System;
using System.Collections.Generic;


namespace Com.Cognizant.Truyum.Dao
{
    public interface ICartDao
    {
        void AddCartItem(long userId, long menuItemId);
        Cart GetAllCartItems(long userId);
        void RemoveCartItem(long userId, long menuItemId);
    }
}
