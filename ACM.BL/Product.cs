﻿using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        private string productName;

        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }

        public string ProductName
        {
            get
            {
                return productName.InsertSpaces();
            }
            set
            {
                productName = value;
            }
        }

        public override string ToString()
        {
            return ProductName;
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
