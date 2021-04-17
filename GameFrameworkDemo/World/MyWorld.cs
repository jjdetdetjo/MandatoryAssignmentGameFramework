using System;
using System.Threading;
using GameFrameworkLibrary;

namespace GameFrameworkDemo
{
    public class MyWorld : World
    {
        public MyWorld(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
            XSize = maxX;
            YSize = maxY;
        }
    }
}