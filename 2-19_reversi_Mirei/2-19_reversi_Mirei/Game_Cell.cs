using System;
public class Game_Cell
{
    public int X;
    public int Y;
    private string Color;

    public void Initialize(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void SetColor(string color)
    {
        Color = color;
    }

    public string GetColor()
    {
        return Color;
    }
}
