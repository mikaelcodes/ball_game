using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveY) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);


    
    }

}
