using UnityEngine;

public class PlantCrate : MonoBehaviour
{
    private PlayerMovement playerScript;
   

    //public Sprite sprite1;
    //public Sprite sprite2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject targetGameObject = GameObject.FindWithTag("player");
        playerScript = targetGameObject.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.plant == true)
        {
            Destroy(gameObject);
        }
    }
}
