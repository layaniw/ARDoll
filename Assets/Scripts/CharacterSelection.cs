using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{

    private GameObject[] characterList;
    private int index;
    public GameObject characterSelectionPanel;
    public GameObject menuPanel;


    void Start()
    {

        index = PlayerPrefs.GetInt("CharacterSelected");
        characterList = new GameObject[transform.childCount];

        // Array with characters
        for(int i=0; i<transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }
        // set inactive at the start
        foreach (GameObject go in characterList)
            go.SetActive(false);

        //toggle on selected character
        if (characterList[index])
            characterList[index].SetActive(true);
    }

    public void ToggleRight()
    {
        //Toggle off the current character
        characterList[index].SetActive(false);

        index++;
        if (index == characterList.Length)
            index = 0;

        //Toggle on new character
        characterList[index].SetActive(true);
    }

    public void ToggleLeft()
    {

        //Toggle off the current character
        characterList[index].SetActive(false);

        index--;
        if (index < 0)
            index = characterList.Length - 1;

        //Toggle on new character
        characterList[index].SetActive(true);
    }

    public void Confirm()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        Debug.Log(index);
        characterSelectionPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
