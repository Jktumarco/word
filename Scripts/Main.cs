using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
        static public Main S;
        public List<string> letter = new List<string>();        // лист букв, при столкновении 
        public List<string> word = new List<string>();          
        public List<string> cheking_Word = new List<string>();  // словарь уровня.
        public string wordes;                                   // слово, из перебора букв
     
        public GameObject[] spriteLetter;                       

        public List<Vector3> positionLetter = new List<Vector3>();

        public void Instanse()
        {
            
            for (int i = 0; i < spriteLetter.Length; i++)
            {
                
                Instantiate(spriteLetter[i], positionLetter[i], Quaternion.identity);
            }
        }


      
        

        public void ParsLetter()
        {
            string str = "";
            foreach (string sTemp in letter)
            {
                str += sTemp + "";
                textMesh.S.text_Mesh.text = str;
                wordes = str;
            }
        }



        void Awake()
        {

            if (S == null)
            {
                S = this;
            }
            cheking_Word.Add("тап");
            cheking_Word.Add("тип");

            cheking_Word.Add("пет");
            cheking_Word.Add("тапа");
            cheking_Word.Add("епта");
           





        }
        void Start()
        {
            Instanse();

        }

        void Update()
        {
            ParsLetter();
        }

    
    
}