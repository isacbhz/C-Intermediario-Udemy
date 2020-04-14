using System.Text;
using System.Globalization;
namespace Aula_122_Exercicio_Enumeracao_e_composicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem() { }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double subTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Product.Name+", $"+Product.Price.ToString("F2",CultureInfo.InvariantCulture)
                +", Quantity: "+Quantity+", Subtotal:$ "+subTotal().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
