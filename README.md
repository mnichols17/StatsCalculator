# 421-StatsCalc

### Issue with Travis CL
Just like with the GroupCalculator, my project has errors regarding a missing package. My tests pass though so nothing is wrong with the code/tests.
![Passing Test](https://github.com/mnichols17/StatsCalculator/blob/master/tests.jpg)

* Calculator Object
   * Contains basic functions such as Addition, Subtraction, Multiplication, Division, Exponentiation and Radical -> Calls Radical static method from Math Operations
       * Each function has an interface and a function in MathOperations so that they are more re-usable

* Stats Calculator Object
   * Contains Simple Sampling, Systematic Sampling, Confidence Interval, Margin of Error, Cochran Formula, SampleSize, Mean
            Median, Mode, Variance, Standard Deviation, Quartiles, Skewness, Sample Correlation, Population Correlation, Z Score, Deviation and Random Number Generator - Calls the random number generator static method from Static Operations
       * Each function has an additional function in either StatOperations/PopulationOperations/RandomOperations. This is to make it re-usable
