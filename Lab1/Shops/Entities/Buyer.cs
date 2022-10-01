namespace Shops.Entities
{
    internal class Buyer
    {
        public string Name { get; set; }

        public decimal Money { get; private set; }

        public void TopUp(decimal money)
        {
            if (money < 0)
            {
                // throw new custom exception
            }

            Money += money;
        }
    }
}
