using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab3 : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        VisualElement verde = root.Q("ContenedorVerde");
        VisualElement azul = root.Q("ContenedorAzul");
        VisualElement amarillo = root.Q("ItemAmarillo");

        verde.RegisterCallback<MouseDownEvent>(
            ev =>
            {
                Debug.Log("Contenedor verde. Fase: " + ev.propagationPhase);
                Debug.Log("Contenedor verde. Current Target: " + (ev.currentTarget as VisualElement).name);
                Debug.Log("Contenedor verde. Target: " + (ev.target as VisualElement).name);

            }, TrickleDown.NoTrickleDown); //PREGUNTAR AL PROFE: POR QUE NO SALE EN EL DEBUG EL TRICKLE

        azul.RegisterCallback<MouseDownEvent>(
            ev =>
            {
                Debug.Log("Contenedor azul. Fase: " + ev.propagationPhase);
                Debug.Log("Contenedor verde. Current Target: " + (ev.currentTarget as VisualElement).name);
                Debug.Log("Contenedor verde. Target: " + (ev.target as VisualElement).name);

            }, TrickleDown.NoTrickleDown); //PREGUNTAR AL PROFE: POR QUE NO SALE EN EL DEBUG EL TRICKLE

        amarillo.RegisterCallback<MouseDownEvent>(
            ev =>
            {
                Debug.Log("Contenedor amarillo. Fase: " + ev.propagationPhase);
                Debug.Log("Contenedor verde. Current Target: " + (ev.currentTarget as VisualElement).name);
                Debug.Log("Contenedor verde. Target: " + (ev.target as VisualElement).name);

                ev.StopPropagation(); //diap15
            });
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
