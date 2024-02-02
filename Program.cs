// Karson Talbot, Feb-1/24, Lab 1.5
// 11=cyan, 12=red, 15=white, 0=black, 14=yellow, 6=brown, 9=blue
// 1-D array depicting the image of Mario provided
int[] MarioArray = new int[] 
{
    11,11,11,11,11,11,11,11,11,11,11,11,11,11,
    11,11,11,11,12,12,12,12,12,11,11,11,11,11,
    11,11,11,12,12,12,12,12,12,12,12,12,11,11,
    11,11,11, 0, 0, 0,15,15, 0,15,11,11,11,11,
    11,11, 0,15, 0,15,15,15, 0,15,15,15,11,11,
    11,11, 0,15, 0, 0,15,15,15, 0,15,15,15,11,
    11,11, 0, 0,15,15,15,15, 0, 0, 0, 0,11,11,
    11,11,11,11,15,15,15,15,15,15,15,11,11,11,
    11,11,11, 9, 9,12, 9, 9, 9,11,11,11,11,11,
    11,11, 9, 9, 9,12, 9, 9,12, 9, 9, 9,11,11,
    11, 9, 9, 9, 9,12, 9, 9,12, 9, 9, 9, 9,11,
    11,15,15, 9, 9,12,12,12,12, 9, 9,15,15,11,
    11,15,15,15,12,14,12,12,14,12,15,15,15,11,
    11,15,15,12,12,12,12,12,12,12,12,15,15,11,
    11,11,11,12,12,12,11,11,12,12,12,11,11,11,
    11,11, 6, 6, 6,11,11,11, 6, 6, 6,11,11,11,
    11, 6, 6, 6, 6,11,11,11, 6, 6, 6, 6,11,11,
    11,11,11,11,11,11,11,11,11,11,11,11,11,11
};

// Set up a clean canvas to draw
Console.Clear();
Console.SetCursorPosition(0, 0);

// Iterates over every number in the array and prints the corresponding color by casting the array member as an enum
for(int i = 0; i < MarioArray.Length; i++){
    Console.BackgroundColor = (ConsoleColor)MarioArray[i];
    Console.Write("  ");

    // Checks for a new line by calculating the remainder of 1 + i (because it starts at 0) and 14
    if(i != 0 && (i + 1) % 14 == 0){Console.ResetColor(); Console.Write('\n');}
}
// Resets the background so you can continue to use the console
Console.ResetColor();