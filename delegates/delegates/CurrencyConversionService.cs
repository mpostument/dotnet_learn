namespace delegates;

public delegate float CurrencyConverter(float amount, float rate);

public class CurrencyConversionService
{
    public float Convert(float amount, float rate, CurrencyConverter converter)
    {
        return converter(amount, rate);
    }
}