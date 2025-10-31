// SceneHotkeys.cs
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneHotkeys : MonoBehaviour
{
    public string scene1 = "Scene1";
    public string scene2 = "Scene2";
    public string scene3 = "Scene3";

    void Update()
    {
        var kb = Keyboard.current;
        if (kb == null) return;

        if (Pressed1(kb)) LoadIfDifferent(scene1);
        else if (Pressed2(kb)) LoadIfDifferent(scene2);
        else if (Pressed3(kb)) LoadIfDifferent(scene3);
    }

    bool Pressed1(Keyboard kb) => kb.digit1Key.wasPressedThisFrame || kb.numpad1Key.wasPressedThisFrame;
    bool Pressed2(Keyboard kb) => kb.digit2Key.wasPressedThisFrame || kb.numpad2Key.wasPressedThisFrame;
    bool Pressed3(Keyboard kb) => kb.digit3Key.wasPressedThisFrame || kb.numpad3Key.wasPressedThisFrame;

    void LoadIfDifferent(string target)
    {
        if (string.IsNullOrWhiteSpace(target)) return;
        if (SceneManager.GetActiveScene().name == target) return;
        SceneManager.LoadScene(target, LoadSceneMode.Single);
    }
}
