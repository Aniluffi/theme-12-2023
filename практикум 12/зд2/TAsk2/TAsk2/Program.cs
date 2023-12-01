class Program
{
    static public void Main(String[] args)
    {
        Point dot1 = new Point(3,3);

        Console.WriteLine(dot1.ToString());
    }
}

class Point 
{
    int x;
    int y;

   public Point ()
    {

    }

   public Point (int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double Lenght()
    {
        return Math.Sqrt(Math.Pow(0 - x,2) + Math.Pow(0-y,2));
    }
    public override string ToString()
    {
        return ($"координаты: \n x = {x}, y = {y} \n длина: \n {Lenght()}");
    }
}
