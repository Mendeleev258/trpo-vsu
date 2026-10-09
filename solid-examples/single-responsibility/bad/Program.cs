using Bad;

// Нарушение SRP: RadioFilterReport имеет сразу несколько причин для изменения.
var report = new RadioFilterReport
{
    ResistanceOhms = 1_000,
    CapacitanceFarads = 0.000_001
};

report.Print();
report.SaveToFile("filter-report.txt");
Console.WriteLine("Отчёт сохранён в файл filter-report.txt");
