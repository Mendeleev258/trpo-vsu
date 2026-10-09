using Good.Models;
using Good.Services;

namespace Good;

internal static class Program
{
    private static void Main()
    {
        var applianceManager = new ApplianceManager();
        applianceManager.Add(new Refrigerator("Холодильник", 0.15));
        applianceManager.Add(new WashingMachine("Стиральная машина", 1.2));

        PrintTotalEnergyConsumption(applianceManager);
        applianceManager.Add(new Microwave("Микроволновая печь", 0.9));
        PrintTotalEnergyConsumption(applianceManager);

        applianceManager.StartAll();
    }

    private static void PrintTotalEnergyConsumption(ApplianceManager applianceManager)
    {
        Console.WriteLine(
            $"Суммарное энергопотребление: {applianceManager.CalculateTotalEnergyConsumption():F2} кВт⋅ч");
    }
}
