using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PromptTrigger : MonoBehaviour
{
    private TMP_Text promptTextComponent;
    public bool chosen = false;
    private string dataToKeep;

    public void Selected(){
        if(chosen){
            Debug.Log("Selected");
            promptTextComponent = GetComponentInChildren<TMP_Text>();
            dataToKeep = promptTextComponent.text;
        }
    }
}
