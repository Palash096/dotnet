namespace Drawing;

public class Circle : Shape, IPrintable
{
    public Point Center { get; set; }
    public int Radius { get; set; }

    public Circle()
    {
        this.Center = new Point(0, 0);
        this.Radius = 1;
    }

    public Circle(Point c, int r)
    {
        this.Center = c;
        this.Radius = r;
    }

    // overriding
    public override void Draw()
    {
        Type t = this.GetType();
        Console.WriteLine("Type = " + t.Name);
        Console.WriteLine("(" + this.Center + "), Radius=" + this.Radius + "," +
                            this.Width + "," + this.Color);
    }

    // implemented from interface
    public void Print()
    {
        Console.WriteLine("Printing Object of Circle : ");
        Type t = this.GetType();
        Console.WriteLine("Type : " + t.Name);
        Console.WriteLine("(" + this.Center + "), Radius=" + this.Radius + "," +
                            this.Width + "," + this.Color);
    }
}