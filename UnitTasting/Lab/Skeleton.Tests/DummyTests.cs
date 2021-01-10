using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShouldLoseHelthAfterAttack()
    {
        //Arange
        Axe axe = new Axe(1, 1);
        Dummy dummy = new Dummy(10, 10);

        //Act
        axe.Attack(dummy);

        //Assert
        Assert.AreEqual(9, dummy.Health);
    }

    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        //Arange
        Dummy dummy = new Dummy(0, 0);

       
        //Act Assert
        Assert.That(() => dummy.TakeAttack(2),
                Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }
}
