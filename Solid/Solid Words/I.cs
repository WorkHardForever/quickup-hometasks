/// <summary>
/// Interface Segregation Principle
/// </summary>

// Interfaces that have become “fat” should
// be split into several interfaces
namespace QuickUp.HomeTasks.Day1.Solid.I
{
    #region Bad code

    // Let we have fat interface
    public interface IPerson
    {
        void Think();
        void Move();
        // ...
        void Sleep();
    }

    // It's not good idea, because some old men
    // suffers from insomnia insomniac or can't
    // move without help. It's bad :(

    #endregion

    #region Good code

    // Let's make simple interfaces
    public interface IThink
    {
        void Think();
    }

    public interface IMove
    {
        void Move();
    }

    public interface ISleep
    {
        void Sleep();
    }

    #endregion
}
