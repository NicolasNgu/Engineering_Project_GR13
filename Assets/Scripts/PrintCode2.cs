using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintCode2 : MonoBehaviour
{
    [SerializeField] private GameObject code2;
    public void printBerCode()
    {
        code2.SetActive(true);
    }
}
