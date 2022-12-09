using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonImprimante : MonoBehaviour
{
    [SerializeField] private AudioSource _sonImprimante;
    [SerializeField] private GameObject _imprimante;
     [SerializeField] private GameObject _consignes;

    // Start is called before the first frame update
    void Start()
    {
        _consignes.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Printing()
    {
        
        _sonImprimante = _imprimante.GetComponent<AudioSource>();
        _sonImprimante.Play();
        
        
    }

      public void ConsignesApparition(){
        _consignes.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
