using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    public void WeaponShouldLoseDurabilityAfterAttack()
    {
        //Arange
        Axe axe = new Axe(100, 100);
        Dummy dummy = new Dummy(50, 40);

        //Act
        axe.Attack(dummy);

        //Assert
        Assert.AreEqual(99, axe.DurabilityPoints);
    }

    [Test]
    public void AttackWithBrokenWeaponShouldThrowInvalidOperationException()
    {
        //Arange
        Axe axe = new Axe(1, 1);
        Dummy dummy = new Dummy(10, 10);
        
        //Act
        axe.Attack(dummy);
        
        //Assert
        Assert.That(() => 
        axe.Attack(dummy), 
        Throws.InvalidOperationException.
        With.Message.EqualTo("Axe is broken."));
    }
}