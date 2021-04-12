using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audi : MonoBehaviour
{
    static public audi S;
    public AudioSource audio;
    void Awake(){
        if(S==null){
            S=this;
        }
        audio = GetComponent<AudioSource>();
    }
   
    void Start()
    {
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
