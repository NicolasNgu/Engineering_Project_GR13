using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterScript : MonoBehaviour
{
    [SerializeField] private GameObject _consigne1;
    [SerializeField] private Animator _consigneAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _consigneAnimator = _consigne1.GetComponent<Animator>();
            _consigneAnimator.Play("Printing");
        }
    }

}
