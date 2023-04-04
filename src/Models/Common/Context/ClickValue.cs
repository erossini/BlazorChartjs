namespace PSC.Blazor.Components.Chartjs.Models.Common
{
    /// <summary>
    /// Class ClickValue.
    /// </summary>
    public readonly record struct ClickValue(int DatasetIndex, int ValueIndex, decimal Value)
    {
    }
}
