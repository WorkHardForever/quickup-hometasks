/// <summary>
/// Dependency Inversion Principle
/// </summary>

// 1) Classes are not responsible for creating dependencies
// 2) Abstractions should not depend upon details
namespace QuickUp.HomeTasks.Day1.Solid.D
{
    #region Bad code
    
    class BadSimpleClass
    {
        public void DoSomethingImportant() { }
        // ...
        // A lot of main information
        // which we don't want to give everything
    }

    class BadVeryFragileClass
    {
        public void GetClassWithImportantInfo(BadSimpleClass simpleClass)
        {
            simpleClass.DoSomethingImportant();

            // if next time we change logic in 
            // this method then can brake program.
            // It's can be difficult error for big project
        }
    }

    #endregion

    #region Good code

    // Best idea is creating interface,
    // that create weak link
    public interface IGoodSimpleClass
    {
        void DoSomethingImportant();
    }

    class GoodSimpleClass : IGoodSimpleClass
    {
        public void DoSomethingImportant() { }
        // ...
    }

    class GoodVeryFragileClass
    {
        public void GetClassWithImportantInfo(IGoodSimpleClass simpleClass)
        {
            simpleClass.DoSomethingImportant();

            // call this by
            //
            // GoodVeryFragileClass veryFragileClass = new GoodVeryFragileClass();
            // GoodSimpleClass simpleClass = new GoodSimpleClass();
            // veryFragileClass.GetClassWithImportantInfo(simpleClass);
            //
        }
    }

    // After this manipulations you can
    // change logic in simpleClass, but debug
    // and after making test-unit find error faster

    #endregion
}
