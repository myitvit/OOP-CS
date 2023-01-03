using Acme.Common;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        // Constructor chaining, we call the parametrized contructor from base contructor ": this(0)" 0 is a customerId for the parametrized constructor
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }

        public int CustomerType { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public List<Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }

        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
    }
}