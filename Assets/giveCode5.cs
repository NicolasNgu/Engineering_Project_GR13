using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveCode5 : MonoBehaviour
{
    [SerializeField] private GameObject code5;

    public void printCode5()
    {
        code5.SetActive(true);
    }
}
