namespace CollisionLab1
{
    public class Ball
    {
        double vx, vy, posx, posy, ax, ay, radius;
        public Ball(double p1, double p2, double v1, double v2, double a1, double a2, double r)
        {
            this.vx = v1;
            this.vy = v2;
            this.posx = p1;
            this.posy = p2;
            this.ax = a1;
            this.ay = a2;
            this.radius = r;
        }
        public double getvx()
        {
            return vx;
        }
        public double getvy()
        {
            return vy;
        }
        public double getposx()
        {
            return posx;
        }
        public double getposy()
        {
            return posy;
        }
        public double getax()
        {
            return ax;
        }
        public double getay()
        {
            return ay;
        }
        public double getradius()
        {
            return radius;
        }
    }
}