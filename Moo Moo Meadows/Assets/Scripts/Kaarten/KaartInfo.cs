using UnityEngine;
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
            case "Extra service fees":
                return 3;
            case "Noise complaint":
                return 3;
            case "Pet/ abandoned puppy":
                return 4;
            case "Painting":
                return 4;
            case "Pet 2":
                return 4;

            //school kaarten
            case "Flat tire right before school":
                return 4;
            case "School or work":
                return 3;
            case "All-nighter":
                return 4;


            //fun kaarten
            case "Friends":
                return 2;
            case "New game":
                return 2;
            case "Birthday":
                return 3;
            case "New clothes":
                return 2;
            case "Go to the casino":
                return 3;
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
                        this.GetComponent<CardStats>().money = -50;
                        break;
                    case "kaart2":
                        titel.text = "Not your problem";
                        omschrijving.text = "Demand your landlord to pay for this";
                        this.GetComponent<CardStats>().home = -2;
                        this.GetComponent<CardStats>().money = -50;
                        break;
                    case "kaart3":
                        titel.text = "Contract";
                        omschrijving.text = "In your contract it says repairs in your house will be compensated";
                        this.GetComponent<CardStats>().home = +2;
                        break;
                    case "kaart4":
                        titel.text = "Contract";
                        omschrijving.text = "In your contract it says big maintenance repairs will be compensated";
                        this.GetComponent<CardStats>().home = +4;
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
                        this.GetComponent<CardStats>().money = -30;
                        break;
                    case "kaart2":
                        titel.text = "Justice";
                        omschrijving.text = "Call the Rent Tribunal";
                        this.GetComponent<CardStats>().home = +4;
                        break;
                    case "kaart3":
                        titel.text = "Contract";
                        omschrijving.text = "In your contract it says Landlords can only increase the rent once every year";
                        this.GetComponent<CardStats>().home = +2;
                        break;
                    case "kaart4":
                        titel.text = "No thank you";
                        omschrijving.text = "Decline the advancement";
                        this.GetComponent<CardStats>().home = -2;
                        this.GetComponent<CardStats>().money = -10;
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
                        this.GetComponent<CardStats>().money = -20;
                        break;
                    case "kaart2":
                        titel.text = "Another way";
                        omschrijving.text = "Buy new keys from a keymaker";
                        this.GetComponent<CardStats>().money = -40;
                        break;
                    case "kaart3":
                        titel.text = "Contract";
                        omschrijving.text = "In your contract it says the costs are compensated ";
                        this.GetComponent<CardStats>().home = -2;
                        break;
                    case "kaart4":
                        titel.text = "Sleepover";
                        omschrijving.text = "Ask a friend if you can sleep over for now";
                        this.GetComponent<CardStats>().hapiness = +5;
                        this.GetComponent<CardStats>().home = -2;
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
                        this.GetComponent<CardStats>().home = -2;
                        break;
                    case "kaart2":
                        titel.text = "Who you gonna call?";
                        omschrijving.text = "Call the police, this is a legitimate crime";
                        this.GetComponent<CardStats>().home = +4;
                        break;
                    case "kaart3":
                        titel.text = "Dont open!";
                        omschrijving.text = "Tell him he cant enter because you are naked";
                        break;
                    case "kaart4":
                        titel.text = "Contract";
                        omschrijving.text = "Tell him there is no written agreement for allowing your landlord to always come in, then send him out";
                        this.GetComponent<CardStats>().home = +2;
                        break;
                    case "kaart5":
                        titel.text = "No thank you";
                        omschrijving.text = "In your contract it says you can decline his entrance, hope it works...";
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
            case "Extra service fees":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Whatever";
                        omschrijving.text = "Pay the extra service fees";
                        this.GetComponent<CardStats>().home = -30;
                        break;
                    case "kaart2":
                        titel.text = "No is no";
                        omschrijving.text = "Just don't pay any service fees anymore";
                        this.GetComponent<CardStats>().home = -4;
                        break;
                    case "kaart3":
                        titel.text = "Justice";
                        omschrijving.text = "Call the Rent Tribunal";
                        this.GetComponent<CardStats>().home = +4;
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
            case "Noise complaint":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Pay";
                        omschrijving.text = "Just pay it";
                        this.GetComponent<CardStats>().home = -2;
                        this.GetComponent<CardStats>().money = -30;
                        break;
                    case "kaart2":
                        titel.text = "Contract";
                        omschrijving.text = "In your contract it says there are no fees for a noise complaint";
                        this.GetComponent<CardStats>().home = +2;
                        break;
                    case "kaart3":
                        titel.text = "Lie";
                        omschrijving.text = "You weren't home, how will he prove you wrong";
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
            case "Pet/ abandoned puppy":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Bye bye";
                        omschrijving.text = "Send your pet back to your parents house";
                        this.GetComponent<CardStats>().home = +2;
                        this.GetComponent<CardStats>().hapiness = -15;
                        break;
                    case "kaart2":
                        titel.text = "Poor cat";
                        omschrijving.text = "Say you can't leave the pet alone anymore";
                        this.GetComponent<CardStats>().home = -2;
                        this.GetComponent<CardStats>().hapiness = +15;
                        break;
                    case "kaart3":
                        titel.text = "Contract";
                        omschrijving.text = "You can't find anything about this rule in your contract";
                        this.GetComponent<CardStats>().home = +2;
                        break;
                    case "kaart4":
                        titel.text = "Contract";
                        omschrijving.text = "In the contract it says pets are allowed";
                        this.GetComponent<CardStats>().home = +4;
                        break;
                }
                break;
        }

        switch (eventnaam)
        {
            case "Painting":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Not my problem";
                        omschrijving.text = "Leave it there";
                        this.GetComponent<CardStats>().home = -2;
                        break;
                    case "kaart2":
                        titel.text = "Responsible";
                        omschrijving.text = "Pay for the damage";
                        this.GetComponent<CardStats>().home = +2;
                        this.GetComponent<CardStats>().grades = -30;
                        break;
                    case "kaart3":
                        titel.text = "This is for you";
                        omschrijving.text = "Tell your landlord that it will be reimbursed (This is not true)";
                        this.GetComponent<CardStats>().home = -2;

                        break;
                    case "kaart4":
                        titel.text = "Handyman";
                        omschrijving.text = "Paint it yourself";
                        this.GetComponent<CardStats>().money = -20;
                        this.GetComponent<CardStats>().home = +10;
                        break;
                }
                break;
        }

        switch (eventnaam)
        {
            case "Pet 2":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "If it's for mr. bubbles";
                        omschrijving.text = "Pay the fee";
                        break;
                    case "kaart2":
                        titel.text = "No";
                        omschrijving.text = "Don't pay";
                        break;
                    case "kaart3":
                        titel.text = "What rule?";
                        omschrijving.text = "Say you can't find anything back in the contract about this fee";
                        break;
                    case "kaart4":
                        titel.text = "Threaten";
                        omschrijving.text = "(If your level is high enough) This is against the law, and you could file a complaint about this";
                        break;
                }
                break;
        }

        //SCHOOL KAARTEN
        switch (eventnaam)
        {
            case "Flat tire right before school":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Handyman";
                        omschrijving.text = "Repair it yourself";
                        this.GetComponent<CardStats>().grades = +5;
                        break;
                    case "kaart2":
                        titel.text = "Lifesaver";
                        omschrijving.text = "Find a shop that can fix your bike";
                        this.GetComponent<CardStats>().grades = +10;
                        break;
                    case "kaart3":
                        titel.text = "Social powers";
                        omschrijving.text = "Ask your neighbours if they have a bike you can borrow";
                        this.GetComponent<CardStats>().hapiness = +5;
                        this.GetComponent<CardStats>().grades = -5;
                        break;
                    case "kaart4":
                        titel.text = "Whatever";
                        omschrijving.text = "Be late for class/skip the class";
                        this.GetComponent<CardStats>().hapiness = +15;
                        this.GetComponent<CardStats>().grades = -10;
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
            case "School or work":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Work";
                        omschrijving.text = "go to work";
                        break;
                    case "kaart2":
                        titel.text = "School";
                        omschrijving.text = "go to school";
                        break;
                    case "kaart3":
                        titel.text = "Multitasker";
                        omschrijving.text = "be late for work";
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
            case "All-nighter":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Bye bye";
                        omschrijving.text = "Make your friends leave";
                        break;
                    case "kaart2":
                        titel.text = "You liar";
                        omschrijving.text = "Tell your landlord there is no such rule in your contract";
                        break;
                    case "kaart3":
                        titel.text = "Bribe";
                        omschrijving.text = "Pay the fine, and your friends can stay this time";
                        break;
                    case "kaart4":
                        titel.text = "Guests";
                        omschrijving.text = "Your contract doesn't say you can't have people visit and/or sleep over";
                        break;
                }
                break;
        }

        //fun kaarten

        switch (eventnaam)
        {
            case "Friends":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Go";
                        omschrijving.text = "Go out with our friends";
                        break;
                    case "kaart2":
                        titel.text = "Don't go";
                        omschrijving.text = "Don't go out with your friends";
                        break;
                }
                break;
        }

        switch (eventnaam)
        {
            case "New game":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Buy";
                        omschrijving.text = "Buy the new game";
                        break;
                    case "kaart2":
                        titel.text = "Don't buy";
                        omschrijving.text = "Don't buy the new game";
                        break;
                }
                break;
        }

        switch (eventnaam)
        {
            case "Birthday":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Go out";
                        omschrijving.text = "Go out";
                        break;
                    case "kaart2":
                        titel.text = "Buy";
                        omschrijving.text = "Buy something nice";
                        break;
                    case "kaart3":
                        titel.text = "Just another day";
                        omschrijving.text = "Don't do anything";
                        break;
                }
                break;
        }

        switch (eventnaam)
        {
            case "New clothes":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Buy";
                        omschrijving.text = "Buy new clothes";
                        break;
                    case "kaart2":
                        titel.text = "Don't buy";
                        omschrijving.text = "Don't buy new clothes";
                        break;
                }
                break;
        }

        switch (eventnaam)
        {
            case "Go to the casino":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "Don't go";
                        omschrijving.text = "Don't go to the casino";
                        break;
                    case "kaart2":
                        //hier moet nog iets aan gedaan worden
                        titel.text = "Luck is by my side";
                        omschrijving.text = "Go (random: win)";
                        break;
                    case "kaart3":
                        titel.text = "Luck is by my side";
                        omschrijving.text = "Go (random:lose)";
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
