namespace ShapePrototypeSystem
{
    public class ContextMenu
    {
        public IComponent Duplicate(IComponent component)
        {
            return component.Clone();
        }
    }
}
