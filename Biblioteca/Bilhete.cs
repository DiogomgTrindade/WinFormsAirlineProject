namespace Biblioteca;

public class Bilhete
{
    public int IdVoo { get; set; }

    public int Lugar { get; set; }

    public bool Ocupado { get; set; }

    public string Passageiro { get; set; }


    /// <summary>
    /// Método para encontrar o id do aparelho associado a este bilhete
    /// </summary>
    /// <param name="voos">Lista de voos</param>
    /// <returns>Id do aparelho associado ao bilhete</returns>
    public int GetAparelho(List<Voo> voos)
    {
        return voos.Find(voo => voo.Id == IdVoo).Aparelho.Id;
    }

    public override string ToString()
    {
        return $"Lugar Nº{Lugar}";
    }


}
