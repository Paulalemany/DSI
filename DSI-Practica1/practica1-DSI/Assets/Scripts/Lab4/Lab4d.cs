using UnityEngine;
using UnityEngine.UIElements;

public class Lab4d : VisualElement
{
    public new class UxmlFactory : UxmlFactory<Lab4d> { };

    public Lab4d() 
    {
        VisualElement panelRojo = new VisualElement();
        VisualElement panelAmbar = new VisualElement();
        VisualElement panelVerde = new VisualElement();

        panelRojo.style.width   = 100;
        panelRojo.style.height  = 100;
        panelRojo.style.opacity = 100;
        panelRojo.style.color   = Color.red;

        panelAmbar.style.width = 100;
        panelAmbar.style.height = 100;
        panelAmbar.style.color = Color.blue;

        panelVerde.style.width = 100;
        panelVerde.style.height = 100;
        panelVerde.style.color = Color.blue;

        hierarchy.Add(panelRojo);
        hierarchy.Add(panelAmbar);
        hierarchy.Add(panelVerde);
    }
}
