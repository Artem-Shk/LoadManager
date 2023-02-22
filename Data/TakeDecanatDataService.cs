using LoadManager.Model.DataModels;
using Microsoft.EntityFrameworkCore;

namespace LoadManager.Data
{
    public class TakeDecanatDataService
    {

        public async Task<portfolio[]> GetPhotosObject()
        {
            using(DecanatContext db = new DecanatContext())
            {
                return await Task.FromResult(db
                    .Преподаватели
                    .Where(u => u.ФайлФото != null & u.Логин != null).Select(column => new portfolio(column.Код, column.Фио, column.ФайлФото, column.Логин))
                    .ToArray());
                    
            }
        }
		public async Task<List<string>> GetPhotosName()
		{
			using (DecanatContext db = new DecanatContext())
			{
				return await Task.FromResult(db
					.Преподаватели
					.Where(u => u.ФайлФото != null).Select(column => column.ФайлФото)
					.ToList<string>());

			}
		}
	}
}
