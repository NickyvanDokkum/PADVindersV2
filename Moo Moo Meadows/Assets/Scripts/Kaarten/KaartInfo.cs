﻿using UnityEngine;
using UnityEngine.UI;

public class KaartInfo : MonoBehaviour
{
    //kaart info
    private string[] kaarten = new string[] { "kaart1", "kaart2", "kaart3", "kaart4", "kaart5" };
    public int kaartID;
    [SerializeField] private Text titel;
    [SerializeField] private Text omschrijving;
    public static string eventnaam;

    public static int GetCardAmount() //functie die ervoor zorgt dat de array van kaarten altijd de juiste hoeveelheid heeft
    {
        switch (eventnaam)
        {
            //HUIS KAARTEN
            case "Damages to your maintenance":
                return 4;
            case "Rent Increase":
                return 4;
            case "Keys":
                return 4;
            case "Rude invitation":
                return 5;
        }

        return 0;
    }
    public void KaartGegevens(string kaartnaam) //zorgt er dmv switch statements voor dat de text op kaarten wordt veranderd
    {
        switch (eventnaam)
        {
            //HUIS KAARTEN
            case "Damages to your maintenance":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Pay up";
                        omschrijving.text = "pay for the repairs";
                        break;
                    case "kaart2":
                        titel.text = "Not your problem";
                        omschrijving.text = "Demand your landlord to pay for this";
                        break;
                    case "kaart3":
                        titel.text = "Contract";
                        omschrijving.text = "In your contract it says repairs in your house will be compensated";
                        break;
                    case "kaart4":
                        titel.text = "Contract";
                        omschrijving.text = "In your contract it says big maintenance repairs will be compensated";
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
            case "Rent Increase":
                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Nothing";
                        omschrijving.text = "Dont do anything";
                        this.GetComponent<CardStats>().money = 10;
                        break;
                    case "kaart2":
                        titel.text = "Justice";
                        omschrijving.text = "Call the Rent Tribunal";
                        break;
                    case "kaart3":
                        titel.text = "Contract";
                        omschrijving.text = "In your contract it says Landlords can only increase the rent once every year";
                        break;
                    case "kaart4":
                        titel.text = "No thank you";
                        omschrijving.text = "Decline the advancement";
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
              case "Keys":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Pay";
                        omschrijving.text = "Pay your landlord";
                        break;
                    case "kaart2":
                        titel.text = "Another way";
                        omschrijving.text = "Buy new keys from a keymaker";
                        break;
                    case "kaart3":
                        titel.text = "Contract";
                        omschrijving.text = "In your contract it says the costs are compensated ";
                        break;
                    case "kaart4":
                        titel.text = "Sleepover";
                        omschrijving.text = "Ask a friend if you can sleep over for now";
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
            case "Rude invitation":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Nothing";
                        omschrijving.text = "let him enter, as long as he doesnt break anything";
                        break;
                    case "kaart2":
                        titel.text = "Who you gonna call?";
                        omschrijving.text = "Call the police, this is a legitimate crime";
                        break;
                    case "kaart3":
                        titel.text = "Dont open!";
                        omschrijving.text = "Tell him he cant enter because you are naked";
                        break;
                    case "kaart4":
                        titel.text = "Contract";
                        omschrijving.text = "Tell him there is no written agreement for allowing your landlord to always come in, then send him out";
                        break;
                    case "kaart5":
                        titel.text = "No thank you";
                        omschrijving.text = "In your contract it says you can decline his entrance, hope it works...";
                        break;
                }
                break;
        }

    }

    void Update()
    {
        KaartGegevens(kaarten[kaartID]);  //kaartID zorgt ervoor dat specifieke text uit Kaartgegevens wordt aangeroepen
    }

}
