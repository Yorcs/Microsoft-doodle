using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PromptManager : MonoBehaviour
{
    public Prompts prompts;
    public GameObject[] options;

    private void Start(){
        SetPrompt();
    }

    void SetPrompt(){
        for (int i = 0; i < options.Length; i++){
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = GetPrompt();
        }
    }

    public string GetPrompt(){
        return prompts.promptSentence[Random.Range(0, prompts.promptSentence.Length)];
    }
}
