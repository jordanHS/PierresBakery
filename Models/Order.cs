namespace PierresBakery.Models
{
    public class Order
    {
        public int BreadTotal { get; set;}
        public int PastriesTotal { get; set; }
    
        public Order (int breadTotal, int pastriesTotal)
        {
            BreadTotal = breadTotal;
            PastriesTotal = pastriesTotal;
        }
    }

}