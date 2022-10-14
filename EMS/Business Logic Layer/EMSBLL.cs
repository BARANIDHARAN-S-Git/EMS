using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business_Logic_Layer
{
    public class EMSBLL
    {

        EMSMethods dal;
        public EMSBLL()
        {
            dal = new EMSMethods();
        }
        public List<EmpProfile> ShowEmployeeList()
        {
            return dal.ShowallEmployee();
        }

        public List<DeptMaster> ShowDepartmentList()
        {
            return dal.ShowallDepts();
        }

        public  void AddEmployee(EmpProfile employee)
        {
              dal.InsertEmployee(employee);

        }
        public void AddDept(DeptMaster dept)
        {
            dal.InsertDept(dept);

        }

        public void Editemp(int id,EmpProfile employee)
        {
            dal.UpdateEmp(id, employee);
        }

        public void Editdept(int id, DeptMaster dept)
        {
            dal.Updatedept(id, dept);
        }

        public void Removeemp(int id)
        {
            dal.DeleteEmp(id);
        }

        public void Removedept(int id)
        {
            dal.Deletedep(id);
        }
        public EmpProfile searchemp(int id)
        {
            return dal.findempbyid(id);
        }

        public DeptMaster searchdept(int id)
        {
            return dal.finddeptbyid(id);
        }

    }
}
