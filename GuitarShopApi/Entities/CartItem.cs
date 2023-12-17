namespace GuitarShopApi.Entities
{
    public class CartItem //This entity represents an item added to the user's shopping cart
    {
        public int Id { get; set; }

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
