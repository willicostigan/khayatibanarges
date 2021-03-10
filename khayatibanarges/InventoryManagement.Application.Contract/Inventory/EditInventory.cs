namespace InventoryManagement.Application.Contract.Inventory
{
    public class EditInventory :CreateInventory
    {
        public long ProductId { get; set; }
        public long Id { get; set; }
        public double UnitPrice { get; set; }
    }
}