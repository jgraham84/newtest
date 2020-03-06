using FirstWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FirstWeb.Interface
{
    public interface IStaffService
    {
        Staff GetStaffById(int Id);
        Task CreateStaffMemberAsync(Staff staff);

    }
}