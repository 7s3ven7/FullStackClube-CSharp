namespace POO
{
    public class Produto
    {

        private string Name { get; set; }
        private double Price { get; set; }
        private int Quantity { get; set; }

        public Produto(string name ="", double price = 0, int quantity = 0)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void DescreverProduto(int order)
        {
            Console.WriteLine($"Produto {order}° {Name} | {Price}R$ | quantidade disponivel: {Quantity}");
        }

        public bool venderQuantidade(int quantity)
        {

            if (verificarQuantidade(quantity))
            {
                Quantity -= quantity;
                return true;
            }

            return false;
        }

        public bool verificarQuantidade(int quantity)
        {

            if(Quantity - quantity > 0)
            {
                return true;
            }else if(Quantity - quantity == 0)
            {
                return true;
            }

            return false;
        }
    }
}
