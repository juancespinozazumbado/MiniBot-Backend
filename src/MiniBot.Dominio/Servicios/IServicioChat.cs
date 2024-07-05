
namespace MiniBot.Dominio.Servicios;

public interface IServicioChat
{
    /// <summary>
    /// Valida que la consulta recibida este dentro de las posibles respuesta.
    /// </summary>
    /// <param name="consulta"></param>
    /// <returns></returns>
    public bool Validar(string consulta);
}
