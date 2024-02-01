// 0=cyan, 1=red, 2=white, 3=black, 4=yellow, 5=brown, 6=blue
// 1-D array depicting the image of Mario provided
int[] MarioArray = new int[] 
{
    0,0,0,0,0,0,0,0,0,0,0,0,0,0,
    0,0,0,0,1,1,1,1,1,0,0,0,0,0,
    0,0,0,1,1,1,1,1,1,1,1,1,0,0,
    0,0,0,3,3,3,2,2,3,2,0,0,0,0,
    0,0,3,2,3,2,2,2,3,2,2,2,0,0,
    0,0,3,2,3,3,2,2,2,3,2,2,2,0,
    0,0,3,3,2,2,2,2,3,3,3,3,0,0,
    0,0,0,0,2,2,2,2,2,2,2,0,0,0,
    0,0,0,6,6,1,6,6,6,0,0,0,0,0,
    0,0,6,6,6,1,6,6,1,6,6,6,0,0,
    0,6,6,6,6,1,6,6,1,6,6,6,6,0,
    0,2,2,6,6,1,1,1,1,6,6,2,2,0,
    0,2,2,2,1,4,1,1,4,1,2,2,2,0,
    0,2,2,1,1,1,1,1,1,1,1,2,2,0,
    0,0,0,1,1,1,0,0,1,1,1,0,0,0,
    0,0,5,5,5,0,0,0,5,5,5,0,0,0,
    0,5,5,5,5,0,0,0,5,5,5,5,0,0,
    0,0,0,0,0,0,0,0,0,0,0,0,0,0
};

// Set up a clean canvas to draw
Console.Clear();
Console.SetCursorPosition(0, 0);

// Iterates over every number in the array and prints the corresponding color
for(int i=0;i<MarioArray.Length;i++){
    switch(MarioArray[i]){
        case 0: Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write("  ");
                break;
        case 1: Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("  ");
                break;
        case 2: Console.BackgroundColor = ConsoleColor.White; // There was no good color for skin
                Console.Write("  ");
                break;
        case 3: Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("  ");
                break;
        case 4: Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("  ");
                break;
        case 5: Console.BackgroundColor = ConsoleColor.DarkYellow; // No good color for brown either
                Console.Write("  ");
                break;
        case 6: Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("  ");
                break;
        default: Console.WriteLine("INVALID"); break; // If there is an unexpected number in the array, print an error

    }
    // Checks for a new line by calculating the remainder of 1 + i (because it starts at 0) and 14
    if(i !=0 && (i + 1) % 14 == 0){Console.ResetColor(); Console.Write('\n');}
}
// Resets the background so you can continue to use the console
Console.ResetColor();