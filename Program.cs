using System.Security.Cryptography.X509Certificates;

const System.ConsoleColor c_Cyan = ConsoleColor.Cyan;
const System.ConsoleColor c_Red = ConsoleColor.Red;
const System.ConsoleColor c_Blue = ConsoleColor.Blue;
const System.ConsoleColor c_Yellow = ConsoleColor.Yellow;
const System.ConsoleColor c_Brown = ConsoleColor.DarkYellow;
const System.ConsoleColor c_White = ConsoleColor.White;
const System.ConsoleColor c_Black = ConsoleColor.Black;

void Cyan(){
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.Write("  ");
}
void Red(){
    Console.BackgroundColor = ConsoleColor.Red;
    Console.Write("  ");
}
void Blue(){
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Write("  ");
}
void Yellow(){
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.Write("  ");
}
void Brown(){
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.Write("  ");
}
void White(){
    Console.BackgroundColor = ConsoleColor.White;
    Console.Write("  ");
}
void Black(){
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("  ");
}
void Draw(int pixels, System.ConsoleColor color, bool newline){
    Console.BackgroundColor = color;
    for(int i=0;i<pixels;i++){
        Console.Write("  ");
    } 
    Console.ResetColor();
    if(newline){
        Console.Write('\n');
    }
}

Console.Clear();
Console.SetCursorPosition(0, 0);
Draw(14, c_Cyan, true);
Draw(4, c_Cyan, false); Draw(5, c_Red, false); Draw(5, c_Cyan, false);
Draw(3, c_Cyan, false); Draw(9, c_Red, false); Draw(2, c_Cyan, true);