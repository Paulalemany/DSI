using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab3b : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        VisualElement izda = root.Q("Izda");
        VisualElement dcha = root.Q("Dcha");

        //diap25
        izda.AddManipulator(new Lab3Manipulator());
        dcha.AddManipulator(new Lab3Manipulator());

        //diap26
        List<VisualElement> lveizda = izda.Children().ToList();
        List<VisualElement> lvedcha = dcha.Children().ToList();
        lveizda.ForEach(elem => elem.AddManipulator(new Lab3Manipulator()));
        lvedcha.ForEach(elem => elem.AddManipulator(new Lab3Manipulator()));


        izda.RegisterCallback<MouseDownEvent>(
            ev =>
            {
                Debug.Log("Contenedor Izquierda. Fase: " + ev.propagationPhase);
                Debug.Log("Contenedor Izquierda. Target: " + (ev.target as VisualElement).name);


                //Cambia color al clicar
                (ev.target as VisualElement).style.backgroundColor = Color.green;

            }, TrickleDown.TrickleDown);
        
        dcha.RegisterCallback<MouseDownEvent>(
            ev =>
            {
                Debug.Log("Contenedor Derecha. Fase: " + ev.propagationPhase);
                Debug.Log("Contenedor Derecha. Target: " + (ev.target as VisualElement).name);

                //Cambia color al clicar
                (ev.target as VisualElement).style.backgroundColor = Color.blue;

            }, TrickleDown.TrickleDown);
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
