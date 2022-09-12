using CRUD_Escolinha.Models;

namespace CRUD_Escolinha.Repositorio
{
    public interface IHeroisRepositorio
    {
        Cadastro_Herois Adicionar(Cadastro_Herois herois);
    }
}
