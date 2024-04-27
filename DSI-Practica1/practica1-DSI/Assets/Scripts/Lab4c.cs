using UnityEngine;
using UnityEngine.UIElements;

public class Lab4c : MonoBehaviour
{

    private void OnEnable()
    {
        VisualElement rootve = GetComponent<UIDocument>().rootVisualElement;

        VisualElement top       = rootve.Q("Top");
        VisualElement bottom    = rootve.Q("Bottom");

        VisualTreeAsset template_cajas = Resources.Load<VisualTreeAsset>("Templates/ContenedorCajas");

        VisualElement cajasTop1     = template_cajas.Instantiate();
        VisualElement cajasTop2     = template_cajas.Instantiate();
        VisualElement cajasBottom   = template_cajas.Instantiate();

        top.Add(cajasTop1);
        top.Add(cajasTop2);
        bottom.Add(cajasBottom);
    }
}
