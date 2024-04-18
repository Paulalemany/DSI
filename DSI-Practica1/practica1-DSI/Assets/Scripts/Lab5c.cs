using UnityEngine;
using UnityEngine.UIElements;
using System.Collections.Generic;

using Lab5b_namespace;

namespace Lab5c_namespace
{
    public class Lab5c : MonoBehaviour
    {
        //VisualElement plantilla;

        List<Individuo> individuos;
        Individuo selecIndividuo;

        VisualElement tarjeta1;
        VisualElement tarjeta2;
        VisualElement tarjeta3;
        VisualElement tarjeta4;

        TextField input_nombre;
        TextField input_apellido;

        private void OnEnable()
        {
            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            //plantilla = root.Q("plantilla");
            //input_nombre = root.Q<TextField>("InputNombre");
            //input_apellido = root.Q<TextField>("InputApellido");

            //individuoPrueba = new Individuo("Perico", "Palotes");

            //Tarjeta tarjetaPrueba = new Tarjeta(plantilla, individuoPrueba);

            tarjeta1 = root.Q("Tarjeta1");
            tarjeta2 = root.Q("Tarjeta2");
            tarjeta3 = root.Q("Tarjeta3");
            tarjeta4 = root.Q("Tarjeta4");

            input_nombre = root.Q<TextField>("InputNombre");
            input_apellido = root.Q<TextField>("InputApellido");

            individuos = Basedatos.getData();

            VisualElement panelDcha = root.Q("Dcha");
            panelDcha.RegisterCallback<ClickEvent>(seleccionTarjeta);

            //plantilla.RegisterCallback<ClickEvent>(SeleccionIndividuo);
            input_nombre.RegisterCallback<ChangeEvent<string>>(CambioNombre);
            input_apellido.RegisterCallback<ChangeEvent<string>>(CambioApellido);

            //input_nombre.SetValueWithoutNotify(individuoPrueba.Nombre);
            //input_apellido.SetValueWithoutNotify(individuoPrueba.Apellido);

            InitializeUI();
        }

        //void SeleccionIndividual(ClickEvent evt)
        //{
        //    string nombre = plantilla.Q<Label>("Nombre").text;
        //    string apellido = plantilla.Q<Label>("Apellido").text;

        //    Debug.Log(nombre);

        //    input_nombre.SetValueWithoutNotify(nombre);
        //    input_apellido.SetValueWithoutNotify(apellido);
        //}

        void CambioNombre(ChangeEvent<string> evt)
        {
            selecIndividuo.Nombre = evt.newValue;
        }

        void CambioApellido(ChangeEvent<string> evt)
        {
            selecIndividuo.Apellido = evt.newValue;
        }

        void SeleccionTarjeta(ClickEvent e)
        {
            VisualElement tarjeta = e.target as VisualElement;
            selecIndividuo = tarjeta.userData as Individuo;

            input_nombre.SetValueWithoutNotify(selecIndividuo.Nombre);
            input_apellido.SetValueWithoutNotify(selecIndividuo.Apellido);
        }

        void InitializeUI()
        {
            Tarjeta tar1 = new Tarjeta(tarjeta1, individuos[0]);
            Tarjeta tar2 = new Tarjeta(tarjeta2, individuos[1]);
            Tarjeta tar3 = new Tarjeta(tarjeta3, individuos[2]);
            Tarjeta tar4 = new Tarjeta(tarjeta4, individuos[3]);
        }
    }
}
