using UnityEngine;
using TMPro;
using System.Collections;

public class AutoType : MonoBehaviour
{

    public float letterPause = 0.2f;
    public AudioClip sound;

    private string message;
    private TMP_Text textComp;

    void Start()
    {
        message = GetComponent<TMP_Text>().text;
        GetComponent<TMP_Text>().text = "";
        textComp = GetComponent<TMP_Text>();
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            textComp.text += letter;

            if (sound)
            {
                GetComponent<AudioSource>().PlayOneShot(sound);
            }

            yield return new WaitForSeconds(letterPause);
        }
    }
}
