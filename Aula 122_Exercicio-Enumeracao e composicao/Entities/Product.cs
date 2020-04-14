namespace Aula_122_Exercicio_Enumeracao_e_composicao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
