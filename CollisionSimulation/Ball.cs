namespace CollisionSimulation
{
    public class Ball
    {
        double vx,vy, posx, posy, ax, ay, radius;
        public Ball(double p1, double p2, double v1, double v2, double a1, double a2, double r )
        {
            this.vx = v1;
            this.vy = v2;
            this.posx = p1;
            this.posy = p2;
            this.ax = a1;
            this.ay = a2;
            this.radius = r;
        }
    }
}