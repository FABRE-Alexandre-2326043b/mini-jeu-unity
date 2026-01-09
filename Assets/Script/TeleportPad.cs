using UnityEngine;

public class TeleportPad : MonoBehaviour
{
    public Transform destination;

    [Header("Effets Spéciaux")] 
    public GameObject particlePrefab;
    public AudioSource sourceAudio;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (sourceAudio != null)
            {
                sourceAudio.Play();
            }

            if (particlePrefab != null)
            {
                GameObject particles = Instantiate(particlePrefab, transform.position, Quaternion.identity);

                Destroy(particles, 2f);
            }

            Debug.Log("Téléportation !");

            CharacterController cc = other.GetComponent<CharacterController>();
            if (cc != null)
            {
                cc.enabled = false;
                other.transform.position = destination.position;
                cc.enabled = true;
            }
        }
    }
}