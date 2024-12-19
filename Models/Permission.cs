namespace _23210202037.Models
{
    public class Permission
    {
        public string? PermissionId { get; set; }
        public string PermissionName { get; set; } = string.Empty;
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}