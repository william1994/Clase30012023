using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EJERCICIOS.Entidades;

namespace EJERCICIOS.Negocio
{
    public class ClsOperacions
    {
        //Cuando creamos el objeto
        //C# va a diferenciar las mayusculas de las minusculas
        public int Suma(Operaciones operaciones){
           
           return operaciones.Resultado = operaciones.Dato1 + operaciones.Dato2;

        }
    }
}