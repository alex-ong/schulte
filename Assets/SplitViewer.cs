using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplitViewer : MonoBehaviour
{
    [SerializeField] private Text t = null;

    public void Show(List<float> times)
    {
        string t = "";
        for (int i = 1; i < times.Count; i++)
        {
            t += (times[i]-times[i-1]).ToString("0.00") + " ";
            if (i % 5 == 0)
            {
                t += "\n";
            }
        }
        
        this.t.text = t;
    }

    public void Hide()
    {
        t.gameObject.SetActive(false);
    }
}
