namespace Biblioteca;

public class Voo
{

    public int Id { get; set; }

    public string NumeroVoo { get; set; }

    public string Origem { get; set; }

    public string Destino { get; set; }

    public Aparelho Aparelho { get; set; }

    public DateTime DataVoo { get; set; }

    public string Hora { get; set; }



    public string DadosVoo
    {
        get
        {
            return $"{NumeroVoo} | {Origem} - {Destino} {DataVoo.ToString("dd/MM/yyyy")} ";
        }
    }


    public string DadosVooOrigem
    {
        get
        {
            return $"{NumeroVoo} | {Origem} - {Destino} {DataVoo.ToString("dd/MM/yyyy")} ";
        }
    }


    public string DadosVooData
    {
        get
        {
            return $"{NumeroVoo} | {DataVoo.ToString("dd/MM/yyyy")} {Origem} - {Destino} ";
        }
    }




    public string Descricao
    {
        get
        {
            return $"{NumeroVoo} | Origem - {Origem}; Destino - {Destino} | {DataVoo.ToString("dd/MM/yyyy")}; Hora de partida: {Hora} | {Aparelho}";
        }
    }

    public override string ToString()
    {
        return Descricao;
    }


}
