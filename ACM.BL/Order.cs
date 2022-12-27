using System;

namespace ACM.BL
{
    public class Order
    {
        public int OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }

        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
