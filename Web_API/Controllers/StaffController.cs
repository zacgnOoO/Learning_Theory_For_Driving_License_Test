using BusinessObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StaffController : ControllerBase
    {
        private IStaffRepository _staffRepository;
        public StaffController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        [HttpGet("getallstaff")]
        public IActionResult GetAll()
        {
            List<Staff> staffs = _staffRepository.GetAllStaff();
            return Ok(staffs);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(string id)
        {
            Staff staffs = _staffRepository.GetStaffById(id);
            return Ok(staffs);
        }

        [HttpPut("{id}/updateinfostaff")]
        public IActionResult UpdateInfoStaff(Staff staff)
        {
            var staffs = _staffRepository.UpdaterStaff(staff);
            return Ok("Update successfully1!");
        }
        


    }
}
