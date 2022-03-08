using System.Collections.Generic;
namespace Cadastro_Series.interfaces;

public interface IRepositorio<T>
{
    List<T> List();
    T RetornaPorID(int id);
    void Insere(T entidade);
    void Exclui(int id);
    void Atualiza(int id, T entidade);
    int proximoID();
}