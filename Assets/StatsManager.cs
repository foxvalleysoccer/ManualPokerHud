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

    public GameObject player0;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    public GameObject player6;
    public GameObject player7;
    public GameObject player8;
    public void Start()
    {
        removeplayer.SetActive(false);
        hands.text = "Total Hands 1";
    }


    public void Incrimenthands()
    {
        totalhandsCount += 1;
        hands.text = "Total Hands= " + totalhandsCount.ToString();

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
        AllPlayers.Insert(position,pl);

    }
    public void RemovePlayer(int position)
    {


        //Clear out data in text boxes
        ClearDataFromScreen(position);
        //Call some function to Save that players data for future
       AllPlayers.RemoveAt(position);

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
        //If i PFL I also VPIP
        CalculateVPIP(playerNumber);
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
        currentplayer.LimpFoldPercent = currentplayer.LimpFoldCount / currentplayer.TotalHandsPlayed * 100;
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

        if (playerNumber == 0)
        {
            player0.GetComponent<UpdateMyTextFields>().UpdateTextFieldsPlease(curentplayer);
        }
        else if (playerNumber == 1)
        {
            player1.GetComponent<UpdateMyTextFields>().UpdateTextFieldsPlease(curentplayer);
        }
        else if (playerNumber == 2)
        {
            player2.GetComponent<UpdateMyTextFields>().UpdateTextFieldsPlease(curentplayer);
        }
        else if (playerNumber == 3)
        {
            player3.GetComponent<UpdateMyTextFields>().UpdateTextFieldsPlease(curentplayer);
        }
        else if (playerNumber == 4)
        {
            player4.GetComponent<UpdateMyTextFields>().UpdateTextFieldsPlease(curentplayer);
        }
        else if (playerNumber == 5)
        {
            player5.GetComponent<UpdateMyTextFields>().UpdateTextFieldsPlease(curentplayer);
        }
        else if (playerNumber == 6)
        {
            player6.GetComponent<UpdateMyTextFields>().UpdateTextFieldsPlease(curentplayer);
        }
        else if (playerNumber == 7)
        {
            player7.GetComponent<UpdateMyTextFields>().UpdateTextFieldsPlease(curentplayer);
        }
        else if (playerNumber == 8)
        {
            player8.GetComponent<UpdateMyTextFields>().UpdateTextFieldsPlease(curentplayer);
        }
    }
    public void ClearDataFromScreen(int playerNumber)
    {
        //Fix this
        Player1PFR.text = "";
        Player1Vpip.text = "";
        Player1FoldBlinds.text = "";
        Player1LimpFold.text = "";
        Player1FoldToCBet.text = "";
        Player1CallCbet.text = "";
        TotalHandsTextBox.text = "";

        player1name.text = "";
    }
    public Player GetAPlayer(int playerNumber)
    {
        var pl = AllPlayers[playerNumber];
        return new Player();
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