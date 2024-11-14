using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //��ġ �� �ߵ�
    public void OnClick(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {   
            //���ӿ�����Ʈ�� ��ġ�ߴ��� Ȯ��
            if (EventSystem.current.IsPointerOverGameObject())
            {
                Debug.Log("��ġ �Ұ�");
                return;
            }
            // ��ġ ��ġ ��������
            Vector3 touchPosition = Input.mousePosition;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, Camera.main.nearClipPlane));
            if(GameManager.Instance.Is_Battle == false)
            {
                Data.Instance.gameData.money += (Data.Instance.gameData.touchLV + 1);
                GameManager.Instance.Player.particle.CreateMainParticle(worldPosition);
                Debug.Log("��ġ �ߵ�");
            }
            else if (GameManager.Instance.Is_Battle == true)
            {
                Attack();
                //Effect
                GameManager.Instance.Player.particle.CreateBattleParticle(worldPosition);
                Debug.Log("�������ߵ�");
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
