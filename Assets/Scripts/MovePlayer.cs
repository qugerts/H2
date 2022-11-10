using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    public int score;
    [SerializeField] Text scoreText;
    public float speed = 500f, _thrust = 1000f;
    private Rigidbody2D _rb;
    private void Awake() 
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * speed; //Time.fixedDeltaTime - метод подобный Time.deltaTime, который нужно использовать в FixedUpdate() (Если его использовать все очень замедлится)
        float v = Input.GetAxis("Vertical") * speed; // Input.GetAxis("[Направление]") нужно использовать для перемещения (получает число от 1 до -1 соответственно), что бы определить направление

        _rb.velocity = transform.TransformDirection(new Vector2(h, v));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(other.gameObject);
        score++;
    }

    private void Update(){
        scoreText.text = score.ToString();
    }
}