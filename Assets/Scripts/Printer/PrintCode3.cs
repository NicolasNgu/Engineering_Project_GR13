using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintCode3 : MonoBehaviour
{
    [SerializeField] private GameObject code3;
    [SerializeField] private GameObject imprimante;
    [SerializeField] private Compass compass;
    [SerializeField] private GameObject bouton;
    [SerializeField] private GameObject bouton1;
    [SerializeField] private GameObject bouton2;
    [SerializeField] private GameObject bouton3;
    [SerializeField] private GameObject bouton4;
    [SerializeField] private GameObject bouton5;
    [SerializeField] private GameObject bravo;

    public void printCode(){
        code3.SetActive(true);
        compass.target = imprimante.transform; 

        bouton.SetActive(false);
        bouton1.SetActive(false);
        bouton2.SetActive(false);
        bouton3.SetActive(false);
        bouton4.SetActive(false);
        bouton5.SetActive(false);
        bravo.SetActive(true);


    }

}
