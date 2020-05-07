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
            case "aaa":
                return 2;
            case "bbb":
                return 4;
        }

        return 0;
    }
    public void KaartGegevens(string kaartnaam) //zorgt er dmv switch statements voor dat de text op kaarten wordt veranderd
    {
        switch (eventnaam)
        {
            case "aaa":

                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "111111111";
                        omschrijving.text = "1111111111111";
                        break;
                    case "kaart2":
                        titel.text = "22222";
                        omschrijving.text = "6969696969696969";
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
            case "bbb":
                switch (kaartnaam)
                {
                    case "kaart1":
                        titel.text = "123123";
                        omschrijving.text = "11111111231232111111";
                        break;
                    case "kaart2":
                        titel.text = "1231223";
                        omschrijving.text = "12312";
                        break;
                    case "kaart3":
                        titel.text = "123asgdsagd123";
                        omschrijving.text = "11111111231asdgd232111111";
                        break;
                    case "kaart4":
                        titel.text = "123sadggdsa1223";
                        omschrijving.text = "sadgsadg";
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
