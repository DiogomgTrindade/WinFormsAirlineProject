using System.Globalization;

namespace Biblioteca
{
    public class Carregar
    {

        // ------------------------------------------------- Para os Aparelhos---------------------------------------------------------------------

        public static int CarregarAparelhosID(string caminhoContaAparelhos)
        {
            if (File.Exists(caminhoContaAparelhos))
            {
                string text = File.ReadAllText(caminhoContaAparelhos);
                if (int.TryParse(text, out int contaAparelhos))
                {
                    return contaAparelhos;
                }
            }
            return 1;
        }


        /// <summary>
        /// Faz com que os aparelhos já criados, sejam carregados
        /// </summary>
        /// <param name="aparelhos">Lista de Aparelhos</param>
        /// <param name="caminhoB">Caminho para o ficheiro onde se encontram os Aparelhos</param>
        public static void CarregarAparelhos(List<Aparelho> aparelhos, string caminhoB)
        {
            using (StreamReader reader = new StreamReader(caminhoB))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] dados = linha.Split(";");
                    if (dados.Length == 4)
                    {
                        Aparelho aparelho = new Aparelho
                        {
                            Id = int.Parse(dados[0]),
                            Tipo = dados[1],
                            Capacidade = int.Parse(dados[2]),
                            Atribuido = bool.Parse(dados[3])
                        };

                        aparelho.Lugares = new List<int>();
                        for (int i = 0; i < aparelho.Capacidade; i++)
                        {
                            aparelho.Lugares.Add(i + 1);
                        }
                        aparelhos.Add(aparelho);
                    }
                }
            }
        }






        // ------------------------------------------------- Para os Voos---------------------------------------------------------------------
        public static void CarregarVoos(List<Voo> voos, List<Aparelho> aparelhos, string caminhoB)
        {
            using (StreamReader reader = new StreamReader(caminhoB))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length == 7)
                    {
                        Aparelho aparelho = aparelhos.Find(a => a.Id == int.Parse(dados[4]));
                        if (aparelho != null)
                        {
                            Voo voo = new Voo
                            {
                                Id = int.Parse(dados[0]),
                                NumeroVoo = dados[1],
                                Origem = dados[2],
                                Destino = dados[3],
                                Aparelho = aparelho,
                                DataVoo = DateTime.ParseExact(dados[5], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                                Hora = dados[6],
                            };
                            voos.Add(voo);
                        }
                    }
                }
            }

        }


        public static int CarregarVoosID(string caminhoContaVoos)
        {
            if (File.Exists(caminhoContaVoos))
            {
                string text = File.ReadAllText(caminhoContaVoos);
                if (int.TryParse(text, out int contaVoos))
                {
                    return contaVoos;
                }
            }
            return 1;
        }



        // ------------------------------------------------- Para os Bilhetes---------------------------------------------------------------------
        public static void CarregarBilhetes(List<Voo> voos, List<Bilhete> bilhetes, string caminhoBilhetes)
        {
            if (File.Exists(caminhoBilhetes))
            {
                using (StreamReader reader = new StreamReader(caminhoBilhetes))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        var dados = linha.Split(';');
                        if (dados.Length == 4)
                        {
                            int idVoo = int.Parse(dados[0]);
                            int numeroLugar = int.Parse(dados[1]);
                            bool ocupado = bool.Parse(dados[2]);
                            string passageiro = dados[3];

                            var voo = voos.FirstOrDefault(v => v.Id == idVoo);

                            if (voo != null)
                            {
                                var bilhete = new Bilhete
                                {
                                    IdVoo = idVoo,
                                    Lugar = numeroLugar,
                                    Ocupado = ocupado,
                                    Passageiro = passageiro
                                };
                                bilhetes.Add(bilhete);
                            }
                        }
                    }
                }
            }

        }

        public static int CarregarBilhetesID(string caminhoContaBilhetes)
        {
            if (File.Exists(caminhoContaBilhetes))
            {
                using (StreamReader reader = new StreamReader(caminhoContaBilhetes))
                {
                    string linha = reader.ReadLine();
                    if (int.TryParse(linha, out int contaBilhetes))
                    {
                        return contaBilhetes;
                    }
                }
            }
            return 0;
        }



    }
}
