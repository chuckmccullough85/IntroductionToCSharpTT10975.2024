## Overview
Quick sample of streams.

| | |
| --------- | --------------------------- |
| Exercise Folder | Streams |
| Builds On | None |
| Time to complete | 20 minutes

---
## Instructions
---

1. Create a new console application in your solution named *Streams*
1. In top-level code, open an input stream, **StreamReader** on a plain text file you have on your system (could even be Program.cs)
1. Open a **StreamWriter** on an output file
    - use a full path for both files

1. Loop through the input file, line by line
1. Convert line to upper case and write to the output file

Utilize **using** to make sure both files get closed!

---

:::spoiler
```C#
using StreamReader input = new StreamReader("""
input file path here
""");

using StreamWriter output = new StreamWriter(@"output file here");

string? line = "";
while ((line = input.ReadLine()) != null)
{
    output.WriteLine(line.ToUpper());
}

```
:::