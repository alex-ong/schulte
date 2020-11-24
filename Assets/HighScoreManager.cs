using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    [SerializeField] private Text label = null;
    public void OnScoreUpdate(List<float> times)
    {
        var l = Instantiate(label);
        l.transform.SetParent(this.transform);
        l.transform.localScale = Vector3.one;
        l.text = times[times.Count-1].ToString("0.000");
    }

}
