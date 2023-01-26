using LoadManager.Model;
using LoadManager.Model.DataModels;

namespace LoadManager.Data
{

    public class FileRootService
    {
        public Task<FileRoot[]> GetFileRootsAsynch ()
        {
            return Task.FromResult( new Sql().SelectFromFileRoot().ToArray());
        }
    }
}
