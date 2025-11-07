using UnityEngine;

public class music : MonoBehaviour
{
    private static music instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep it when changing scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates
        }
    }
}
