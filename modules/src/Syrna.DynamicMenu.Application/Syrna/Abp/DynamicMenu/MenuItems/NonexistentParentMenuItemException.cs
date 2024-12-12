using Volo.Abp;

namespace Syrna.DynamicMenu.MenuItems
{
    public sealed class NonexistentParentMenuItemException : BusinessException
    {
        public NonexistentParentMenuItemException(string parentId)
            : base("Syrna.DynamicMenu:NonexistentParentMenuItem")
        {
            Data["ParentId"] = parentId;
        }
    }
}