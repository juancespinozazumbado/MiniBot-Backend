using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniBot.Dominio.Entitdades.Chat;
using MiniBot.Dominio.Servicios;
using MiniBot.Infraestructura.Persistencia;

namespace MiniBot.Servicio.Controllers;

[ApiController]
[Route("api/v1/chat")]
public class ChatController : ControllerBase
{
   
    private readonly ILogger<ChatController> _logger;
    private readonly ChatBotDbContext _dbContex;
    private readonly IServicioChat _servicioChat;

    public ChatController(ILogger<ChatController> logger, IServicioChat servicio, ChatBotDbContext dbContex)
    {
        _logger = logger;
        _servicioChat = servicio;
        _dbContex = dbContex;
    }

    [HttpGet("")]
    public IActionResult Get()
    {
        return Ok(new { Mensage = "servicio fumciona correctamente!" });
    }


    [HttpPost("send")]
    public async Task<IActionResult> EnviarMensage(Mensage consulta)
    {
       try
{
    if (_servicioChat.Validar(consulta.Texto))
    {
        var diccionario = await _dbContex.Set<Diccionario>()
            .FirstOrDefaultAsync(c => c.Consulta.Equals(consulta.Texto));
        return Ok(new { Respuesta = diccionario.Respuesta });

    }
    else
    {
        // Indica que no existe respuesta para esta pregunta!
        var respuestaDefault = _dbContex.Set<Diccionario>()
            .First(c => c.Consulta.Equals("No reconocida"));
        return Ok(new { Respuesta = respuestaDefault.Respuesta });
    }

}
catch(Exception ex)
{
    return Problem(ex.Message);
}
        

    }



}
