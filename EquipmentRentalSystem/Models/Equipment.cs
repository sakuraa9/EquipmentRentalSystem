namespace EquipmentRentalSystem.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int? TypeId { get; set; }
        public decimal RentalPrice { get; set; }
        public string Status { get; set; } = "Available";
        public string Description { get; set; } = string.Empty;
    }
}