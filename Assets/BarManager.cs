using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class BarManager : MonoBehaviour
{
    [SerializeField] private Split prefab;
    private List<Split> splits = new List<Split>();

    public void Setup(List<float> times)
    {
        foreach(var s in splits)
        {
            Destroy(s.gameObject);
        }
        splits.Clear();

        
        var times2 = new List<float>();
        for (int i = 1; i < times.Count; i++)
        {
            times2.Add(times[i] - times[i - 1]);
        }
        float max = times2.Max();

        for (int i = 1; i < times2.Count; i++)
        {
            var s = Instantiate(prefab);
            s.transform.SetParent(this.transform, false);
            s.Setup(times2[i], max, i);
            splits.Add(s);
        }
    }

 
}
