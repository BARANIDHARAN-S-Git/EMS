using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Access_Layer
{
    public  class EMSMethods
    {

        MyContext Context = null;
        public EMSMethods()
        {
            Context = new MyContext();
        }

        public List<DeptMaster> ShowallDepts()
        {
              return Context.DepartmentTable.ToList();
    
        }

        public List<EmpProfile> ShowallEmployee()
        {
            return Context.EmployeeTable.ToList();

        }

        public void InsertEmployee(EmpProfile emp)
        {

            
                Context.EmployeeTable.Add(emp);
                Context.SaveChanges();
                
        }
        public void InsertDept(DeptMaster dept)
        {


            Context.DepartmentTable.Add(dept);
            Context.SaveChanges();

        }
        public void UpdateEmp(int id,EmpProfile employee)
        {
            var r = Context.EmployeeTable.ToList().Find(a => a.EmpCode == id);
            Context.EmployeeTable.Remove(r);
            Context.EmployeeTable.Add(employee);
            Context.SaveChanges();

        }

        public void Updatedept(int id, DeptMaster dept)
        {
            var a = Context.DepartmentTable.ToList().Find(b => b.DeptCode == id);
            Context.DepartmentTable.Remove(a);
            Context.DepartmentTable.Add(dept);
            Context.SaveChanges();

        }

        public void DeleteEmp(int id)
        {
            var d = Context.EmployeeTable.ToList().Find(c => c.EmpCode == id);
            Context.EmployeeTable.Remove(d);
            Context.SaveChanges();
        }

        public void Deletedep(int id)
        {
            var e= Context.DepartmentTable.ToList().Find(d => d.DeptCode == id);
            Context.DepartmentTable.Remove(e);
            Context.SaveChanges();
        }

        public EmpProfile findempbyid(int id)
        {
            var z = Context.EmployeeTable.ToList().Find(e => e.EmpCode == id);
            return z;
        }

        public DeptMaster finddeptbyid(int id)
        {
           
            var u = Context.DepartmentTable.ToList().Find(f => f.DeptCode == id);
            return u;
        }

    }
      
}
