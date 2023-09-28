namespace IRepository
{
    /// <summary>
    /// Crear los métodos genericos para todas las tablas
    /// </summary>
    /// <typeparam name="T">Nombre de tabla</typeparam>
    public interface IRepositoryCrud<T>:IDisposable
    {
        /// <summary>
        /// Muestra los registros de la tabla <typeparamref name="T"/>
        /// </summary>
        /// <returns>Una lista de registros</returns>
        List<T> GetAll();
        /// <summary>
        /// Muserta solo un registro de la tabla <typeparamref name="T"/>
        /// </summary>
        /// <param name="id">Condicion para buscar el registro</param>
        /// <returns>Un unico registro</returns>
        T GetById(object id);
        /// <summary>
        /// Se registra un nuevo registro en la tabla <typeparamref name="T"/>
        /// </summary>
        /// <param name="entity">los datos del nuevo registro</param>
        /// <returns>El registro insertardo</returns>
        T Create(T entity);
        /// <summary>
        /// Mando un lista de registros nuevos a la tabla <typeparamref name="T"/>
        /// </summary>
        /// <param name="lista">Es una lista de registros</param>
        /// <returns>Lista de registro insertados</returns>
        List<T> CreateMultiple(List<T> lista);
        /// <summary>
        /// Se actualiza un registro de la tabla <typeparamref name="T"/>
        /// </summary>
        /// <param name="entity">los datos del nuevos</param>
        /// <returns>El registro actualizado</returns>
        T Update(T entity);
        /// <summary>
        /// Mando un lista de registros actualizados a la tabla <typeparamref name="T"/>
        /// </summary>
        /// <param name="lista">Es una lista de registros</param>
        /// <returns>Lista de registro actualizado</returns>
        List<T> UpdateMultiple(List<T> lista);
        /// <summary>
        /// Elimina un registro de una tabla <typeparamref name="T"/> segun el id
        /// </summary>
        /// <param name="id">identifador unico de la tabla</param>
        /// <returns>la cantida de registros afectadas</returns>
        int Delete(object id);
        /// <summary>
        /// Realiza una eliminacion multiple de una lista de registros de la tabla <typeparamref name="T"/>
        /// </summary>
        /// <param name="lista">Lista de registros a eliminiar</param>
        /// <returns>La cantidad de registros eliminados</returns>
        int DeleteMultiple(List<T> lista);

    }
}