using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ClickableButton : MonoBehaviour, IPointerClickHandler
{
    private Action<int> OnClick;

    private int id = 0;
    [SerializeField] private Text label = null;

    public void Setup(int id, Action<int> callback)
    {
        this.id = id;
        label.text = id.ToString();
        OnClick += callback;        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick(id);
    }

}
