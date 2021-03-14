using System.Collections.Generic;
using ProjectUdemyFechamentoEnumCompos.Entities;
using System.Globalization;

namespace ProjectUdemyFechamentoEnumCompos.Entities
{
    class OrderItem
    {

        public int QtdProduct { get; set; }
        public double  PriceProduct { get; set; }
        public Product product { get; set; } = new Product();


        public OrderItem(int qtdProduct, double priceProduct, Product product)
        {
            QtdProduct = qtdProduct;
            PriceProduct = priceProduct;
            this.product = product;
        }

        public OrderItem()
        {
        }

        public double SubTotal()
        {
            return PriceProduct * QtdProduct;
        }

        public override string ToString()
        {
            return product.NameProduct
                + ", $"
                + PriceProduct.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + QtdProduct
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
