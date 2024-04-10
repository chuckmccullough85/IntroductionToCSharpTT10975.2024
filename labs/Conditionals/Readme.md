## Overview
In this lab, we generate a table of temperatures.

| | |
| --------- | --------------------------- |
| Exercise Folder | Conditionals |
| Builds On | For Loop |
| Time to complete | 10 minutes

- Certain temperatures are dangerous
- Notify the user by displaying a ^ to indicate that it is hot if the temperature is above 130F
- Display an * at the start of the line for temperatures below 20F

 --- 
 
 *If you need a hint - check it out:*
 ```C#
for (double F = -40; F <= 212; F+=2)
{
    double C = 5.0f / 9.0f * (F - 32);
    double K = C + 274.15;
    if (F <= 20) Console.Write('*');
    else if (F > 130) Console.Write('^');
    Console.WriteLine($"{F}\t{C}\t{K}");
}
 ```
 
 ### Want More?
 <iframe width="560" height="315" src="https://www.youtube.com/embed/KA7HA7b6a68?si=bIwsgzeJhzrB-low" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>
 
 [youtube.com](https://youtu.be/KA7HA7b6a68)