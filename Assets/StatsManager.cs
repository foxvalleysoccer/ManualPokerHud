using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour
{

    public Text hands;
    public int totalhandsCount = 1;
    private int howManyPlayers = 0;
    private int playerPosition;
    public Text[] playerNameText;
    public Text player1name;
    public List<Player> AllPlayers = new List<Player>();
    public Text Player1Vpip;
    public Text Player1PFR;
    public Text Player1FoldBlinds;
    public Text Player1LimpFold;
    public Text Player1LimpCall;
    public Text Player1FoldToCBet;
    public Text Player1CallCbet;
    public Text TotalHandsTextBox;

    public GameObject addplayer;
    public GameObject removeplayer;

    public void Start()
    {
        removeplayer.SetActive(false);
    }
    public void ToggleAddRemoveButton()
    {
        if (removeplayer.activeSelf == false)
        {
            addplayer.SetActive(false);
            removeplayer.SetActive(true);
        }
        else
        {
            addplayer.SetActive(true);
            removeplayer.SetActive(false);
        }
    }

    public void Incrimenthands()
    {
        totalhandsCount += 1;
        hands.text = "Totalhands= " + totalhandsCount.ToString();

        //Incriment total hands played by all players
        AddHandToCurrentPlayers();
       // AdjustAllPlayersStats();
    }

    private void AdjustAllPlayersStats()
    {
       
    }

    public void AddHandToCurrentPlayers()
    {
        foreach (Player player in AllPlayers)
        {
            player.TotalHandsPlayed += 1;
        }

    }
    public void AddPlayer(int position)
    {
        howManyPlayers++;
        Player pl = new Player();
        pl.Name = player1name.text + howManyPlayers;
        pl.LimpCall = 0;
        pl.LimpFoldPercent = 0;
        pl.VPIPPercent = 0;
        pl.FoldBlindsCount = 0;
        pl.TotalHandsPlayed = 1;
        pl.PreFlopRaiseCount = 0;
        AllPlayers.Add(pl);
        ToggleAddRemoveButton();
    }
    public void RemovePlayer(int position)
    {
        AllPlayers.RemoveAt(position);

        //Clear out data in text boxes
        ClearDataFromScreen(position);
        //Call some function to Save that players data for future

        ToggleAddRemoveButton();
    }
    public void CalculateVPIP(int playerNumber)
    {
        Player curentplayer = AllPlayers[playerNumber];
        curentplayer.VPIPCount += 1;
        curentplayer.VPIPPercent = curentplayer.VPIPCount / curentplayer.TotalHandsPlayed * 100;
        UpdatePlayersStats(playerNumber);
    }
    public void CalculatePFR(int playerNumber)
    {
        Player curentplayer = AllPlayers[playerNumber];
        curentplayer.PreFlopRaiseCount += 1;
        curentplayer.PreFlopRaisePercent = curentplayer.PreFlopRaiseCount / curentplayer.TotalHandsPlayed * 100.0f;
        UpdatePlayersStats(playerNumber);
    }
    public void CalculateFoldBlinds(int playerNumber)
    {
        Player curentplayer = AllPlayers[playerNumber];
        curentplayer.FoldBlindsCount += 1;
        curentplayer.PreFlopRaisePercent = curentplayer.PreFlopRaiseCount / curentplayer.TotalHandsPlayed * 100;
        UpdatePlayersStats(playerNumber);
    }
    public void CalculateLimpFold(int playerNumber)
    {
        Player currentplayer = AllPlayers[playerNumber];
        currentplayer.LimpFoldCount += 1;
        currentplayer.LimpFoldPercent = currentplayer.LimpFoldCount / currentplayer.TotalHandsPlayed*100;
        UpdatePlayersStats(playerNumber);
    }
    public void FoldToCbet(int playerNumber)
    {
        Player currentplayer = AllPlayers[playerNumber];
        currentplayer.FoldToCBetCount += 1;
        UpdatePlayersStats(playerNumber);
    }
    public void LimpFoldCount(int playerNumber)
    {
        Player currentplayer = AllPlayers[playerNumber];
        currentplayer.LimpFoldCount += 1;
        UpdatePlayersStats(playerNumber);
    }
    public void CallCbet(int playerNumber)
    {
        Player currentplayer = AllPlayers[playerNumber];
        currentplayer.CallCbetCount += 1;
        UpdatePlayersStats(playerNumber);
    }
    public void UpdatePlayersStats(int playerNumber)
    {
        //For each player update the stats?
        Player curentplayer = AllPlayers[playerNumber];
        Player1PFR.text = curentplayer.PreFlopRaisePercent.ToString();
        Player1Vpip.text = curentplayer.VPIPPercent.ToString();
        Player1FoldBlinds.text = curentplayer.FoldBlindsCount.ToString();
        Player1LimpFold.text = curentplayer.LimpFoldCount.ToString();
        Player1FoldToCBet.text = curentplayer.FoldToCBetCount.ToString();
        Player1CallCbet.text = curentplayer.CallCbetCount.ToString();
        TotalHandsTextBox.text = curentplayer.TotalHandsPlayed.ToString();
    }
    public void ClearDataFromScreen(int playerNumber)
    {
        Player1PFR.text = "";
        Player1Vpip.text = "";
        Player1FoldBlinds.text = "";
        Player1LimpFold.text = "";
        Player1FoldToCBet.text = "";
        Player1CallCbet.text = "";
        TotalHandsTextBox.text = "";
        
        player1name.text = "";
    }
}
public class Player
{
    public string Name;

    public float TotalHandsPlayed;

    public float VPIPPercent;
    public float VPIPCount;

    public float LimpFoldPercent;
    public float LimpFoldCount;
    public float LimpCounnt;

    public float FoldToCBetCount;
    public float CallCbetCount;

    public float LimpCall;

    public float FoldBlindsPercent;
    public float FoldBlindsCount;

    public float PreFlopRaisePercent;
    public float PreFlopRaiseCount;


}