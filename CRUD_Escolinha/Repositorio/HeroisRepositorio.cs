using CRUD_Escolinha.Data;
using CRUD_Escolinha.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Escolinha.Repositorio
{
    public class HeroisRepositorio : IHeroisRepositorio
    {
        private readonly HeroiContext _heroiContext;
        public HeroisRepositorio(HeroiContext heroiContext)
        {
            _heroiContext = heroiContext;
        }
        public Cadastro_Herois Adicionar(Cadastro_Herois herois) {

            _heroiContext.cadastro_Herois.Add(herois);
            _heroiContext.SaveChanges();
            return herois;
        }
    }
}
