using Calculator;

namespace TestCalculator;

public class TestUnitCalc
{
    [Fact]
    public void TestsTheSumOf1And2AndExpects3()
    {
        // arrange
        int val1 = 1;
        int val2 = 2;
        Calc calc = new Calc();

        // action
        double result = calc.Sum(val1, val2);

        // assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void TestsDecreases1Of2AndExpects1()
    {
        // arrange
        int val1 = 2;
        int val2 = 1;
        Calc calc = new Calc();

        // action
        double result = calc.deduct(val1, val2);

        // assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void TestsMultiply4By2AndExpects8()
    {
        // arrange
        int val1 = 4;
        int val2 = 2;
        Calc calc = new Calc();

        // action
        double result = calc.multiply(val1, val2);

        // assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void TestsDivide4By2AndExpects2()
    {
        // arrange
        int val1 = 4;
        int val2 = 2;
        Calc calc = new Calc();

        // action
        double result = calc.divide(val1, val2);

        // assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void TestsDivide4ByZeroAndExpectsThrow()
    {
        // arrange
        int val1 = 4;
        int val2 = 0;
        Calc calc = new Calc();

        // action and assert
        Assert.Throws<DivideByZeroException>(() => calc.divide(val1, val2));
    }

    [Fact]
    public void TestsreturnsTheLastThreeHistories()
    {
        // arrange
        Calc calc = new Calc();

        // action
        calc.Sum(1, 2);
        calc.Sum(1, 3);
        calc.divide(4, 2);
        int total = calc.historic().Count;

        // assert
        Assert.Equal(3, total);
    }
}