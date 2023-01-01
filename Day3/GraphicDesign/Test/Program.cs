using Drawing;
using OrderProcessing;
using System.Collections.Generic;

Console.WriteLine("Graphical Design Solution");

Console.WriteLine("Drawing new Lines");

Point pt1 = new Point(20, 40);
Point pt2 = new Point(56, 12);

Console.WriteLine("First Point : "+pt1);
Console.WriteLine("Second Point : "+pt2);

Shape shape1 = new Line(pt1,pt2);

Point pt3 = new Point(50, 60);
Point pt4 = new Point(45, 182);
Shape shape2 = new Rectangle(pt3,pt4);

Point pt5 = new Point(30, 100);
int radius = 12;
Shape shape3 = new Circle(pt5,radius);

List<Shape> shapes = new List<Shape>();

shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(shape3);

foreach (Shape s in shapes)
{
    s.Draw();
    IPrintable obj = (IPrintable)s;
    obj.Print();
}

// Shape s1 = new Line(pt1, pt2);

CRMHistory crm = new CRMHistory();

crm.ShowCustomerDetails();
crm.ChangeProfile();
crm.ShowOrderDetails();
