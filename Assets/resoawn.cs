using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTriggerLoader : MonoBehaviour
{
    public string targetTag = "Player";  // Tag of the player object
    public string sceneToLoad = "SampleScene";  // Scene to load

    private void OnTriggerEnter(Collider other)
    {
        // Log entry to trigger zone
        Debug.Log("Entered Trigger: " + other.name + " with tag: " + other.tag);

        // Check if the object with the correct tag has entered the trigger
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Correct tag detected! Loading scene: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.Log("Wrong tag. Expected: " + targetTag + " but got: " + other.tag);
        }
    }
}
