using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LoadManager.Data
{

	public class MigrationPhotService
	{

		private DataFile _dataFile;
		private string _photoSource = @"\\cons/PlanyMini/Photo1/";
		private Dictionary<string, string> levels = new Dictionary<string, string>()
  {{"Неудвл","Неудоволетворительно"},
		{"Удовл","Удоволетворительно"},
		  {"Хор","Хорошо"},
			  {"Отл","Отлично"}};

		public struct DataFile
		{
			public string? filename;
			public byte[]? buffer;
		}
		public Task<bool> CheckAsync(List<string> neededFiles, string PcLogin,string pass)
		{
			NetworkShare.DisconnectFromShare(_photoSource, true);
			NetworkShare.ConnectToShare(_photoSource, PcLogin, pass);

			foreach (string file in neededFiles)
			{
				string? filename = Path.GetFileName("\\" + _photoSource + file);
				if (neededFiles.Contains(filename))
				{
					_dataFile.filename = _photoSource + file;
					NetworkShare.DisconnectFromShare(_photoSource, true);
					return Task.FromResult(true);
				}
			}
			return (Task.FromResult(false));
		}
		public bool SaveToBuffer()
		{

			try
			{
				byte[] buffer = File.ReadAllBytes(_dataFile.filename);
				_dataFile.buffer = buffer;
				return true;
			}
			catch (Exception error)
			{
				Console.WriteLine(error.Message + "SaveToBufferError");
				return false;
			{

				}
			}
		}

		public async Task<DataFile> Procedure(List<string> neededFiles, string PcLogin, string pass)
		{
			
			await CheckAsync(neededFiles,PcLogin,pass);
			SaveToBuffer();
			return _dataFile;
		}
	}
}



