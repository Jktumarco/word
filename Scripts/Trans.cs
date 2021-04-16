using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trans : MonoBehaviour
{
    static public Trans S;
    public Vector3 posMouse;
   

    
    
    void Awake()
    {
        if(S==null){
            S = this;
        } 
    }
    void Update()
    {
        
        Vector3 posMouse = Input.mousePosition;

        posMouse.z = -Camera.main.transform.position.z;
        Vector3 newPOs = Camera.main.ScreenToWorldPoint(posMouse);
        Vector3 pos = this.transform.position;
        pos.x = newPOs.x;
        pos.y = newPOs.y;
        this.transform.position = pos;
        
    }
}
