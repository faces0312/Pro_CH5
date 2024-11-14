# Pro_CH5

## 2D 클리커 게임

### Scene 구성
- MainScene
  - 재화, 강화, 아군을 관리 및 제어할 수 있는 Scene
  - GameScene으로 이동할 수 있다
  - 아군을 통해 능력치와 지원을 받을 수 있도록 진행

- GameScene
  - 전투를 진행하는 Scene
  - 보스몬스터를 시간 내에 잡는 방식으로 진행
  - 적체력, 남은시간, 내 체력 UI 사용
  - 아군을 통해 능력치와 지원을 받을 수 있도록 진행

### Character 구성
1. Player
2. Boss
3. SubFirend

### 재화 획득
- touchLevel에 따라 재화 획득량 증가
- 아군의 자동 재화 증가를 코루틴을 통한 재귀함수로 구현
- 터치시 파티클 시스템을 통해 이펙트 설정

### 강화
- 터치재화, 체력, 공력력, 치명타데미지, 치명타 확률로 구성
- 스크롤을 통한 UI 제어
- 보유 제화에 따라 강화 버튼의 enabled를 조절

### 아군 기능 
- 자동 재화, 체력2배, 공격력2배, 치명타데미지2배로 구성
- 스크롤을 통한 UI 제어
- 구매 시 버튼의 SetActive로 조절
  
### 저장
- Json 형식으로 저장
- stage와 재화, 강화레벨, 아군 보유 여부를 설정

### 트러블 슈팅
- PlayerInput을 통해 터치 구현
- 강화 버튼, 취소 버튼 등 UI 터치 시에도 재화 획득 및 파티클 시스템 발동
- 해결 코드
```c#
//게임오브젝트 외에 터치했는지 확인
if (EventSystem.current.IsPointerOverGameObject())
{
    Debug.Log("터치 불가");
    return;
}
```

### 초기 기획
![KakaoTalk_20241114_101854806_01](https://github.com/user-attachments/assets/c9715128-315b-4c2e-a8b1-018be8495e83)

![KakaoTalk_20241114_101854806_02](https://github.com/user-attachments/assets/04f68e6c-8778-4500-b162-45e9a868ecc5)