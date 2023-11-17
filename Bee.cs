using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.PlayerSettings;

public class Bee : MonoBehaviour
{
    public GameManager GameManager;
    public float lerpSpeed = 5f;

    void Update()
    {
        Move();
    }

    public virtual void Move() // MOVE
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = Vector3.Lerp(transform.position, mousePos3D, Time.deltaTime * lerpSpeed);
        this.transform.position = new Vector3(pos.x, pos.y, transform.position.z);
    }

    void OnCollisionEnter(Collision coll) // COLLISION
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.CompareTag("balloon"))
        {
            Destroy(collidedWith);

        }
        else if (collidedWith.CompareTag("death"))
        {
            GameManager.Death();
        }
    }
}
