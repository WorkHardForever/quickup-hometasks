/// <summary>
///  Single Responsibility Principle
/// </summary>

// Requare just one reason to change: all
// tasks should be devided to simple classes.
namespace QuickUp.HomeTasks.Day1.Solid.S
{
    #region Bad code

    // Let we have some class as phone
    class BadPhone
    {
        // Let your phone can CallVasya and RunGameChess and do something more
        public void Call() { }
        public void CallVasya() { }
        // ...
        public void RunGames() { }
        public void RunGameChess() { }
        // ...
        // Unfortunately, at the end we get big class-bin. We need refactor this code
    }

    #endregion

    #region Good code

    // Our phone can just call and run games, so...
    class GoodPhone
    {
        // Now we can use controllers
        public void Call()
        {
            var callController = new PhoneCallController("Vasya");
        }
        // ...
        public void RunGames() { }
    }

    class PhoneCallController
    {
        public PhoneCallController(string personName)
        {
            // Calling Vasya or someone else
            // who named as personName
        }
    }

    class PhoneRunGamesController
    {
        public PhoneRunGamesController(string gameName)
        {
            // Run game "Chess" or something else
            // what named as gameName
        }
    }

    #endregion
}
