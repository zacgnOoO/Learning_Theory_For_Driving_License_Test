using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStaffRepository
    {
        List<Staff> GetAllStaff();
        Staff GetStaffById(string staffid);
        bool UpdaterStaff(Staff staff);
        bool InsertStaff(Staff staff);
        bool DeleteStaff(Staff staff);
    }
}
