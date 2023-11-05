using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class StaffDAO
    {
        public static StaffDAO instance = null;
        public static object lockObject = new object();

        private StaffDAO() { }
        public static StaffDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                }
                return instance;
            }
        }

        public List<Staff> GetAllStaff()
        {
            List<Staff> listStaff = new List<Staff>();
            try
            {
                using (var context = new Swp391Context())
                {
                    listStaff = context.Staff.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listStaff;
        }

        public Staff GetStaffById(string id)
        {
            using var db = new Swp391Context();
            return db.Staff.SingleOrDefault(s => s.StaffId == id);
        }
        public bool InsertStaff(Staff staff)
        {
            using var db = new Swp391Context();
            db.Staff.Add(staff);
            db.SaveChanges();
            return true;
        }

        public bool UpdaterStaff(Staff staff)
        {
            using var db = new Swp391Context();
            db.Staff.Update(staff);
            db.SaveChanges();
            return true;
        }

        public bool DeleteStaff(Staff staff)
        {
            using var db = new Swp391Context();
            db.Staff.Remove(staff);
            db.SaveChanges();
            return true;
        }
    }
}
