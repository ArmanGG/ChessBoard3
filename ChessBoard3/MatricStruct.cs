using System;

struct PossMas
{
    private char[,] S;
    public PossMas()
    {
        S = new char[9, 18];
        for (int i = 0; i < 9; i++)
        {
            S[i, 0] = '1';
        }

        for (int j = 0; j < 17; j++)
        {
            S[0, j] = '1';
        }
    }
    public void Write(int x, int y, char c)
    {
        S[x, y] = c;
    }

    public char Read(int x, int y)
    {
        return S[x, y];
    }
}