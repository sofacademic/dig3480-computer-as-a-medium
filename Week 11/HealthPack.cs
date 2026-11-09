using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth; //define player health
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")&&(playerHealth.health != 100)) //if player touches collider AND health is not at 100,
        {
            playerHealth.health += 10; //add 10 health
            Destroy(gameObject); //and destroy the health pack
        }
    }
}
