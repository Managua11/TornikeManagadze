namespace MathClass
{
    static class MathClass
    {
        public static T Pow<T>(T baseNumber, T exponent)
        {
            if (!typeof(T).IsPrimitive || typeof(T) == typeof(bool) || typeof(T) == typeof(char))
            {
                throw new InvalidOperationException("Pow is only supported for numeric types.");
            }


            double baseAsDouble = Convert.ToDouble(baseNumber);
            double exponentAsDouble = Convert.ToDouble(exponent);


            if (baseAsDouble < 0)
            {
                throw new ArgumentException("Base number must be greater than or equal to 0.");
            }

            if (exponentAsDouble < 0)
            {
                throw new ArgumentException("Exponent must be greater than or equal to 0.");
            }


            double result = Math.Pow(baseAsDouble, exponentAsDouble);

            return (T)Convert.ChangeType(result, typeof(T));
        }

    }
}