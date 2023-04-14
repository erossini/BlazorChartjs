namespace PSC.Blazor.Components.Chartjs.Models.Common;

/// <summary>
/// Callback Generic Context
/// </summary>
public readonly record struct CallbackGenericContext(
    int DatasetIndex,
    int DataIndex,
    decimal Value,
    Guid? ChartId);
