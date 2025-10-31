// era_switch.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class era_switch : MonoBehaviour
{
    private static era_switch instance;

    // saves the latest good world position
    private Vector3 savedPosition;

    void Awake()
    {
        // singleton guard
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        // VERY important: this must be on the root object you want to persist
        DontDestroyOnLoad(gameObject);

        savedPosition = transform.position;

        // re-place the player after every scene load
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        if (instance == this)
            SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // keep updating the saved position while you move around
    void LateUpdate()
    {
        savedPosition = transform.position;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // put player back exactly where they were
        transform.position = savedPosition;
    }
}
