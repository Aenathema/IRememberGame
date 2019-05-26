using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    private Vector3 originalScale;
    private GameObject _player;
	
    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //move towards player
        Vector3 dv = _player.transform.position + (Vector3.up * 0.4f) - transform.position;
        Vector3 movement = new Vector3(dv.x, dv.y, 0).normalized * moveSpeed * Time.deltaTime;
        transform.position += movement;

        //flip scale on x if moving right / left
        if (movement.x < 0.0f)
        {
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
        }
        else
        {
            transform.localScale = originalScale;
        }
    }
}
