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

    void AddList(){
        savedPrompt.AddRange(prompts.promptSentence);
    }

    void SetPrompt(){
        foreach (GameObject obj in options){
            GetPrompt();
            obj.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = newPrompt;
            savedPrompt.RemoveAt(currentPrompt);
        }
    }

    void GetPrompt(){
        currentPrompt = Random.Range(0, savedPrompt.Count);
        newPrompt = savedPrompt[currentPrompt];
    }
}
