namespace bai8_w06
{
    public class Point2D
    {
        private float x;
        private float y;
        public Point2D()
        {
            x = 0; y = 0;
        }

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float getX()
        {
            return x;
        }
        public void setX(float x)
        {
            this.x = x;
        }
        public float getY()
        {
            return y;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public float[] getXY()
        {
            float[] xy = new float[2];
            xy[0] = x;
            xy[1] = y;
            return xy;
            
        }
        public void setXY(float x, float y) 
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "("+x+","+y+")";
        }
    }
    public class Point3D : Point2D
    {
        private float z;
        public Point3D()
        {
            z = 0;
        }

        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float getZ()
        {
            return z;     
        }
        public void setZ(float z)
        {
            this.z = z;     
        }
        public float[] getXYZ()
        {
            float[] xyz = new float[3];
            xyz[0] = getX();
            xyz[1] = getY();
            xyz[2] = z;
            return xyz;
        }
        public void setXYZ(float x, float y, float z)
        {
            setX(x);
            setY(y);
            this.z=z;

        }

        public override string ToString()
        {
            return "(" + getX() + "," + getY() +","+z+")";
        }
    }
}
