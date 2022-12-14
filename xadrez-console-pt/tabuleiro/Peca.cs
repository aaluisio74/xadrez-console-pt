namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = posicao;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            quantMovimentos = 0;
        }

        public void incrementarQuantMovimentos()
        {
            quantMovimentos++;
        }
        
    }
}
