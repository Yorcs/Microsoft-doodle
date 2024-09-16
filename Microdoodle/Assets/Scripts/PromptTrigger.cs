using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptTrigger : MonoBehaviour
{
    public bool chosen = false;

    public void Selected(){
        if(chosen){
            Debug.Log("Selected");
        }
    }
}
