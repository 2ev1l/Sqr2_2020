using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonSounds : MonoBehaviour, IPointerEnterHandler, ISelectHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Msounds4.soundData4.Play();
    }

    public void OnSelect(BaseEventData eventData)
    {
        Msounds3.soundData3.Play();
    }
}
