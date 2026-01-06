using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    private bool isOpen = false; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOpen)
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();

            if (inventory != null && inventory.HasKey() == true)
            {
                OpenChest();
                inventory.UseKey();
            }
            else
            {
                Debug.Log("Il vous faut la clé !");
            }
        }
    }

    void OpenChest()
    {
        isOpen = true;
        Debug.Log("Le coffre s'ouvre !");

        GetComponent<Animator>().SetTrigger("Open");
    }
}