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

<h4>Sample Programs</h4>
<hr>
<h5>Sum Array</h5>
<p>
This program will sum the contents of an array stored in memory starting at memory cell 50.
</p>
<p>
STOR 22<br>
LOAD 21 //Change starting number at line 21<br>
MODA 3<br>
LOAD <br>
ADD 22<br>
STOR 22 //Stores sum<br>
LOAD 19<br>
SUB 20<br>
STOR 19<br>
JMPZ 16<br>
LOAD 21<br>
ADD 20<br>
STOR 21<br>
WRIT 22<br>
MODA 3<br>
JUMP 3<br>
HALT<br>
<br>
<br>
20<br>
1<br>
50<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
1<br>
2<br>
3<br>
4<br>
5<br>
6<br>
7<br>
8<br>
9<br>
10<br>
11<br>
12<br>
13<br>
14<br>
15<br>
16<br>
17<br>
18<br>
19<br>
20<br>
</p>
<hr>

<h5>nth Fibonacci Number</h5>
<br>
<p>This program will input from the user and output that Fibonacci number.</p>
READ 50<br>
LOAD 50<br>
JMPZ 60 //if 0 jmp writ 0<br>
SUB 52 //subtract 2<br>
JMPZ 62 //jmp writ 1<br>
JMPN 62 //jmp writ 1<br>
LOAD 50<br>
SUB 52 //sub 2<br>
STOR 50 //stor counter start<br>
LOAD 53<br>
ADD 54<br>
STOR 53<br>
STOR 55<br>
LOAD 50<br>
SUB 51<br>
STOR 50<br>
JMPZ 60<br>
LOAD 54<br>
ADD 53<br>
STOR 54<br>
STOR 55<br>
LOAD 50<br>
SUB 51<br>
STOR 50<br>
JMPZ 60<br>
JUMP 9<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
1<br>
2<br>
1<br>
1<br>
0<br>
<br>
<br>
<br>
<br>
WRIT 55 //60<br>
HALT<br>
WRIT 51 //62<br>
HALT<br>

