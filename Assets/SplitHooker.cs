using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class SplitHooker : MonoBehaviour, IPointerEnterHandler
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
        Debug.Log("onmouseover");
        splitViewer.gameObject.SetActive(true);
        splitViewer.Show(this.times);
    }
}
