using static LoadManager.Data.MigrationPhotService;

namespace LoadManager.Data
{
	public static class DataCore
	{
		
		public static async Task<DataFile> Preload(string name) {
			MigrationPhotService MigrationPhotService = new MigrationPhotService();
			TakeDecanatDataService TakeDecanatDataService = new TakeDecanatDataService();
			List<string> data = await TakeDecanatDataService.GetPhotosName();
		 	DataFile[] dataFile = await MigrationPhotService.Procedure(data, "shakrislanoc.a","Gatter23D", name);
			var result = dataFile[0];


		 return await Task.FromResult(result);
		}
		
		
	}


}
