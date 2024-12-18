namespace _23210202037.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string PermissionName { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}