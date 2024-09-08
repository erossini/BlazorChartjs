namespace PSC.Blazor.Components.Chartjs.Interfaces
{
    /// <summary>
    /// Interface IDataset
    /// </summary>
    public interface IDataset
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        ChartType Type { get; set; }
    }

    /// <summary>
    /// Interface IDataset
    /// Extends the <see cref="PSC.Blazor.Components.Chartjs.Interfaces.IDataset" />
    /// Extends the <see cref="System.Collections.Generic.IList{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="PSC.Blazor.Components.Chartjs.Interfaces.IDataset" />
    /// <seealso cref="System.Collections.Generic.IList{T}" />
    public interface IDataset<T> : IDataset, IList<T>
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        List<T> Data { get; set; }
    }
}