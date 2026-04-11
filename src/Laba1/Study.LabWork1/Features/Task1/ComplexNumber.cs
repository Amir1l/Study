using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Study.LabWork1.Features.Task1
{
    /// <summary>
    /// Класс, представляющий комплексное число
    /// </summary>
    public class ComplexNumber
    {
        /// <summary>
        /// Реальная часть (только для чтения)
        /// </summary>
        public double Real { get; }

        /// <summary>
        /// Воображаемая часть (только для чтения)
        /// </summary>
        public double Imagine { get; }

        /// <summary>
        /// Конструктор класса ComplexNumber
        /// </summary>
        /// <param name="real">Реальная часть</param>
        /// <param name="imagine">Воображаемая часть</param>
        public ComplexNumber(double real, double imagine)
        {
            Real = real;
            Imagine = imagine;
        }

        /// <summary>
        /// Сложение двух комплексных чисел
        /// </summary>
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imagine + b.Imagine);
        }

        /// <summary>
        /// Вычисление модуля комплексного числа
        /// </summary>
        public static double operator +(ComplexNumber a)
        {
            return Math.Sqrt(a.Real*a.Real+a.Imagine*a.Imagine);
        }

        /// <summary>
        /// Вычитание двух комплексных чисел
        /// </summary>
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imagine - b.Imagine );
        }

        /// <summary>
        /// Вычисление сопряженного комплексного числа
        /// </summary>
        public static ComplexNumber operator -(ComplexNumber a)
        {
            return new ComplexNumber(a.Real,-a.Imagine);
        }

        /// <summary>
        /// Умножение двух комплексных чисел
        /// </summary>
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real * b.Real - a.Imagine * b.Imagine, a.Imagine * b.Real + a.Real * b.Imagine);
        }

        /// <summary>
        /// Деление двух комплексных чисел
        /// </summary>
        /// <exception cref="ArgumentException">Появляется, если второе число равно нулю</exception>
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            if (b.Real == 0 && b.Imagine == 0)
                throw new ArgumentException("Знаменатель не может равняться 0!");
            ComplexNumber Numerator = a * (-b);
            ComplexNumber Denоminator = b * (-b);
            return new ComplexNumber(Numerator.Real/Denоminator.Real,Numerator.Imagine/Denоminator.Real);
        }

        /// <summary>
        /// Равенство двух комплексных чисел
        /// </summary>
        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return (a.Real == b.Real) && (a.Imagine == b.Imagine);
        }

        /// <summary>
        /// Неравенство двух комплексных чисел
        /// </summary>
        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Перегрузка метода ToString()
        /// </summary>
        /// <returns>Строковое представление комплексного числа</returns>
        public override string ToString()
        {
            if (Real == 0 && Imagine == 0)
                return "0";
            if (Real == 0)
                return $"{(Imagine < 0 ? '-' : '+')}{Math.Abs(Imagine)}i";
            else if (Imagine == 0)
                return $"{Math.Round(Real,2)}";
            return $"{Math.Round(Real,2)}{(Imagine<0?'-':'+')}{Math.Round(Math.Abs(Imagine),2)}i"; 
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            if (obj is ComplexNumber other)
                return this == other;

            return false;
        }
    }
}
