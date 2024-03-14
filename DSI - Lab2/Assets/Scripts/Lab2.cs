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


        #region AddToClasslist
        //UQueryBuilder<VisualElement> builder = new(rootve);
        //List<VisualElement> list_ve = builder.ToList();

        //Escribe cada elemento de la lista
        //list_ve.ForEach(e => { Debug.Log(e.name);
        //e.AddToClassList("amarillo");});    //Le aplica el estilo a los elementos de la lista
        #endregion

        #region Children
        //VisualElement contenedor = builder.Name("mid");
        //List<VisualElement> list_ve = contenedor.Children().ToList();
        #endregion

        #region Query
        //List<VisualElement> list_ve = rootve.Query(className: "azul").ToList();
        #endregion

        #region QueryFirst
        //VisualElement ve = rootve.Query(className: "azul").First();
        ////Es exactamente lo mismo si hacemos: ve.AddToClassList("amarillo");
        //Debug.Log(ve.name);
        //ve.AddToClassList("amarillo");
        #endregion

        #region Query<Type>
        //VisualElement ve = rootve.Query<Button>().Last();
        //Debug.Log(ve.name);
        //ve.AddToClassList("amarillo");
        #endregion

        #region Query<Type>.Atindex()
        //VisualElement ve = rootve.Query<Button>().AtIndex(1);
        //Debug.Log(ve.name);
        //ve.AddToClassList("amarillo");
        #endregion

        #region Ejemplo1
        //VisualElement top = rootve.Query("top");
        //VisualElement bottom = rootve.Query("bottom");
        //List<VisualElement> List_ve = new();

        //List_ve.AddRange(top.Children().ToList());
        //List_ve.AddRange(bottom.Children().ToList());

        //List_ve.ForEach(e => { Debug.Log(e); e.AddToClassList("amarillo"); });
        #endregion

        #region Ejemplo2
        //List<VisualElement> List_ve = new()
        //{
        //    rootve.Q("itemTop3"),
        //    rootve.Q("itemMid2"),
        //    rootve.Q("itemBottom1")
        //};

        //List_ve.ForEach(e => { Debug.Log(e); e.AddToClassList("amarillo"); });
        #endregion

        #region Debugger->inLineStyle
        //List<VisualElement> List_ve = new()
        //{
        //    rootve.Q("itemTop3"),
        //    rootve.Q("itemMid2"),
        //    rootve.Q("itemBottom1")
        //};

        //List_ve.ForEach(e => { Debug.Log(e); e.style.backgroundColor = Color.grey; });
        #endregion

        #region Ejemplo3
        List<VisualElement> List_Contenedor = rootve.Query(className: "azul").ToList();
        List<VisualElement> List_ve = List_Contenedor.SelectMany(e => e.Children()).
            Where(e => e.GetType() == typeof(Button)).ToList();

        List_ve.ForEach(e => { Debug.Log(e); e.AddToClassList("amarillo"); });
        #endregion
    }
}
