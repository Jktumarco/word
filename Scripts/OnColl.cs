using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColl : MonoBehaviour
{
    static public OnColl S;
    public bool write =false;
    public string wordik;
    
    void Awake(){
        if(S==null){
            S=this;
        }
        
        
        wordik =null;
    }

   

    void OnTriggerEnter2D(Collider2D coll){
        GameObject otherGO = coll.gameObject;
        if(write ==true){
            switch (otherGO.tag){
        
                case "я":
                    if(Main.S.letter.Contains("я")){
                        return;
                    }
                    else{

                        Main.S.letter.Add("я");
                        UI.S.audio.Play();
                    }   

        
                break;
                case "ч":
                    if(Main.S.letter.Contains("ч")){
                    return;}
                    else{
                        Main.S.letter.Add("ч");
                        UI.S.audio.Play();

                        print(Main.S.letter.Count-1);
                       
                        }
                    
                break;
                case "с":
                if(Main.S.letter.Contains("с")){
                    return;}
                    Main.S.letter.Add("с");
                    UI.S.audio.Play();
                   
                
                break;
                case "м":
                if(Main.S.letter.Contains("м")){
                    return;}
                    Main.S.letter.Add("м");
                    UI.S.audio.Play();
                    
                
                
                break;
                case "и":
                if(Main.S.letter.Contains("и")){
                    return;}
                    Main.S.letter.Add("и");
                    UI.S.audio.Play();
                    
                
                
                break;
                case "т":
                if(Main.S.letter.Contains("т")){
                    return;}
                    Main.S.letter.Add("т");
                    UI.S.audio.Play();
                    
                
                break;

                case "ь":
                if(Main.S.letter.Contains("ь")){
                    return;}
                    Main.S.letter.Add("ь");
                    UI.S.audio.Play();
                    
                
                break;
                case "б":
                if(Main.S.letter.Contains("б")){
                    return;}
                    Main.S.letter.Add("б");
                    UI.S.audio.Play();
                   
                
                break;
                case "ю":
                if(Main.S.letter.Contains("ю")){
                    return;}
                    Main.S.letter.Add("ю");
                    UI.S.audio.Play();
                    
                
                break;
                case "ф":
                if(Main.S.letter.Contains("ф")){
                    return;}
                    Main.S.letter.Add("ф");
                    UI.S.audio.Play();
                    
                
                break;
                case "ы":
                if(Main.S.letter.Contains("ы")){
                    return;}
                    Main.S.letter.Add("ы");
                    UI.S.audio.Play();
                   
                
                break;
                case "в":
                if(Main.S.letter.Contains("в")){
                    return;}
                    Main.S.letter.Add("в");
                    UI.S.audio.Play();
                    
                
                break;
                case "а":
                if(Main.S.letter.Contains("а")){
                    return;}
                    Main.S.letter.Add("а");
                    UI.S.audio.Play();
                   
                
                break;
                case "п":
                if(Main.S.letter.Contains("п")){
                    return;}
                    Main.S.letter.Add("п");
                    UI.S.audio.Play();
                    
                
                break;
                case "р":
                if(Main.S.letter.Contains("р")){
                    return;}
                    Main.S.letter.Add("р");
                    UI.S.audio.Play();
                   
                
                break;
                case "л":
                if(Main.S.letter.Contains("л")){
                    return;}
                    Main.S.letter.Add("л");
                    UI.S.audio.Play();
                   
                
                break;
                case "д":
                if(Main.S.letter.Contains("д")){
                    return;}
                    Main.S.letter.Add("д");
                    UI.S.audio.Play();
                    
                
                break;
                case "ж":
                if(Main.S.letter.Contains("ж")){
                    return;}
                    Main.S.letter.Add("ж");
                    UI.S.audio.Play();
                   
                
                break;
                case "э":
                if(Main.S.letter.Contains("э")){
                    return;}
                    Main.S.letter.Add("э");
                    UI.S.audio.Play();
                   
                
                break;
                case "й":
                if(Main.S.letter.Contains("й")){
                    return;}
                    Main.S.letter.Add("й");
                    UI.S.audio.Play();
                   
                
                break;
                case "ц":
                if(Main.S.letter.Contains("ц")){
                    return;}
                    Main.S.letter.Add("ц");
                    UI.S.audio.Play();
                    
                
                break;
                case "у":
                if(Main.S.letter.Contains("у")){
                    return;}
                    Main.S.letter.Add("у");
                    UI.S.audio.Play();
                  
                
                break;
                case "к":
                if(Main.S.letter.Contains("к")){
                    return;}
                    Main.S.letter.Add("к");
                    UI.S.audio.Play();
                   
                
                break;
                case "е":
                if(Main.S.letter.Contains("е")){
                    return;}
                    Main.S.letter.Add("е");
                    UI.S.audio.Play();
                   
                
                break;
                case "н":
                if(Main.S.letter.Contains("н")){
                    return;}
                    Main.S.letter.Add("н");
                    UI.S.audio.Play();
                    
                
                break;
                case "г":
                if(Main.S.letter.Contains("г")){
                    return;}
                    Main.S.letter.Add("г");
                    UI.S.audio.Play();
                   
                
                break;
                case "ш":
                if(Main.S.letter.Contains("ш")){
                    return;}
                    Main.S.letter.Add("ш");
                    UI.S.audio.Play();
                    
                
                break;
                case "щ":
                if(Main.S.letter.Contains("щ")){
                    return;}
                    Main.S.letter.Add("щ");
                    UI.S.audio.Play();
                    
                
                break;
                case "з":
                if(Main.S.letter.Contains("з")){
                    return;}
                    Main.S.letter.Add("з");
                    UI.S.audio.Play();
                   
                
                break;
                case "х":
                if(Main.S.letter.Contains("х")){
                    return;}
                    Main.S.letter.Add("х");
                    UI.S.audio.Play();
                    
                
                break;
                
            }
               
        }else return; 
        
    }
    

   
    void Update()
    {
       
       if(Input.GetMouseButtonDown(0) ){
           
           
            
            write = true;
            trill.S.trail.enabled = true;
            Main.S.wordes=null;
           
        }
        
       if(Input.GetMouseButton(0) ){

       }  
       
       if(Input.GetMouseButtonUp(0)){
            trill.S.trail.enabled = false;
            wordik =Main.S.wordes;
            


            if ( wordik ==null){
                write = false;
         
                return;}
            
            
            if(Main.S.cheking_Word.Contains(wordik) ){
              
                write =false;
                Main.S.letter.Clear();
                Main.S.wordes=null;
                wordik =null;
            }
            

            if(wordik!=null){  
                
               
                Main.S.wordes=null;
                
                write = false;
            
                if(Main.S.letter !=null){
                    Main.S.letter.Clear();
                }
            }

            

                           
           
          
       }
       

    }
    
    
}
