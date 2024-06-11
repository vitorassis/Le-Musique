// See https://aka.ms/new-console-template for more information
using Le_Musique.Classes;
using Le_Musique.Classes.ENums;

Musica nona = new Musica();

nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.F, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.G, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.G, 4, EDuracao.SEMINIMA));


nona.Notas.Add(new Nota(ENota.F, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.D, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.C, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.C, 4, EDuracao.SEMINIMA));


nona.Notas.Add(new Nota(ENota.D, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.SEMIBREVE));
nona.Notas.Add(new Nota(ENota.D, 4, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.D, 4, EDuracao.SEMIBREVE));

/*
for (int i = 0; i < 10; i++)
{
    nona.Notas.Add(new Nota(ENota.E, 3, EDuracao.SEMIBREVE));
    nona.Notas.Add(new Nota(ENota.Ds, 3, EDuracao.SEMINIMA));
    nona.Notas.Add(new Nota(ENota.Cs, 3, EDuracao.SEMINIMA));
    nona.Notas.Add(new Nota(ENota.B, 2, EDuracao.SEMIBREVE));

    nona.Notas.Add(new Pausa(EDuracao.SEMIBREVE));

    nona.Notas.Add(new Nota(ENota.B, 2, EDuracao.SEMIBREVE));
    nona.Notas.Add(new Nota(ENota.Cs, 3, EDuracao.SEMINIMA));
    nona.Notas.Add(new Nota(ENota.Ds, 3, EDuracao.SEMINIMA));
    nona.Notas.Add(new Nota(ENota.E, 3, EDuracao.SEMIBREVE));

    nona.Notas.Add(new Pausa(EDuracao.SEMIBREVE));
}*/
nona.Andamento = 240;
nona.Tocar();