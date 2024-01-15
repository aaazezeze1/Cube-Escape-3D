using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameRespawn : MonoBehaviour
{
    // y value of the transform
    public float threshold;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    // respawn the player when it crosses the border
    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
