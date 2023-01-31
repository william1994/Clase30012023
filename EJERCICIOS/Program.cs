// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Nombres espacio para llamar las clases correspondientes
using EJERCICIOS.Entidades;
using EJERCICIOS.Negocio;

/*

//Bloque de codigo para operacion
//Creacion de objetos
Operaciones operaciones = new Operaciones();
ClsOperacions clsOperacions = new ClsOperacions();


//Capturando informacion
//ToInt32 se utiliza para hacer conversiones a tipos de datos entero
Console.WriteLine("Ingresar el primer dato");
operaciones.Dato1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresar el segundo dato");
operaciones.Dato2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El resultado de la operacion es ");
Console.WriteLine(clsOperacions.Suma(operaciones));
*/

//Crear objetos 
User user = new User();
ClsUser clsUser = new ClsUser();



//Capturar informacion del usuario
Console.WriteLine("Ingresa tu usuario");
user.user = Console.ReadLine();
Console.WriteLine("Ingresa tu password");
user.password = Console.ReadLine();

bool Resultado = clsUser.Autenticacion(user);
if(Resultado==true){
    Console.WriteLine("Welcome");
}else {
     Console.WriteLine("You are bad");
}