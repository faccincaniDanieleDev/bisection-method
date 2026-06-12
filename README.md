# 📐 Bisection Method

Implementation of the Bisection Method for finding roots of a function, written in C++, C# and Python.

---

## What is the Bisection Method?

The Bisection Method is a numerical algorithm used to approximate the root of a function f(x) in a given interval [a, b]. It works by repeatedly halving the interval and selecting the subinterval where the sign change occurs, until the desired tolerance is reached.

**Function used:** `f(x) = x³ - x + 1`

---

## Features

- Input validation: rejects non-numeric values
- Automatic swap if b < a
- Hypothesis check based on Bolzano's theorem
- Tolerance: 0.01
- Result formatted to 5 decimal places

---

## Project Structure
bisection-method/

│

├── cpp/

│   └── bisection-method.cpp

│

├── csharp/

│   ├── bisection-method-c-sharp.csproj

│   └── Program.cs

│

├── python/

│   └── bisection-method.py

│

├── README.md

├── .gitignore

└── LICENSE

---

## Requirements

- **C++**: g++ compiler
- **C#**: .NET SDK 6.0 or higher
- **Python**: Python 3.10 or higher

---

## How to Run

### C++
g++ bisection-method.cpp -o bisection-method

./bisection-method

### C#
cd csharp

dotnet run

### Python
cd python

python bisection-method.py

---

## Test Values

| Input | Result |
|---|---|
| a = -2, b = 0 | -1.32812 |

---

## What I Learned

- How to implement the Bisection Method across three different languages
- Differences in syntax, type system and input handling between C++, C# and Python
- How Bolzano's theorem guarantees the existence of a root in an interval

---

## License

MIT License — see [LICENSE](LICENSE) for details.
