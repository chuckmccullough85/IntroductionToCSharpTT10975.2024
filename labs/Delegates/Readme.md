## Overview
This lab demonstrates delegates.  We will add a callback to the *Organization* pay loop.

| | |
| --------- | --------------------------- |
| Exercise Folder | Delegates |
| Builds On | Interfaces |
| Time to complete | 20 minutes

---
## Instructions

1. Add an auto property to *Organization* as shown below:
```c#
public Action<Payable>? PayProcessor { get; set; }
```
2. In *Pay*, if the property isn't null, call the pay processor
3. In *Main* (or top-level statements)  set a processor before calling pay 

:::spoiler

*In Organization*
```c#
        public Action<Payable>? PayProcessor { get; set; }

        public float Pay()
        {
            float total = 0;
            foreach (var r in Resources)
            {
                total += r.Pay();
                PayProcessor?.Invoke(r);
            }
            return total;
        }
```

*Test Code*
```c#
acme.PayProcessor = ProcessPay;
acme.Pay();


void ProcessPay(Payable payable)
{
    Console.WriteLine($"Paying {payable.ToString()} ");
}
```