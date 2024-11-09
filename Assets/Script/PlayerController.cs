using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{


    //터치 시 발동
    public void OnClick(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Started && GameManager.Instance.Is_Battle == false)
        {
            Data.Instance.gameData.money++;
            Debug.Log("터치 발동");
        }

        if (context.phase == InputActionPhase.Started && GameManager.Instance.Is_Battle == true)
        {
            Debug.Log("데미지발동");
        }
    }
}
