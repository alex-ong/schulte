using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour
{
    [SerializeField] public GameObject target = null;
    // Start is called before the first frame update
    public void Show()
    {
        target.SetActive(true);
    }

    public void Hide()
    {
        target.SetActive(false);
    }
}
