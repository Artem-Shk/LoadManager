namespace LoadManager.Model.DataModels
{
    public class FileRoot
    {
        public static int Id { get; set; }
        private  string _FileName;
        private FileData? _FileData;
        public string FileName
		{
			get => _FileName;
            set => _FileName = value;
		}
		public FileData? FileData
        {
            get { return _FileData; }
            set { if (value is FileData) { this._FileData = value; }

                // TODO: learning about exceptions and add it here
                else {
                    
                }
            }

        }

        public FileRoot(string filename, FileData? fileData = null) { 
            this.FileData = fileData;
            _FileName = filename;
        }
    }
}
