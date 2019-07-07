using App.Data.Repository.Interface;
using App.Entities.Base;
using App.Entities.Queries;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository 
    {
       public EmployeeRepository(DbContext context) : base(context)
       {
           
       }
       
    }
}
