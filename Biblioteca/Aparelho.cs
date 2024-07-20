using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca;

public class Aparelho
{
    public int Id { get; set; }

    public string Tipo {  get; set; }

    public int Capacidade { get; set; }

    public List<int> Lugares { get; set; }

    public bool Atribuido { get; set; }

    public string Descricao
    {
        get
        {
            return $"Avião {Tipo} com {Capacidade} Lugares";
        }
    }

    public override string ToString()
    {
        return Descricao;
    }


}
