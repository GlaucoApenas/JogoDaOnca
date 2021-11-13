namespace JogoDaOnça.Class
{
    public class Movimento
    {
        public Posicao Origem { get; set; }
        public Posicao Destino { get; set; }

        public Movimento(){}

        public Movimento(Posicao origem, Posicao destino)
        {
            Origem = origem;
            Destino = destino;
        }

        public bool ChecaMovimento(Movimento origem,Movimento destino)
        {
            return true;
        }
    }
}
