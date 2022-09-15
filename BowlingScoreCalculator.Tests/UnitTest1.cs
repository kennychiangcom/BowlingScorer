using Microsoft.VisualBasic;
using System;
using NUnit.Framework;
using FluentAssertions;

namespace BowlingScoreCalculator.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // (When scoring “X” indicates a strike, “/” indicates a spare, “-” indicates a miss)

        // X X X X X X X X X X X X(12 rolls: 12 strikes) = 10 frames * 30 points = 300
        BowlingScoreCalculator.ScoreCalc("X X X X X X X X X X X X").Should().Be(300);
    }
    [Test]
    public void Test2()
    {
        // 9 - 9 - 9 - 9 - 9 - 9 - 9 - 9 - 9 - 9 - (20 rolls: 10 pairs of 9 and miss) = 10 frames * 9 points = 90
        BowlingScoreCalculator.ScoreCalc("9 - 9 - 9 - 9 - 9 - 9 - 9 - 9 - 9 - 9 -").Should().Be(300);
    }
    [Test]
    public void Test3()
    {
        // 5 / 5 / 5 / 5 / 5 / 5 / 5 / 5 / 5 / 5 / 5(21 rolls: 10 pairs of 5 and spare, with a final 5) = 10 frames * 15 points = 150
        BowlingScoreCalculator.ScoreCalc("5 / 5 / 5 / 5 / 5 / 5 / 5 / 5 / 5 / 5 / 5").Should().Be(300);
    }
}