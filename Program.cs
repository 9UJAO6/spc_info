class Program
{
    static void Main(string[] args)
    {
        SaoPauloInstituicao SP = new SaoPauloInstituicao("São Paulo","São Paulo" )
        {
            Cores = "Vermelho, preto e branco",
            Torcida = 21200000
        };

        SPFC time = new SPFC("São Paulo Futebol Clube")
        {
            Apelido = "Soberano",
        };

        SPFC timeFutebol = new SPFC("São Paulo Futebol Clube");

        Console.WriteLine($"Esporte: {timeFutebol.Nome}");
        Console.WriteLine($"Estado: {SP.Estado}");
        Console.WriteLine($"Cores: {SP.Cores}");
        Console.WriteLine($"Torcida: {SP.Torcida}");



        JogadoresSPFC jogador = new JogadoresSPFC();
        var jogador1 = new SaoPauloInstituicao.Times.SPFC.JogadoresFutebol("Lucas moura", 7, "Meia/ponta");
        var jogador2 = new SaoPauloInstituicao.Times.SPFC.JogadoresFutebol("Rogério Ceni", 1, "Goleiro");
        jogador.AdicionarJogadores(jogador1);
        jogador.AdicionarJogadores(jogador2);

        jogador.ExibirJogadoresSPFC();

        SPBC timeBasquete = new SPBC("São Paulo Basquete");
        Console.WriteLine($"Esporte:{timeBasquete.Nome}");
        Console.WriteLine($"Estado: {SP.Estado}");
        Console.WriteLine($"Cores: {SP.Cores}");
        Console.WriteLine($"Torcida: {SP.Torcida}");

        JogadoresSPBC jogadorBasquete = new JogadoresSPBC();
        var jogadorBasquete1 = new SaoPauloInstituicao.Times.SPBC.JogadoresSPBC("Henrique Coelho", 10, "armador");
        jogadorBasquete.adicionarJogadores (jogadorBasquete1);
        jogadorBasquete.exibirJogadoresBasquete();


    }


}