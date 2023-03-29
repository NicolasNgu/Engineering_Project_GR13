using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messagesManager : MonoBehaviour
{
    // Start is called before the first frame update

    public void afficherMessageSuivant(GameObject MessageSuivant){
        MessageSuivant.SetActive(true);
    }

    public void desactiverMessageCourant(GameObject messageCourant)
    {
        messageCourant.SetActive(false);
        Debug.Log("dza");
    }
  
}
