## Overview
In this lab, we will extend the *Temperature* lab by adding an enumeration to represent the various temp scales

| | |
| --------- | --------------------------- |
| Exercise Folder | Enum |
| Builds On | Struct |
| Time to complete | 15 minutes

---

### Steps
1. In *Temperature.cs* before **struct Temperature** define an enum named *TemperatureScale* with 3 values, *CELSIUS*, *FAHRENHEIT*, and *KELVIN*
2. Add another parameter to the *Temperature* constructor so that the scale can be passed.  Make the default value CELSIUS so that we don't break existing code
3. Modify *Program.cs*  so that the various temperature objects can be created with different scales via the constructor

:::spoiler

*Temperature.cs*
```c#

public enum TemperatureScale { Celsius, Fahrenheit, Kelvin }

public struct Temperature
{
    double celsius;

    public Temperature(double value, TemperatureScale scale = TemperatureScale.Celsius)
    {
        switch (scale)
        {
            case TemperatureScale.Celsius:
                celsius = value;
                break;
            case TemperatureScale.Fahrenheit:
                Fahrenheit = value;
                break;
            case TemperatureScale.Kelvin:
                Kelvin = value;
                break;
        }
    }
    public double Celsius
    {
        get { return celsius; }
        set { celsius = value; }
    }
    public double Fahrenheit
    {
        get { return celsius * 9 / 5 + 32; }
        set { celsius = 5.0f / 9.0f * (value - 32); }
    }
    public double Kelvin
    {
        get { return Celsius + 274.15; }
        set { Celsius = value - 274.15; }
    }

    public string Format()
    {
        return $"{Fahrenheit}F is {Celsius}C which is {Kelvin}K";
    }
}
```

*Program.cs*
```c#
Temperature freezing = new Temperature(32, TemperatureScale.Fahrenheit);
Temperature boiling = new Temperature(100);

Console.WriteLine(boiling.Fahrenheit);

Temperature room = new Temperature(75, TemperatureScale.Fahrenheit);
Temperature absoluteZero = new Temperature(0, TemperatureScale.Kelvin);

Console.WriteLine(freezing.Format());
Console.WriteLine(boiling.Format());
Console.WriteLine(room.Format());
Console.WriteLine(absoluteZero.Format());
```
