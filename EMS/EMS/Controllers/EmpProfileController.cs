using Business_Logic_Layer;
using Data_Access_Layer;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace EMS.Controllers
{
    public class EmpProfileController : ApiController
    {
        EMSBLL e = null;
        public EmpProfileController()
        {
            e = new EMSBLL();
        }




        [Route("Getallemp")]
        public List<EmpProfile> Get()
        {
            List<EmpProfile> m = new List<EmpProfile>();
            var a = e.ShowEmployeeList();
            foreach (var item in a)
            {
                m.Add(

                      new EmpProfile() { EmpCode = item.EmpCode, DateOfBirth = item.DateOfBirth, EmpName = item.EmpName, Email = item.Email, DeptCode = item.DeptCode }
                  );
            }
            return m;
        }

        [Route("Searchempbyid/{id}")]
        public EmpProfileModel Get(int id)
        {
            EmpProfileModel employee = new EmpProfileModel();
            EmpProfile empdata = e.searchemp(id);
            employee.EmpCode = Convert.ToInt32(empdata.EmpCode);
            employee.DateOfBirth = Convert.ToDateTime(empdata.DateOfBirth);
            employee.EmpName = empdata.EmpName.ToString();
            employee.Email = empdata.Email.ToString();
            employee.DeptCode = Convert.ToInt32(empdata.DeptCode);
            return employee;
        }

        [Route("Addemp")]
        public void  Post([FromBody] EmpProfileModel empdata)
        {
            EmpProfile emp = new EmpProfile();
            
           emp.EmpCode=empdata.EmpCode;
           emp.DateOfBirth = empdata.DateOfBirth;
           emp.EmpName=empdata.EmpName;
           emp.Email=empdata.Email;
           emp.DeptCode=empdata.DeptCode;


            e.AddEmployee(emp);
        }

        [Route("Editemp/{id}")]
        public void Put(int id,[FromBody] EmpProfileModel empdata)
        {
            EmpProfile emp = new EmpProfile();

            emp.EmpCode = empdata.EmpCode;
            emp.DateOfBirth = empdata.DateOfBirth;
            emp.EmpName = empdata.EmpName;
            emp.Email = empdata.Email;
            emp.DeptCode = empdata.DeptCode;
            e.Editemp(id, emp);
        }

        [Route("Removeemp/{id}")]
        public void Delete(int id)
        {
            e.Removeemp(id);
        }

        
    }
}