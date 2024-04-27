using System.Drawing;
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
        item3.style.backgroundColor = UnityEngine.Color.cyan;

        contenedor.Add(item3);

        Debug.Log("Dentro de OnEnable");

        //Texto??
        Label texto = rootve.Q<Label>("texto");
        item1.style.backgroundColor = UnityEngine.Color.white;

        texto.text = @"
        <line-indent=15%>Habia una vez <smallcaps>una tierra,</smallcaps> </line-indent><br>
        Donde <rotate=""45""> el sol nunca se pone</rotate>,
        <b><gradient=""cuatro colores"">Y la gente era amable</gradient><b>,
        Y la tierra nunca estaba mojada.
        <b><color=""black""><gradient=""Complementario"">La tierra era tan hermosa</gradient><b>,
        <i>que la gente nunca se fue.
        ";

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
