namespace Good.Services;

// Класс отвечает только за сохранение текста в файл.
public class FileReportSaver
{
    public void Save(string path, string report) => File.WriteAllText(path, report);
}
