using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintCode2 : MonoBehaviour
{

    [SerializeField] private GameObject mail1;
    [SerializeField] private GameObject mail2;
    [SerializeField] private GameObject mail3;
    [SerializeField] private GameObject mail4;
    [SerializeField] private GameObject mail5;
    [SerializeField] private GameObject mail6;
    [SerializeField] private GameObject mail7;
    [SerializeField] private GameObject mail8;
    [SerializeField] private GameObject mail9;
    [SerializeField] private GameObject ReinitPass;
    [SerializeField] private GameObject code2;
    public void printBerCode()
    {
        code2.SetActive(true);

        mail1.SetActive(false);
        mail2.SetActive(false);
        mail3.SetActive(false);
        mail4.SetActive(false);
        mail5.SetActive(false);
        mail6.SetActive(false);
        mail7.SetActive(false);
        mail8.SetActive(false);
        mail9.SetActive(false);
        ReinitPass.SetActive(true);
    }
}
