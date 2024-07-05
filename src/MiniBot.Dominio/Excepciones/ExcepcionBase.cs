
namespace MiniBot.Dominio.Excepciones;

/// <summary>
/// Clase abstracta para definir excepciones de dominio
/// </summary>
public abstract class ExcepcionBase : Exception
{
    /// <summary>
    /// Mensaje de la excepcion
    /// </summary>
    public string Mensage {  get; set; } = string.Empty;


}
