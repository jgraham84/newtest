using FirstWeb.Interface;
using FirstWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FirstWeb
{
    public class StaffService : IStaffService
    {

        private readonly EfExampleEntities _db;
        public StaffService(EfExampleEntities db)
        {
            _db = db;
        }

        public async Task CreateStaffMemberAsync(Staff staff)
        {
            _db.Staffs.Add(staff);
            await _db.SaveChangesAsync();
        }

        public Staff GetStaffById(int Id) => _db.Staffs.Where(x => x.Id == Id).FirstOrDefault();

   
    
    }
}