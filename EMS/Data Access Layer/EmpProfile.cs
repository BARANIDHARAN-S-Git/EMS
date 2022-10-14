using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace Data_Access_Layer
{
   
       

        public class EmpProfile
        {
            [Key]
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int EmpCode { get; set; }

            public DateTime DateOfBirth { get; set; }

            [MaxLength(30, ErrorMessage = "Not allowed above 30 chars")]
            [MinLength(3, ErrorMessage = "Not allowed below 3 chars")]
            public string EmpName { get; set; }

            public string Email { get; set; }

      
            [ForeignKey("DeptMaster")]
            public int DeptCode { get; set; }

        
            public virtual DeptMaster DeptMaster { get; set; }
        
        }
        public class MyContext : DbContext
        {
            public MyContext() : base("MyContext")
            {
                Database.SetInitializer(new SeedMethod());
            }

           public virtual DbSet<DeptMaster> DepartmentTable { get; set; }
        
            public virtual DbSet<EmpProfile> EmployeeTable { get; set; }
           
        }

       
    
}
