
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMS.Models
{
   
      
        public class EmpProfileModel
        {
            [Required()]
            public int EmpCode { get; set; }

            public DateTime DateOfBirth { get; set; }

            [MaxLength(30, ErrorMessage = "Not allowed above 30 chars")]
            [MinLength(3, ErrorMessage = "Not allowed below 3 chars")]
            public string EmpName { get; set; }

            public string Email { get; set; }
        

             
            public int DeptCode { get; set; }
            
            public virtual DeptmasterModel DeptMaster { get; set; }
        

        }
    
}