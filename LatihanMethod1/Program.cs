int a = 10, b = 2, c = 0;

void tambah(int a,int b)
{
    c = a + b;
    Console.WriteLine($"{a} + {b} + {c}");
}

void kurang(int a,int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} - {c}");
}

void kali(int a,int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} * {c}");
}

void bagi(int a,int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} / {c}");
}

tambah(8, 6);
kali(5, 3);
bagi(4, 2);
kurang(10, 6);
