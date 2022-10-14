using System.Linq;
using CropManagementAPI.Models;
using CropManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace CropManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {

        private readonly CropManagementSystemContext context;

        public TrackController(CropManagementSystemContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("All")]
        public IActionResult trackIndex()
        {
            var Tracks = this.context.tracks.ToList();

            return Ok(Tracks);
        }

        [HttpGet("{id}")]
        [Route("Get/{id}")]
        public IActionResult userTrack(int id)
        {
            var Tracks = this.context.tracks.Where(t => t.user_id == id).ToList();

            return Ok(Tracks);
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult createTrack(TrackModel track)
        {
            var Tracks = this.context.tracks.Add(track);
            this.context.SaveChanges();
            return Ok(track);
            
        }
    }
}
