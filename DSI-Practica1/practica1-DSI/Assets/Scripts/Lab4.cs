using UnityEngine;
using UnityEngine.UIElements;

public class Lab4 : MonoBehaviour
{
    VisualElement contenedor, item1, item2, item3;

    void OnEnable()
    {
        VisualElement rootve = GetComponent<UIDocument>().rootVisualElement;
        contenedor = rootve.Q("Contenedor");
        item1 = rootve.Q("item1");
        item2 = rootve.Q("item2");

        item3 = new VisualElement();
        item3.name = "item3";
        item3.AddToClassList("item");
        //item3.style.height = 200;
        item3.style.backgroundColor = Color.cyan;

        contenedor.Add(item3);

        Debug.Log("Dentro de OnEnable");
    }

    private void Update()
    {
        Debug.Log("Dentro del Update");
    }

    private void LateUpdate()
    {
        Debug.Log("Dentro de LateUpdate");
    }
}
