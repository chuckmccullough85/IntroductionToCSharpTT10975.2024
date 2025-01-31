﻿
public class Employee
{
    private const float TAX_RATE = .0765f;
    private string _name = string.Empty;
    private uint _id;
    private float _salary;
    private float _ytdSalary;
    private float _ytdTax;

    public Employee(string name, uint id, float salary)
    : this(name, id, salary, DateTime.MinValue)
    {
    }

    public Employee(string name, uint id, float salary, DateTime dateOfBirth)
    {
        Name = name;
        Id = id;
        Salary = salary;
        _ytdSalary = 0;
        _ytdTax = 0;
        DateOfBirth = dateOfBirth;
    }

    public string Name
    {
        get => _name;
        set
        {
            if (!string.IsNullOrEmpty(value))
                _name = value;
        }
    }
    public uint Id
    {
        get => _id;
        private set => _id = value;
    }
    public float Salary
    {
        get => _salary;
        set
        {
            if (value < 50 || value > 1000)
                throw new ArgumentException("Salary must be between 50 and 1000");
            _salary = value;
        }
    }
    public float YtdSalary
    {
        get => _ytdSalary;
    }
    public float YtdTax
    {
        get => return _ytdTax;
    }

    public DateTime? DateOfBirth { get; set; }

    public float Pay()
{
    var tax = _salary * TAX_RATE;
    _ytdTax += tax;
    _ytdSalary += _salary;
    return _salary - tax;
}
}

