using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;

public class Lab3Manipulator : MouseManipulator
{
    public Lab3Manipulator()
    {
        activators.Add(new ManipulatorActivationFilter { button = MouseButton.RightMouse });
        //Debug.Log("Constructora Lab3Manipulator");
    }
    protected override void RegisterCallbacksOnTarget()
    {
        target.RegisterCallback<MouseDownEvent>(OnMouseDown);
    }

    protected override void UnregisterCallbacksFromTarget()
    {
        target.UnregisterCallback<MouseDownEvent>(OnMouseDown);
    }

    private void OnMouseDown(MouseDownEvent mev)
    {
        Debug.Log(target.name + ": Click en Elemento");

        if (CanStartManipulation(mev))
        {
            //ESTO SERIA CON CLICK DERECHO
            target.style.borderBottomColor = Color.white;
            target.style.borderLeftColor = Color.white;
            target.style.borderRightColor = Color.white;
            target.style.borderTopColor = Color.white;

            mev.StopPropagation();
        }
    }
}
