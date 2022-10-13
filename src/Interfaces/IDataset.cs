namespace PSC.Blazor.Components.Chartjs.Interfaces
{
    /// <summary>
    /// Represents a dataset with an id and a type.
    /// </summary>
    public interface IDataset
    {
        /// <summary>
        /// Gets the ID of this dataset. Used to keep track of the datasets
        /// across the .NET &lt;-&gt; JavaScript boundary.
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Gets the <see cref="ChartType"/> this dataset is for.
        /// Important to set in mixed charts.
        /// </summary>
        ChartType Type { get; set; }
    }

    /// <summary>
    /// Represents a strongly typed dataset that holds data of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of data this dataset contains.</typeparam>
    public interface IDataset<T> : IDataset, IList<T>
    {
        /// <summary>
        /// Gets the data contained in this dataset. This property is read-only.
        /// This is in addition to implementing <see cref="IList{T}"/>.
        /// </summary>
        List<T> Data { get; set; }
    }
}