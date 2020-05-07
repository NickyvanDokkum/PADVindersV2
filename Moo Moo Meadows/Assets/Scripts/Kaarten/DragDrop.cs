using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [System.NonSerialized] public Transform ReturnParent = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");

        ReturnParent = this.transform.parent;   //slaat de huidige parent van de kaart op
        this.transform.SetParent(this.transform.parent.parent);
        //turns off raycasts zodat de de kaart niet de muisfunctionaliteit blokkeert
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //zet de kaartpositie naar de muispositie
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        //zet een nieuwe parent voor een kaart, als deze niet veranderd wordt in het 'dropzone' script wordt deze weer teruggezet naar de parent die eerder is opgeslagen
        this.transform.SetParent(ReturnParent);
        //zet de raycasts weer aan zodat de kaart weer geselecteerd kan worden
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        if (ReturnParent.tag != "Player") {
            Debug.Log(this.gameObject.name);
            CardStats[] cardStats = GetComponentsInChildren<CardStats>();
            EventController.eventController.PlayCard(cardStats);
        }
    }
}
