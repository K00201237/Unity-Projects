using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Declaring Variables
    public float speed = 10;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    private AudioSource playerAudio;
    public AudioClip pickUpCan;
    public AudioClip pickUpSpeed;



    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);

        playerAudio = GetComponent<AudioSource>();
    }

    // The on move function will store the players inputs as a vector 2 variable
    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // DIspalying the how many collectibles have been collected. If the player collects 40, a new scene loads.
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 40)
        {
            winTextObject.SetActive(true);
            SceneManager.LoadScene(4);
        }
    }

    // Every fixed frame the players movement will be updated. Also using the Addforce function to add force to a rigidbody.
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    // When the player collides with pickups, the comparetag function will check the game objects tag and remove the gameobject as wellas update the players
    // score, play audio or increase the players speed.
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();

            playerAudio.PlayOneShot(pickUpCan);
        }
        if (other.gameObject.CompareTag("SpeedPickUp"))
        {
            other.gameObject.SetActive(false);
            speed = speed + 5;



            playerAudio.PlayOneShot(pickUpSpeed);
        }

    }

    
}
