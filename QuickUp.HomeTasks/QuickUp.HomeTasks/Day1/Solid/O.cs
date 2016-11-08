/// <summary>
/// Open/Closed principle
/// </summary>

// Base class should be open for extensions
// but closed for modifications
namespace QuickUp.HomeTasks.Day1.Solid.O
{
    #region Bad code

    // Let we create rpg-game with some classes
    abstract class BadPerson
    {
        // And let we create some methods,
        // which we well use in child-classes
        abstract public void Heal();
        abstract public void Strike();
        // ...
        abstract public void Movement();
    }

    class BadDoctor : BadPerson
    {
        public override void Heal()
        {
            // Healing in game other players
        }

        public override void Strike()
        {
            // OOPS! Our Doctor can just heal, but can't strike!
        }

        public override void Movement() { }
    }

    class BadKiller : BadPerson
    {
        public override void Heal()
        {
            // AAA! He can't heal, he kill everybody!!!
        }

        public override void Strike()
        {
            // Of course, it person can strike,
            // but looking at this code, have you
            // seen anything strange?
        }

        public override void Movement() { }
    }

    #endregion

    #region Good code

    // We can use our Base-class, but some methods
    // need put to interfaces
    abstract class GoodPerson
    {
        // ...
        abstract public void Movement();
    }

    public interface IHealable
    {
        void Heal();
    }

    public interface IStrikeable
    {
        void Strike();
    }

    // multi-inheritance
    class GoodDoctor : GoodPerson, IHealable
    {
        public void Heal() { }

        public override void Movement() { }
    }

    class GoodKiller : GoodPerson, IStrikeable
    {
        public void Strike() { }

        public override void Movement() { }
    }

    #endregion
}
