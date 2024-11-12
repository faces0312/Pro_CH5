using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //��ġ �� �ߵ�
    public void OnClick(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Started && GameManager.Instance.Is_Battle == false)
        {
            Data.Instance.gameData.money += (Data.Instance.gameData.touchLV + 1);
            Debug.Log("��ġ �ߵ�");
        }

        if (context.phase == InputActionPhase.Started && GameManager.Instance.Is_Battle == true)
        {
            Debug.Log("�������ߵ�");
        }
    }
}
