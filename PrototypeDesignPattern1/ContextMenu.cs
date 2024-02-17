namespace PrototypeDesignPattern1
{
    internal class ContextMenu
    {
        public IComponent Duplicate(IComponent component)
        {
            return component.Clone();
        }
    }
}
