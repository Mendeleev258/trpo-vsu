using Good.Models;

namespace Good.Services;

// Класс отвечает только за представление результата в виде текста.
public class FilterReportFormatter
{
    public string Format(RadioFilter filter, double cutoffFrequency) =>
        $"RC-фильтр: R = {filter.ResistanceOhms:F0} Ом, " +
        $"C = {filter.CapacitanceFarads * 1_000_000:F2} мкФ\n" +
        $"Частота среза: {cutoffFrequency:F2} Гц";
}
