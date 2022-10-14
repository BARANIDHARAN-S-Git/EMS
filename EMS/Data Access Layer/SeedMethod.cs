using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class SeedMethod : DropCreateDatabaseIfModelChanges<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            List<DeptMaster> deptlist = new List<DeptMaster>();
            deptlist.Add(new DeptMaster()
            {
                DeptCode=101,DeptName="Sales"
            });
            deptlist.Add(new DeptMaster()
            {
                DeptCode = 102,
                DeptName = "Finance"
            });
            deptlist.Add(new DeptMaster()
            {
                DeptCode = 103,
                DeptName = "Administration"
            });
            context.DepartmentTable.AddRange(deptlist);
            List<EmpProfile>emplist=new List<EmpProfile>();
            emplist.Add(new EmpProfile()
            {
                EmpCode=4522,
                DateOfBirth=new DateTime(2000,06,17),
                EmpName="Buttler",
                Email="Buttler123@gmail.com",
                DeptCode=101

            }
            );
            emplist.Add(new EmpProfile()
            {
                EmpCode = 4542,
                DateOfBirth = new DateTime(2000, 04, 23),
                EmpName = "Axar",
                Email = "Axar456@gmail.com",
                DeptCode = 102

            }
            );
            emplist.Add(new EmpProfile()
            {
                EmpCode = 4564,
                DateOfBirth = new DateTime(2001, 08, 14),
                EmpName = "IshanKishan",
                Email = "IshanKishan234@gmail.com",
                DeptCode = 103

            }
            );
            context.EmployeeTable.AddRange(emplist);
            context.SaveChanges();
            base.Seed(context);
        }

    }

}
