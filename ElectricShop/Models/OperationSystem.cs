namespace ElectricShop.Models
{
    public class OperationSystem
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Version { get; set; }


        //Kapcsolat kialaktása
        public ICollection<Computer> computers { get; set; } = new List<Computer>();
        
    }
}
