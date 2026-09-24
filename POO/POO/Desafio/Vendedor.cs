namespace POO
{
    public class Vendedor : Pessoa
    {
        public List<Produto> Produtos = new();

        public void adicionarProduto(string name = "", double price = 0, int quantity = 0)
        {
            Produto newProduct = new(name,price,quantity);

            Produtos.Add(newProduct);
        }

        protected bool verificarEstoque(Produto product, int quantity)
        {
            if (product.verificarQuantidade(quantity))
            {
                return true;
            }

            return false;
        }

        public bool venderProduto(Produto product, int quantity)
        {
            if(verificarEstoque(product, quantity))
            {
                Produtos.Remove(product);
                return true;
            }

            return false;
        }

        public void listarProdutos()
        {
            for (int i = 0; Produtos.Count > i; i++)
            {
                Produtos[i].DescreverProduto(i);
            }
        }

    }
}
