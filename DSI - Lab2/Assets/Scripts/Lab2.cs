using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab2 : MonoBehaviour
{
    private void OnEnable()
    {
        UIDocument document = GetComponent<UIDocument>();
        VisualElement rootve = document.rootVisualElement;

        //UQueryBuilder<VisualElement> builder = new(rootve);
        //List<VisualElement> list_ve = builder.ToList();
        //List<VisualElement> list_ve = rootve.Query(className: "azul").ToList();
        VisualElement ve = rootve.Query(className: "azul").First();
        Debug.Log(ve.name);
        ve.AddToClassList("amarillo");

        //VisualElement contenedor = builder.Name("mid");
        //List<VisualElement> list_ve = contenedor.Children().ToList();


        //Escribe cada elemento de la lista
        //list_ve.ForEach(e => { Debug.Log(e.name);
            //e.AddToClassList("amarillo");});    //Le aplica el estilo a los elementos de la lista
    }
}
