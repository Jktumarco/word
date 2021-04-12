using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sd : MonoBehaviour{

    public AudioSource eee;
    void Awake(){
        eee = GetComponent<AudioSource>();
    }

    public void UIsound(){
        
        eee.Play();
    }
    public void OnMouseEnter(){
        eee.Play();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
