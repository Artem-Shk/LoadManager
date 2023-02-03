namespace LoadManager.Model.DataModels
{
    public class FileRoot
    {
        public static int Id { get; set; }
        private  string _FileName;
      
        public string FileName
		{
			get => _FileName;
            set => _FileName = value;
		}
		

        public FileRoot(string filename) { 
            _FileName = filename;
        }
    }
}
