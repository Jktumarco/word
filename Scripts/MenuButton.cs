using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class MenuButton : MonoBehaviour
{
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

    public void ButtonMenu(){
        SceneManager.LoadScene(0);
    }


    public void ButtonPlay(){
        SceneManager.LoadScene(1);
    }

    public void ButtonExit(){
        Application.Quit();
    }

    public void ButtonSetup(){
        SceneManager.LoadScene(2);
    }
    
    
}
