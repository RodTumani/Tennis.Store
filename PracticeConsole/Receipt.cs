namespace a
{
    public class Receipt
    {
        private List<(string item, decimal price)> items = new List<(string item, decimal price)>();

        public void AddItem(string item, decimal price)
        {
            items.Add((item, price));
        }

        public decimal GetSubtotal()
        {
            decimal subtotal = 0;
            foreach (var item in items)
            {
                subtotal += item.price;
            }
            return subtotal;
        }
    }

}
