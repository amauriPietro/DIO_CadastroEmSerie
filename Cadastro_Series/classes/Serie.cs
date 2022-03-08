namespace Cadastro_Series;

public class Serie : EntidadeBase
{
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }
    private bool existe { get; set; }

    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
    {
        this.Id = id;
        this.Genero = genero;
        this.Descricao = descricao;
        this.Ano = ano;
        this.existe = true;
    }

    public override string ToString()
    {
        string retorno = "";
        retorno += "Genero: " + this.Genero + "\n";
        retorno += "Titulo: " + this.Titulo + "\n";
        retorno += "Descicao: " + this.Descricao + "\n";
        retorno += "Ano de lancamento: " + this.Ano + "\n";
        return retorno;
    }

    public string GetTitulo()
    {
        return this.Titulo;
    }

    public int GetId()
    {
        return this.Id;
    }

    public void Exclui()
    {
        this.existe = false;
    }
}