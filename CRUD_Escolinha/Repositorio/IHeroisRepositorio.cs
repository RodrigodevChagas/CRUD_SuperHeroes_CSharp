using CRUD_Escolinha.Models;

namespace CRUD_Escolinha.Repositorio
{
    public interface IHeroisRepositorio
    {
        Cadastro_Herois ListarPorId(int Id);
        List<Cadastro_Herois> BuscarTodos();
        Cadastro_Herois Adicionar(Cadastro_Herois herois);

        Cadastro_Herois Editar(Cadastro_Herois heroi);

        bool Apagar(int id);
    }
}
