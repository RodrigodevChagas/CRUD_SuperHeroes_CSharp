using CRUD_Escolinha.Models;

namespace CRUD_Escolinha.Repositorio
{
    public interface IHeroisRepositorio
    {
        List<Cadastro_Herois> BuscarTodos();
        Cadastro_Herois Adicionar(Cadastro_Herois herois);
    }
}
