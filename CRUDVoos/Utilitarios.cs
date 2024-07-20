using Biblioteca;

namespace ProjetoFinalVoos
{
    internal class Utilitarios
    {

        /// <summary>
        /// Metodo construido para poder salvar os dados da aplicação
        /// </summary>
        /// <param name="voos">vai ser a lista de Voos criados</param>
        /// <param name="contaVoos">vai ser o id dos voos</param>
        /// <param name="aparelhos">vai ser a lista de Aparelhos já criados</param>
        internal static void SalvarDados(List<Voo> voos, int contaVoos, List<Aparelho> aparelhos)
        {
            Gravar.GravarVoos(voos, @"ListaVoos.txt");
            Gravar.GravarVoosID(contaVoos, @"ContaVoos.txt");
            Gravar.GravarAparelhos(aparelhos, @"ListaAparelhos.txt");
            //Gravar.GravarBilhetes();
            //Gravar.GravarBilhetesID();
        }
    }
}