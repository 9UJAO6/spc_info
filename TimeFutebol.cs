class SPFC
{
    private List<SaoPauloInstituicao.Times> timeFutebol = new List<SaoPauloInstituicao.Times>();

    public SPFC(string nome) 
    { 
        Nome = nome;
    }
    public string Nome = "São Paulo Futebol Clube";
    public string Apelido{ get; set; }
    internal class JogadoresFutebol
    {
        public string  JogadorNome { get; set; }
        public  int JogadorNumero { get; set; }
        public string JogadorPosição { get; set; }
    }
}