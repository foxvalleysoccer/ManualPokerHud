using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddRemoveButtons : MonoBehaviour
{
    public GameObject addPlayer;
    public GameObject removePlayer;
    public GameObject textarea;
   //ublic Text playerName;
  //public Text inputplayerText;
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
           //extarea.SetActive(false);
          //playerName.text = inputplayerText.text;
        }
        else
        {
            this.removePlayer.SetActive(false);
            this.addPlayer.SetActive(true);
           //extarea.SetActive(true);
           //layerName.text = "";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
