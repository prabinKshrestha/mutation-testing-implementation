using System.Collections.Generic;
using System.Linq;

namespace MutationApp
{
    /*
     * Incomplete class for Shopping Cart Service
     * This class is incomplete because it is created to show the implementation of Mutation Testing.
     * */
    public class ShoppingCartService
    {
        /* Minimum Quantity to get discount */
        public readonly static int DISCOUNT_THRESHOLD_QUANTITY = 5;
        /* Cart Items of shopping cart */
        public readonly List<CartItem> items;

        /* Constructor */
        public ShoppingCartService() { items = new List<CartItem>(); }

        /* Add Item to the list */
        public void AddItem(CartItem item) => items.Add(item);

        /* Remove Item from the list */
        public void RemoveItem(CartItem item) => items.Remove(item);

        /* Check if shopping cart is empty */
        public bool IsEmpty() => items.Count == 0;

        /* Check if cart is eligible for discount */
        public bool IsDiscountEligible() => items.Count >= DISCOUNT_THRESHOLD_QUANTITY;   

        /* Calculate and returns the total price without discount */
        public decimal CalculateTotalPriceWithoutDiscount() => items.Select(item => item.Price * item.Quantity).Sum();
    }

    /* Model Class to represent the Cart Item */
    public class CartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
