// 3)

// Codificar un programa que solicite al usuario qué tipo de pizza desea, 
// y en función de su respuesta le muestre un menú con los ingredientes disponibles para que elija uno de ellos, 
// además todas las pizzas llevan mozzarella y tomate. Al final se debe mostrar por pantalla si la pizza es vegetariana o no y todos los ingredientes que lleva.

Console.WriteLine("Bienvenidos a Pizzas T. ¿Qué pizza desea?");
String TipoPizza=Console.ReadLine().ToLower();
if(TipoPizza!="vegetariana" & TipoPizza!="no vegetariana"){
Console.WriteLine("Seleccione un tipo de pizza valido");
Environment.Exit(0);
}
switch (TipoPizza) {
case "vegetariana":
Console.WriteLine("Los ingredientes son: pimiento y champiñones ");
String ingredientesVt=Console.ReadLine().ToLower();
    if(ingredientesVt!="pimiento" & ingredientesVt!="champiñones"){
        Console.WriteLine("Ingrese un ingrediente valido");
        Environment.Exit(0);
    }
    if(ingredientesVt=="pimiento"){
        Console.WriteLine("Los ingredientes son: mozarella, tomate y pimiento");
    }
    if(ingredientesVt=="champiñones"){
        Console.WriteLine("Los ingredientes son: mozarella, tomate y champiñones");
    }
    break;
case "no vegetariana":
Console.WriteLine("Los ingredientes son: Pepperoni, Salami y Pollo ");
String ingredientesC=Console.ReadLine().ToLower();
    if(ingredientesC!="pepperoni" & ingredientesC!="salami" & ingredientesC!="pollo"){
        Console.WriteLine("Ingrese un ingrediente valido");
        Environment.Exit(0);
    }
    if(ingredientesC=="pepperoni"){
        Console.WriteLine("Su pizza es vegetariana. Los ingredientes son: mozarella, tomate y pepperoni");
    }
    if(ingredientesC=="salami"){
        Console.WriteLine("Su pizza es vegetariana. Los ingredientes son: mozarella, tomate y salami");
    }
    if(ingredientesC=="pollo"){
        Console.WriteLine("Su pizza es vegetariana. Los ingredientes son: mozarella, tomate y pollo");
    }
    break;
default:;
    break;
};