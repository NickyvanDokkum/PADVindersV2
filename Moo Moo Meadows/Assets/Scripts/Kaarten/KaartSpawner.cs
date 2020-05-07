using UnityEngine;

public class KaartSpawner : MonoBehaviour
{
    public GameObject baseKaart;
    private GameObject[] meerdereKaarten = new GameObject[2];
    [SerializeField] public Transform hand;

    void Start()
    {
        KaartInfo.eventnaam = "bbb"; //selecteert een event
        meerdereKaarten = new GameObject[KaartInfo.GetCardAmount()]; //zet de array naar de hoeveelheid kaart die in de GetCardAmount() functie word aangegeven
        for (int eventKaartAmount = 0; eventKaartAmount < meerdereKaarten.Length; eventKaartAmount++)
        {
            GameObject objekkie = Instantiate(baseKaart, new Vector3(0, 0, 0), Quaternion.identity, hand);  //spawnt kaarten in de hand
            objekkie.GetComponent<KaartInfo>().kaartID = eventKaartAmount; //zorgt ervoor dat de juiste kaartinfo wordt weergeven op de kaarten
            meerdereKaarten[eventKaartAmount] = objekkie; //zorgt ervoor dat de juiste hoeveelheid kaarten wordt gespawned
        }

    }
}
