using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trill : MonoBehaviour
{
    public TrailRenderer trail;
    static public trill S;
    void Awake(){
        if(S==null){
            S=this;
        }
        trail = GetComponent<TrailRenderer>();
    }
    void Start()
    {
        trail.enabled = false;
    }

    
    
}
