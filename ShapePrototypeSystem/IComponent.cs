namespace ShapePrototypeSystem
{
    public interface IComponent
    {
        IComponent Clone();
        void Render();
    }
}
