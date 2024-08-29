class JogadoresSPBC
{
    private List<SaoPauloInstituicao.Times.SPBC.JogadoresSPBC> jogadoresBasquete = new List<SaoPauloInstituicao.Times.SPBC.JogadoresSPBC>();
    public void adicionarJogadores(SaoPauloInstituicao.Times.SPBC.JogadoresSPBC jogadores)
    {
        jogadoresBasquete.Add(jogadores);
    }

    public void exibirJogadoresBasquete()
    {
        Console.WriteLine("Jogadores do time de Basquete do São Paulo");
        foreach (var jogador  in jogadoresBasquete) 
        { 
            Console.WriteLine($"{jogador.JogadorNome}\n{jogador.JogadorNumero}\n{jogador.JogadorPosicao}"); 
        }
    }
}