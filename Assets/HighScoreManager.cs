using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    [SerializeField] private Text label = null;
    [SerializeField] private SplitViewer sv = null;

    public void OnScoreUpdate(List<float> times)
    {
        var l = Instantiate(label);
        l.transform.SetParent(this.transform);
        l.transform.localScale = Vector3.one;
        l.text = times[times.Count-1].ToString("0.000");
        l.GetComponent<SplitHooker>().Init(sv, times);
    }

}
