using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class DeptmasterModel
    {
       
            [Required()]
            public int DeptCode { get; set; }

            [MaxLength(30, ErrorMessage = "Not allowed above 30 chars")]
            [MinLength(3, ErrorMessage = "Not allowed below 3 chars")]
            public string DeptName { get; set; }

           public virtual ICollection<EmpProfileModel> EmpProfiles { get; set; }
        
    }
}