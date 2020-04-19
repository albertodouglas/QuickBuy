namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome não pode estar em branco");
            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Descrição não pode estar em branco");
        }
    }
}
