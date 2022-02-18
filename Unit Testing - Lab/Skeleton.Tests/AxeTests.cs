namespace Skeleton.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLoosesDurabilityAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack.");
        }

        [Test]

        public void BrokenAxeCantAttack()

        {
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            try
            {
                Assert.That(() => axe.Attack(dummy),
                    Throws.InvalidOperationException
                    .With.Message.EqualTo("Axe is broken."));

            }
            catch
            {
                Console.WriteLine("BrokenAxeDoesn't throw exeption if used for attack");
            }

        }
    }
}