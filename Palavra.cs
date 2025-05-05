using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Palavra : IComparable<Palavra>, IRegistro
{
    const int tamanhoPalavra = 30;

    string palavraInfo;
    string dica;

    public string PalavraInfo
    {
        get => palavraInfo;

        set
        {
            if (value != "")
                palavraInfo = value.PadRight(tamanhoPalavra, ' ');
            else
                throw new Exception("Palavra vazia é inválido.");
        }
    }

    public string Dica { get => dica; set => dica = value; }

    public Palavra(string linhaDeDados)
    {
        palavraInfo = linhaDeDados.Substring(0, tamanhoPalavra);
        dica = linhaDeDados.Substring(tamanhoPalavra);
    }

    public Palavra(string palavraInfo, string dica)
    {
        PalavraInfo = palavraInfo;
        Dica = dica;
    }

    public int CompareTo(Palavra outraPalavra)
    {
        return this.palavraInfo.CompareTo(outraPalavra.palavraInfo);
    }
    public override string ToString()
    {
        return palavraInfo + " " + dica;
    }

    public string FormatoDeArquivo()
    {
        return PalavraInfo + dica;
    }
}