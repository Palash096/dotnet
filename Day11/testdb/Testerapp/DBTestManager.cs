namespace Testing;

using HR;
using MySql.Data.MySqlClient;

public class DbTestManager{

    public static string conString=@"server=localhost;port=3306;user=root;password=root123;database=transflower";

    public static List<Department> GetAllDepartments(){
        List<Department> allDepartments =new List<Department>();

        //connected
        //connection building
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;

        try{
            con.Open();
            //fire query

            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection=con;

            string query="SELECT * FROM departments";
            cmd.CommandText=query;

            //result of query

            MySqlDataReader reader=cmd.ExecuteReader();

            while(reader.Read()){
                int id=int.Parse(reader["id"].ToString());
                string name= reader["name"].ToString();
                string location=reader["location"].ToString();

                Department dept=new Department{
                    Id=id,
                    Name=name,
                    Location=location
                };
                allDepartments.Add(dept);
            }
        }
        catch(Exception ee){
            Console.WriteLine(ee.Message);
        }
        finally{
            con.Close();
        }
        return allDepartments;
    }
}