using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    public float bounceForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        playerRigidBody.velocity = Vector3.up * bounceForce;

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;

        if(materialName == "Safe (Instance)")
        {

        }
        else if (materialName == "Unsafe (Instance)")
        {
            GameManager.gameOver = true;
        }
        else if (materialName == "Base (Instance)")
        {
            GameManager.levelComplete = true;
        }
    }
}
