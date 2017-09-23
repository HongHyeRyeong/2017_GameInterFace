using UnityEngine;


public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            Destroy(other.gameObject);
            return;
        }

        if (other.tag == "Bolt")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Gamecoin.AddCoin(10);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    

        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            life_Manager.MinusLife();
            sound.Play();
            Destroy(gameObject);

        }
    }
}