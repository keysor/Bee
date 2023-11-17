using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.PlayerSettings;

public class Bee2 : MonoBehaviour
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

    public virtual void Move()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        // Calculate the movement direction
        Vector3 movement = (mousePos3D - transform.position).normalized;

        // Move the bee using Translate
        transform.Translate(movement * lerpSpeed * Time.deltaTime);

        // Optional: You can limit the bee's movement to a specific area, if needed.
        // For example, you can clamp the bee's position to stay within certain bounds:

        //float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        //float clampedY = Mathf.Clamp(transform.position.y, minY, maxY);
        //transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
