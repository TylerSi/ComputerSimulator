ComputerSimulator
=================

Assembly computer simulator

Commands
========================================================================================
READ Read a word from the keyboard into a specific location in memory
WRIT Write a word from a specific location in memory to the screen
LOAD Load a word from a specific location in memory to the accumulator
STOR Write the contents of the accumulator to a specific memory location
ADD Add a word from a specific memory location to the word in the accumulator, result
in accumulator
SUB Subtract a word from a specific memory location from the word in the accumulator,
result in accumulator
DIV Divide a word from a specific location in memory into the word in the accumulator,
result in accumulator
MULT Multiply a word from a specific location in memory by the word in the accumulator,
result in accumulator
JUMP Branch to a specific location in memory
JMPN if the accumulator is negative, branch to a specific location in memory
JMPZ if the accumulator is zero, branch to a specific location in memory
DUMP Show the contents of all registers and memory to the screen
MODA Change the address of instruction at a specific memory location with value in the
accumulator
HALT Halt. The program has completed its task.
========================================================================================
