using System;
using System.Collections.Generic;
using System.Text;
using Study.LabWork1.Features.Task1;

namespace Study.LabWork1.UnitTests.Features.Task1;

[TestFixture]
public sealed class ComplexNumberTests
{
    /// <summary>
    /// Тест на то, что сумма должна возвращать корректное значение
    /// </summary>
    [Test]
    public void Addition()
    {
        var a = new ComplexNumber(1, 3);
        var b = new ComplexNumber(2, -4);

        var result = a + b;

        Assert.That(result.Real, Is.EqualTo(3));
        Assert.That(result.Imagine, Is.EqualTo(-1));
    }

    /// <summary>
    /// Тест на то, что вычитание должно возвращать корректное значение
    /// </summary>
    [Test]
    public void Subtraction()
    {
        var a = new ComplexNumber(5, 3);
        var b = new ComplexNumber(2, 1);

        var result = a - b;

        Assert.That(result.Real, Is.EqualTo(3));
        Assert.That(result.Imagine, Is.EqualTo(2));
    }

    /// <summary>
    /// Тест на то, что умножение должно возвращать корректное значение
    /// </summary>
    [Test]
    public void Multiplication()
    {
        var a = new ComplexNumber(1, 2);
        var b = new ComplexNumber(3, 4);

        var result = a * b;

        Assert.That(result.Real, Is.EqualTo(-5));
        Assert.That(result.Imagine, Is.EqualTo(10));
    }

    /// <summary>
    /// Тест на то, что деление должно возвращать корректное значение
    /// </summary>
    [Test]
    public void Division_Result()
    {
        var a = new ComplexNumber(1, 2);
        var b = new ComplexNumber(3, 4);

        var result = a / b;

        Assert.That(result.Real, Is.EqualTo(0.44).Within(0.0001));
        Assert.That(result.Imagine, Is.EqualTo(0.08).Within(0.0001));
    }

    /// <summary>
    /// Тест на то, что при делении на ноль возвращаем исключение
    /// </summary>
    [Test]
    public void Division_Zero()
    {
        var a = new ComplexNumber(1, 2);
        var b = new ComplexNumber(0, 0);

        Assert.Throws<DivideByZeroException>(() => _ = a / b);
    }

    /// <summary>
    /// Тест на то, что унарный плюс должен возвращать модуль комплексного числа
    /// </summary>
    [Test]
    public void UnaryPlus()
    {
        var val = new ComplexNumber(3, 4);

        var mod = +val;

        Assert.That(mod, Is.EqualTo(5));
    }

    /// <summary>
    /// Тест на то, что унарный минус должен возвращать сопряженное комплексное число
    /// </summary>
    [Test]
    public void UnaryMinus()
    {
        var val = new ComplexNumber(3, -4);

        var result = -val;

        Assert.That(result.Real, Is.EqualTo(3));
        Assert.That(result.Imagine, Is.EqualTo(4));
    }

    /// <summary>
    /// Тест на то, что при равенстве значения действительно сравниваются
    /// </summary>
    [Test]
    public void Equality()
    {
        var a = new ComplexNumber(10, -2);
        var b = new ComplexNumber(10, -2);

        Assert.That(a == b, Is.True);
        Assert.That(a != b, Is.False);
        Assert.That(a.Equals(b), Is.True);
    }

    /// <summary>
    /// Тест на то, что ToString переводит комплексное число в строку
    /// </summary>
    [Test]
    public void ToString()
    {
        Assert.That(new ComplexNumber(1.01, 2).ToString(), Is.EqualTo("1.01 + 2i"));
        Assert.That(new ComplexNumber(3, 0).ToString(), Is.EqualTo("3"));
        Assert.That(new ComplexNumber(0, 4).ToString(), Is.EqualTo("4i"));
        Assert.That(new ComplexNumber(0, -4).ToString(), Is.EqualTo("-4i"));
        Assert.That(new ComplexNumber(0, 0).ToString(), Is.EqualTo("0"));
    }
}
