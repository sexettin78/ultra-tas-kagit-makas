using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Hareket hýzý
    private Rigidbody2D rb;
    public float minX = -3.0f; // Karakterin sol sýnýrý
    public float maxX = 14.0f;  // Karakterin sað sýnýrý
    public float minY = -3.5f; // Karakterin alt sýnýrý
    public float maxY = 3.5f;  // Karakterin üst sýnýrý

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("RandomizeMovement", 0.0f, 0.5f);
    }

    void RandomizeMovement()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        randomDirection.Normalize();

        Vector2 newPosition = rb.position + randomDirection * moveSpeed * Time.deltaTime;

        // Karakterin yeni pozisyonunu sýnýrlar içinde kontrol edin
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        rb.MovePosition(newPosition);
    }


    public void yenile() {
        SceneManager.LoadScene(0);
    }

}