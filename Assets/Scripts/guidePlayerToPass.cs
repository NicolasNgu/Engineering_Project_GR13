using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidePlayerToPass : MonoBehaviour
{
    [SerializeField] private GameObject panneauPass;
    [SerializeField] private Compass compass;
    [SerializeField] private GameObject sms;
    [SerializeField] private AudioSource ding;

    public void panneauActivation()
    {
        panneauPass.SetActive(true);
        compass.target = panneauPass.transform;
        sms.SetActive(true);
        ding.Play();
        
    }
}
