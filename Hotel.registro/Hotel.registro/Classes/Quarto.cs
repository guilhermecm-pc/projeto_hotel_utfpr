using System.ComponentModel;

namespace Hotel.registro;

public class Quarto
{
    public int Numeroquarto {get;set;}
    public int Statusquarto {get;set;}
    public string Descricaoquarto {get;set;}
    public float ValorQuarto {get;set;}

    public class Quarto(int numero, int status,string descricao,float valor)
    {
        Numeroquarto = numero;
        Statusquarto = status;
        Descricaoquarto = descricao;
        ValorQuarto = valor;
    }
}
