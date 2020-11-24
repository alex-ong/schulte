using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Split : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image bar = null;
    [SerializeField] private Text text = null;
    [SerializeField] private Text index = null;

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.gameObject.SetActive(false);
    }

    public void Setup(float time, float maxTime, float index)
    {
        text.text = time.ToString("0.00");
        SetPerc(time / maxTime);
        this.index.text = index % 5 == 0 ? index.ToString() : "";
    }

    private void SetPerc(float perc)
    {
        RectTransform rt = this.bar.rectTransform;
        rt.anchorMin = new Vector2(0f, 0f);
        rt.anchorMax = new Vector2(1f, perc);
        rt.sizeDelta = Vector2.zero;
    }
    
}
