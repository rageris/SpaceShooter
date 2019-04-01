using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private GameController1 gameController;
    

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController1");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController1>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController1' script");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);

            gameController.GameOver();
        }
        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}







/*
using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private GameController1 gameController;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        GameObject gameControllerObject = GameObject.FindWithTag("GameController1");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController1>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController1' script");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            audio.Play();
        }
        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
*/