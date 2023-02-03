using LoadManager.Model.DataModels;
using Microsoft.EntityFrameworkCore;

namespace LoadManager.Data
{
    public class TakeDecanatDataService
    {

        public Task<portfolio[]> GetPhotosName()
        {
            using(DecanatContext db = new DecanatContext())
            {
                return Task.FromResult(db
                    .Преподаватели
                    .Where(u => u.ФайлФото != null).Select(column => new portfolio(column.Код, column.Фио, column.ФайлФото))
                    .ToArray());
                    
            }
        } 
    }
}
