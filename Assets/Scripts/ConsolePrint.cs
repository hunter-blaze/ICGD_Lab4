using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    
    int i = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(obj.name + ":" + i);
    }
}
