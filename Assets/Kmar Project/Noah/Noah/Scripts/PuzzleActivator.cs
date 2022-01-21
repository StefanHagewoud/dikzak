using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleActivator : MonoBehaviour
{
    public bool isSolved;

    public GameObject puzzleUI;
    public GameObject pressECanvas;
    public GameObject thisPuzzleManager;
    public GameObject door;
    public GameObject lockObj;
    private GameObject player;

    [Header("Sort Puzzle")]
    public bool sleutel;
    public bool knop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pressECanvas.activeInHierarchy == true && Input.GetKeyDown(KeyCode.E))
        {
            pressECanvas.SetActive(false);
            puzzleUI.SetActive(true);

            if(sleutel == true)
            {
                for (int i = 0; i <= puzzleUI.GetComponent<KeySystem>().keys.Count - 1; i++)
                {
                    puzzleUI.GetComponent<KeySystem>().keys[i].GetComponent<Key>().puzzleActivator = thisPuzzleManager;
                }
            }
            if(knop == true)
            {
                puzzleUI.GetComponent<ButtonSystem>().puzzleActivator = thisPuzzleManager;
            }
        }

        if(isSolved == true)
        {
            puzzleUI.SetActive(false);
            pressECanvas.SetActive(false);
            door.SetActive(false);
            lockObj.SetActive(false);
            player.GetComponent<PlayerController>().equippedGun.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(isSolved == false)
            {
                pressECanvas.SetActive(true);
                other.GetComponent<PlayerController>().equippedGun.SetActive(false);

                player = other.gameObject;
            }
        }
    }
    public void OnTriggerExit(Collider other)
    {
        pressECanvas.SetActive(false);
        puzzleUI.SetActive(false);
        other.GetComponent<PlayerController>().equippedGun.SetActive(true);
    }

}
