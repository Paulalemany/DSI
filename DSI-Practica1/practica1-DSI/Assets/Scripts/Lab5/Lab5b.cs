using UnityEngine;
using UnityEngine.UIElements;


namespace Lab5b_namespace
{
    public class Lab5b : MonoBehaviour
    {
        VisualElement plantilla;

        TextField input_nombre;
        TextField input_apellido;

        Individuo individuoPrueba;

        private void OnEnable()
        {
            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            plantilla       = root.Q("plantilla");
            input_nombre    = root.Q<TextField>("InputNombre");
            input_apellido  = root.Q<TextField>("InputApellido");

            individuoPrueba = new Individuo("Perico", "Palotes");

            Tarjeta tarjetaPrueba = new Tarjeta(plantilla, individuoPrueba);

            //input_nombre.RegisterCallback<ChangeEvent<string>>(CambioNombre);
            //input_apellido.RegisterCallback<ChangeEvent<string>>(CambioApellido);

            input_nombre.SetValueWithoutNotify(individuoPrueba.Nombre);
            input_apellido.SetValueWithoutNotify(individuoPrueba.Apellido);

        }

        void CambioNombre(ChangeEvent<string> evt)
        {
            individuoPrueba.Nombre = evt.newValue;
        }

        void CambioApellido(ChangeEvent<string> evt)
        {
            individuoPrueba.Apellido = evt.newValue;
        }
    }

}
