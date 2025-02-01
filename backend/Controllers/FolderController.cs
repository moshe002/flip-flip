using Microsoft.AspNetCore.Mvc;
using backend.Services;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FolderController: ControllerBase
    {
        private readonly FolderService _folderService;

        public FolderController(FolderService folderService)
        {
            _folderService = folderService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Folder>>> GetFolders()
        {
            try {
                var folders = await _folderService.GetFolders();

                return Ok(folders);
            }
            catch (Exception ex)
            {
                return BadRequest("Error fetching folders: " + ex.Message);
            }
        }
    }
}