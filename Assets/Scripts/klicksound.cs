using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klicksound : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource clickSource;
    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("start");
        clickSource = gameObject.AddComponent<AudioSource>();
        clickSource.clip = clickSound;
        clickSource.loop = false;
        clickSource.playOnAwake = false;
    }

    private void OnMouseDown()
    {
        Debug.Log("Abspielen");
        clickSource.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
