using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMyTextFields : MonoBehaviour
{
    public Text totalHands;
    public Text Vpip;
    public Text PFR;
    public Text foldBlinds;
    public Text LimpFold;
    public Text foldToCbet;
    public Text callCbet;

    public void UpdateTextFields(Player player)
    {
        totalHands.text = player.TotalHandsPlayed.ToString();
        Vpip.text = player.VPIPPercent.ToString();
        PFR.text = player.PreFlopRaisePercent.ToString();
        LimpFold.text = player.LimpFoldCount.ToString();
        foldBlinds.text = player.FoldBlindsCount.ToString();
        foldToCbet.text = player.FoldToCBetCount.ToString();
        callCbet.text = player.CallCbetCount.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
