namespace bad;

public class Robot
{
    private string Name { get; }
    private string Type { get; } // explorer, builder ЖЕСТКОСТЬ
    private double Step { get; set; }
    
    private double _x = 0;
    private double _y = 0;
    
    private void MoveUp() { _y +=  Step; }
    private void MoveDown() { _y -=  Step; }
    private void MoveRight() { _x +=  Step; }
    private void MoveLeft() { _x -=  Step; }

    public Robot(string name, string type, double x, double y, double step)
    {
        Name = name;
        Type = type;
        _x = x;
        _y = y;
        Step = step;
    }

    public void Move(string where) // "up, down, right, left" НЕПОДВИЖНОСТЬ
    {
        switch (where)
        {
            case "up":
                this.MoveUp();
                break;
            case "down":
                this.MoveDown();
                break;
            case "right":
                this.MoveRight();
                break;
            case "left":
                this.MoveLeft();
                break;
        }
    }

    public void Build()
    {
        if (this.Type == "explorer")
        {
            throw new Exception("robot with an explorer type cannot build something");
        }
        Console.WriteLine($"Built a tower at {this._x}, {this._y}");
    }
}