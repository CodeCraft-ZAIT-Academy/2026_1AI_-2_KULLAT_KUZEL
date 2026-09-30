decimal PI = 3.14m;

decimal polomer = Nacitajcislo("polomer cm");
decimal vyska = Nacitajcislo("vyska cm");
decimal prepona = Nacitajcislo("prepona cm");

decimal Objem = VypocitajObjem(PI, polomer, vyska);
decimal Obsah = VypocitajObsah(PI, polomer, prepona);

decimal Nacitajcislo(string text)
{
    Console.Write(text + ":  ");
    string cislo1 = Console.ReadLine();
    return decimal.Parse(cislo1);
}
decimal VypocitajObjem(decimal PI, decimal polomer, decimal vyska)
{
return PI * (polomer * polomer) * vyska / 3;
}
decimal VypocitajObsah(decimal PI, decimal polomer, decimal prepona)
{
    return PI * (polomer * polomer) + PI * polomer * prepona;
}

Console.Write("Objem: " + Objem + "cm");
Console.WriteLine("");
Console.Write("Obsah: " + Obsah + "cm");

