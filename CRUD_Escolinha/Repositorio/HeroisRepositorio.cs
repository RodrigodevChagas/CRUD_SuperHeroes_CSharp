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
        public Cadastro_Herois Adicionar(Cadastro_Herois herois)
        {

            _heroiContext.cadastro_Herois.Add(herois);
            _heroiContext.SaveChanges();
            return herois;
        }
        public Cadastro_Herois ListarPorId(int id) {
            var listaHeroiPorId = _heroiContext.cadastro_Herois.FirstOrDefault(h => h.Id == id);
            if (listaHeroiPorId == null) throw new System.Exception("Nenhum Heroi Econtrado");
            return listaHeroiPorId;
        }
        public List<Cadastro_Herois> BuscarTodos()
        {
            return _heroiContext.cadastro_Herois.ToList();
        }
        public Cadastro_Herois Editar(Cadastro_Herois heroi) {

            var heroiEditado = ListarPorId(heroi.Id);
            if (heroiEditado == null) throw new System.Exception("Heroi não encontrado");

            heroiEditado.Nome = heroi.Nome;
            heroiEditado.Nome_De_Heroi = heroi.Nome_De_Heroi;
            heroiEditado.Local_de_Origem = heroi.Local_de_Origem;
            heroiEditado.Empresa = heroi.Empresa;

            _heroiContext.Update(heroiEditado);
            _heroiContext.SaveChanges();

            return heroiEditado;
        }

        public bool Apagar(int id)
        {
            var apagarHeroi = ListarPorId(id);
            if (apagarHeroi == null) throw new System.Exception("Houve um erro na deleção");

            _heroiContext.Remove(apagarHeroi);
            _heroiContext.SaveChanges();
            
            return true;
        }
    }
}
