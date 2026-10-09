using Good.Models;

namespace Good.Services;

// Класс отвечает только за расчёт частоты среза.
public class CutoffFrequencyCalculator
{
    public double Calculate(RadioFilter filter) =>
        1 / (2 * Math.PI * filter.ResistanceOhms * filter.CapacitanceFarads);
}
