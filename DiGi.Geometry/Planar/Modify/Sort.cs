using DiGi.Core;
using DiGi.Geometry.Planar.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Modify
    {
        public static void Sort(this List<Point2D> point2Ds, Func<Point2D, double> func)
        {
            if (point2Ds == null || func == null)
            {
                return;
            }

            List<Tuple<Point2D, double>> tuples = new List<Tuple<Point2D, double>>();
            for(int i = 0; i < point2Ds.Count; i++)
            {
                tuples.Add(new Tuple<Point2D, double>(point2Ds[i], func.Invoke(point2Ds[i])));
            }

            tuples.Sort((x, y) => x.Item2.CompareTo(y.Item2));

            point2Ds.Clear();
            for(int i = 0; i < tuples.Count; i++)
            {
                point2Ds.Add(tuples[i].Item1);
            }
        }
    }
}
