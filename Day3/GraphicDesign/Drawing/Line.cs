namespace Drawing;

public class Line : Shape, IPrintable{
    public Point StartPoint{get; set;}
    public Point EndPoint{get; set;}

    public Line(){
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);
    }

    public Line(Point pt1, Point pt2){
        this.StartPoint=pt1;
        this.EndPoint=pt2;
    }

    // override from shape class
    public override void Draw(){
        Type t = this.GetType();
        Console.WriteLine("Type : "+t.Name);
        Console.WriteLine("("+this.StartPoint+","+this.EndPoint+")"+"(Width : "+this.Width+" , Color : "+this.Color+")");
    }

    // implementation from interface
    public void Print(){
        Console.WriteLine("Printing Object of Line : ");
        Type t = this.GetType();
        Console.WriteLine("Type : "+t.Name);
        Console.WriteLine("("+this.StartPoint+","+this.EndPoint+")"+"(Width : "+this.Width+" , Color : "+this.Color+")");
    }

}