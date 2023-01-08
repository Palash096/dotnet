using HR;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var emp = new {Id = 123, FirstName = "Palash", LastName = "Kardhekar"};

var employee = new List<Employee>();
employee.Add(new Employee(){EmpId = 123, FullName = "Palash", Address = "Kardhekar"});
employee.Add(new Employee(){EmpId = 13, FullName = "Mayur", Address= "Pakhale"});
employee.Add(new Employee(){EmpId = 23, FullName = "Pritish", Address = "Ramadaas"});
employee.Add(new Employee(){EmpId = 120, FullName  = "Bhavesh", Address = "Verma"});

app.MapGet("/", () => "Hello World!");
app.MapGet("/welcome", () => "Welcome Page!");
app.MapGet("/emp", () => emp);
app.MapGet("/employee", () => employee);

app.Run();
