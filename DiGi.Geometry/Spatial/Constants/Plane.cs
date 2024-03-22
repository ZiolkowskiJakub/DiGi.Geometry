namespace DiGi.Geometry.Spatial
{
    public static partial class Constans
    {
        public static class Plane
        {
            public static Classes.Plane WorldX 
            { 
                get 
                {
                    return new Classes.Plane(Point3D.Zero, Vector3D.WorldX);
                } 
            }

            public static Classes.Plane WorldY
            {
                get
                {
                    return new Classes.Plane(Point3D.Zero, Vector3D.WorldY);
                }
            }

            public static Classes.Plane WorldZ
            {
                get
                {
                    return new Classes.Plane(Point3D.Zero, Vector3D.WorldZ);
                }
            }
        }
    }
}