using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform target; // Assign the object to follow in the Inspector
    public Vector3 offset = new Vector3(0, 5, -10); // Adjust as needed

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}