using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StaffRepository : IStaffRepository
    {
        public bool DeleteStaff(Staff staff) => StaffDAO.Instance.DeleteStaff(staff);

        public List<Staff> GetAllStaff() => StaffDAO.Instance.GetAllStaff();

        public Staff GetStaffById(string staffid) => StaffDAO.Instance.GetStaffById(staffid);

        public bool InsertStaff(Staff staff) => StaffDAO.Instance.InsertStaff(staff);

        public bool UpdaterStaff(Staff staff) => StaffDAO.Instance.UpdaterStaff(staff);
    }
}
