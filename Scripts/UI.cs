using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    static public UI S;
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
