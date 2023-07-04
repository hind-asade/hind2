namespace BlazorApp2.Modles
{
	public class ArchivingModle
	{
        public int id { get; set; }
		public string DocNane { get; set; }
		public string DocNumber { get; set; }
		public DateTime DocDate { get; set; }
		public string To { get; set; }
		public string From { get; set; }
		public string Note { get; set; }
		public string Thumbnailpath { get; set; }

        public  string Signaturepath { get; set; }
        public string Filepath { get; set; }
    }
}
