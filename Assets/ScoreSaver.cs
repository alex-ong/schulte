using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;

public class ScoreSaver : MonoBehaviour
{

    [SerializeField] public ButtonManager bm = null;


    public void SaveScore(List<float> results)
    {
        List<string> data = new List<string>();
        data.Add(DateTime.Now.ToString("yyyy-dd-MM_hhmmss"));

        foreach (float f in results)
        {
            data.Add(f.ToString("0.0000"));
        }

        StringBuilder sb = new StringBuilder();
        foreach (string s in data)
        {
            sb.Append(s);
            sb.Append(",");
        }

        using (StreamWriter w = File.AppendText("C:/Schulte/Schulte.txt"))
        {
            w.WriteLine(sb.ToString());
        }
    }


}
