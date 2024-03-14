using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab2 : MonoBehaviour
{
    private void OnEnable()
    {
        UIDocument document = GetComponent<UIDocument>();
        VisualElement rootve = document.rootVisualElement;

        UQueryBuilder<VisualElement> builder = new(rootve);
        List<VisualElement> list_ve = builder.ToList();

        //Escribe cada elemento de la lista
        list_ve.ForEach(e => { Debug.Log(e.name); });
    }
}
