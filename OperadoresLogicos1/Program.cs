Console.WriteLine("Hello, World!");

bool c1 = 10 >= 15; //false
bool c2 = 20 != 15; //true
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}");

//Operador (AND) = &&

resultado = c1 && c2;
Console.WriteLine("Operador AND(&&) : " + resultado);

//Operador (OR) = ||

resultado = c1 || c2;
Console.WriteLine("Operador OR(||) : " + resultado);

//Operador (NOT) = !
resultado = !c1;
Console.WriteLine("Operador NOT(!) : " + resultado);