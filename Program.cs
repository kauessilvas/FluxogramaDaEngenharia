Console.Clear();

Console.WriteLine("--- Fluxograma da Engenharia ---");

Console.Write("O objeto está se movendo (S/N)?: ");
char movendo = char.ToUpper(char.Parse(Console.ReadLine()!));

Console.Write("Deveria?: ");
char deveria = char.ToUpper(char.Parse(Console.ReadLine()!));

if (movendo == 'S') {
    if (deveria == 'S') {
        Console.WriteLine("\nÓtimo!\n");
    } else {
        Console.WriteLine("\nUse Silver Tape.\n");
    }
} else {
    if (deveria == 'S') {
        Console.WriteLine("\nUse WD-40.\n");
    } else {
        Console.WriteLine("\nÓtimo!\n");
    }
}