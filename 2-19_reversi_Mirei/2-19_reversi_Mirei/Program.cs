using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Game_Field field = new Game_Field();
        field.Initialize();
        Game_Cell cell = field.GetGame_Cell(2, 7);

        //Game_Cell cell = new Game_Cell();
        //cell.Initialize(0, 0);
        //cell.SetColor("黒");
        //Console.WriteLine(cell.GetColor());
    }
}