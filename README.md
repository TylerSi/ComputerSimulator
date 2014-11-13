ComputerSimulator
=================

<p>Assembly computer simulator</p>
<p>This desktop application was created using Visual C#.  It was created as a class project and simulates a computer with an accumulator and various registers.  This computer is limited to 100 memory cells and will read, store, and write information accordingly.  Please review the samples below.</p>

<h4>Commands</h4>
<hr>
<p>
<b>READ</b> Read a word from the keyboard into a specific location in memory<br>
<b>WRIT</b> Write a word from a specific location in memory to the screen<br>
<b>LOAD</b> Load a word from a specific location in memory to the accumulator<br>
<b>STOR</b> Write the contents of the accumulator to a specific memory location<br>
<b>ADD</b> Add a word from a specific memory location to the word in the accumulator, result
in accumulator<br>
<b>SUB</b> Subtract a word from a specific memory location from the word in the accumulator,
result in accumulator<br>
<b>DIV</b> Divide a word from a specific location in memory into the word in the accumulator,
result in accumulator<br>
<b>MULT</b> Multiply a word from a specific location in memory by the word in the accumulator,
result in accumulator<br>
<b>JUMP</b> Branch to a specific location in memory<br>
<b>JMPN</b> if the accumulator is negative, branch to a specific location in memory<br>
<b>JMPZ</b> if the accumulator is zero, branch to a specific location in memory<br>
<b>DUMP</b> Show the contents of all registers and memory to the screen<br>
<b>MODA</b> Change the address of instruction at a specific memory location with value in the
accumulator<br>
<b>HALT</b> Halt. The program has completed its task.
</p>
<hr>
