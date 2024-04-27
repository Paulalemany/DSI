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

        #region Parte 1
        //VisualElement cajasTop1     = template_cajas.Instantiate();
        //VisualElement cajasTop2     = template_cajas.Instantiate();
        //VisualElement cajasBottom   = template_cajas.Instantiate();

        //top.Add(cajasTop1);
        //top.Add(cajasTop2);
        //bottom.Add(cajasBottom);
        #endregion

        #region Parte 2
        //for (int i = 0; i < 6; i++)
        //{
        //    top.Add(template_cajas.Instantiate());
        //    bottom.Add(template_cajas.Instantiate());
        //}
        #endregion

        VisualElement cajasTop1 = template_cajas.Instantiate();
        VisualElement cajasTop2 = template_cajas.Instantiate();
        VisualElement cajasBottom = template_cajas.Instantiate();

        top.Add(cajasTop1);
        top.Add(cajasTop2);
        bottom.Add(cajasBottom);

        Sprite img_bear = Resources.Load<Sprite>("Images/oso");
        Sprite img_wolf = Resources.Load<Sprite>("Images/Lobo");
        Sprite img_cat = Resources.Load<Sprite>("Images/gato");

        VisualElement caja1 = cajasTop1.Q("Caja1");
        VisualElement caja2 = cajasTop2.Q("Caja2");
        VisualElement caja3 = cajasBottom.Q("Caja3");
        caja1.style.backgroundImage = new StyleBackground(img_bear);
        caja2.style.backgroundImage = new StyleBackground(img_wolf);
        caja3.style.backgroundImage = new StyleBackground(img_cat);

    }
}
