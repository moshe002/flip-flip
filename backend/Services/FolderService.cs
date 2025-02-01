using backend.Models;

namespace backend.Services
{
    public class FolderService
    {
        private readonly DatabaseService _databaseService;
        private readonly ILogger<FolderService> _logger;
        
        public FolderService(DatabaseService databaseService, ILogger<FolderService> logger)
        {
            _databaseService = databaseService;
            _logger = logger;
        }
        
        public async Task<List<Folder>> GetFolders()
        {
            var folders = new List<Folder>();

            folders.Add(new Folder { Name = "Folder 1", Description = "Description 1" });
            folders.Add(new Folder { Name = "Folder 2", Description = "Description 2" });
            folders.Add(new Folder { Name = "Folder 3", Description = "Description 3" });

            _databaseService.GetConnectionString();

            return folders;
        }
    }
}