🎒 Unity 인벤토리 시스템
Unity 기반의 간단한 인벤토리 및 장비 시스템입니다.
스크립터블 오브젝트로 정의된 아이템을 UI 상에서 장착/해제하고, 캐릭터 능력치에 실시간 반영합니다.

🧱 구성 파일
파일명	설명
Item.cs	아이템 정보를 가진 ScriptableObject
Character.cs	플레이어 데이터 및 장비, 능력치 관리
GameManager.cs	싱글톤 패턴으로 캐릭터 초기화
UIInventory.cs	인벤토리 UI 및 장비 시스템
UISlot.cs	인벤토리 슬롯 단위 UI 로직
UIStatus.cs	능력치 UI 표시
UIMainMenu.cs	메인 UI (상태창/인벤토리 전환 포함)
RandomItem.cs	버튼 클릭 시 무작위 아이템 지급

🔧 주요 기능
📦 인벤토리 시스템
최대 24칸의 인벤토리 슬롯 자동 생성

슬롯 클릭 시 선택 및 외곽선 표시

같은 종류(ItemType)의 아이템은 1개만 장착 가능

🛡️ 장비 시스템
장비 장착 시 해당 능력치(Atk, Def, Hp, Crt) 자동 반영

이미 같은 타입 장비가 장착돼 있으면 자동으로 해제 후 교체

장착 여부에 따라 Equip / UnEquip 버튼 전환

🎁 아이템 획득
RandomItem.cs 스크립트에서 버튼 클릭 시 무작위 아이템 지급

골드 100 소비 후 인벤토리 자동 등록

캐릭터 정보 UI도 실시간 갱신

📊 상태창 UI
캐릭터 이름, 직업, 레벨, 경험치, 골드, 설명 표시

능력치는 UIStatus.cs에서 동기화됨

▶️ 사용 방법
Item은 ScriptableObject로 미리 생성

GameManager에서 캐릭터 초기화

UIMainMenu에서 상태창/인벤토리 UI 전환 가능

슬롯 선택 후 장비 장착 및 해제 버튼 사용

RandomItem.cs로 테스트용 아이템 지급 가능

📌 참고 사항
장비 타입은 Weapon, Shield, Accessory의 세 가지

경험치는 12 이상이 되면 레벨업 (Character.PlusExp)

골드 숫자는 N0 포맷으로 쉼표 표시됨 (UIMainMenu.GoldComma())
