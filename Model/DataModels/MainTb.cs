namespace LoadManager.Model.DataModels
{
    public class MainTb
    {
        public int Id { get; set; }
        public string FileName
        {
            get
            {
                if (FileName != null)
                {
                    return FileName;

                }
                else
                {
                    return "FileName is null";
                }
            }
            set { }
        }
        public FileData FileData
        {
            get { return FileData; }
            set { if (value is FileData) { FileData = value; }

                // TODO: learning about exceptions and add it here
                else {
                    
                }
            }

        }
    }
}
