namespace Bad;

// Класс одновременно хранит параметры фильтра, выполняет расчёт,
// формирует отчёт, выводит его и работает с файловой системой.
// Поэтому изменение любой из этих задач потребует изменения одного класса.
public class RadioFilterReport
{
    public double ResistanceOhms { get; init; }
    public double CapacitanceFarads { get; init; }

    public double CalculateCutoffFrequency() =>
        1 / (2 * Math.PI * ResistanceOhms * CapacitanceFarads);

    public string CreateReport() =>
        $"RC-фильтр: R = {ResistanceOhms:F0} Ом, C = {CapacitanceFarads * 1_000_000:F2} мкФ\n" +
        $"Частота среза: {CalculateCutoffFrequency():F2} Гц";

    public void Print() => Console.WriteLine(CreateReport());

    public void SaveToFile(string path) => File.WriteAllText(path, CreateReport());
}
