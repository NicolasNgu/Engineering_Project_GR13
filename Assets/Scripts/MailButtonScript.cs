using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject _ecranMail;
    public bool mailIsLit;

    // Start is called before the first frame update
    void Start()
    {
        mailIsLit = false;
        _ecranMail.SetActive(mailIsLit);
    }

    public void toggleMail(){
        mailIsLit = !mailIsLit;
        _ecranMail.SetActive(mailIsLit);
    }

}
