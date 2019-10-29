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
    public int playerNubmer;
    public StatsManager sM;
    public void UpdateTextFieldsPlease(Player player)
    {
        totalHands.text = player.TotalHandsPlayed.ToString();
        Vpip.text = player.VPIPPercent.ToString();
        PFR.text = player.PreFlopRaisePercent.ToString();
        LimpFold.text = player.LimpFoldCount.ToString();
        foldBlinds.text = player.FoldBlindsCount.ToString();
        foldToCbet.text = player.FoldToCBetCount.ToString();
        callCbet.text = player.CallCbetCount.ToString();
    }
    public void ChangeMyTextFields()
    {
        Player player = sM.GetAPlayer(playerNubmer);
        totalHands.text = player.TotalHandsPlayed.ToString();
        Vpip.text = player.VPIPPercent.ToString();
        PFR.text = player.PreFlopRaisePercent.ToString();
        LimpFold.text = player.LimpFoldCount.ToString();
        foldBlinds.text = player.FoldBlindsCount.ToString();
        foldToCbet.text = player.FoldToCBetCount.ToString();
        callCbet.text = player.CallCbetCount.ToString();
    }
    public void ClearMyTextFields()
    {
        totalHands.text = "";
        Vpip.text = "";
        PFR.text = "";
        LimpFold.text = "";
        foldBlinds.text = "";
        foldToCbet.text = "";
        callCbet.text = "";
    }
}
