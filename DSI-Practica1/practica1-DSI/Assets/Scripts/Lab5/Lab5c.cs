using Lab5b_namespace;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Lab5c_namespace
{
    public class Lab5c : MonoBehaviour
    {
        List<Individuo> individuos;
        Individuo selectIndividuo;

        VisualElement tarjeta1;
        VisualElement tarjeta2;
        VisualElement tarjeta3;
        VisualElement tarjeta4;

        TextField input_nombre;
        TextField input_apellido;

        private void nEnable()
        {
            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            tarjeta1 = root.Q("Tarjeta1");
            tarjeta2 = root.Q("Tarjeta2");
            tarjeta3 = root.Q("Tarjeta3");
            tarjeta4 = root.Q("Tarjeta4");

            input_nombre = root.Q<TextField>("InputNombre");
            input_apellido = root.Q<TextField>("InputApellido");

            individuos = BaseDatos.getData();

            VisualElement panelDcha = root.Q("Dcha");
            panelDcha.RegisterCallback<ClickEvent>(seleccionTarjeta);

            input_nombre.RegisterCallback<ChangeEvent<string>>(CambioNombre);
            input_apellido.RegisterCallback<ChangeEvent<string>>(CambioApellido);

            InitizalizeUI();
        }

        void CambioNombre(ChangeEvent<string> evt)
        {
            selectIndividuo.Nombre = evt.newValue;
        }

        void CambioApellido(ChangeEvent<string> evt)
        {
            selectIndividuo.Apellido = evt.newValue;
        }

        void seleccionTarjeta(ClickEvent e)
        {
            VisualElement tarjeta = e.target as VisualElement;
            selectIndividuo = tarjeta.userData as Individuo;

            input_nombre.SetValueWithoutNotify(selectIndividuo.Nombre);
            input_apellido.SetValueWithoutNotify(selectIndividuo.Apellido);
        }

        void InitizalizeUI()
        {
            Tarjeta tar1 = new Tarjeta(tarjeta1, individuos[0]);
            Tarjeta tar2 = new Tarjeta(tarjeta2, individuos[1]);
            Tarjeta tar3 = new Tarjeta(tarjeta3, individuos[2]);
            Tarjeta tar4 = new Tarjeta(tarjeta4, individuos[3]);
        }
    }
}
