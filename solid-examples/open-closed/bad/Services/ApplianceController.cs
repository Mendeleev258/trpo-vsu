using Bad.Models;

namespace Bad.Services;

public class ApplianceController
{
    public void Start(object appliance)
    {
        // Класс открыт для постоянных изменений: каждый новый прибор требует новой ветки.
        switch (appliance)
        {
            case Refrigerator refrigerator:
                refrigerator.Cool();
                break;
            case WashingMachine washingMachine:
                washingMachine.Wash();
                break;
            case Microwave microwave:
                microwave.Heat();
                break;
        }
    }
}
