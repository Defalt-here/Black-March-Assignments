using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text UIText;

    public void Start(){
        UIText.text = "No Value";
    }
    // Start is called before the first frame update
    public void displayText(string text){
        UIText.text = text;
    }
}
