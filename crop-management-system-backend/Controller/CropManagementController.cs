using CropManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;


namespace crop_management_system_backend
{
    [Route("api/[controller]")]
    public class CropManagementController : Controller
    {
        private readonly CropManagementSystemContext context;

        public CropManagementController(CropManagementSystemContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("Users")]
        public IActionResult Index()
        {
            var Users = this.context.users.ToList();

            return Ok(Users);
        }
    }
}