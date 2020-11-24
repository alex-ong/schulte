using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplitViewer : MonoBehaviour
{
    [SerializeField] private BarManager bars = null;

    public void Show(List<float> times)
    {
        bars.gameObject.SetActive(true);
        bars.Setup(times);
    }

    public void Hide()
    {
        bars.gameObject.SetActive(false);
    }
}
