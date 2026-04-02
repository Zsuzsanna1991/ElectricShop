namespace ElectricShop.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Memory { get; set; }
        public string Display {  get; set; }


        public int OperationSystemId { get; set; }

        //Kapcsolat kialakítása
        public OperationSystem OperationSystem { get; set; }
    }
}
