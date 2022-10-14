using Business_Logic_Layer;
using Data_Access_Layer;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EMS.Controllers
{
    public class DeptMasterController : ApiController
    {
        EMSBLL a=null;
        public DeptMasterController()
        {
            a=new EMSBLL();
        }


        [Route("Getalldept")]
        public List<DeptMaster> Get()
        {
            List<DeptMaster> l=new List<DeptMaster>();
            var b = a.ShowDepartmentList();
            foreach(var item in b)
            {
                l.Add(

                    new DeptMaster()
                    {
                        DeptCode=item.DeptCode,DeptName=item.DeptName
                    }
                );
            }
            return l;

            
        }


        [Route("Searchdeptbyid/{id}")]
        public DeptmasterModel Get(int id)
        {
            DeptmasterModel employee = new DeptmasterModel();
            DeptMaster deptdata = a.searchdept(id);
            employee.DeptCode = Convert.ToInt32(deptdata.DeptCode);
          
            employee.DeptName= deptdata.DeptName.ToString();
            
            return employee;
        }


        [Route("Adddept")]
        public void Post([FromBody] DeptmasterModel empdata)
        {
            DeptMaster dept = new DeptMaster();
           
            dept.DeptCode=empdata.DeptCode;
            dept.DeptName=empdata.DeptName;

            a.AddDept(dept);
            

        }

        [Route("Editdept/{id}")]
        public void Put(int id, [FromBody] DeptmasterModel deptdata)
        {
            DeptMaster dept = new DeptMaster();

            dept.DeptCode = deptdata.DeptCode;
            dept.DeptName = deptdata.DeptName;
            
            a.Editdept(id, dept);
        }

        [Route("Removedept/{id}")]
        public void Delete(int id)
        {
            a.Removedept(id);
        }
    }
}