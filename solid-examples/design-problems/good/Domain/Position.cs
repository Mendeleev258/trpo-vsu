namespace design_problems.Domain;

public readonly record struct Position(double X, double Y)
{
    public Position Move(Direction direction, double distance)
    {
        return direction switch
        {
            Direction.Up => this with { Y = Y + distance },
            Direction.Down => this with { Y = Y - distance },
            Direction.Right => this with { X = X + distance },
            Direction.Left => this with { X = X - distance },
            _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
        };
    }

    public override string ToString() => $"({X}, {Y})";
}
