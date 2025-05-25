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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed!");
            transform.Translate(Vector3.up * 50.0f * Time.deltaTime, Space.World);
        }


    
    }

}
