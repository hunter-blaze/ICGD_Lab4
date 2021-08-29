using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    public Renderer rend;
    
    int i = 3;
    int randomValue;

    // Start is called before the first frame update
    void Start()
    {
        randomValue = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if (obj.tag == "Red" && i == 100)
            obj.SetActive(false);
        if (obj.tag == "Blue" && i == randomValue)
            rend.enabled  = false;
        Debug.Log(obj.name + ":" + i);
    }
}
