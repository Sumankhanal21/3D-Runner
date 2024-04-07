using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject theplayer;
    public GameObject charModel;
    public AudioSource crashthud;
    public GameObject maincam;

    private void OnTriggerEnter(Collider other)
    {
        // Disabling the collider of the collided object
        other.gameObject.GetComponent<Collider>().enabled = false;

        // Disabling player movement script
        //theplayer.GetComponent<PlayerMove>().enabled = false;

        // Playing stumble animation
        charModel.GetComponent<Animator>().Play("Stumble Backwards");

        // Playing crash sound
        crashthud.Play();
        maincam.GetComponent<Animator>().enabled = true;
    }
}
