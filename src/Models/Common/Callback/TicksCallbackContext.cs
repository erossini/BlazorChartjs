namespace PSC.Blazor.Components.Chartjs.Models.Common {
    /// <summary>
    /// Callback Generic Context
    /// </summary>
    public readonly record struct TicksCallbackContext(decimal Value, int Index, decimal[] Ticks) {
    }
}
