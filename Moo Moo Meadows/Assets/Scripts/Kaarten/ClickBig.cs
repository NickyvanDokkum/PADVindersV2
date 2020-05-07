using UnityEngine;
using UnityEngine.EventSystems;

public class ClickBig : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector2 middle;
    GameObject gezoomdeKaart;

    public void OnPointerEnter(PointerEventData eventData)
    {
        gezoomdeKaart = Instantiate(gameObject, new Vector2(Screen.width / 2, Screen.height / 2), transform.rotation, transform.parent.parent);   //maakt een cloon van de kaart waar overheen wordt gehovert en zet zijn positie naar het midden van het scherm
        gezoomdeKaart.transform.localScale = new Vector2(2, 2);     //vergroot de geclonede kaart en tekst zodat het goed leesbaar is
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Destroy(gezoomdeKaart);     //verwijdert de geclonede kaart wanneer je niet meer over de basiskaart hovert
    }
}
