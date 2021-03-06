﻿using NUnit.Framework;

[TestFixture]
public class GrainsTest
{
    [Test]
    public void Test_square_1()
    {
        Assert.That(Grains.Square(1), Is.EqualTo(1));
    }

    [Test]
    public void Test_square_2()
    {
        Assert.That(Grains.Square(2), Is.EqualTo(2));
    }

    [Test]
    public void Test_square_3()
    {
        Assert.That(Grains.Square(3), Is.EqualTo(4));
    }

    [Test]
    public void Test_square_4()
    {
        Assert.That(Grains.Square(4), Is.EqualTo(8));
    }

    [Test]
    public void Test_square_16()
    {
        Assert.That(Grains.Square(16), Is.EqualTo(32768));
    }

    [Test]
    public void Test_square_32()
    {
        Assert.That(Grains.Square(32), Is.EqualTo(2147483648));
    }

    [Test]
    public void Test_square_64()
    {
        Assert.That(Grains.Square(64), Is.EqualTo(9223372036854775808));
    }

    [Test]
    public void Test_total_grains()
    {
        Assert.That(Grains.Total(), Is.EqualTo(18446744073709551615));
    }
}