using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    private bool isOpen = false; 

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Le coffre a été touché par : " + other.name);
        if (other.CompareTag("Player") && !isOpen)
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            PlayerAttack playerAttack = other.GetComponent<PlayerAttack>();

            if (inventory != null && inventory.HasKey() == true)
            {
                OpenChest();
                playerAttack.UnlockAbility();
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