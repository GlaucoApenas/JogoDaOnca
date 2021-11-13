using System.Collections.Generic;

namespace JogoDaOnça.Class
{
    public class Posicao
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Ocupada { get; set; }
        public List<Movimento>? Movimentos{ get; set; }
        public bool? Jogador{ get; set; }

        public Posicao(int x, int y, bool ocupada, List<Movimento>? movimentos, bool? jogador) : this(x, y, ocupada, movimentos)
        {
            Jogador = jogador;
        }

        public Posicao(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Posicao(int x, int y, bool ocupada)
        {
            X = x;
            Y = y;
            Ocupada = ocupada;
        }
        public Posicao(int x, int y, bool ocupada, List<Movimento>? movimentos)
        {
            X = x;
            Y = y;
            Ocupada = ocupada;
            Movimentos = movimentos;
        }
    }
}
