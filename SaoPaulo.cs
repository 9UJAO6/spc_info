
class SaoPauloInstituicao
{
    public SaoPauloInstituicao(string nome, string estado) 
    {
        Nome = nome;
        Estado = estado;
    
    }
    public string Nome = "São Paulo";
    public string Estado = "SP";
    public string Cores{ get; set; }
    public int Torcida { get; set; }

    internal class Times
    {

        internal class SPFC
        {

            internal class JogadoresFutebol
            {

                public string JogadorNome { get; set; }
                public int JogadorNumero { get; set; }
                public string JogadorPosicao { get; set; }

                public JogadoresFutebol(string jogadorNome, int jogadorNumero, string jogadorPosição)
                {
                    JogadorNome = jogadorNome;
                    JogadorNumero = jogadorNumero;
                    JogadorPosicao = jogadorPosição;
                }
                //public override string ToString()
                //{
                //    return $"Esporte: {JogadorNome}\n, Numero: {JogadorNumero}\n, Posição: {JogadorPosicao}";
                //}
            }


        }
        internal class SPBC
        {
            internal class JogadoresSPBC(string JogadorNome, int JogadorNumero, string JogadorPosicao)
            {
                public string JogadorNome { get; set; }
                public int JogadorNumero { get; set; }
                public string JogadorPosicao { get; set; }
            }
        }   
    
    }


}