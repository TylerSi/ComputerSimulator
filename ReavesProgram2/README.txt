This computer simulator was created October 2014 by Tyler Reaves
using Visual Studio Ultimate 2013 on Windows 8.1.

*When commenting programs, be sure to leave a space between the operand and comment
Example:
	READ 10 //comment here
	LOAD 10 //comment here
	STOR 10 //comment here
	HALT //comment here

*Be sure to place HALT to end execution.

To run application standalone:
	ReavesProgram2 -> bin -> Release -> ReavesProgram2.exe

To run in Visual Studio 2013:
	Open ReavesProgram2.sln
	Press F5 or start

When application is running:
	Open:
		File -> Open
	Create New:
		Type program in Program Contents
		File -> Save As...
When ready to run program:
	Make sure instructions are in Program Contents
	Press Load
	Press step to go through program line by line

	If you choose Run All:
		Will run through all steps
		If instruction requiring user input is reached, input and press enter
		*Press Run All again to continue auto step

When inputting a word, press enter to write it to memory

Reset will clear contents of Memory and registers (must Load another program)