using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PromptManager : MonoBehaviour
{
    public Prompts prompts;
    public GameObject[] options;
    public List<string> savedPrompt = new();
    string newPrompt;
    public int currentPrompt;

    void Start(){
        AddList();
        SetPrompt();
    }

    //Adding string from static array to list
    void AddList(){
        savedPrompt.AddRange(prompts.promptSentence);
    }

    //Setting the text on the button
    void SetPrompt(){
        foreach (GameObject obj in options){
            GetPrompt();
            obj.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = newPrompt;
            savedPrompt.RemoveAt(currentPrompt);
        }
    }

    //Get randomized string from list
    void GetPrompt(){
        currentPrompt = Random.Range(0, savedPrompt.Count);
        newPrompt = savedPrompt[currentPrompt];
    }
}
