using UnityEngine;
using UnityEngine.EventSystems;

public class dropzone : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " dropped to" + gameObject.name);

        DragDrop d = eventData.pointerDrag.GetComponent<DragDrop>();    //kijkt waar de muis is terwijl een kaart versleept wordt en de component waar die overheen hovert
        if (d != null)
        {
            d.ReturnParent = this.transform;    //zet de parent van een kaart naar de component waar over wordt gehovert via het 'DragDrop' script
        }
    }

}
