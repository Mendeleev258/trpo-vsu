using design_problems.Application;
using design_problems.Controllers;
using design_problems.Robots;

IRobotFactory robotFactory = new RobotFactory();
IMovementController movementController = new MovementController();
IConstructionController constructionController = new ConstructionController();
var application = new ConsoleRobotApplication(
    robotFactory,
    movementController,
    constructionController);

application.Run();
