using System.Security.Cryptography.X509Certificates;

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

Console.Clear();
Console.SetCursorPosition(0, 0);
for(int i=0;i<14;i++){Cyan();}Console.ResetColor(); Console.Write('\n');
for(int i=0;i<4;i++){Cyan();}for(int i=0;i<5;i++){Red();}for(int i=0;i<5;i++){Cyan();} Console.ResetColor(); Console.Write('\n');

Console.ResetColor();
