class JogadoresSPFC
{
    private List<SaoPauloInstituicao.Times.SPFC.JogadoresFutebol> Jogadores = new List<SaoPauloInstituicao.Times.SPFC.JogadoresFutebol>();
    //public string JogadorNome { get; set; }
    //public int JogadorNumero { get; set; }
    //public string JogadorPosicao { get; set; }


    public void AdicionarJogadores(SaoPauloInstituicao.Times.SPFC.JogadoresFutebol jogador)
    {
        Jogadores.Add(jogador);
    }

    public void ExibirJogadoresSPFC()
    {
        Console.WriteLine("\nJogadores do SPFC:");
        foreach(var  jogador in Jogadores)
        {
            Console.WriteLine($"{jogador.JogadorNome}\n {jogador.JogadorNumero}\n {jogador.JogadorPosicao}");
        }
    }

}