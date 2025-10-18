# LeetCode Solutions in C #

This repository contains C# solutions for LeetCode problems with comprehensive test coverage.

## Structure

Each problem is organized in its own folder named by the problem ID:

```
LetCode/
├── 83/                          # Problem folder (Problem ID)
│   ├── Solution.cs              # Solution implementation
│   └── 83.csproj               # Project file
├── 83.Tests/                    # Test folder
│   ├── SolutionTests.cs         # Unit tests
│   └── 83.Tests.csproj         # Test project file
└── LetCode.sln                  # Solution file
```

## Problems Solved

### 83. Remove Duplicates from Sorted List

- **Difficulty**: Easy
- **Link**: <https://leetcode.com/problems/remove-duplicates-from-sorted-list/>
- **Description**: Given the head of a sorted linked list, delete all duplicates such that each element appears only
  once.
- **Time Complexity**: O(n)
- **Space Complexity**: O(1)

## Running the Solution

### Prerequisites

- .NET 8.0 SDK or later

### Build the project

```bash
cd LetCode
dotnet build
```

### Run tests

```bash
dotnet test
```

### Run tests for a specific problem

```bash
dotnet test 83.Tests/83.Tests.csproj
```

### Run tests with detailed output

```bash
dotnet test --verbosity normal
```

## Adding New Problems

1. Create a new folder with the problem ID (e.g., `84`)
2. Add `Solution.cs` with the solution implementation
3. Add `{ProblemId}.csproj` project file
4. Create a corresponding test project `{ProblemId}.Tests`
5. Add the projects to the solution file
6. Update this README with the problem details

## Test Framework

This project uses **xUnit** for unit testing, which is a popular, modern testing framework for .NET applications.

## License

This project is for educational purposes.
