namespace MiniBot.Dominio.Entitdades;

/// <summary>
/// Entidad base
/// definida para las propiedades que comparten todas las entidades del dominio
/// </summary>
public abstract class EntidadBase
{
    /// <summary>
    /// constructor por defecto
    /// 
    /// cuando se crea una entidad del dominio se asigana un Id unico.
    /// </summary>
    public EntidadBase()
    {
        this.Id = Guid.NewGuid();
        this.FechaCreacion = DateTime.Now;   
    }


    /// <summary>
    /// Identificador unico de cada entidad en el dominio.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Fecha en la que se inserto el registro
    /// requerido para auditoria
    /// </summary>
    public DateTime FechaCreacion { get; set; } 

    /// <summary>
    /// Fecah en la que se modifico el registro
    /// 
    /// En caso de implementar Autenticacion, manejar tambien 
    /// el id del usuario que realizo la accion
    /// </summary>
    public DateTime FechaModificacion { get; set;}

}
