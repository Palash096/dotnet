using WareHouse;
using System.Collections.Generic;
using TFLCollection;
using PlayGround;

// Using super class Object
List<Object> allObj = new List<Object>();
allObj.Add(12);
allObj.Add("Palash Kardhekar");
allObj.Add(true);
allObj.Add(78.12);

foreach(Object o in allObj){
    Console.WriteLine(o);
}

// Using custome build class Part
List<Part> pt = new List<Part>();
pt.Add(new Part() {PartName = "Crank Arm", PartId = 1234});
pt.Add(new Part() {PartName = "Regular Seat", PartId = 4567});
pt.Add(new Part() {PartName = "Hand Break", PartId = 4157});
pt.Add(new Part() {PartName = "Clutch", PartId = 9117});
pt.Add(new Part() {PartName = "NOS", PartId = 3200});

foreach(Part p in pt){
    Console.WriteLine(p);
}

Dictionary<string, Part> spareParts = new Dictionary<string, Part>();
spareParts.Add("Engine", new Part() {PartId = 11, PartName = "V8"});
spareParts.Add("Exhaust", new Part() {PartId = 5012, PartName = "Duel turbo Exhaust"});

Part thePart = spareParts["Engine"];
Console.WriteLine(thePart);
Console.WriteLine(spareParts["Exhaust"]);

Console.WriteLine();

// Employee class ==> IComparer ==> override Compare(object obj1, object obj2){ }

List<Employee> employee = new List<Employee>();
employee.Add(new Employee(100, "Palash", 95000));
employee.Add(new Employee(22, "Mayur", 55000));
employee.Add(new Employee(3, "Pritish", 45000));
employee.Add(new Employee(21, "Bhavesh", 55000));
employee.Add(new Employee(1, "Vijay", 85000));

Console.WriteLine("List of Employee before sort : ");
foreach(Employee emp in employee){
    Console.WriteLine("Employee Id : "+emp.Id+", Employee Name : "+emp.Name+", Employee Salary : "+emp.Salary);
}

EmployeeComparer ec = new EmployeeComparer();
employee.Sort(ec);
Console.WriteLine("List of Employee After sort : ");
foreach(Employee emp in employee){
    Console.WriteLine("Employee Id : "+emp.Id+", Employee Name : "+emp.Name+", Employee Salary : "+emp.Salary);
}

Console.WriteLine();

// Player class
Player p1 = new Player("Palash", 11200, 45, 225.36);
Player p2 = new Player("Bhvesh", 4500, 19, 125.26);
Player p3 = new Player("Rakesh", 7800, 23, 98.56);
Player p4 = new Player("VIjay", 1200, 9, 25.36);
Player p5 = new Player("Shreyash", 64500, 21, 95.26);
Player p6 = new Player("Rinku", 78900, 13, 98.56);

List<Player> players = new List<Player>();

players.Add(p1);
players.Add(p2);
players.Add(p3);
players.Add(p4);
players.Add(p5);
players.Add(p6);

Console.WriteLine("List of Players before sorting : ");
foreach(Player p in players){
    Console.WriteLine(p.ToString());
}

players.Sort();
Console.WriteLine("List of Players After Sorting : ");
foreach(Player p in players){
    Console.WriteLine(p.ToString());
}



