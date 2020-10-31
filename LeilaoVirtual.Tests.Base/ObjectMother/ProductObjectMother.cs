using LeilaoVirtual.Domain.Features.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoVirtual.Tests.Base.ObjectMother
{
    public static class ProductObjectMother
    {

        public static Product Defaut
        {
            get
            {
                var product = new Product()
                {
                    Name = "Product",
                    Value = 100
                };

                return product;
            }
        }

        public static Product InvalidName
        {
            get
            {
                var product = new Product()
                {
                   
                    Value = 100
                };

                return product;
            }
        }

        public static Product InvalidValue
        {
            get
            {
                var product = new Product()
                {
                    Name = "Product",
                    Value = 0
                };

                return product;
            }
        }


    }
}
