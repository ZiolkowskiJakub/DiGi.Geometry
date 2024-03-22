namespace DiGi.Geometry.Spatial
{
    public static partial class Constans
    {
        public static class Vector3D
        {
            public static Classes.Vector3D WorldX 
            { 
                get 
                {
                    return new Classes.Vector3D(1, 0, 0);
                } 
            }

            public static Classes.Vector3D WorldY
            {
                get
                {
                    return new Classes.Vector3D(0, 1, 0);
                }
            }

            public static Classes.Vector3D WorldZ
            {
                get
                {
                    return new Classes.Vector3D(0, 0, 1);
                }
            }
        }
    }
}