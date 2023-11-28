namespace TriangleLib
{
    public enum TriangleType
    {
        Acute = 0,
        Right,
        Obtuse
    }

    public class TriangleResolver
    {
        private static bool Equals(double value1, double value2)
        {
            return Math.Abs(value1 - value2) < 0.000001;
        }

        public TriangleType ResolveTriangleType(double side1, double side2, double side3)
        {
            var pow1 = Math.Pow(side1, 2);
            var pow2 = Math.Pow(side2, 2);
            var pow3 = Math.Pow(side3, 2);

            if (Equals(pow1, pow2 + pow3) || Equals(pow2, pow1 + pow3) || Equals(pow3, pow1 + pow2)) // По теореме Пифагора в Прямоугольном треугольнике квадрат гипотенузы равен сумме квадратов катетов
                return TriangleType.Right;

            if (pow1 > pow2 + pow3 || pow2 > pow1 + pow3 || pow3 > pow1 + pow2) // Если квадрат гипотенузы больше суммы квадратов других сторон, противолежащий угол имеет более 90 градусов, т.е. треугольник Тупоугольный
                return TriangleType.Obtuse;

            return TriangleType.Acute; // Иначе треугольник Остроугольный
        }
    }
}
