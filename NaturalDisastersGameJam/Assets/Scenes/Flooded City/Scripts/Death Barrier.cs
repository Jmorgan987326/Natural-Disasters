using UnityEngine;
public class TeleportScript : MonoBehaviour
{
    // Set this variable in the Unity Editor to the destination point
    public Transform teleportDestination;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Teleport the player to the destination point
            other.transform.position = teleportDestination.position;
        }
    }
}