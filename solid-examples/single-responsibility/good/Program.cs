using Good.Models;
using Good.Services;

var filter = new RadioFilter
{
    ResistanceOhms = 1_000,
    CapacitanceFarads = 0.000_001
};

var calculator = new CutoffFrequencyCalculator();
var cutoffFrequency = calculator.Calculate(filter);

var formatter = new FilterReportFormatter();
var report = formatter.Format(filter, cutoffFrequency);

var printer = new ConsoleReportPrinter();
printer.Print(report);

var fileSaver = new FileReportSaver();
fileSaver.Save("filter-report.txt", report);
Console.WriteLine("Отчёт сохранён в файл filter-report.txt");
