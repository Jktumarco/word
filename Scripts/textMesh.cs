using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textMesh : MonoBehaviour
{
    static public textMesh S;
    public Text text_Mesh;
    public string text_;

    

    void Awake(){
        if(S==null){
            S=this;
        }
        text_Mesh = GetComponent<Text>();
        
    }
   
}
