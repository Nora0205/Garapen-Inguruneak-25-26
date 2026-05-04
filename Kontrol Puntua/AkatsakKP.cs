using System;

namespace BukleAkats
{
    class Program
    {
        static void Main(string[] args)
        {
// 1. AKATSA
int[] balioak = { 10, 20, 30, 40, 50 };
int batura = 0;

for (int i = 0; i < balioak.Length; i++)
{
    batura += balioak[i];
}

// AKATSA: batez bestekoa ez da ondo kalkulatzen (zatiketa falta da)
int batazBestekoa = batura;
Console.WriteLine($"2. Batez bestekoa: {batazBestekoa}");


// 2. AKATSA
int kontagailua = 0;

while (kontagailua < 5)
{
    Console.WriteLine($"4. Kontagailua: {kontagailua}");
    // AKATSA: kontagailua ez da handitzen → begizta infinitua
}


// 3. AKATSA
int[] arrayZenbakiak = { 1, 2, 3, 4, 5 };
Console.WriteLine("5. Zenbakien karratuak:");

int karratua = 0;

foreach (int zenbakia in arrayZenbakiak)
{
    karratua = zenbakia * zenbakia;
}

// AKATSA: azken balioa bakarrik gordetzen da eta loopetik kanpo gaizki erabiltzen da
Console.WriteLine($"Zenbakiaren karratua: {karratua}");


// 4. AKATSA
int[] balioMistoa = { 1, 3, 5, 7, 9 };
int emaitza = 0;

for (int i = 0; i < balioMistoa.Length; i++)
{
    // AKATSA: elementuak gaizki pilatzen dira (logika okerra/errepikapen arazoa izan daiteke)
    emaitza += balioMistoa[i] + balioMistoa[i];
}

Console.WriteLine($"7. Zenbakien batura: {emaitza}");
                  }
    }
}
