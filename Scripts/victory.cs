using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victory : MonoBehaviour
{
    static public victory S;
    public AudioSource audio;
    void Awake(){
        if(S==null){
            S=this;
        }
        audio = GetComponent<AudioSource>();}

    // Update is called once per frame
    void Update()
    {
        
    }
}
