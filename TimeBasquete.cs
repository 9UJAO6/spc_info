

class SPBC
{
   private List<SaoPauloInstituicao.Times> timeBasquete = new List<SaoPauloInstituicao.Times>();
    
    public SPBC(string nome) 
    {
        Nome = nome;
    }
    public string Nome {  get; }
    public string apelido { get; set; }

    internal class JogadoresBasquete
    {
        public string JogadorNome  { get; set;}
        public int JogadorNumero { get; set; }
        public string JogadorPosição { get; set; }
    }
    
}