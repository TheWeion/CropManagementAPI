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
        public IActionResult userIndex()
        {
            var Users = this.context.users.ToList();

            return Ok(Users);
        }

        [HttpGet]
        [Route("Tracks")]
        public IActionResult trackIndex()
        {
            var Tracks = this.context.tracks.ToList();

            return Ok(Tracks);
        }

        [HttpPost]
        [Route("Tracks")]
        public IActionResult createTrack(Track track)
        {
            var Tracks = this.context.tracks.Add(track);
            this.context.SaveChanges();
 
            return Ok();
        }
    }
}