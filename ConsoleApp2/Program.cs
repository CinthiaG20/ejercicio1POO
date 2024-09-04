// See https://aka.ms/new-console-template for more information

using Ej2;

Ingrediente ing1= new Ingrediente("Strawberries",1.50);
Ingrediente ing2 = new Ingrediente("Banana", 0.50);
Ingrediente ing3= new Ingrediente("Mango",2.50);
Ingrediente ing4= new Ingrediente("Blueberries",1);
Ingrediente ing5 = new Ingrediente("Raspberries", 1);
Ingrediente ing6 = new Ingrediente("Apple", 1.75);
Ingrediente ing7 = new Ingrediente("Pineapple", 3.50);

Smoothie S1=new Smoothie("S1");
S1.AddIngredient(ing2);
S1.AddIngredient(ing1);
S1.AddIngredient(ing7);
Console.WriteLine(S1.GetFullName());
Console.WriteLine(S1.GetTotalPrice());