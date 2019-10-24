using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRemoveButtons : MonoBehaviour
{
    public GameObject addPlayer;
    public GameObject removePlayer;
    // Start is called before the first frame update
    void Start()
    {
        removePlayer.SetActive(false);
    }

    public void ToggleButtons(bool isAddPlayerShowing)
    {
        if (isAddPlayerShowing)
        {
            this.removePlayer.SetActive(true);
            this.addPlayer.SetActive(false);
        }
        else
        {
            this.removePlayer.SetActive(false);
            this.addPlayer.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
