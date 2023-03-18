using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver1Manager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject player;
    [SerializeField] private bool isGameOver1;
    [SerializeField] private computerManager computer;
    void Start()
    {
        isGameOver1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit() 
    {
        isGameOver1 = true;

        if (computer.screenIsLit)
        {
            Debug.Log("game over 1");
            Debug.Log("isGameOver1 :" + isGameOver1 );
        }
        
    }
}
