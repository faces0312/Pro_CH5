using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //터치 시 발동
    public void OnClick(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {   
            //게임오브젝트에 터치했는지 확인
            if (EventSystem.current.IsPointerOverGameObject())
            {
                Debug.Log("터치 불가");
                return;
            }
            // 터치 위치 가져오기
            Vector3 touchPosition = Input.mousePosition;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, Camera.main.nearClipPlane));
            if(GameManager.Instance.Is_Battle == false)
            {
                Data.Instance.gameData.money += (Data.Instance.gameData.touchLV + 1);
                GameManager.Instance.Player.particle.CreateMainParticle(worldPosition);
                Debug.Log("터치 발동");
            }
            else if (GameManager.Instance.Is_Battle == true)
            {
                Attack();
                //Effect
                GameManager.Instance.Player.particle.CreateBattleParticle(worldPosition);
                Debug.Log("데미지발동");
            }
        }
    }

    void Attack()
    {
        int randomValue = Random.Range(1, 101);
        bool isCritical = randomValue < GameManager.Instance.Player.conditions.statSO.criticalChance;

        float finalDamage;

        if (isCritical)
        {
            finalDamage = GameManager.Instance.Player.conditions.attackTmp * GameManager.Instance.Player.conditions.criticalTmp;
            GameManager.Instance.bossManager.BossDamaged(finalDamage);
        }
        else
        {
            finalDamage = GameManager.Instance.Player.conditions.attackTmp;
            GameManager.Instance.bossManager.BossDamaged(finalDamage);
        }
       
    }
}
