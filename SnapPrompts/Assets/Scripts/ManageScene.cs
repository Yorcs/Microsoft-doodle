using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ManageScene : MonoBehaviour
{
    private TMP_Text promptTextComponent;

    public void ChangeScene(int sceneID){
        promptTextComponent = GetComponentInChildren<TMP_Text>();
        string dataToKeep = promptTextComponent.text;
        SceneManager.LoadScene(sceneID);
    }
}
