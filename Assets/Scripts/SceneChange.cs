using Unity.VectorGraphics;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public string sceneName;
    void OnTriggerEnter()
    {
        //Перезапуск сцены
        EditorSceneManager.LoadScene(sceneName);
    }
}
