using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


namespace Lab6_namespace
{
    public class Tarjeta
    {
        Individuo miIndividuo;
        VisualElement tarjetaRoot;

        Label nombreLabel;
        Label apellidoLabel;


        public Tarjeta(VisualElement tarjetaRoot, Individuo individuo)
        {
            this.tarjetaRoot = tarjetaRoot;
            this.miIndividuo = individuo;

            nombreLabel = tarjetaRoot.Q<Label>("Nombre");
            apellidoLabel = tarjetaRoot.Q<Label>("Apellido");
            tarjetaRoot.userData = individuo; //diap 15

            UpdateUI();

            miIndividuo.Cambio += UpdateUI;

        }

        void UpdateUI()
        {

            nombreLabel.text = miIndividuo.Nombre;
            apellidoLabel.text = miIndividuo.Apellido;
        }
    }
}