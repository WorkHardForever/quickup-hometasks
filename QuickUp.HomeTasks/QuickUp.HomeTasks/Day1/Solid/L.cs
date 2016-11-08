/// <summary>
/// Liskov’s Substitution Principle
/// </summary>

// Any method that takes class X as a parameter
// must be able to work with any subclasses of X
namespace QuickUp.HomeTasks.Day1.Solid.L
{
    #region Bad code

    // All people can't fly
    abstract class BadPerson
    {
        // When we write move, we think that
        // human will moving by feet
        abstract public void Move();
        // ...
    }

    class BadSchoolboy : BadPerson
    {
        public override void Move()
        {
            // I use feet and movement in the floor!
        }
    }

    // ...

    class BadSuperman : BadPerson
    {
        public override void Move()
        {
            // I can move by my ability
            // and use this method for flying
            // or just move by feet
        }
    }

    /* At the end, when we try to use 
     * BadPerson badPerson = new BadSuperman();   <-- can lose supermen's ability to fly
     */

    #endregion

    #region Good code

    // If we know, that we well use superman, so let
    // create interface than abstract class (create contract)
    public interface IGoodPerson
    {
        void Move();
        // ...
    }

    public interface IFlyablePerson
    {
        void FlyingMove();
    }

    class GoodSchoolboy : IGoodPerson
    {
        public void Move() { }
    }

    // ...

    class GoodSuperman : IGoodPerson, IFlyablePerson
    {
        public void Move() { }

        public void FlyingMove()
        {
            // Hey! I can fly if i will 
            // be called by IGoodPerson
        }
    }

    #endregion
}
