using UnityEngine;
using System.Collections.Generic;
using Lab5b_namespace;

namespace Lab5c_namespace
{
    public class  BaseDatos
    {
        public static List<Individuo> getData()
        {
            List<Individuo> datos = new List<Individuo>();

            Individuo perico = new Individuo(
                "Perico",
                "Palotes"
            );

            Individuo tornasol = new Individuo(
                "Tornasol",
                "Tornasolado"
            );

            Individuo Luca = new Individuo(
                "Luca",
                "Lucatelli"
            );

            Individuo Ivan = new Individuo(
                "Ivan",
                "Ivanochi"
            );

            datos.Add(perico);
            datos.Add(tornasol);
            datos.Add(Luca);
            datos.Add(Ivan);

            return datos;
        }
    }
}
