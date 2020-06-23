using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int whoseTurn; //0 = X & 1 = O
    public int turnCount; //Telt het aantal nummers
    public GameObject[] turnIcons; //laat zien wiens turn het is
    public Sprite[] playerIcons; //0 = X & 1 = O
    public Button[] tictactoeSpaces; //de speelbare velden
    public int[] markedSpaces; //welke plek was getekend door welke speler
    public Text winnerText; //inhoud van de text die de winnar laat zien
    public GameObject[] winningLines; //alle winlijnen staan hierin
    public GameObject winnerPanel; //paneel dat aan voor de knoppen komt zodat je niet meer op ze kan klikken
    public int xPlayerScore;
    public int oPlayerScore;
    public Text xPlayerScoreText;
    public Text oPlayerScoreText;


    // Start is called before the first frame update
    void Start()
    {
        //initialiseren objecten
        whoseTurn = 0;
        turnCount = 0;
        turnIcons[0].SetActive(true);
        turnIcons[1].SetActive(false);
        for (int i = 0; i < tictactoeSpaces.Length; i++)
        {
            tictactoeSpaces[i].interactable = true;
            tictactoeSpaces[i].GetComponent<Image>().sprite = null;
        }

        for (int i = 0; i < markedSpaces.Length; i++)
        {
            markedSpaces[i] = -100;
        }
    }

    
    public void TicTacToeButton(int WhichNumber)
    {
        tictactoeSpaces[WhichNumber].image.sprite = playerIcons[whoseTurn]; //zet sprite image naar de juiste sprite als de button wordt gebruikt     
        tictactoeSpaces[WhichNumber].interactable = false; //zorgt ervoor dat een knop niet 2 keer gebruikt kan worden

        markedSpaces[WhichNumber] = whoseTurn + 1; //manier om te zien welke speler tekende
        turnCount++; //1 turn gaat verbij


        //WinnerCheck wordt alleen uigevoert als er meer dan 4 beurten gespeeld zijn (dan kan er pas iemand winnen)
        if(turnCount > 4)
        {
            WinnerCheck();
        }

        //if statement dat de juist turnicons aanzet
        if(whoseTurn == 0)
        {
            whoseTurn = 1;
            turnIcons[0].SetActive(false);
            turnIcons[1].SetActive(true);
        }
        else
        {
            whoseTurn = 0;
            turnIcons[0].SetActive(true);
            turnIcons[1].SetActive(false);
        }
    }
    

    void WinnerCheck()
    {
        int s1 = markedSpaces[0] + markedSpaces[1] + markedSpaces[2];
        int s2 = markedSpaces[3] + markedSpaces[4] + markedSpaces[5];
        int s3 = markedSpaces[6] + markedSpaces[7] + markedSpaces[8];
        int s4 = markedSpaces[0] + markedSpaces[3] + markedSpaces[6];
        int s5 = markedSpaces[1] + markedSpaces[4] + markedSpaces[7];
        int s6 = markedSpaces[2] + markedSpaces[5] + markedSpaces[8];
        int s7 = markedSpaces[0] + markedSpaces[4] + markedSpaces[8];
        int s8 = markedSpaces[2] + markedSpaces[4] + markedSpaces[6];
        var solutions = new int[] { s1, s2, s3, s4, s5, s6, s7, s8 };
        for(int i = 0; i < solutions.Length; i++)
        {
            if(solutions[i] == 3 * (whoseTurn + 1)) //if statement dat checked of een speler gewonnen heeft
            {
                Debug.Log("Player " + whoseTurn + "won!");
                WinnerDisplay(i);
                return;
            }
        }
    }

    //functie dat de winner displayed
    void WinnerDisplay(int p)
    {
        winnerPanel.gameObject.SetActive(true); //Paneel word op active gezet zodat de speler niet op de velden kan klikken

        //winnerText geeft aan wie er gewonnen heeft en score gaat omhoog
        if(whoseTurn == 0)
        {
            xPlayerScore++;
            xPlayerScoreText.text = xPlayerScore.ToString();
            winnerText.text = "Player X Wins!";
        }
        else if(whoseTurn == 1)
        {
            oPlayerScore++;
            oPlayerScoreText.text = oPlayerScore.ToString();
            winnerText.text = "Player O Wins!";
        }

        //juiste winningline wordt op active gezet
        winningLines[p].SetActive(true);
    }

    //Functie dat de game reset zodat er opnieuw gespeeld kan worden
    public void Reset()
    {
        Start();
        for (int i = 0; i < winningLines.Length; i++)
        {
            winningLines[i].SetActive(false);
        }
        winnerPanel.SetActive(false);
    }
}
