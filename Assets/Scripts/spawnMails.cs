using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class spawnMails : MonoBehaviour
{
    // True mails
    [SerializeField] private GameObject content;
    [SerializeField] private GameObject _truePass;
    [SerializeField] private GameObject _trueLink;
    [SerializeField] private GameObject _truePj;

    // Fake mails
    [SerializeField] private GameObject _fakeMailPass1;
    [SerializeField] private GameObject _fakeMailPass2;
    [SerializeField] private GameObject _fakeMailPj1;
    [SerializeField] private GameObject _fakeMailPj2;
    [SerializeField] private GameObject _fakeMailLink1;
    [SerializeField] private GameObject _fakeMailLink2;

    // Lists of mails
    [SerializeField] List<GameObject> listeTrueMails = new List<GameObject>(); // list of true mails
    [SerializeField] List<GameObject> listeFakePassMails = new List<GameObject>(); // list of fake pass mails
    [SerializeField] List<GameObject> listeFakeLinkMails = new List<GameObject>(); // list of fake link mails
    [SerializeField] List<GameObject> listeFakePjMails = new List<GameObject>(); // list of fake pj mails

    void Start()
    {
        _truePass.SetActive(false);
        _trueLink.SetActive(false);
        _truePj.SetActive(false);
        _fakeMailPass1.SetActive(false);
        _fakeMailPass2.SetActive(false);
        _fakeMailPj1.SetActive(false);
        _fakeMailPj2.SetActive(false);
        _fakeMailLink1.SetActive(false);
        _fakeMailLink2.SetActive(false);
        //set one true and two fake random mails to true
        listeTrueMails.Add(_trueLink);   // adding mails tos lists for shuffle
        listeTrueMails.Add(_truePass);
        listeTrueMails.Add(_truePj);

        listeFakeLinkMails.Add(_fakeMailLink1);
        listeFakeLinkMails.Add(_fakeMailLink2);
        listeFakePassMails.Add(_fakeMailPass1);
        listeFakePassMails.Add(_fakeMailPass2);
        listeFakePjMails.Add(_fakeMailPj1);
        listeFakePjMails.Add(_fakeMailPj2);

        ShuffleMails(listeTrueMails, listeFakeLinkMails, listeFakePassMails, listeFakePjMails);
    }

    private void ShuffleMails(List<GameObject> listeTrueMails, List<GameObject> listeFakeLinkMails, List<GameObject> listeFakePassMails, List<GameObject> listeFakePjMails)
    {
        int randomTrue; //random number between 0 and 2 that will randomly choose the good mail
        int randomFake1; //random number between 0 and 2 that will randomly choose the scam mail
        int randomFake2;
        int randomFakeList1; //random number that will choose the first list of fake mails to be used
        int randomFakeList2;  // same but for the second list of mails

        List<List<GameObject>> listFakeMails = new List<List<GameObject>>();
        List<GameObject> fakeMailsUsed = new List<GameObject>(); //fake mails in this list will be activated 

        listFakeMails.Add(listeFakeLinkMails);
        listFakeMails.Add(listeFakePjMails);
        listFakeMails.Add(listeFakePassMails);      //adding all lists of fake mails to a unique list

        Random random = new Random();
        randomTrue = random.Next(0, 3);

        randomFake1 = random.Next(0, 2);
        randomFake2 = random.Next(0, 2);

        randomFakeList1 = random.Next(0, 3); // Generates a random index between 0 and 2
        do
        {
            randomFakeList2 = random.Next(0, 3); // Generates another random index
        } while (randomFakeList1 == randomFakeList2); // Make sure that index2 is different from index1


        //set one true and two fake random mails to true

        listeTrueMails[randomTrue].SetActive(true);

        listFakeMails[randomFakeList1][randomFake1].SetActive(true);
        listFakeMails[randomFakeList2][randomFake2].SetActive(true);
    }
}
