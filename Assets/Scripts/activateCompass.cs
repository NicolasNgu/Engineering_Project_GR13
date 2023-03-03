using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateCompass : MonoBehaviour
{

    public GameObject hand; 
    public GameObject CompassApp;

    public GameObject watchScreen;

    public bool isCompass;
    // Start is called before the first frame update
    void Start()
    {
        isCompass = false;
        watchScreen.GetComponent<watchManager>().Compass.SetActive(isCompass);

    }

    // Update is called once per frame
    void Update()
    {
        watchScreen.GetComponent<watchManager>().Compass.SetActive(isCompass);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == hand)
        {

            isCompass = !isCompass;
            watchScreen.GetComponent<watchManager>().Compass.SetActive(isCompass);
           //watchScreen.GetComponent<watchManager>().screenRenderer.enabled = !watchScreen.GetComponent<watchManager>().screenRenderer.enabled;
           watchScreen.GetComponent<watchManager>().isLit = !watchScreen.GetComponent<watchManager>().isLit;
            
         
            Debug.Log("app touché");
        }
    }
}
