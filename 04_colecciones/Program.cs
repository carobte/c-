﻿using System.Collections;
using System.Globalization;
// -*********************************************************-

// Arrays vs ArrayList vs List

Console.WriteLine("ArrayList");
// No es tipado

// Crear un ArrayList con elementos iniciales
ArrayList nombres = new() { "Juan", "Ana", "Pedro" };

// Acceder al número de elementos 
Console.WriteLine($"Numero de elementos: {nombres.Count}");

// Acceder a un elemento
Console.WriteLine($"Primer elemento: {nombres[0]}");
Console.WriteLine($"Ultimo elemento: {nombres[nombres.Count - 1]}");
Console.WriteLine($"Ultimo elemento usando ^ (operador índice): {nombres[^1]}");

// Añadir un elemento al final .Add(Object item)
nombres.Add("Luis");
Console.WriteLine($"Nuevo numero de elementos: {nombres.Count}");

// Insertar un elemento en el índice especificado .Insert(Int32 index, Object item) -> Object: cualquier tipo de dato
nombres.Insert(1, "Maria");
Console.WriteLine($"Nuevo numero de elementos: {nombres.Count}");

// Remover un elemento en el índice especificado .RemoveAt(Int32 index)
nombres.RemoveAt(1);
Console.WriteLine($"Nuevo numero de elementos: {nombres.Count}");

// Determinar si un elemento existe .Contains(Object item)
bool anaExiste = nombres.Contains("Ana");
Console.WriteLine($"El elemento 'Ana' existe: {anaExiste}");

// Obtener el índice de un elemento .IndexOf(Object item)
int indicePedro = nombres.IndexOf("Pedro"); // -> -1 si no se encuentra
Console.WriteLine($"El elemento 'Pedro' se encuentra en el índice {indicePedro}");

Console.WriteLine();
Console.WriteLine();
// -*********************-

// -*********************************************************-

// -*********************************************************-

Console.WriteLine("List");
// Tipada

List<string> nombresLista = new() { "Juan", "Ana", "Pedro" };

List<string> mayusculaNombresLista = nombresLista.Select(nombre => nombre.ToUpper()).ToList();

mayusculaNombresLista.ForEach(nombre => Console.WriteLine(nombre));


Console.WriteLine();
Console.WriteLine();

// -*********************************************************-

// -*********************************************************-

Console.WriteLine("Array");

int[] numeros = { 1, 2, 3, 4, 5 };

var nuevosNumeros = numeros.Append(6);


// -*********************************************************-

Console.WriteLine("#######################");

// -*********************************************************-

// EJERCICIOS

// Calculadora de Promedio de Calificaciones

Console.WriteLine("Ingresa las notas separadas por ,: ");
string notas = Console.ReadLine()!;

var listaNotas = notas.Split(',', ' ', StringSplitOptions.RemoveEmptyEntries).ToList(); // var infiere tipo de dato

var listaNotasNumber = listaNotas.Select(nota => Convert.ToDouble(nota, NumberFormatInfo.InvariantInfo) );

double total = 0;

// Console.WriteLine($"total: {total + 4.5 + 5 + 4 + 3 + 2}");

 foreach (var nota in listaNotasNumber)
 {
        Console.WriteLine(nota);
        total = total + nota;
 }

 Console.WriteLine($"count: {listaNotasNumber.Count()}");
 Console.WriteLine($"total: {total}");

var promedio = total / listaNotasNumber.Count();

Console.WriteLine(promedio);
