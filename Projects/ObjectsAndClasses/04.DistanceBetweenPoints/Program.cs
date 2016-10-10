﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        static void Main(string[] args)
        {
            // Reads both points separately
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            // Calculate the distance between them
            double distance = CalcDistance(p1, p2);

            // Print the distance
            Console.WriteLine("Distance: {0:f3}", distance);
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        }
        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
