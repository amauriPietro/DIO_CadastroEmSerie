using Cadastro_Series.interfaces;
namespace Cadastro_Series;

public class SerieRepositorio : IRepositorio<Serie>
{
    
    public List<Serie> lista = new List<Serie>();
    public List<Serie> List()
    {
        return lista;
    }

    public Serie RetornaPorID(int id)
    {
        return lista[id];
    }

    public void Insere(Serie entidade)
    {
        lista.Add(entidade);
    }

    public void Exclui(int id)
    {
        lista[id].Exclui();
    }

    public void Atualiza(int id, Serie entidade)
    {
        lista[id] = entidade;
    }

    public int proximoID()
    {
        return lista.Count;
    }
}