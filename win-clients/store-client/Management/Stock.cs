namespace store_client.Management
{
    public class Stock
    {

        public string _id_order { get; set; }
        public string isbn { get; set; }
        public int quantity { get; set; }
        public bool accepted { get; set; }

        public Stock()
        {

        }
    }
}
