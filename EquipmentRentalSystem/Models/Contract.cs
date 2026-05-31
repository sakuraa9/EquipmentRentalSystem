namespace EquipmentRentalSystem.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EquipmentId { get; set; }

        public string ClientFullName { get; set; } = string.Empty;
        public string EquipmentName { get; set; } = string.Empty;

        public string RentalDate { get; set; } = string.Empty;
        public string ReturnDate { get; set; } = string.Empty;
        public string? ActualReturnDate { get; set; }

        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Active";
        public string CreatedAt { get; set; } = string.Empty;
    }
}