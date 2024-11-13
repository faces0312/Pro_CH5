using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //터치 시 발동
    public void OnClick(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            // 터치 위치 가져오기
            Vector3 touchPosition = Input.mousePosition;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, Camera.main.nearClipPlane));
            if(GameManager.Instance.Is_Battle == false)
            {
                Data.Instance.gameData.money += (Data.Instance.gameData.touchLV + 1);
                //Effect
                GameManager.Instance.Player.particle.CreateMainParticle(worldPosition);
                Debug.Log("터치 발동");
            }
            else if (GameManager.Instance.Is_Battle == true)
            {
                GameManager.Instance.bossManager.BossDamaged(GameManager.Instance.Player.conditions.attackTmp);
                //Effect
                GameManager.Instance.Player.particle.CreateBattleParticle(worldPosition);
                Debug.Log("데미지발동");
            }
        }
    }
}
