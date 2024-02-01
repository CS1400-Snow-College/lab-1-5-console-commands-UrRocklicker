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
void White(){ // No good color built in for the skin
    Console.BackgroundColor = ConsoleColor.White;
    Console.Write("  ");
}
void Black(){
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("  ");
}
void Draw(int pixels, System.ConsoleColor color){
    Console.BackgroundColor = color;
    for(int i=0;i<pixels;i++){
        Console.Write("  ");
    } 
    Console.ResetColor();
}
void DrawNl(int pixels, System.ConsoleColor color){ // Apparently you cannot overload local functions
    Console.BackgroundColor = color;
    for(int i=0;i<pixels;i++){
        Console.Write("  ");
    } 
    Console.ResetColor();
    Console.Write('\n');
}

Console.Clear();
Console.SetCursorPosition(0, 0);
DrawNl(14, c_Cyan);
Draw(4, c_Cyan); Draw(5, c_Red); DrawNl(5, c_Cyan);
Draw(3, c_Cyan); Draw(9, c_Red); DrawNl(2, c_Cyan);
Draw(3, c_Cyan); Draw(3, c_Black); Draw(2, c_White); Black(); White(); DrawNl(4, c_Cyan);