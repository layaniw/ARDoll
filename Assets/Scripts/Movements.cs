using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{


    private Animator animator;
    public GameObject characterSelectionPanel;
    public GameObject menuPanel;
    private int index;
    public GameObject characterList;
    private GameObject selectedAnimal;

    // Start is called before the first frame update
    void Start()
    {
       

        

       

        
    }

    
    public void Walk()
    {
        animator.SetBool("isWalk", true);
        Debug.Log("*******");
        Debug.Log(index);
    }
    public void Rotate()
    {
        Debug.Log("");
    }

    public void MakeSounds()
    {
        Debug.Log("");
    }

    public void Eat()
    {
        Debug.Log("");
    }

    public void Chracters()
    {
        Debug.Log("");
        animator.SetBool("isWalk", false);
        menuPanel.SetActive(false);
        characterSelectionPanel.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        selectedAnimal = characterList.transform.GetChild(index).gameObject;
        animator = selectedAnimal.GetComponent<Animator>();
    }
}
