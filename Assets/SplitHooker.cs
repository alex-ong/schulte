using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class SplitHooker : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private List<float> times = null;
    private SplitViewer splitViewer = null;

    public void Init(SplitViewer s, List<float> times)
    {
        this.times = new List<float>(times);
        this.splitViewer = s;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        splitViewer.gameObject.SetActive(true);
        splitViewer.Show(this.times);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        splitViewer.gameObject.SetActive(false);
    }
}
