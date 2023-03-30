using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class gagne : MonoBehaviour
{
    public void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player")
        {
             SceneManager.LoadScene("win");
        }
    }
    // Start is called before the first frame update
}
