namespace Example.Service.ComponentTest
{
    using Xbehave;

    public class Calculator
    {
        public int Add(int x, int y) => x + y;
    }

    public class CalculatorFeature
    {
        [Scenario]
        public void Addition(int x, int y, Calculator calculator, int answer)
        {
            "Given the number 1"
                .x(() => x = 1);

            "And the number 2"
                .x(() => y = 2);

            "And a calculator"
                .x(() => calculator = new Calculator());

            "When I add the numbers together"
                .x(() => answer = calculator.Add(x, y));

            "Then the answer is 3"
                .x(() => Xunit.Assert.Equal(4, answer));
        }
    }
}