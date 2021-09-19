using System;
using System.Collections.Generic;

public class Game_Field
{
    //プロパティ　List<Game_Cell>型のcells変数
    List<Game_Cell> cells = new List<Game_Cell>();

    //戻り値なし引数なしの8×8のGame_Cellを初期化し、cellsプロパティに全てのGame_Cellを追加
    public void Initialize()
    {
        for(int y = 0; y < 8; y++)
        {
            for(int x = 0; x < 8; x++)
            {
                Game_Cell cell = new Game_Cell();
                cell.Initialize(x, y);
                cells.Add(cell);
            }
        }
    }

    //引数のx,yの場所に置かれているGame_Cellを返す
    public Game_Cell GetGame_Cell(int x,int y)
    {
        Game_Cell target_Cell = new Game_Cell();
        foreach(Game_Cell cell in cells)
        {
            if (cell.X == x && cell.Y == y)
            {
                target_Cell = cell;
            }
        }
        return target_Cell;
    }
}
