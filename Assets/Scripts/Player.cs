using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    public float bounceForce = 10f;
    AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        playerRigidBody.velocity = Vector3.up * bounceForce;
        audioManager.Play("bounce");
        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;

        if(materialName == "Safe (Instance)")
        {

        }
        else if (materialName == "Unsafe (Instance)")
        {
            audioManager.Play("game-over");
            GameManager.gameOver = true;
        }
        else if (materialName == "Base (Instance)" && !GameManager.levelComplete)
        {
            GameManager.levelComplete = true;
            audioManager.Play("win level");
        }
    }
}
