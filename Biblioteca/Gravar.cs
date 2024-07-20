namespace Biblioteca
{
    public class Gravar
    {

        // ------------------------------------------------- Para os Aparelhos---------------------------------------------------------------------

        public static void GravarAparelhosID(int contaAparelhos, string caminhoContaAparelhos)
        {
            using (StreamWriter writer = new StreamWriter(caminhoContaAparelhos))
            {
                writer.WriteLine(contaAparelhos);
            }
        }




        public static void GravarAparelhos(List<Aparelho> aparelhos, string caminhoA)
        {
            using (StreamWriter writer = new StreamWriter(caminhoA))
            {
                foreach (Aparelho aparelho in aparelhos)
                {
                    writer.WriteLine($"{aparelho.Id};{aparelho.Tipo};{aparelho.Capacidade};{aparelho.Atribuido}");
                }
            }

        }






        // ------------------------------------------------- Para os Voos---------------------------------------------------------------------

        public static void GravarVoos(List<Voo> voos, string caminhoA)
        {
            using (StreamWriter writer = new StreamWriter(caminhoA))
            {
                foreach (Voo voo in voos)
                {
                    writer.WriteLine($"{voo.Id};{voo.NumeroVoo};{voo.Origem};{voo.Destino};{voo.Aparelho.Id};{voo.DataVoo};{voo.Hora}");
                }
            }

        }


        public static void GravarVoosID(int contaVoos, string caminhoContaVoos)
        {
            using (StreamWriter writer = new StreamWriter(caminhoContaVoos))
            {
                writer.WriteLine(contaVoos);
            }
        }


        // ------------------------------------------------- Para os Bilhetes---------------------------------------------------------------------

        public static void GravarBilhetes(List<Bilhete> bilhetes, string caminhoBilhetes)
        {
            using (StreamWriter writer = new StreamWriter(caminhoBilhetes))
            {
                foreach (Bilhete bilhete in bilhetes)
                {
                    writer.WriteLine($"{bilhete.IdVoo};{bilhete.Lugar};{bilhete.Ocupado};{bilhete.Passageiro}");
                }
            }
        }

        public static void GravarBilhetesID(int contaBilhetes, string caminhoContaBilhetes)
        {
            using (StreamWriter writer = new StreamWriter(caminhoContaBilhetes))
            {
                writer.WriteLine(contaBilhetes);
            }
        }





    }
}

