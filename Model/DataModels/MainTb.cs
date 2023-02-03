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
     
        
    }
}
