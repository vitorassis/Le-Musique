// See https://aka.ms/new-console-template for more information
using Le_Musique.Classes;
using Le_Musique.Classes.ENums;

Musica nona = new Musica();

nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.F, 4, EDuracao.COLCHEIA));
nona.Notas.Add(new Nota(ENota.G, 4, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.G, 4, EDuracao.MINIMA));


nona.Notas.Add(new Nota(ENota.F, 4, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.D, 4, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.C, 4, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.C, 4, EDuracao.MINIMA));


nona.Notas.Add(new Nota(ENota.D, 4, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.B, 3, EDuracao.MINIMA));
nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.E, 4, EDuracao.COLCHEIA));
nona.Notas.Add(new Nota(ENota.D, 4, EDuracao.SEMINIMA));
nona.Notas.Add(new Nota(ENota.D, 4, EDuracao.SEMINIMA));

nona.Tocar();