using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace InventoryManagement.Infrastructure.Configuration.Permissions
{
    public class InventoryPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Inventory", new List<PermissionDto>
                    {
                        new PermissionDto(InventoryPermissions.List, "ListInventory"),
                        new PermissionDto(InventoryPermissions.Search, "SearchInventory"),
                        new PermissionDto(InventoryPermissions.Create, "CreateInventory"),
                        new PermissionDto(InventoryPermissions.Edit, "EditInventory")
                    }
                }
            };
        }
    }
}
