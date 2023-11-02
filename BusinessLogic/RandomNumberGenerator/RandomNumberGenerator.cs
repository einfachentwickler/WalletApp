using System.Diagnostics.CodeAnalysis;

namespace BusinessLogic.RandomNumberGenerator;

public class RandomNumberGenerator : IBalanceGenerator
{
    public double Balance => new Random().NextDouble() * 1500;
}