# RecursionExample
Mentoring example used to demonstrate the fundamentals of recursion and application to real world scenarios.


## FibonacciSequence

This class provides methods to calculate and print Fibonacci sequences.

### Methods

#### `RunFibonacciSequence()`

This method will print the first 10 numbers of the Fibonacci sequence using the `FibonacciRecursive` method.

#### `FibonacciRecursive(int n)`

This is a recursive method to compute the nth Fibonacci number. It returns n for n <= 1 and computes the Fibonacci number recursively for values of n greater than 1.

## NQueensSolution

This class provides methods to solve the N Queens problem, which involves placing N chess queens on an NxN chessboard such that no two queens threaten each other.

The SolveNQueens method uses recursion and backtracking to solve the N-Queens puzzle. For each column, it tries placing a queen in every possible row. If the placement seems valid (doesn't threaten any other queen), it moves forward to the next column. If a dead-end is reached (i.e., no safe row is found in a column), it backtracks, altering previous placements, and continues the search. The process continues until a solution is found or all configurations are tried.

### Overview

* The program begins by trying to place a queen in a specific column of the board. Initially, the column is set to 0, indicating the very first column.

* If a queen has been placed successfully in every column (i.e., the column number is equal to N), then a solution to the puzzle has been found, and the method returns true.

* For the current column, the method tries placing a queen in each row. For each row, before placing the queen, it checks whether it's safe to do so using the IsSafe method. The method ensures that the placement doesn't conflict with any previously placed queens.

* If the queen's placement in the current row and column is safe, the method places the queen there (by setting the cell value to 1) and then makes a recursive call to attempt placing a queen in the next column. This is analogous to saying, "Now that I've safely placed a queen in this column, let's try to place queens in the remaining columns."

* If placing a queen in a specific row and column doesn't lead to a solution (i.e., the recursive call returns false), then that choice is undone by setting the cell value back to 0. This is the core of backtracking. After undoing the choice, the next row in the current column is tried.

* If all rows in the current column have been tried and none of them lead to a solution, the method returns false, signaling that with the current configuration, a solution is not possible and prompting backtracking in the previous column(s). If queens are successfully placed in all columns, the method returns true, indicating a solution has been found.

### Methods

#### `RunNQueensSolution()`

This method initializes an 8x8 chessboard and attempts to find a solution to the N Queens problem. If a solution is found, it prints the chessboard with queens placed in valid positions.

#### `SolveNQueens(int[,] board, int col, int n)`

This recursive method attempts to place queens on the chessboard in valid positions. It returns true if a solution has been found and false otherwise.

* board: The current configuration of the chessboard.
* col: The current column being considered.
* n: The size of the board (and number of queens).

#### `IsSafe(int[,] board, int row, int col, int n)`

This method determines if it's safe to place a queen on the given row and column of the chessboard. It checks the current row, upper diagonal, and lower diagonal to ensure no other queens can attack the position.

* board: The current configuration of the chessboard.
* row: The row to check.
* col: The column to check.
* n: The size of the board.

#### `PrintSolution(int[,] board, int n)`

This method prints the current configuration of the chessboard, using Q to represent queens and . for empty spaces.

* board: The configuration of the chessboard.
* n: The size of the board.

## PlantGrowthModel

This class provides methods to simulate the growth of a plant over a given number of days.

### Methods

#### `RunPlantGrowthModel()`

This method initializes the plant's initial height to 1 inch and sets the simulation to run over 10 days. It then calls the `SimulatePlantGrowth` method to display the height of the plant on each day.

#### `SimulatePlantGrowth(int currentHeight, int currentDay, int totalDays)`

A recursive method simulating the daily growth of the plant. It prints the plant's height for each day, assuming a consistent growth of 2 inches per day. The simulation ends when the currentDay exceeds the totalDays.

* currentHeight: The plant's height at the beginning of the current day.
* currentDay: The current simulation day.
* totalDays: The total number of simulation days.

## PopulationModel

The PopulationModel class provides methods to model the growth of a population over a specified number of years, taking into consideration a given growth rate.

### Methods

#### `RunPopulationModel()`

This method sets the initial conditions and begins the population growth simulation:

* Sets the initial population to 1000.
* Specifies a growth rate of 5% or 0.05.
* Models the population growth over 10 years.
* For each year, it calculates and displays the population using the CalculatePopulation method.

#### `CalculatePopulation(double initialPopulation, double growthRate, int years)`

A recursive method that calculates the population after a certain number of years given an initial population and growth rate.

* initialPopulation: The starting population.
* growthRate: The rate at which the population grows each year (as a decimal, e.g., 0.05 for 5%).
* years: The number of years over which the population growth should be calculated.
* Returns: The calculated population after the specified number of years.

#### Note: The method uses the previous year's population to calculate the current year's population. When the number of years is 0, the initial population is returned.

## SudokuSolution

The SudokuSolution class provides methods to solve a given Sudoku puzzle using the backtracking algorithm.

The SolveSudoku method uses recursion and backtracking to solve the Sudoku puzzle. At each empty cell, it tries different numbers, checking if each one fits with the current puzzle configuration. If a number seems to fit, it moves forward (dives deeper into recursion) to solve the next cells. If it hits a dead-end where no numbers fit, it backtracks, changing previous choices, and continues the search until a solution is found or all possibilities are exhausted.

### Overview

* The method begins by looking for an empty cell in the Sudoku grid using the FindEmptyCell method. If there's no empty cell, it means the Sudoku is solved, and the method returns true.

* Once an empty cell is found, the method tries to fill it with a number. The possible numbers are between 1 to 9 (inclusive), which are the allowed numbers in a Sudoku puzzle.

* For each number (from 1 to 9), before placing it in the empty cell, it checks whether it's safe to place that number there using the IsSafe method. The number should not already exist in the same row, column, or the 3x3 box of the cell. If it's safe, the number is temporarily placed in the empty cell.

* With that number in the cell, the method calls itself recursively, attempting to solve the rest of the grid. This is like saying, "Okay, I've made a choice for this cell; now let's try to solve the rest."

* If placing a number in a cell does not lead to a solution (i.e., the recursive call returns false), that choice is undone (the cell is set back to empty, or 0), and the next number is tried. This is the essence of backtracking. The process continues until a valid number is found for the cell, or all numbers have been tried without success.

* If after trying all numbers for the current cell, no solution is found, the method returns false, signaling that a solution could not be found with the current set of choices. On the other hand, if the rest of the grid gets successfully filled (i.e., there are no more empty cells), the method returns true, signaling a successful solution.

### Methods

#### `RunSudokuSolution()`

This method initializes a Sudoku puzzle and attempts to solve it:

* Sets up a Sudoku grid.
* Displays the initial Sudoku puzzle using the PrintSudoku method.
* Calls the SolveSudoku method to solve the puzzle.
* Displays the solved Sudoku puzzle if a solution exists; otherwise, informs the user that no solution exists.

#### `SolveSudoku(int[,] grid)`

A recursive method that attempts to solve a given Sudoku grid. It tries numbers from 1 to 9 in each cell and uses backtracking if a number doesn't lead to a solution.

* grid: The Sudoku puzzle to solve.
* Returns: true if a solution exists, false otherwise.

#### `FindEmptyCell(int[,] grid, out int row, out int col)`

Searches the Sudoku grid for an empty cell (represented by 0).

* grid: The Sudoku grid to search.
* row and col: The coordinates of the empty cell (if one exists).
* Returns: true if an empty cell is found, false otherwise.

#### `IsSafe(int[,] grid, int row, int col, int num)`

Checks if it's safe to place a specific number in a given cell.

* grid: The Sudoku grid.
* row and col: The coordinates of the cell.
* num: The number to check.
* Returns: true if it's safe to place the number, false otherwise.

#### `UsedInRow(int[,] grid, int row, int num)`
#### `UsedInColumn(int[,] grid, int col, int num)`
#### `UsedInBox(int[,] grid, int boxStartRow, int boxStartCol, int num)`

These methods check if a number is used in the specified row, column, or 3x3 box respectively.

* Returns: true if the number is used, false otherwise.

#### `PrintSudoku(int[,] grid)`

Displays the Sudoku grid on the console.

* grid: The Sudoku grid to display.

## TowersOfHanoiSolution

This class provides methods to solve the Towers of Hanoi puzzle.

The Tower of Hanoi is a mathematical puzzle that consists of three rods and a number of disks of different sizes. The puzzle starts with the disks in a neat stack in ascending order of size on one rod, the smallest at the top, thus making a conical shape.

### Methods

#### `RunTowersOfHanoiSolution()`

This method initializes the Tower of Hanoi puzzle with a default number of 3 disks. It then calls the SolveHanoi method to initiate the recursive solution.

#### `SolveHanoi(int n, char source, char destination, char auxiliary)`

This is a recursive method to solve the Tower of Hanoi puzzle for n disks.

* int n: The number of disks to be moved.
* char source: The rod from which disks are to be moved.
* char destination: The rod to which disks are to be moved.
* char auxiliary: The auxiliary rod used as an intermediate in the process.
* Console output: The method prints out each move of the disk from one rod to another.
