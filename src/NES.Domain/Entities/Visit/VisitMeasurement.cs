namespace NES.Domain.Entities.Visit;

public class VisitMeasurement
{
    public decimal? Weight { get; private set; }

    public decimal? Height { get; private set; }

    public decimal? BMI { get; private set; }


    private VisitMeasurement()
    {
    }


    public VisitMeasurement(
        decimal? weight,
        decimal? height,
        decimal? bmi)
    {
        Weight = weight;
        Height = height;
        BMI = bmi;
    }


    public void Update(
        decimal? weight,
        decimal? height,
        decimal? bmi)
    {
        Weight = weight;
        Height = height;
        BMI = bmi;
    }
}