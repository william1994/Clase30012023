using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EJERCICIOS.Entidades;

namespace EJERCICIOS.Negocio
{
    public class ClsUser
    {

        //Tipo de dato bool es utilizado para true/ false = verdadero o falso
        public bool Autenticacion(User user)
        {

            //if(Condicion)
            //Si la condicion de usuario y contraseña se cumplen entrara en
            //El primer bloque de codigo 
            //Utilizando compuerta logica AND
            if (user.user.Equals("William") && user.password.Equals("123"))
            {

                return true;
            }
            return false;


        }

    }
}