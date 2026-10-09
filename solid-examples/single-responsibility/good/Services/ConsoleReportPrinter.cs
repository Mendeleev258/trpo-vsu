namespace Good.Services;

// Класс отвечает только за вывод текста в консоль.
public class ConsoleReportPrinter
{
    public void Print(string report) => Console.WriteLine(report);
}
