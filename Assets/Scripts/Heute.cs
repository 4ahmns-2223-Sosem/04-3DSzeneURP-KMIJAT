using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heute : MonoBehaviour
{
    public GameObject satelit;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        satelit.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
