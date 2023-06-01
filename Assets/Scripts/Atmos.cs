using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atmos : MonoBehaviour
{
    public AudioClip atmoSound;
    private AudioSource audioSource;
   
    // Start is called before the first frame update
    private void Start()
    {
        
            Debug.Log("start");
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = atmoSound;
            audioSource.loop = false;
            audioSource.playOnAwake = false;
        
    }
    private void OnMouseDown()
    {
        Debug.Log("mouse down");
        if (audioSource != null)
        {
           
           
           if (!audioSource.isPlaying)
           {
                audioSource.loop = true;
                audioSource.Play();
          }
       
         
        }

        private void AtmoStop()
        {
            //if ()
            //{ 
            //audioSource.Stop();
            //}
        }


    // Update is called once per frame
    // void Update()
    // {

        //}
    }
}
