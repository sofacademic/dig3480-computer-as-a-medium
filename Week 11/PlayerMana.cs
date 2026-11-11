
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMana : MonoBehaviour
{
    public int mana = 100;
    public TextMeshProUGUI manaText;
    public Animator animator;

    void Update()
    {
        // Mana Text Just Below Hp
        manaText.text = "Mana: " + mana;

        //  R Should  cast Animation
        if (Keyboard.current.rKey.wasPressedThisFrame && mana >= 10)
        {
            animator.ResetTrigger("Cast");
            animator.SetTrigger("Cast");
            mana -= 10;
        }
    }
}
