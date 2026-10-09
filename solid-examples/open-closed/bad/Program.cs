using Bad.Models;
using Bad.Services;

namespace Bad;

internal static class Program
{
    private static void Main()
    {
        var appliances = new List<object>
        {
            new Refrigerator("Холодильник", 0.15),
            new WashingMachine("Стиральная машина", 1.2)
        };

        PrintTotalEnergyConsumption(appliances);
        appliances.Add(new Microwave("Микроволновая печь", 0.9));
        PrintTotalEnergyConsumption(appliances);

        var applianceController = new ApplianceController();
        foreach (object appliance in appliances)
        {
            applianceController.Start(appliance);
        }
    }

    private static void PrintTotalEnergyConsumption(IEnumerable<object> appliances)
    {
        // При добавлении нового вида техники этот код также приходится изменять.
        double total = appliances.Sum(appliance => appliance switch
        {
            Refrigerator refrigerator => refrigerator.PowerConsumption,
            WashingMachine washingMachine => washingMachine.PowerConsumption,
            Microwave microwave => microwave.PowerConsumption,
            _ => 0
        });

        Console.WriteLine($"Суммарное энергопотребление: {total:F2} кВт⋅ч");
    }
}
