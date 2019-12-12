using NUnit.Framework;

[TestFixture]
public class HikerTest
{
    [Test]
    public void Roman_1_isI()
    {
        Assert.AreEqual("I", Hiker.getRoman(1));
    }

    [Test]
    public void Roman_2_isII()
    {
        Assert.AreEqual("II", Hiker.getRoman(2));
    }

    [Test]
    public void Roman_3_isIII()
    {
        Assert.AreEqual("III", Hiker.getRoman(3));
    }

    [Test]
    public void Roman_4_isIV()
    {
        Assert.AreEqual("IV", Hiker.getRoman(4));
    }

    [Test]
    public void Roman_12_isXII()
    {
        Assert.AreEqual("XII", Hiker.getRoman(12));
    }
}
