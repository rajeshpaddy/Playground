namespace Civilization
{
    public interface IWindow
    {
        WindowType TypeOfWindow { get; set; }
    }

    public enum WindowType
    {
        Sliding=1,
        VerticalPull=2,
        OutsidePush=3,
        InsidePull=4,
        FixedClosed=5
    }
}