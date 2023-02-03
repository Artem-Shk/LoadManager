namespace LoadManager.Model.DataModels
{
    public class portfolio
    {
        public string photoName { get; set; }
        public string fio { get; set; }
        public int code { get; set; }

        public portfolio(int code, string fio,string photoName)
        {
            this.code = code;
            this.fio = fio;
            this.photoName = photoName;
        }
    }
}
