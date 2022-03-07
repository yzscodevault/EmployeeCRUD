using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7EmpDBSystem
{
    interface CRUD//for current operation
    {
        //ICollection<T> interface Defines methods to manipulate generic collections.
        //public interface ICollection<T> : System.Collections.Generic.IEnumerable<T>
        //The ICollection<T> interface is the base interface for classes in the System.Collections.Generic namespace.
        //generic in c# means specific data type compared to non-generic
        //The ICollection<T> interface extends IEnumerable<T> and is extended by IDictionary<TKey, TValue> and IList<T>.
        //An IDictionary<TKey, TValue> implementation is a collection of key/value pairs, like the Dictionary<TKey, TValue> class.
        //An IList<T> implementation is a collection of values, and its members can be accessed by index, like the List<T> class.





        ICollection<Department> ReadDepts();//DB tbl name - Department
        int GetMaxId();
        void AddRecord(Employee obj);//DB tbl name - Employee
        void DeleteRecord(Empolyee obj);
        ICollection<Employee> GetEmployees();
        EmployeeForm FindEmployee(int id);
        void UpdateRecord(int id, Employee empchanges);
    }

    class EmpRepository : CRUD
    {
        PCAD5EmolyeeEntities entities;//represent the database
        public EmpRepository()
        {
            entities = new PCAD5EmolyeeEntities();
        }
        public void AddRecord(Employee obj)
        {
            entities.Employee.Add(obj);//First, update list
            entities.SaveChanges();//update db(actual table)
        }

        public void DeleteRecord(Empolyee obj)
        {
            entities.Employees.Remove(obj);//remove obj from the list, not affecting db unless update db
            entities.SaveChanges();//save changes to db
        }

        public EmployeeForm FindEmployee(int id)
        {
            //var emptoupdate = entities.Employees.Find(id);//find the entire object by using input id
            //above and below performs save function
            var emp = entities.Emploees.First(anyname => anyname.EmpId == id);
            if (emp != null)
            {
                return emp;
            }
            else
                return null;
        }

        public ICollection<Employee> GetEmployees()
        {
            return entities.Employees.ToList();//for use in dataGridEmployee
        }

        public int GetMaxId()
        {
            return entities.Employees.Max(anyname => anyname.salary);//return the object w max salary
        }

        public ICollection<Department> ReadDepts()//for use in cmbxDept
        {
            return entities.Department.ToList();//for use in dataGridEmployee
        }

        public void UpdateRecord(int id, Employee empchanges)
        {            
            var emptoupdate = entities.Employees.Find(id);//find the entire object by using input id
            //above is the same as public EmployeeForm FindEmployee(int id){}; method
            emptoupdate.EId = empchanges.EId;
            emptoupdate.EmpFName = empchanges.EmpFName;
            emptoupdate.EmpLName = empchanges.EmpLName;
            emptoupdate.DeptId = empchanges.DeptId;
            emptoupdate.Designation = empchanges.Designation;
            emptoupdate.Salary = empchanges.Salary;
            entities.SaveChanges();
        }
    }
}
