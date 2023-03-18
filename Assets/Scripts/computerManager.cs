using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class computerManager : MonoBehaviour
{
    public bool screenIsLit;
    public bool menuIsLit;
    [SerializeField] private GameObject screen;
    [SerializeField] private GameObject menu;

    
    // Start is called before the first frame update
    void Start()
    {
        screenIsLit = true;
        menuIsLit = false;
        screen.SetActive(screenIsLit);
        menu.SetActive(menuIsLit);
    }

    // Update is called once per frame
    void Update()
    {
        screen.SetActive(screenIsLit);
        menu.SetActive(menuIsLit);
    }

    public void AppuiEcran()
    {
        menuIsLit = !menuIsLit;
    }
    public void DeconnecterSession()
    {
        screenIsLit = false;
    }

    public void ConnecterSession()
    {
        screenIsLit = true;
    }


}
