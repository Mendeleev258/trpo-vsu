namespace Good.Models;

// Модель отвечает только за хранение параметров RC-фильтра.
public class RadioFilter
{
    public double ResistanceOhms { get; init; }
    public double CapacitanceFarads { get; init; }
}
