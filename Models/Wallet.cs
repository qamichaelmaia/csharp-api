namespace WalletApi.Models
{
    public class Wallet
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public decimal ValorAtual { get; set; }
        public string Banco { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}
