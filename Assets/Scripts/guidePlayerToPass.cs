using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidePlayerToPass : MonoBehaviour
{
    [SerializeField] private GameObject panneauPass;
    [SerializeField] private Compass compass;

    public void panneauActivation()
    {
        panneauPass.SetActive(true);
        compass.target = panneauPass.transform;
        
    }
}
