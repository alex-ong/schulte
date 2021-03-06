using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Events;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private ClickableButton prefab = null;
    [SerializeField] private GameObject restartButton = null;    
    [SerializeField] private SplitViewer sv = null;
    public FloatEvent OnFinishSplits;

    private List<ClickableButton> buttons = new List<ClickableButton>();
    private int currentID = 0;
    private float startTime = 0.0f;

    private List<float> times = new List<float>();

    public void Start()
    {
        
    }

    public void RandomizeAndInit()
    {
        foreach (var button in buttons)
        {
            Destroy(button.gameObject);
        }
        buttons.Clear();

        for (int i = 0; i < 25; i++)
        {
            var button = Instantiate(prefab);
            button.Setup(i + 1, OnButtonClick);
            buttons.Add(button);
        }
        buttons.Shuffle();
        foreach (var button in buttons)
        {
            button.transform.SetParent(this.transform);
            button.transform.localScale = Vector3.one;
        }
        currentID = 0;
        startTime = Time.time;
        times.Clear();
        times.Add(0.0f);
        restartButton.gameObject.SetActive(false);
        sv.gameObject.SetActive(false);
    }

    private void OnButtonClick(int i)
    {
        if (i == currentID + 1)
        {            
            currentID++;
            times.Add(Time.time - startTime);
            if (currentID == 25)
            {
                OnFinishSplits?.Invoke(times);
                restartButton.gameObject.SetActive(true);
            }
        }

    }
}
