using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            PlayerTakeDmg(20);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }


        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayerHeal(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }

    }

        
    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
    }

    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
    }

}