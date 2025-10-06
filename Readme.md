# Software Engineer Coding Interviews - DSA

This repository contains Data Structures and Algorithms practice problems and solutions for coding interviews, focusing on LeetCode problems implemented in C#.

## Repository Structure

```
Software-Engineer-Coding-Interviews-DSA/
├── LetCode/                     # LeetCode solutions
│   ├── 83/                      # Problem 83: Remove Duplicates from Sorted List
│   │   ├── Solution.cs
│   │   └── 83.csproj
│   ├── 83.Tests/                # Unit tests for Problem 83
│   │   ├── SolutionTests.cs
│   │   └── 83.Tests.csproj
│   ├── LetCode.sln              # Visual Studio solution file
│   └── README.md                # LeetCode-specific documentation
├── LICENSE
└── Readme.md                    # This file
```

## Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Visual Studio 2022, Visual Studio Code, or JetBrains Rider (optional)

### Building and Running

1. Clone the repository:
```bash
git clone https://github.com/yourusername/Software-Engineer-Coding-Interviews-DSA.git
cd Software-Engineer-Coding-Interviews-DSA
```

2. Navigate to the LeetCode folder:
```bash
cd LetCode
```

3. Build the solution:
```bash
dotnet build
```

4. Run all tests:
```bash
dotnet test
```

5. Run tests with detailed output:
```bash
dotnet test --verbosity normal
```

## Problems Solved

| # | Title | Difficulty | Solution | Tests |
|---|-------|------------|----------|-------|
| 83 | [Remove Duplicates from Sorted List](https://leetcode.com/problems/remove-duplicates-from-sorted-list/) | Easy | [Solution](LetCode/83/Solution.cs) | [Tests](LetCode/83.Tests/SolutionTests.cs) |

## Project Organization

Each LeetCode problem follows this structure:
- **Solution Folder**: Named with the problem ID (e.g., `83`)
- **Test Folder**: Named with the problem ID followed by `.Tests` (e.g., `83.Tests`)
- Each folder is a separate C# project
- All projects are part of a single solution file (`LetCode.sln`)

## Testing

This project uses **xUnit** as the testing framework. Each problem includes comprehensive test cases covering:
- Example cases from LeetCode
- Edge cases (empty input, single element, etc.)
- Corner cases (all duplicates, no duplicates, etc.)

## Contributing

Feel free to add more problems and solutions! Follow the existing structure:
1. Create a new folder with the problem ID
2. Implement the solution with proper documentation
3. Create comprehensive test cases
4. Update the problems table in this README

## License

This project is licensed under the terms specified in the LICENSE file.

## Resources

- [LeetCode](https://leetcode.com/)
- [.NET Documentation](https://docs.microsoft.com/dotnet/)
- [xUnit Documentation](https://xunit.net/)
