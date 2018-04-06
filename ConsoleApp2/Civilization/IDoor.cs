namespace Civilization
{
    public interface IDoor
    {
        Doortype TypeOfDoor { get; set; }
    }

    public enum Doortype
    {
        FrenchDouble=1,
        Single=2,
        Sliding=3,
        Double=4
    }
}