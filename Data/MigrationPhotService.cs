using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LoadManager.Data
{

	public class MigrationPhotService
	{
		private List<DataFile> _dataFile = new List<DataFile>();
		private string _photoSource = @"\\cons/PlanyMini/Photo1/";
		public struct DataFile
		{
			public string? filename;
			public byte[]? buffer;
		}


		public void ConnectToServer(string PcLogin, string pass)
		{
			NetworkShare.DisconnectFromShare(_photoSource, true);
			NetworkShare.ConnectToShare(_photoSource, PcLogin, pass);

		}

		private void set__dataFilename(string filename)
		{
		    
			_dataFile.Add(new DataFile { filename = filename, buffer = SaveToBuffer(filename) });
			
			NetworkShare.DisconnectFromShare(_photoSource, true);
		}


		public async Task<bool> CheckAsync(List<string> neededFiles, string PcLogin, string pass)
		{

			ConnectToServer("shakrislanov.a", "Gatter23D");
			foreach (string file in neededFiles)
			{
				string? filename = Path.GetFileName("\\" + _photoSource + file);
				if (file == filename)
				{
					set__dataFilename(_photoSource + file);
					return await Task.FromResult(true);

				}
				
			}
			return await (Task.FromResult(false));
		}


		public byte[] SaveToBuffer(string filename)
		{


			try
			{
				byte[] buffer = File.ReadAllBytes(filename);
				return buffer;
			}
			catch (Exception error)
			{
				throw new Exception(error + "saveTobufferShit");
			}
		}

		public async Task<DataFile[]> Procedure(List<string> neededFiles, string PcLogin, string pass,string name)
		{

			await CheckAsync(neededFiles, PcLogin, pass);

			return _dataFile.ToArray();
		}
	}
} 




