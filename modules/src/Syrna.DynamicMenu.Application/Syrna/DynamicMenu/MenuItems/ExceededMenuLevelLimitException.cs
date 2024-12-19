using Volo.Abp;

namespace Syrna.DynamicMenu.MenuItems
{
    public sealed class ExceededMenuLevelLimitException : BusinessException
    {
        public ExceededMenuLevelLimitException(int maxLevel)
            : base("Syrna.DynamicMenu:ExceededMenuLevelLimit")
        {
            Data["MaxLevel"] = maxLevel;
        }
    }
}