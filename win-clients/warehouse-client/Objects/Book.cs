namespace warehouse_client.Objects
{
    public class Book
    {
        public Book()
        {

        }

        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public string publisher { get; set; }
        public float price { get; set; }
        public int stock { get; set; }
        public string image { get; set; }
    }
}