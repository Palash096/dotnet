namespace TFLCollection;

public class EmployeeComparer : IComparer<Employee>{
    // Sort by salary
    // public int Compare(Employee e1, Employee e2){
    //      //int ret = e1.name.Length.CompareTo(e2.name.Length);
    //     //return ret
    //     if(e1.Salary > e2.Salary ){
    //         return 1;
    //     }else if(e1.Salary < e2.Salary){
    //         return -1;
    //     }else {
    //         return 0;
    //     }
    // }

    // Sort by id
    public int Compare(Employee e1, Employee e2){
        if(e1.Id > e2.Id){
            return 1;
        }else if(e1.Id < e2.Id){
            return -1;
        }else{
            return 0;
        }
    }

}