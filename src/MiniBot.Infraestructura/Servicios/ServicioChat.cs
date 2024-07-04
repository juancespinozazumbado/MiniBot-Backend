using MiniBot.Dominio.Entitdades.Chat;
using MiniBot.Dominio.Servicios;
using MiniBot.Infraestructura.Persistencia;

namespace MiniBot.Infraestructura.Servicios;

public class ServicioChat : IServicioChat
{
    private readonly ChatBotDbContext _dbContext;

    public ServicioChat(ChatBotDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public bool Validar(string consulta)
    {
        var consultas = _dbContext.Set<Diccionario>().AsQueryable<Diccionario>();
        return consultas.Any( consultaValida => consulta.Equals(consultaValida.Consulta));
    }
}
