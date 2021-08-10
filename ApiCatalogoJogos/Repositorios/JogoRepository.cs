using ApiCatalogoJogos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Repositorios
{
    public class JogoRepository : IJogoRepository
    {
        private static Dictionary<Guid, Jogo> jogos = new Dictionary<Guid, Jogo>()
{

    { Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd04"), new Jogo { Id = Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd04"), Nome = "Fifa 22", Produtora = "EA", Preco = 338 }},
    { Guid.Parse("5e99c84a-108b-4dfa-ab7e-d8c55957a7ec"), new Jogo { Id = Guid.Parse("5e99c84a-108b-4dfa-ab7e-d8c55957a7ec"), Nome = "Dead by daylight", Produtora = "Behaviour Interactive", Preco = 36 } },
    { Guid.Parse("da033439-f352-4539-879f-515759312d53"), new Jogo { Id = Guid.Parse("da033439-f352-4539-879f-515759312d53"), Nome = "BATTLEFIELD™ 2042", Produtora = "DICE, EA", Preco = 249 }},
    { Guid.Parse("92576bd2-388e-4f5d-96c1-8bfda6c5a268"), new Jogo { Id = Guid.Parse("92576bd2-388e-4f5d-96c1-8bfda6c5a268"), Nome = "Grand Theft Auto V: Premium Edition", Produtora = "Rockstar Games", Preco = 38 } },
    { Guid.Parse("c3c9b5da-6a45-4de1-b28b-491cbf83b589"), new Jogo { Id = Guid.Parse("c3c9b5da-6a45-4de1-b28b-491cbf83b589"), Nome = "Street Fighter V: Champion Edition Upgrade Kit", Produtora = "Capcom", Preco = 95 } }
 };
        public Task<List<Jogo>> Obter(int pagina, int quantidade)
        {
            return Task.FromResult(jogos.Values.Skip((pagina - 1) * quantidade).Take(quantidade).ToList());
        }
        public Task<Jogo> Obter(Guid id)
        {
            if (!jogos.ContainsKey(id))
                return null;
            return Task.FromResult(jogos[id]);

        }
        public Task<List<Jogo>> Obter(string nome, string produtora)
        {
            return Task.FromResult(jogos.Values.Where(jogo => jogo.Nome.Equals(nome) && jogo.Produtora.Equals(produtora)).ToList());
        }

        public Task Inserir(Jogo jogo)
        {
            jogos.Add(jogo.Id, jogo);
            return Task.CompletedTask;
        }
        public Task Atualizar(Jogo jogo)
        {
            jogos[jogo.Id] = jogo;
            return Task.CompletedTask;
        }
        public Task Remover(Guid id)
        {
            jogos.Remove(id);
            return Task.CompletedTask;
        }

        public void Dispose()
        {

        }
    }
}











