using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Xml.Schema;
using NUnit.Framework;

public class QueenAttackTest
{
    [Test]
    public void Cannot_occupy_same_space()
    {
        var white = new Queen(2, 4);
        var black = new Queen(2, 4);
        Assert.Throws<ArgumentException>(() => new Queens(white, black));
    }

    [Test]
    public void Cannot_attack()
    {
        var queens = new Queens(new Queen(2, 3), new Queen(4, 7));
        Assert.False(queens.CanAttack());
    }

    [Test]
    public void Can_attack_on_same_row()
    {
        var queens = new Queens(new Queen(2, 4), new Queen(2, 7));
        Assert.True(queens.CanAttack());
    }

    [Test]
    public void Can_attack_on_same_column()
    {
        var queens = new Queens(new Queen(5, 4), new Queen(2, 4));
        Assert.True(queens.CanAttack());
    }

    [Test]
    public void Can_attack_on_diagonal()
    {
        var queens = new Queens(new Queen(1, 1), new Queen(6, 6));
        Assert.True(queens.CanAttack());
    }

    [Test]
    public void Can_attack_on_other_diagonal()
    {
        var queens = new Queens(new Queen(0, 6), new Queen(1, 7));
        Assert.True(queens.CanAttack());
    }

    [Test]
    public void Can_attack_on_yet_another_diagonal()
    {
        var queens = new Queens(new Queen(4, 1), new Queen(6, 3));
        Assert.True(queens.CanAttack());
    }

    [Test]
    public void Can_attack_on_a_diagonal_slanted_the_other_way()
    {
        var queens = new Queens(new Queen(6, 1), new Queen(1, 6));
        Assert.True(queens.CanAttack());
    }
}

public class Queens
{
    private readonly Queen white;
    private readonly Queen black;

    public Queens(Queen white, Queen black)
    {
        this.white = white;
        this.black = black;
    }

    public bool CanAttack()
    {
        var wQueen = new[] {white.X, white.Y};
        var bQueen = new[] {black.X, black.Y};

        var o = wQueen.Zip(bQueen, (i1, i2) => new Tuple<int, int>(i1, i2)).Select(x => Math.Abs(x.Item1 - x.Item2)).ToList();

        return o.All(x => x == o.First()) || o.Any(x => x == 0);
    }
}

public class Queen
{
    public int X { get; }
    public int Y { get; }

    public Queen(int x, int y)
    {
        X = x;
        Y = y;
    }
}