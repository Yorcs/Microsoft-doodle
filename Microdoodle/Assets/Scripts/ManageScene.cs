using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    public void ChangeScene(int sceneID){
        SceneManager.LoadScene(sceneID);
    }
}
