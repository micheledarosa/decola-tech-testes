﻿using Calculadora.Services;

CalculadoraImplementacao calculadora = new CalculadoraImplementacao();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {calculadora.Somar(num1, num2)}");